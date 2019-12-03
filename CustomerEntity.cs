namespace dip_ioc
{
    public class CustomerEntity
    {
        DataAccessLayer dataAccess;

        public CustomerEntity()
        {
            dataAccess = new DataAccessLayer();
        }

        public string GetCustomerName(int id) => dataAccess.GetCustomerName(id);
    }
}