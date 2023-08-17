using System;
using Common.IO;
using nanoFramework.Json;

namespace Common.Configuration
{
    public abstract class ConfigurationBase
    {
        private const string Path = @"config.json";

        protected static object Load(Type type)
        {
            var json = InternalFlash.ReadAllText(Path);

            if (json == null)
                return Activator.CreateInstance(type);
            else
                return (Configuration)JsonConvert.DeserializeObject(json, type);
        }

        public void Save()
        {
            InternalFlash.WriteAllText(Path, JsonConvert.SerializeObject(this));
        }

        public void Delete()
        {
            InternalFlash.Delete(Path);
        }
    }
}