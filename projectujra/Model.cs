using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectujra
{
    public class Model
    {
        private database mydb;
        public Model(database persistence)
        {
            mydb = persistence;

        }

        public int id(string vmi)
        {
            

        }

        public void save(string Username,string Pizzaname1,string Pizzaname2,string Pizzaname3,Int32 Pizza1size,Int32 Pizza2size,Int32 Pizza3size,Int32 Pizza1count,Int32 Pizza2count,Int32 Pizza3count,Int32 Summa)
        {

                using var trx = mydb.Database.BeginTransaction();
                mydb.order.Add(new Order { Username= Username ,Pizzaname1 = Pizzaname1,  Pizzaname2 = Pizzaname2,  Pizzaname3 = Pizzaname3,  Pizza1size = Pizza1size,  Pizza2size = Pizza2size,  Pizza3size = Pizza3size,  Pizza1count = Pizza1count,  Pizza2count = Pizza2count,  Pizza3count = Pizza3count,  Summa = Summa });
                trx.Commit();
                mydb.SaveChanges();
              
        }

        public bool Registration(string name, string pass)
        {
            if (mydb.user.Where(x => x.Name == name).Any())
            {
                return false;
            }
            else
            {
                using var trx = mydb.Database.BeginTransaction();
                mydb.user.Add(new User { Name = name, Password = pass });
                trx.Commit();
                mydb.SaveChanges();
                return true;
            }
        }
        public bool SigIn(string name, string pass)
        {
            return mydb.user.Where(x => x.Name == name && x.Password == pass).Any();
        }



    }

}

