using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDescr { set; get; }

        public string longDescr { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool isFavorite { set; get; }

        public int available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }


    }
}
