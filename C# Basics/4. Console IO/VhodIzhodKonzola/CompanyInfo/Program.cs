using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxnumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();
            Console.WriteLine(companyName);
            Console.WriteLine("Address: "+companyAddress);
            Console.WriteLine("Tel. "+phoneNumber);
            Console.WriteLine("Fax: "+(string.IsNullOrWhiteSpace(faxnumber)==true? "(no fax)": faxnumber));
            Console.WriteLine("Web site: "+webSite);
            Console.WriteLine("Manager: "+firstName+" "+lastName+" (age: "+age+", tel. "+managerPhone+")");
        }
    }
}
