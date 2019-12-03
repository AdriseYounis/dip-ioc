namespace dip_ioc
{
    public class CustomerEntity
    {
        ICustomerDataAccessLayer customerDataAccess;

        public CustomerEntity(ICustomerDataAccessLayer customerDataAccess)
        {
            this.customerDataAccess = customerDataAccess;
        }

        public string GetCustomerName(int id) 
        {
            return customerDataAccess.GetCustomerName(id);
        }
    }
}