internal class Program
{
    private static void Main(string[] args)
    {
        Data.phoneList = new List<User>() {
        new User("Ahmet","Kara",999999999)
        ,new User("Helin","Baş",888888888)
        ,new User("Zeynep","Atlı",77777777)
        ,new User("Kenan","Büyük",66666666)
        ,new User("Ersin","Tetik",555555555)};

        ProgramStart();

    }



    static private void ProgramStart()
    {
        while (true)
        {
            int choice2 = 0;
            Console.WriteLine("Please select the action you want to take: ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1-Register user\n2-User deleted\n3-User updated\n4-Show list\n5-Search in list");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (UserAdded.UserAddedInList())
                {
                    Console.WriteLine("User added is succes");
                }
            }


            else if (choice == 2)
            {
                choice2 = 0;
                while (true)
                {
                    if (UserDelete.UserDeleteInList())
                    {
                        Console.WriteLine("User delete is succes");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User not fount in list.\n1-To finalize deletion\n2-To try Again:");
                        choice2 = Convert.ToInt32(Console.ReadLine());

                        if (choice2 == 1)
                        {
                            break;
                        }
                    }
                }
            }


            else if (choice == 3)
            {
                choice2 = 0;

                while (true)
                {
                    if (UserUpdate.UserUpdatedInList())
                    {
                        Console.WriteLine("User update is succes");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User not fount in list.\n1-To finalize deletion\n2-To try Again:");
                        choice2 = Convert.ToInt32(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            break;
                        }
                    }
                }
            }

            else if (choice == 4)
            {
                UserListShow.UserShow();
            }

            else if (choice == 5)
            {
                while (true)
                {
                    if (SearchUser.SearchUserInList())
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User not found in list");
                        break;
                    }
                }

            }

            else
            {
                break;
            }
        }
    }
}

