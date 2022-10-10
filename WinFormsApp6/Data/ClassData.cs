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

        public List<ClassMethod> Methods = new List<ClassMethod>() {
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "int",
            Name = "method1"
            },
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "int",
            Name = "method2"
            },
            new ClassMethod() {
            AccessModifier = "public",
            DataType = "int",
            Name = "method3"
            }
        };
    }
}
