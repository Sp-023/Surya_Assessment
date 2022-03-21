using Generate_Invest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generate_Invest_Api.ApiServices
{
    public class Class_Api_Service : Interface_Api_Service
    {
        private readonly InvestApiContext db;

        public Class_Api_Service(InvestApiContext Db)
        {
            db = Db;
        }


        public IEnumerable<Invest> GetAll()
        {
            return db.Invest.ToList();
        }
        public Invest Add_Invest(Invest prod)
        {
             db.Invest.Add(prod);
            db.SaveChanges();
            return prod;

        }

        public Invest Delete_Invest(int id)
        {
            var dd = db.Invest.Find(id);
            db.Invest.Remove(dd);
            db.SaveChanges();
            return dd;
        }

       

        public Invest Update_Invest(Invest prod)
        {
            db.Entry(prod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return prod;
        }
    }
}
