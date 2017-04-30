#region License

// The MIT License (MIT)
// 
// Copyright (c) 2017 Werner Strydom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

namespace Observability.AspNetCore.Mvc.Controllers
{
    using Abstractions;
    public class AssemblyModel
    {
        private readonly IAssembly _assembly;

        public AssemblyModel(IAssembly assembly)
        {
            _assembly = assembly;
        }

        public string FileVersion
        {
            get { return _assembly.FileVersion; }
        }

        public string Version
        {
            get { return _assembly.Version; }
        }

        public string InformationalVersion
        {
            get { return _assembly.InformationalVersion; }
        }

        public string Company
        {
            get { return _assembly.Company; }
        }

        public string Configuration
        {
            get { return _assembly.Configuration; }
        }

        public string Copyright
        {
            get { return _assembly.Copyright; }
        }

        public string Description
        {
            get { return _assembly.Description; }
        }

        public string FullName
        {
            get { return _assembly.FullName; }
        }
    }
}