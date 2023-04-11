using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyAppLiam
{
    public class user
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    


        public static void MyList()
        {
            List<user> users = new List<user>();

            users.Add(new user { Name = "Liam Kilsdonk", Id = 1 });
            users.Add(new user { Name = "Meneer Held", Id = 2 });
            users.Add(new user { Name = "Luke Peters", Id = 3 });
            users.Add(new user { Name = "Amber Opsteen", Id = 4 });
            users.Add(new user { Name = "Daan Parker", Id = 5 });

        }
    }
}
