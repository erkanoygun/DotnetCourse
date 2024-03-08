static class UserDelete
{
    static public bool UserDeleteInList()
    {
        Console.WriteLine("Please enter user name and surname wich you want deleted: ");
        string? userInfo = Console.ReadLine();

        if (Data.CheckUser(userInfo!))
        {
            foreach (User i in Data.phoneList)
            {
                if (i.name == userInfo || i.surName == userInfo)
                {
                    Data.phoneList.Remove(i);
                    return true;
                }
            }
        }

        return false;
    }
}   