namespace dip_ioc
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccessLayer GetDataAccessLayer() 
        {
            return new CustomerDataAccessLayer();
        } 
    }
}