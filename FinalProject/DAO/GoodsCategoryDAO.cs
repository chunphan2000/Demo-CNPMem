using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class GoodsCategoryDAO
    {
        private static GoodsCategoryDAO instance;

        public static GoodsCategoryDAO Instance
        {
            get { if (instance == null) instance = new GoodsCategoryDAO(); return GoodsCategoryDAO.instance; }
            private set { GoodsCategoryDAO.instance = value; }
        }

        private GoodsCategoryDAO() { }

        public List<GoodsCategory> GetListCategory()
        {
            List<GoodsCategory> list = new List<GoodsCategory>();

            string query = "select * from [GOODSCATEGORY]";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                GoodsCategory category = new GoodsCategory(item);
                list.Add(category);
            }

            return list;
        }
    }
}
