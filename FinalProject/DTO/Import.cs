﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public class Import
    {
        public Import (int id, DateTime? dateCheckOut)
        {
            this.ID = id;
            this.DateCheckOut = dateCheckOut;
        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        public Import(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckOut = (DateTime?)row["dateCheckOut"];
        }
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
