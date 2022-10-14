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
        public bool ValidateText(string text)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9]+$");

            return regex.IsMatch(text);
        }

        public bool ValidateUniqueName(List<string> existingNames, string newName)
        {
            foreach (string name in existingNames)
            {
                if (newName==name)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
