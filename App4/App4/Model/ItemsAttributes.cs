using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Model
{
   public class ItemsAttributes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}
