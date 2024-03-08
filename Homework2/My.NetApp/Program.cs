internal class Program
{
    private static void Main(string[] args)
    {
        ProgramStart();
    }

    static private void ProgramStart()
    {
        while (true)
        {
            Console.WriteLine("Please select the action you want to perform");
            Console.WriteLine("1-Board Show\n2-Add cart\n3-Delete Cart\n4-Moved Cart: ");
            int choise = Convert.ToInt32(Console.ReadLine());

            if (choise == 1)
            {
                Board.ShowCartsList();
            }


            else if (choise == 2)
            {
                ProcessType processType = ToDoCart.CreateNewCart();
                
                if(processType == ProcessType.Succes)
                {
                    Console.WriteLine("---------Create New Cart Succes----------");
                    continue;
                }
                else if(processType == ProcessType.UserNotFound)
                {
                    Console.WriteLine("-----------User Not Found-----------");
                    continue;
                }
                else
                    continue;
            }

            else if (choise == 3)
            {
                while (true)
                {
                    ProcessType processType = Board.CartDeleted();
                    if (processType == ProcessType.Succes)
                    {
                        Console.WriteLine("-----Cart Deleted------\n");
                        break;
                    }
                    else if (processType == ProcessType.CartNotFound)
                    {
                        Console.WriteLine("Cart Not Found\n1-Try again\n2-End process: ");
                        int choise2 = Convert.ToInt32(Console.ReadLine());

                        if(choise2 != 1)
                            break;
                    }
                }
            }


            else if (choise == 4)
            {

                ProcessType processType = Board.CartMoved();
                if(processType == ProcessType.Succes)
                {
                    Console.WriteLine("-------Moved Success------");
                    continue;
                }
                else if(processType == ProcessType.CartNotFound)
                {
                    Console.WriteLine("---------Moved Failed - Cart Not Found-----------");
                    continue;
                }
            }
            else
            {
                break;
            }
        }
    }

}

