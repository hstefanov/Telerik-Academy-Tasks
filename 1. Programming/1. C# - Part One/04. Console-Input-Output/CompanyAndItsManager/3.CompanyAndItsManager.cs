using System;

class CompanyAndItsManager
{
    static void Main()
    {
        Console.WriteLine("Enter the name of the company :");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter adress of the company :");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter company phone number : ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Enter company fax : ");
        string fax = Console.ReadLine();
        Console.Write("Enter company web site : ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter company's manager name : ");
        Console.Write("First name : ");
        string firstName = Console.ReadLine();
        Console.Write("Second name :");
        string lastName = Console.ReadLine();
        Console.Write("Enter manager age : ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number : ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(new String('-',20) + "Informaton about {0} company" + new String('-',20),companyName);
        Console.WriteLine("Company : {0}\nAdress: {1}\nPhone :{2}\nFax :{3}\nWeb Site :{4}", companyName, adress, companyPhone, fax, webSite);
        Console.WriteLine("Manager : {0} {1} - {2} age\nPhone : {3}", firstName, lastName, age, managerPhone);
    }
}

