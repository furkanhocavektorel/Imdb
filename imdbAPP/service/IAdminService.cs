using imdbAPP.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imdbAPP.service
{
    internal interface IAdminService
    {
        public void save(string name,string username,string password);
        public void deleteById(int id);
        public void updateById(int id,string name);

        public Admin findById(int id);
        
        public List<Admin> findByName(string name);
      
    }
}
