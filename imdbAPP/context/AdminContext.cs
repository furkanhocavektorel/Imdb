using imdbAPP.db;
using imdbAPP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdbAPP.context
{
    internal class AdminContext
    {
        public void save(string name, string username, string password)
        {
            Admin admin = new Admin();
            admin.Id = 1;
            admin.Username= username;
            admin.Password = password;
            admin.Name = name;
            Class1.Admins.Add(admin);
        }

        public void save(string name, string username, string password,string surname)
        {
            Admin admin = new Admin();
            admin.Id = 1;
            admin.Username = username;
            admin.Password = password;
            admin.Name = name;
            admin.Surname = surname;
            Class1.Admins.Add(admin);
        }

        internal Admin findById(int id)
        {
            Admin admin = new Admin();
            foreach(Admin a in Class1.Admins)
            {
                if(a.Id == id)
                {
                    admin.Surname=a.Surname;
                    admin.Name=a.Name;
                    admin.Id = a.Id;
                    admin.Username = a.Username;
                    admin.Password = a.Password;
                }
            }
            return admin;
        }

        public void deleteById(Admin admin)
        {       
                Class1.Admins.Remove(admin);   
        }
    }
}
