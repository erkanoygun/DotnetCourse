public class UserAdded
{
    static public bool UserAddedInList()
    {
        Console.WriteLine("Please enter user name: ");
        string? userName = Console.ReadLine();
        Console.WriteLine("Please enter user surname: ");
        string? userSurName = Console.ReadLine();
        Console.WriteLine("Please enter user number: ");
        long number = Convert.ToInt64(Console.ReadLine());

        User user = new User(userName!,userSurName!,number);
        Data.phoneList.Add(user);

        return true;
    }
}
