using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryContacts();
        }

        private static void QueryContacts()
        {
            using (var context = new SampleEntities())
            {
                var contacts = from c in context.Contacts select c;

                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName);
                }

                Console.Read();
            }
        }
    }
}
