using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Goods
    {
        public Goods(int id, string name, int iDCategory, int price)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = iDCategory;
            this.Price = price;
        }

        public Goods(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["iDCategory"];
            this.Price = (int)row["UPRICE_DELIVERY"];
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private int iDCategory;

        public int IDCategory
        {
            get { return iDCategory; }
            set { iDCategory = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
