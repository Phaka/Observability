namespace Observability
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Abstractions;

    public class DefaultAssemblyProvider : IAssemblyProvider
    {

        private static Assembly GetEntryAssembly()
        {
            return (typeof(Assembly).GetMethod("GetEntryAssembly", BindingFlags.NonPublic | BindingFlags.Static) ?? typeof(Assembly).GetMethod("GetEntryAssembly", BindingFlags.Public | BindingFlags.Static)).Invoke((object)null, Array.Empty<object>()) as Assembly;
        }

        public IEnumerable<IAssembly> GetAssemblies()
        {
            var visited = new HashSet<Assembly>();
            var stack = new Stack<Assembly>();
            stack.Push(GetEntryAssembly());
            while (stack.Count > 0)
            {
                var assembly = stack.Pop();
                if (visited.Contains(assembly))
                {
                    continue;
                }
                visited.Add(assembly);

                foreach (var referencedAssemblyName in assembly.GetReferencedAssemblies())
                {
                    var referencedAssembly = Assembly.Load(referencedAssemblyName);
                    stack.Push(referencedAssembly); 
                }

                yield return new AssemblyWrapper(assembly);
            }
        }
    }
}