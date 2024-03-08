public class User
{
    private string name;
    private int id;
    static private List<User> userList = new List<User>()
    {
        new User("Ali", 1),
        new User("Ahmet", 2),
        new User("Mehmet", 3),
        new User("Ece", 4),
        new User("Hüseyin", 5),
        new User("Kamil", 6)
    };

    public User(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public string Name { get => name; set => name = value; }
    public int Id { get => id; set => id = value; }
    public static List<User> UserList { get => userList; set => userList = value; }
}