/*A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age,
gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single 
employee using appropriate data types and descriptive names.*/

using System;

class RecordOfEmloyes
{
    static void Main()
    {
        string FirstName;
        string FamilyName;
        byte age; //using byte becouse the age would'n be more than 100 and that will be verry rare
        string gender;
        uint IDNumber;
        uint EmployeeNumber;

        Console.Write("First Name:");
        FirstName = Console.ReadLine();
        Console.Write("Family Name:");
        FamilyName = Console.ReadLine();
        Console.Write("Age:");
        age = byte.Parse(Console.ReadLine());
        Console.Write("Gender(Male or Female):");
        gender = Console.ReadLine();
        Console.Write("ID Number:");
        IDNumber = uint.Parse(Console.ReadLine());
        Console.Write("Employe Number:");
        EmployeeNumber= uint.Parse(Console.ReadLine());

        Console.WriteLine(@"Details for this employee:
First Name: {0}
Family Name: {1}
Age: {2}
Gender: {3}
ID Number: {4}
Emplyee Number: {5}", FirstName, FamilyName, age, gender, IDNumber, EmployeeNumber);
    }
}
