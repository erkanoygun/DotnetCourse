static class UserListShow
{
    static public bool UserShow()
    {
        int count = 1;
        foreach(User i in Data.phoneList)
        {
            Console.WriteLine($"**************{count}. User********");
            Console.WriteLine($"Name Surname: {i.name} {i.surName} Number: {i.number}");
            count++;
        }
        return true;
    }
}