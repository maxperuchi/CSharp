using System.Collections.Generic;
using VUMeter.Controller;
using VUMeter.Plugin;

namespace VUMeter.Controllers
{
    public class CoreController
    {
        List<VUController> _vuControllers;
        List<IPlugin> _plugins;

        public CoreController()
        {
            this._vuControllers = new List<VUController>();
            this._plugins = PluginHelper.GetAvaliablePlugins();

            foreach (IPlugin plugin in _plugins)
            {
                _vuControllers.Add(new VUController(plugin.VU));
            }

            _plugins.ForEach(p => p.Start());
        }
        public List<VUController> VUControllers
        {
            get
            {
                return _vuControllers;
            }
        }

        public List<IPlugin> Plugins
        {
            get
            {
                return _plugins;
            }
        }

    }
}
