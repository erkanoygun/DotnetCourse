static class SearchUser
{
    static public bool SearchUserInList()
    {
        Console.WriteLine("Please enter user name or surname wich you want search");
        string? userInfo = Console.ReadLine();

        if (Data.CheckUser(userInfo!))
        {
            foreach (User i in Data.phoneList)
            {
                if (i.name == userInfo || i.surName == userInfo)
                {
                    Console.WriteLine($"User number: {i.number}");
                    return true;
                }
            }
        }

        return true;
    }
}