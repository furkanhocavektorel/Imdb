using imdbAPP.service;


namespace imdbAPP.controller
{
    internal class CustomerCommentController
    {
        IBaseInterface service;
            public CustomerCommentController(IBaseInterface service)
        {
            this.service = service;
        }
    }
}
