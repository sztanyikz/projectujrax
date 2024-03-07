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

