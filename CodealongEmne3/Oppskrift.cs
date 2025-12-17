using System;
using System.Collections.Generic;
using System.Text;

namespace CodealongEmne3
{
    internal class Oppskrift
    {
        public string Name;
        public string[] Ingredients;
        public string[] Category;

        public Oppskrift(string name, string[] ingredients, string[] category)
        {
            Name = name;
            Ingredients = ingredients;
            Category = category;
        }


    }
}
