

using imdbAPP.context;
using imdbAPP.db;
using imdbAPP.model;

namespace imdbAPP.service
{
    // ortak interface
    internal class AdminService : IAdminService
    {
        AdminContext adminContext;

        public AdminService()
        {
            adminContext = new AdminContext();
        }

        public void save(string name, string username, string password)
        {
            adminContext.save(name, username, password);
        }
        public void deleteById(int id)
        {
            Admin admin = null;
            admin=findById(id);
            if (admin != null)
            {
                adminContext.deleteById(admin);

            }


        }

        public Admin findById(int id)
        {
            return adminContext.findById(id);
        }

        public List<Admin> findByName(string name)
        {
            return null;
        }



        public void updateById(int id, string name)
        {
        }
    }
}
