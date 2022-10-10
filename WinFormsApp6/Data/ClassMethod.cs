namespace WinFormsApp6.Data
{
    public class ClassMethod
    {
        public string AccessModifier { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"+ {this.AccessModifier} {this.DataType} {this.Name}()";
        }
    }
}
