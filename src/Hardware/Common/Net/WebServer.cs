using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Common.Collections;
using Common.IO;

namespace Common.Net
{
    public class WebServer
    {
        public delegate string HandlerDelegate(Hashtable request, Stream body);
        public delegate void PostHandlerDelegate(Hashtable request);

        private readonly ArrayList _handlers = new ArrayList();
        private HttpListener _listener;
        private Thread _serverThread;

        public void Run()
        {
            if (_listener != null) return;

            _listener = new HttpListener("http");
            _serverThread = new Thread(RunServer);
            _serverThread.Start();
        }

        public void Stop()
        {
            if (_listener != null) _listener.Stop();
        }

        public void MapGet(string path, HandlerDelegate handler,
            PostHandlerDelegate postHandler = null)
        {
            Map("GET", path, handler, postHandler);
        }

        public void MapPost(string path, HandlerDelegate handler,
            PostHandlerDelegate postHandler = null)
        {
            Map("POST", path, handler, postHandler);
        }

        public void MapPut(string path, HandlerDelegate handler,
            PostHandlerDelegate postHandler = null)
        {
            Map("PUT", path, handler, postHandler);
        }

        public void MapDelete(string path, HandlerDelegate handler,
            PostHandlerDelegate postHandler = null)
        {
            Map("DELETE", path, handler, postHandler);
        }

        public void Map(string method, string path, HandlerDelegate handler,
            PostHandlerDelegate postHandler)
        {
            _handlers.Add(new RequestHandler(method, path, handler, postHandler));
        }

        private void RunServer()
        {
            _listener.Start();

            while (_listener.IsListening)
            {
                var context = _listener.GetContext();
                if (context != null)
                    ProcessRequest(context);
            }
            _listener.Close();

            _listener = null;
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            var method = request.HttpMethod?.ToUpper();
            var path = request.RawUrl.GetRelativePath();

            var handler = FindHandler(method, path);

            if (handler != null)
            {
                var requestData = request.RawUrl.GetQueryString().ParseQueryString();
                var form = request.ContentType?.ToLower() == "application/x-www-form-urlencoded";

                if (form)
                    requestData.AddRange(request.InputStream.ReadLength().ParseQueryString());

                var responseText = handler.Handler(requestData, form ? null : request.InputStream);

                WriteString(response, responseText);

                response.Close();

                handler.PostHandler?.Invoke(requestData);
            }
            else
            {
                response.StatusCode = 404;
                response.Close();
            }
        }

        private RequestHandler FindHandler(string method, string path)
        {
            foreach (var item in _handlers)
            {
                var handler = (RequestHandler)item;

                if (handler.Method == method &&
                    handler.Path.ToLower().Trim().Trim('\\') == path.ToLower().Trim().Trim('\\'))
                    return handler;
            }

            return null;
        }

        private void WriteString(HttpListenerResponse response,
            string responseText, string contentType = "text/html")
        {
            var responseBytes = Encoding.UTF8.GetBytes(responseText);
            response.ContentType = contentType;
            response.ContentLength64 = responseBytes.Length;
            response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
        }

        private class RequestHandler
        {
            public RequestHandler(string method, string path, HandlerDelegate handler, PostHandlerDelegate postHandler)
            {
                Method = method;
                Path = path;
                Handler = handler;
                PostHandler = postHandler;
            }

            public string Method { get; }
            public string Path { get; }
            public HandlerDelegate Handler { get; }
            public PostHandlerDelegate PostHandler { get; }
        }
    }
}