static public class Data
{
    static public List<User> phoneList = new List<User>();

    static public bool CheckUser(string userInfo)
    {
        foreach(User i in Data.phoneList)
        {
            if(i.name == userInfo || i.surName == userInfo)
            {
                return true;
            }
        }

        return false;
    }
}