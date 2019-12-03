namespace dip_ioc
{
     public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        public string GetCustomerName(int id) => $"Dummy Customer";
    }
}