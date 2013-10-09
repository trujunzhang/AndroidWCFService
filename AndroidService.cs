using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AndroidWCFService.Model;

namespace AndroidWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AndroidService : IAndroidService
    {
        public List<string> GetAllJokes()
        {
            List<string> Jokes = new List<string>();

            using (AndroidEF ef = new AndroidEF())
            {
                Jokes = (from x in ef.Tables
                         select x.Joke).ToList<string>();

            }

            return Jokes;
        }

        public bool AddJoke(string joke)
        {
            using (AndroidEF ef = new AndroidEF())
            {
                Table t = new Table();
                t.Joke = joke;
                ef.Tables.Add(t);
                ef.SaveChanges();

                return true;
            }

            return false;
        }
    }

}
