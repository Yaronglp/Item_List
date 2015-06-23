using System;
using System.Collections.Generic;
using System.Text;

namespace YGList.Logic
{
    [Serializable]
    public class Product
    {
        public Product(string i_ProductName)
        {
            Name = i_ProductName;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
