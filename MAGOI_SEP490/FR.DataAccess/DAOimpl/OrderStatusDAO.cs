using FR.BusinessObjects.DataContext;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;
using FR.DataAccess.DAO;

namespace FR.DataAccess.DAOimpl
{
    public class OrderStatusDAO : BaseDAO<OrderStatus>, IOrderStatusDAO
    {
        public OrderStatusDAO(DBContext context) : base(context)
        {
        }
    }
}
