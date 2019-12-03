namespace dip_ioc
{
    public class CustomerEntity
    {
        ICustomerDataAccessLayer customerDataAccess;
        
        public CustomerEntity()
        {
            customerDataAccess = DataAccessFactory.GetDataAccessLayer();
        }

        public string GetCustomerName(int id) 
        {
            return customerDataAccess.GetCustomerName(id);
        }
    }
}