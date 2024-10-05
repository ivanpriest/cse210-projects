using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to your journal");
        Console.Write("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\nWhat would you like to do (please enter the index of your choice): ");
        string reply=Console.ReadLine();
        int userChoice=int.Parse(reply);
        Journal journal1=new Journal();
        while(userChoice != 5)
        {

            
            if (userChoice==1)
            {
                Entry entry1= new Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                PromptGenerator prompt1= new PromptGenerator();
                string prompt =prompt1.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string journalEntry=Console.ReadLine();
                entry1._date= dateText;
                entry1._promptText=prompt;
                entry1._entryText=journalEntry;
                journal1.AddEntry(entry1);
            }
            else if (userChoice==2)
            {
                journal1.DisplayAll();
            }
            else if(userChoice==3)
            {
                Console.Write("Enter the name of file:");
                string fileName=Console.ReadLine();
                journal1.LoadFromfile(fileName);


            }
            else if(userChoice==4)
            {
                Console.Write("Enter the name of file:");
                string fileName=Console.ReadLine();
                journal1.SaveToFile(fileName);
            }
            
            Console.Write("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit\nWhat would you like to do please enter the index of your choice: ");
            string loopReply=Console.ReadLine();
            int loopUserChoice=int.Parse(loopReply);
            userChoice=loopUserChoice;
        }
       
   
    }
}