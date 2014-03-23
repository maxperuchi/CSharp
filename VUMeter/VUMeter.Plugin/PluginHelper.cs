using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
namespace VUMeter.Plugin
{
    public static class PluginHelper
    {
        public static List<IPlugin> GetAvaliablePlugins()
        {
            List<IPlugin> _result = new List<IPlugin>();

            foreach (var file in Directory.EnumerateFiles(Directory.GetCurrentDirectory(),"VUMeter.Plugin.*.dll",SearchOption.AllDirectories))
            {
                Assembly assembly = Assembly.LoadFrom(file);
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsClass == true)
                    {
                        if (type.FullName.EndsWith(".Plugin"))
                        {
                            _result.Add((IPlugin)Activator.CreateInstance(type));
                        }
                    }
                }
            }

            return _result;
        }
    }
}
