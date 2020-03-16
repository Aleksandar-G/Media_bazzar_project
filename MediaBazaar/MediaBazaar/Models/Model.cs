using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.Models
{
    public abstract class Model
    {
        protected DBconnection dbConnection;

        public Model()
        {
           dbConnection  = new DBconnection();
        }

        public abstract void Insert();


        public abstract void Update<T>(T obj);

        public abstract void Delete();
    }
}
