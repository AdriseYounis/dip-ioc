namespace dip_ioc
{
    public class DataAccessFactory
    {
        public static DataAccessLayer GetDataAccessLayer() 
        {
            return new DataAccessLayer();
        } 
    }
}