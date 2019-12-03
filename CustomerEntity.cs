namespace dip_ioc
{
    public class CustomerEntity
    {
        public CustomerEntity()
        {
        }

        public string GetCustomerName(int id) 
        {
            var dataAccessLayer = DataAccessFactory.GetDataAccessLayer();
            return dataAccessLayer.GetCustomerName(id);
        }
    }
}