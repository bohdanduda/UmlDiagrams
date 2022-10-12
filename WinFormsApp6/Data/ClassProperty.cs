namespace WinFormsApp6.Data
{
    public class ClassProperty
    {
        public string AccessModifier { get; set; }
        public string DataType { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            if (this.AccessModifier == "public")
            {
                return $" + {this.DataType} {this.Name}()";
            }
            else if (this.AccessModifier == "private")
            {
                return $" - {this.DataType} {this.Name}()";
            }

            return $" # {this.DataType} {this.Name}()";
        }
    }
}
