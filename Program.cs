namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fMember1 = new FamilyMember()
            { Name = "Дедушка Толя", SurName = "Иванов", Gender = Gender.Male, BirthDate = new DateTime(1990, 12, 10) };
            var fMember2 = new FamilyMember()
            { Name = "Бабушка Нина", SurName = "Иванова", Gender = Gender.Female, BirthDate = new DateTime(1990, 12, 10) };

            var fMember3 = new FamilyMember()
            { Name = "Дедушка Петя", SurName = "Петров", Gender = Gender.Male, BirthDate = new DateTime(1990, 12, 10) };
            var fMember4 = new FamilyMember()
            { Name = "Бабушка Зина", SurName = "Петрова", Gender = Gender.Female, BirthDate = new DateTime(1990, 12, 10) };

            var fMember5 = new FamilyMember()
            {   Name = "Папа Саша",
                SurName = "Иванов", 
                Gender = Gender.Male, 
                BirthDate = new DateTime(1990, 12, 10),
                Father = fMember1, 
                Mother = fMember2 };
            var fMember6 = new FamilyMember()
            {   Name = "Мама Света",
                SurName = "Иванова", 
                Gender = Gender.Female, 
                BirthDate = new DateTime(1990, 12, 10),
                Father = fMember3, 
                Mother = fMember4 };

            var fMember7 = new FamilyMember()
            {
                Name = "Сын Семен",
                SurName = "Иванов",
                Gender = Gender.Male,
                BirthDate = new DateTime(1990, 12, 10),
                Father = fMember5,
                Mother = fMember6};
            var fMember8 = new FamilyMember()
            {
                Name = "Дочь Галя",
                SurName = "Иванова",
                Gender = Gender.Male,
                BirthDate = new DateTime(1990, 12, 10),
                Father = fMember5,
                Mother = fMember6};

            var service = new FamilyMemberService();
            service.AddPerson(fMember1, fMember2, fMember3, fMember4, fMember5, fMember6, fMember7, fMember8);

            Console.WriteLine("-------------------------------------------------");            
            service.GetParents(service.FindHusbandOrWife(fMember5));
            Console.WriteLine("-------------------------------------------------");
        }

    }
}
