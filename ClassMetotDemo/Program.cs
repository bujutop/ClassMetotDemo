using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 102605;
            customer1.Name = "Nurettin";
            customer1.Surname = "Ayıpettin";
            customer1.AccountNumber = "123456789";
            customer1.Debt = 365.50;
            

            Customer customer2 = new Customer();
            customer2.ID = 321654;
            customer2.Name = "Bazı";
            customer2.Surname = "İsimler";
            customer2.AccountNumber = "987654321";
            customer2.Debt = 826.70;

            Customer customer3 = new Customer();
            customer3.ID = 987321;
            customer3.Name = "Çeşitli";
            customer3.Surname = "Soyadlar";
            customer3.AccountNumber = "456321987";
            customer3.Debt = 1956.88;

            Customer customer4 = new Customer();
            customer4.ID = 546798;
            customer4.Name = "Zengin";
            customer4.Surname = "Şahıs";
            customer4.AccountNumber = "999888777";
            customer4.Debt = 0;            
;

            CustomerManager newCustomer = new CustomerManager();
            newCustomer.AddCustomer(customer4);
            Console.WriteLine("-----");

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerlist = new CustomerManager();
            Console.WriteLine("Müşreti Listesi:" + "\n");
            customerlist.ListCustomers(customers);
            Console.WriteLine("-----");

            CustomerManager customerLoan = new CustomerManager();
            double exchangeRate = 5.86;
            double loan = customer1.Debt;
            customerLoan.DebtPayment(out exchangeRate, loan,customer1);
            Console.WriteLine("------");

            Object[] options = new Object[] { "Vadeyi uzatma", "Yeniden yapılandırma", "Haciz işlemi başlatma" };
            CustomerManager customerOptions = new CustomerManager();
            customerOptions.TotalDebt(customers, options);



            










        }
    }
}
