public class ToDoCart
{
    private string title;
    private string content;
    private int assignedUserID;
    private SizeToDOEnum sizeToDo;
    private ColonsEnum colons;

    public string Title { get => title; set => title = value; }
    public string Content { get => content; set => content = value; }
    public int AssignedUserID { get => assignedUserID; set => assignedUserID = value; }
    public SizeToDOEnum SizeToDo { get => sizeToDo; set => sizeToDo = value; }
    public ColonsEnum Colons { get => colons; set => colons = value; }

    public ToDoCart(string title, string content, int assignedUserID, SizeToDOEnum sizeToDo, ColonsEnum colons)
    {
        this.title = title;
        this.content = content;
        this.assignedUserID = assignedUserID;
        this.sizeToDo = sizeToDo;
        this.colons = colons;
    }

    static public ProcessType CreateNewCart()
    {
        Console.WriteLine("Please enter title: ");
        string? title = Console.ReadLine();
        Console.WriteLine("Please enter content: ");
        string? content = Console.ReadLine();
        Console.WriteLine("Please enter assigned user id: ");
        int assignedUserID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter assigned size cart\nXS(1),S(2),M(3),L(4),XL(5): ");
        int cartSize = Convert.ToInt32(Console.ReadLine());
        SizeToDOEnum sizeEnum;
        switch (cartSize)
        {
            case 1:
                {
                    sizeEnum = SizeToDOEnum.XS;
                    break;
                }
            case 2:
                {
                    sizeEnum = SizeToDOEnum.S;
                    break;
                }
            case 3:
                {
                    sizeEnum = SizeToDOEnum.M;
                    break;
                }
            case 4:
                {
                    sizeEnum = SizeToDOEnum.L;
                    break;
                }
            case 5:
                {
                    sizeEnum = SizeToDOEnum.XL;
                    break;
                }
            default:
                {
                    sizeEnum = SizeToDOEnum.XL;
                    break;
                }
        }

        foreach (User item in User.UserList)
        {
            if (item.Id == assignedUserID)
            {
                ToDoCart newCart = new ToDoCart(title!, content!, assignedUserID, sizeEnum, ColonsEnum.TODO);
                Board.AddCartInBoard(newCart);
                return ProcessType.Succes;
            }
        }
        return ProcessType.UserNotFound;

    }


}