using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice=0;
        // 4 is quit so stating what the should happen when the user does not quit(enter 4).
        while (userChoice !=4)
        {
            // what should happen if user choices the breathing activity which is 1
            if (userChoice ==1)
            {  
                Console.Clear(); 
                BreathingActivity newBreathingActivity =new BreathingActivity();
                newBreathingActivity.DisplayStartingMessage();
                newBreathingActivity.Run();
                newBreathingActivity.DisplayEndingMessage();
                newBreathingActivity.ShowSpinner(5);
            }
            //  what should happen if user choices the Listing activity which is 2
            else if (userChoice==2)
            {
                Console.Clear(); 
                ListingActivity newListingActivity =new ListingActivity();
                newListingActivity.DisplayStartingMessage();
                newListingActivity.Run();
                newListingActivity.DisplayEndingMessage();
                newListingActivity.ShowSpinner(5);

            }
            //  what should happen if user choices the reflecting activity which is 3
            else if (userChoice==3)
            {
                Console.Clear(); 
                ReflectingActivity newReflectingActivity =new ReflectingActivity();
                newReflectingActivity.DisplayStartingMessage();
                newReflectingActivity.Run();
                newReflectingActivity.DisplayEndingMessage();
                newReflectingActivity.ShowSpinner(5);
            }
            Console.Clear(); 
            // displaying the options the  user has to choose from and receiving the response
            Console.Write($"1.Breathing Activity \n2.Listing Activity \n3.Reflecting Activity\n4.Quit\n\nChoose the activity you want to do (Enter the index ex. 1): ");
            userChoice=int.Parse(Console.ReadLine());   
        }
        Console.WriteLine($"Thanks for using this program and have a great day");
        
           
    }
}