namespace dip_ioc
{
     public class CustomerDataAccessLayer : ICustomerDataAccessLayer
    {
        public CustomerDataAccessLayer()
        {
            
        }

        public string GetCustomerName(int id) => $"Dummy Customer";
    }
}