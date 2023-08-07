using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine_Storage
{
    internal class Medicine
    {
        public int id{get; set;}
        public string name { get; set; }
        public double amount { get; set; }
        public int quantity { get; set; }
        public Medicine(int id, string name, double amount, int quantity) {
            this.id = id;
            this.name = name; ;
            this.amount = amount;
            this.quantity = quantity;
        }
        public Medicine() { }
        public String ToString()
        {
            return this.id+", "+this.name+ ", "+this.amount+ ", "+this.quantity;
        }
    }
}
