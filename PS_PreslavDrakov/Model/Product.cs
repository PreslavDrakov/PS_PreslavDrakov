using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.Model
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProdId { get; set; }

        public string ProdName { get; set; }

        public int ProdQty { get; set; }

        public decimal ProdPrice { get; set; }


    }
}
