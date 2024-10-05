using System;

class Program
{
    static void Main(string[] args)
    {
        
       Job job1=new Job();
       job1._company="Google";
       job1._jobTitle="manager";
       job1._startYear=2000;
       job1._endYear=2010;

       Job job2=new Job();
       job2._company="ogle";
       job2._jobTitle="ager";
       job2._startYear=2001;
       job2._endYear=2011;
       


       Resume resume1=new Resume();
       resume1._name="ivan";
       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);
       resume1.Display();


    }
}