using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri başarıyla eklendi");
        }

        public void ListCustomers(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Ad: " + customer.Name);
                Console.WriteLine("Soyad: " + customer.Surname);
                Console.WriteLine("Müşteri Numarası: " + customer.ID);
                Console.WriteLine("Hesap Numarası :" + customer.AccountNumber);
                Console.WriteLine("Borcu: " + customer.Debt + "USD");
                Console.WriteLine("\n");
            }
        }
        public double DebtPayment(out double exchangeRate, double debt, Customer customer)
        {
            exchangeRate = 7.48;
            double amount = exchangeRate * customer.Debt;
            Console.WriteLine("{0} {1} adlı müşterinin kredi borcu döviz oranına göre yeniden hesaplanmıştır.", customer.Name, customer.Surname);
            Console.WriteLine("Kredi Borcu: {0}TL", amount);
            Console.WriteLine("Döviz Oranı: {0}", exchangeRate);
            Console.WriteLine("\n");
            return amount;
        }

        public void TotalDebt(Customer[] customers,params object[] options  )
        {
            foreach (var customer in customers)
            {
                if (customer.Debt > 0) 
                {
                    Console.WriteLine("{0} {1} adlı müşterinin {2}USD borcuna yönelik opsiyonları:",customer.Name,customer.Surname,customer.Debt);
                    foreach (var item in options)
                    {
                        Console.WriteLine(item); ;
                    }
                }
                else 
                {
                    Console.WriteLine("{0} {1} adlı müşteriyi krediye teşvik ediniz.",customer.Name,customer.Surname);
                    
                }
                Console.WriteLine("\n");
            }



            
            
           
           
            
                    
            
        }
    }
}
