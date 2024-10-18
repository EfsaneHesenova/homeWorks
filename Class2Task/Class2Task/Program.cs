using Class2Task;
using System.Security.Cryptography.X509Certificates;

Group groupObj = null;
while (true)
{
    Console.WriteLine("1. Grup elave et \n2. Telebe elave et \n3. Qruplari goster \n4. Telebeleri goster \n5. Telebe qrupda varmi? \n6. davamiyyet \nsecim et: ");
    string choise = Console.ReadLine();
    switch (choise)
    {
        case "1":
            string groupName;
            string shift;
            Console.Write("Grup adi: ");
            groupName = Console.ReadLine();
            Console.Write("Simen: ");
            shift = Console.ReadLine();

            groupObj = new Group(groupName, shift);
            break;

        case "2":
            if (groupObj == null)
            {
                Console.WriteLine("qrup elave et!");
                continue;
            }
            string Name;
            string Surname;
            string Gender;
            int Age;
            int PhoneNumber;
            string StudentGroup;
            Console.WriteLine("adi:");
            Name = Console.ReadLine();
            Console.WriteLine("soyadi:");
            Surname = Console.ReadLine();
            Console.WriteLine("cinsi:");
            Gender = Console.ReadLine();
            Console.WriteLine("yasi:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("nomresi:");
            PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("qrupu:");
            StudentGroup = Console.ReadLine();

            groupObj.AddStudent(Name, Surname, Gender, Age, PhoneNumber, StudentGroup);
            break;
        case "3":
            for (int i = 0; i < Group.AllGroups.Length; i++)
            {
                Console.WriteLine(Group.AllGroups[i]);
            }
            break;
        case "4":
            for (int i = 0; i < groupObj.Students.Length; i++)
            {
                Console.WriteLine(groupObj.Students[i].Name + " " + groupObj.Students[i].SurName + " " + groupObj.Students[i].Gender + " " + groupObj.Students[i].Age + " " + groupObj.Students[i].PhoneNumber + " " + groupObj.Students[i].StudentGroup + " " + groupObj.Students[i].Limit );


            }

            break;
        case "5":
            string searchName;
            Console.WriteLine("adi:");
            searchName = Console.ReadLine();
            if (groupObj.FindStudent(searchName))
            {
                Console.WriteLine("var");
            }
            else
            {
                Console.WriteLine("axtardiginiz telebe yoxdur");
            }
            break;
        case "6":
            string absentName;
            Console.WriteLine("ad:");
            absentName = Console.ReadLine();
            groupObj.AbSent(absentName);
            break;

    }
}
