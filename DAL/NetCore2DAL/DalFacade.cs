using NetCore2DAL.Repositories;
using NetCore2DAL.UOW;

namespace NetCore2DAL
{
    public class DalFacade
    {  
        public IUOW UnitOfWork
        {
            get
            {
                return new UnitOfWork();
            }
        }
    }
}
