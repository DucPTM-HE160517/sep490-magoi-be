using FR.BusinessObjects.Models;

namespace FR.Services.GraphQL.Payload
{
    public class FinishOrderPayload : Payload
    {
        public List<Order>? Orders { get; }
        public Bill? Bill { get; }
        public FinishOrderPayload(List<Order> orders, Bill bill)
        {
            Orders = orders;
            Bill = bill;
        }

        public FinishOrderPayload(UserError error) : base(error) { }
    }
}
