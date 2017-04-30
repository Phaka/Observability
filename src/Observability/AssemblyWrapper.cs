namespace Observability
{
    using System.Reflection;
    using Abstractions;

    public class AssemblyWrapper : IAssembly
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
        }

        public Assembly Assembly { get; }

        public string FileVersion
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyFileVersionAttribute>();
                return attribute?.Version;
            }
        }

        public string FullName
        {
            get
            {
                return Assembly?.FullName;
            }
        }

        public string Version
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyVersionAttribute>();
                return attribute?.Version;
            }
        }

        public string InformationalVersion
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
                return attribute?.InformationalVersion;
            }
        }

        public string Company
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyCompanyAttribute>();
                return attribute?.Company;
            }
        }

        public string Configuration
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyConfigurationAttribute>();
                return attribute?.Configuration;
            }
        }

        public string Copyright
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyCopyrightAttribute>();
                return attribute?.Copyright;
            }
        }

        public string Description
        {
            get
            {
                var attribute = Assembly?.GetCustomAttribute<AssemblyDescriptionAttribute>();
                return attribute?.Description;
            }
        }
    }
}