using System;

class Program
{
    static void Main(string[] args)
    {
        Random random=new Random();
        // Reading from the file
        string[] lines = System.IO.File.ReadAllLines("Memoryverses.txt");
        int index=random.Next(lines.Length);
        // Getting a random scripture and spliting it into the reference and the scripture text itself into a values array
        string[] values = lines[index].Split(":");
        // splitting the reference and assign the book ,chapter and verses into an array
        string [] referenceValues=values[0].Split("-");
        string book=referenceValues[0];
        int chapter=int.Parse(referenceValues[1]);
        int verse=int.Parse(referenceValues[2]);
        int referenceArraySize= referenceValues.Length;
        string text=values[1];
        // intantiating new Reference object with contructor
        Reference newReference;
        if (referenceArraySize==4)
        {
            int endverse=int.Parse(referenceValues[3]);
            newReference= new Reference(book,chapter,verse,endverse);
        }
        else
        {
            newReference= new Reference(book,chapter,verse);
        }
        // splitting the text into a list of words and keeping count of the it's size
        List<string> newText=new List<string>();
        newText=text.Split(" ").ToList();
        int size=newText.Count();
        // declaring the the variable for the index to be hidden 
        int wordIndex;
        // creating a new list to hold the index of the random hidden words
        List<int> randomNumbers= new List<int>();
        // instantiating a new Scripture object and assigning it
        Scripture newScripture= new Scripture(newReference,text);
        // initial scripture printing
        Console.WriteLine($"{newReference.GetDisplayText()} {text}");
        Console.Write($"Press Enter to continue or type \"quit\" to finish: ");
        string reply =Console.ReadLine();
        // continue hiding random words until all words are hidden or the user enters quit
        while( reply.ToLower()!="quit" && newScripture.IsCompletelyHidden()== false)
        {
            // picking a new index from the list to hide
            wordIndex=random.Next(size);
            // but if the index has already been picked, continously pick new until a new one is picked;
            while(randomNumbers.Contains(wordIndex))
            {
                wordIndex=random.Next(size);
            }
            // add the the new index to the list of picked random numbers
            randomNumbers.Add(wordIndex);
            // hidding the word with that index
            newScripture.HideRandomWords(wordIndex);
            // getting and the scripture text 
            string scripture= newScripture.GetDisplayText();
            string reference=newReference.GetDisplayText();
            // clear terminal
            Console.Clear();
            // printing the scripture text and reference
            Console.WriteLine($"{reference} {scripture}");
            // assigning the new scripture text for a new random word to be hidden
            text=scripture;
            // prompt user if they want to stop or continue
            Console.Write($"Press Enter to continue or type \"quit\" to finish: ");
            reply =Console.ReadLine();

        }
        // this will render if the user enters quit
        if (reply.ToLower()=="quit")
        {
            Console.Write("Quiting...\nThanks for using the this program");
        }


        
    }
   
}