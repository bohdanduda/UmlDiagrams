namespace WinFormsApp6.Data
{
    public class ClassData
    {
        public string ClassName { get; set; } = "";

        public List<ClassProperty> Properties = new List<ClassProperty>() {
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "int",
                Name = "Property1"
            },
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "string",
                Name = "Property2"
            },
            new ClassProperty() {
                AccessModifier = "public",
                DataType = "string",
                Name = "Property3"
            },
        };

        public List<ClassMethod> Methods = new List<ClassMethod>() {
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "int",
            Name = "Method1"
            },
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "string",
            Name = "Method2"
            },
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "string",
            Name = "Method3"
            }
        };
    }
}
