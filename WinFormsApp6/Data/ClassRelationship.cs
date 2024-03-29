﻿namespace WinFormsApp6.Data
{
    public class ClassRelationship
    {
        public string Type { get; set; }

        public string RelatedClassName { get; set; }

        public override string ToString()
        {
            return $"{Type} - {RelatedClassName}";
        }
    }
}
