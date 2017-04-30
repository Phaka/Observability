namespace Observability.Abstractions
{
    public interface IAssembly
    {
        string FileVersion { get; }
        string Version { get; }
        string InformationalVersion { get; }
        string Company { get; }
        string Configuration { get; }
        string Copyright { get; }
        string Description { get; }
        string FullName { get; }
    }
}