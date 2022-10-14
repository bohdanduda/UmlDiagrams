using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class TextValidator
    {
        public bool Validate(string text, List<string> strings)
        {
            if (!this.ValidateText(text) && this.ValidateUniqueName(strings))
            {
                return false;
            }
             return true;

        }

        public bool ValidateText(string text)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            return regex.IsMatch(text);
        }


        public bool ValidateUniqueName(List<string> strings)
        {
            foreach (string item in strings)
            {
                if (item == item)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
