public class Board
{
    private static List<ToDoCart> toDoCartsList = new List<ToDoCart>() {
        new ToDoCart("Title", "AnythinkCnt",1,SizeToDOEnum.M,ColonsEnum.DONE),
        new ToDoCart("Title2", "AnythinkCnt2",2,SizeToDOEnum.S,ColonsEnum.IN_PROGRESS),
        new ToDoCart("Title3", "AnythinkCnt3",3,SizeToDOEnum.XL,ColonsEnum.TODO)
    };

    static public bool AddCartInBoard(ToDoCart cart)
    {
        toDoCartsList.Add(cart);
        return true;
    }

    static public ProcessType CartMoved()
    {
        ColonsEnum newColon;
        Console.WriteLine("Enter title");
        string title = Console.ReadLine()!;
        Console.WriteLine("Select new Colon 1(TODO), 2(IN_PROGRESS),3(DONE)");
        int choise = Convert.ToInt32(Console.ReadLine());

        switch (choise)
        {
            case 1:
                {
                    newColon = ColonsEnum.TODO;
                    break;
                }
            case 2:
                {
                    newColon = ColonsEnum.IN_PROGRESS;
                    break;
                }
            case 31:
                {
                    newColon = ColonsEnum.DONE;
                    break;
                }
            default:
                {
                    newColon = ColonsEnum.TODO;
                    break;
                }
        }

        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Title == title)
            {
                i.Colons = newColon;
                return ProcessType.Succes;
            }
        }
        return ProcessType.CartNotFound;
    }

    static public ProcessType CartDeleted()
    {
        Console.WriteLine("Enter cart title: ");
        string? cartTitle = Console.ReadLine();

        bool removedCart = false;
        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Title == cartTitle!)
            {
                toDoCartsList.Remove(i);
                removedCart = true;
                break;
            }
        }

        if (removedCart)
            return ProcessType.Succes;
        else
            return ProcessType.CartNotFound;
    }

    static public void ShowCartsList()
    {
        Console.WriteLine("\n*********** TODO ***********");
        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Colons == ColonsEnum.TODO)
            {
                Console.WriteLine($"Title: {i.Title}\nContent: {i.Content}\nUser ID: {i.AssignedUserID}\nSize: {i.SizeToDo}");
                Console.WriteLine("---------------------------");
            }

        }
        Console.WriteLine("\n*********** IN_PROGRESS ***********");
        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Colons == ColonsEnum.IN_PROGRESS)
            {
                Console.WriteLine($"Title: {i.Title}\nContent: {i.Content}\nUser: {i.AssignedUserID}\nSize: {i.SizeToDo}");
                Console.WriteLine("---------------------------");
            }
        }
        Console.WriteLine("\n*********** Done ***********");
        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Colons == ColonsEnum.DONE)
            {
                Console.WriteLine($"Title: {i.Title}\nContent: {i.Content}\nUser: {i.AssignedUserID}\nSize: {i.SizeToDo}");
                Console.WriteLine("---------------------------");
            }
        }
    }

    static public ProcessType CartUpdate(string cartTitle)
    {
        foreach (ToDoCart i in toDoCartsList)
        {
            if (i.Title == cartTitle)
            {
                Console.WriteLine("Please enter new title: ");
                i.Title = Console.ReadLine()!;
                Console.WriteLine("Please enter new content: ");
                i.Content = Console.ReadLine()!;
                return ProcessType.Succes;
            }
        }

        return ProcessType.CartNotFound;
    }
}