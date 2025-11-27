using Lab08.Editor;
using Lab08.Engine;
using Lab08.Engine.Lights;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;
using System;
using System.IO;
using System.Reflection;

namespace Lab08.Engine.Scripting
{
    internal class ScriptController
    {
        private static readonly Lazy<ScriptController> lazy = new(() => new ScriptController());
        public static ScriptController Instance { get { return lazy.Value; } }

        private readonly Script m_LUAScript = new();

        private ScriptController()
        {
        }

        public void RegisterMethods()
        {
        }

        public DynValue LoadScript(string _script)
        {
            return m_LUAScript.DoString(_script);
        }

        public void LoadEmbeddedScript(string _file)
        {
            m_LUAScript.Options.ScriptLoader = new EmbeddedResourcesScriptLoader(Assembly.GetCallingAssembly());
            m_LUAScript.DoFile(_file);
        }

        public void LoadScriptFile(string _file)
        {
            if (_file.Contains(".lua"))
            {
                int index = _file.IndexOf(".lua") + 4;
                _file = _file.Substring(0, index);
            }
            else
            {
                return;
            }
            using var inStream = new FileStream(_file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var streamReader = new StreamReader(inStream);
            string script = streamReader.ReadToEnd();
            LoadScript(script);
        }

        public void LoadSharedObjects(Project _project)
        {
            UserData.RegisterType<Light>();
            UserData.RegisterType<Terrain>();
            UserData.RegisterType<Level>();
            UserData.RegisterType<Camera>();
            UserData.RegisterType<Project>();
            DynValue project = UserData.Create(_project);
            m_LUAScript.Globals.Set("project", project);
        }

        public DynValue Execute(string _function, params object[] _params)
        {
            DynValue function = m_LUAScript.Globals.Get(_function);

            if (function.IsNil())
            {
                return function;
            }
            return m_LUAScript.Call(function, _params);
        }
    }
}
