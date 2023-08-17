using nanoFramework.Runtime.Native;
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
    public abstract class SimpleWebServerBase
    {
        private HttpListener _listener;
        private Thread _serverThread;

        public void Start()
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

        protected abstract string ProcessRequest(string path, string method, Hashtable request);
        protected abstract void PostProcessRequest(string path, string method, Hashtable request);

        private void ProcessRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            var requestData = request.RawUrl.GetQueryString().ParseQueryString();
            var path = request.RawUrl.GetRelativePath();
            
            if (request.ContentType == "application/x-www-form-urlencoded")
            {
                requestData.AddRange(request.InputStream.ReadLength().ParseQueryString());
            }

            var responseText = ProcessRequest(path.ToLower(), request.HttpMethod.ToUpper(), requestData);
            
            var responseBytes = System.Text.Encoding.UTF8.GetBytes(responseText);
            response.ContentType = "text/html";
            response.ContentLength64 = responseBytes.Length;
            response.OutputStream.Write(responseBytes, 0, responseBytes.Length);
            
            response.Close();

            PostProcessRequest(path, request.HttpMethod, requestData);
        }
    }
}
