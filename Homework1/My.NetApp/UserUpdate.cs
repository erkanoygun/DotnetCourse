public class UserUpdate
{
    static public bool UserUpdatedInList()
    {
        Console.WriteLine("Please enter user name and surname wich you want updated: ");
        string? userInfo = Console.ReadLine();

        if (Data.CheckUser(userInfo!))
        {
            Console.WriteLine("Please enter new number: ");
            long newNumber = Convert.ToInt64(Console.ReadLine());
            foreach (User i in Data.phoneList)
            {
                if (i.name == userInfo || i.surName == userInfo)
                {
                    i.number = newNumber;
                    return true;
                }
            }
        }

        return false;
    }
}