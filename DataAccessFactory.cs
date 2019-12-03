namespace dip_ioc
{
    public class DataAccessFactory
    {
        public static DataAccessLayer DataAccessLayer() 
        {
            return new DataAccessLayer();
        } 
    }
}