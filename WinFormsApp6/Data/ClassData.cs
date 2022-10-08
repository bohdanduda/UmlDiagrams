namespace WinFormsApp6.Data
{
    public class ClassData
    {
        public string ClassName { get; set; } = "";
        public List<ClassProperty> Properties = new List<ClassProperty>() {
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "int",
                Name = "id"
            },
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "string",
                Name = "name"
            },
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "string",
                Name = "surname"
            },
        };
        public List<string> Methods = new List<string> { "method1", "method2", "method3" };
    }
}
