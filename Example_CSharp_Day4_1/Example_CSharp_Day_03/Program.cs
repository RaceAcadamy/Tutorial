using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_CSharp_Day_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;
            int deposit, withdraw;
            int choice, pin = 1234, x = 0;
            Console.WriteLine("Enter Your Pin Number ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU USING ATM");
                        break;
                }
            }
            Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
        }
    }
}



//unsigned long amount = 1000, deposit, withdraw;
//int choice, pin, k;
//char transaction = 'y';

//void main()
//{
//    while (pin != 1520)
//    {
//        printf("ENTER YOUR SECRET PIN NUMBER:");
//        scanf("%d", &pin);
//        if (pin != 1520)
//            printf("PLEASE ENTER VALID PASSWORD\n");
//    }
//    do
//    {
//        printf("********Welcome to ATM Service**************\n");
//        printf("1. Check Balance\n");
//        printf("2. Withdraw Cash\n");
//        printf("3. Deposit Cash\n");
//        printf("4. Quit\n");
//        printf("******************?**************************?*\n\n");
//        printf("Enter your choice: ");
//        scanf("%d", &choice);
//        switch (choice)
//        {
//            case 1:
//                printf("\n YOUR BALANCE IN Rs : %lu ", amount);
//                break;
//            case 2:
//                printf("\n ENTER THE AMOUNT TO WITHDRAW: ");
//                scanf("%lu", &withdraw);
//                if (withdraw % 100 != 0)
//                {
//                    printf("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
//                }
//                else if (withdraw > (amount - 500))
//                {
//                    printf("\n INSUFFICENT BALANCE");
//                }
//                else
//                {
//                    amount = amount - withdraw;
//                    printf("\n\n PLEASE COLLECT CASH");
//                    printf("\n YOUR CURRENT BALANCE IS%lu", amount);
//                }
//                break;
//            case 3:
//                printf("\n ENTER THE AMOUNT TO DEPOSIT");
//                scanf("%lu", &deposit);
//                amount = amount + deposit;
//                printf("YOUR BALANCE IS %lu", amount);
//                break;
//            case 4:
//                printf("\n THANK U USING ATM");
//                break;
//            default:
//                printf("\n INVALID CHOICE");
//        }
//        printf("\n\n\n DO U WISH TO HAVE ANOTHER TRANSCATION?(y/n): \n");
//        fflush(stdin);
//        scanf("%c", &transaction);
//        if (transaction == 'n' || transaction == 'N')
//            k = 1;
//    } while (!k);
//    printf("\n\n THANKS FOR USING OUT ATM SERVICE");
//}