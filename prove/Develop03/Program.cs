using System;

class Program
{
    static void Main(string[] args)
    {
        Random random=new Random();
        string[] lines = System.IO.File.ReadAllLines("Memoryverses.txt");
        int index=random.Next(lines.Length);
        string[] values = lines[index].Split(":");
        string [] referenceValues=values[0].Split("-");
        int referenceArraySize= referenceValues.Length;
        string book=referenceValues[0];
        int chapter=int.Parse(referenceValues[1]);
        int verse=int.Parse(referenceValues[2]);
        string text=values[1];
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
        List<string> newtext=new List<string>();
        newtext=text.Split(" ").ToList();
        int size=newtext.Count();
        int wordIndex;
        List<int> randomNumbers= new List<int>();
        Scripture newScripture= new Scripture(newReference,text);
        Console.WriteLine($"{newReference.GetDisplayText()} {text}");
        Console.Write($"Press Enter to continue or type \"quit\" to finish: ");
        string reply =Console.ReadLine();
        while( reply.ToLower()!="quit" && newScripture.IsCompletelyHidden()== false)
        {
            wordIndex=random.Next(size);
            while(randomNumbers.Contains(wordIndex))
            {
                wordIndex=random.Next(size);
            }
            randomNumbers.Add(wordIndex);
            newScripture.HideRandomWords(wordIndex);
            string scripture= newScripture.GetDisplayText();
            string reference=newReference.GetDisplayText();
            Console.Clear();
            Console.WriteLine($"{reference} {scripture}");
            text=scripture;
            Console.Write($"Press Enter to continue or type \"quit\" to finish: ");
            reply =Console.ReadLine();

        }
        if (reply.ToLower()=="quit")
        {
            Console.Write("Quiting...\nThanks for using the this program");
        }


        
    }
   
}