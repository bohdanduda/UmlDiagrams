using System.Runtime.CompilerServices;

namespace WinFormsApp6.Data
{
    public class ClassData
    {
        public string ClassName { get; set; } = "";
        public List<string> Properties = new List<string>() {"property1", "property2", "property3"};
        public List<string> Methods = new List<string> { "method1", "method2", "method3" };
    }
}
