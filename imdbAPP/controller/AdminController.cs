using imdbAPP.model;
using imdbAPP.service;


namespace imdbAPP.controller
{
    internal class AdminController
    {
        IAdminService IadminService;
        public AdminController()
        {
            IadminService = new AdminService();
        }

        public void save(string name , string username,string password)
        {
            IadminService.save(name,username,password);
        }
        public Admin getById(int id)
        {
            return IadminService.findById(id);
        }
        public void deleteById(int id)
        {
            IadminService.deleteById(id);
        }

        
    }
}
