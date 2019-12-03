using System;
using Unity;

namespace dip_ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ICustomerDataAccessLayer, CustomerDataAccessLayer>();

            var customerEntity = container.Resolve<CustomerEntity>();

            int customerid = 5;

            Console.WriteLine(customerEntity.GetCustomerName(customerid));
        }
    }
}
