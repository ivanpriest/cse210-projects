using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YOUTUBE");
        List<Video> videoList = new List<Video>();
        Video vid1=new Video();
        vid1.SetTitle("Grace");
        vid1.SetAuthor("LutherX");
        vid1.SetVideoLength(220);
        Video vid2=new Video();
        vid2.SetTitle("Kitchen hacks");
        vid2.SetAuthor("DIY");
        vid2.SetVideoLength(280);
        Video vid3=new Video();
        vid3.SetTitle("5 facts");
        vid3.SetAuthor("DidYouKnow");
        vid3.SetVideoLength(160);
        Comment com1=new Comment();
        com1.SetCommentorsName("Tina");
        com1.SetCommentText("good");
        Comment com2=new Comment();
        com2.SetCommentorsName("Aaron");
        com2.SetCommentText("I like this");
        Comment com3=new Comment();
        com3.SetCommentorsName("Ian");
        com3.SetCommentText("sucks");
        Comment com4=new Comment();
        com4.SetCommentorsName("Lin");
        com4.SetCommentText("great work");
        Comment com5=new Comment();
        com5.SetCommentorsName("Frank");
        com5.SetCommentText("That is just facts");
        Comment com6=new Comment();
        com6.SetCommentorsName("Ama");
        com6.SetCommentText("Jesus loves you");
        Comment com7=new Comment();
        com7.SetCommentorsName("charles");
        com7.SetCommentText("this is interesting");
        Comment com8=new Comment();
        com8.SetCommentorsName("kelvin");
        com8.SetCommentText("I always felt like that too");
        Comment com9=new Comment();
        com9.SetCommentorsName("bismark");
        com9.SetCommentText("I take my walk serious");
        vid1.AddComment(com6);
        vid1.AddComment(com4);
        vid1.AddComment(com1);
        videoList.Add(vid1);
        vid2.AddComment(com2);
        vid2.AddComment(com7);
        vid2.AddComment(com8);
        videoList.Add(vid2);
        vid3.AddComment(com5);
        vid3.AddComment(com9);
        vid3.AddComment(com3);
        videoList.Add(vid3);
        foreach (Video video in videoList)
        {
           Console.WriteLine($"{video.GetTitle()}:{video.GetVideoLength()}secs - {video.GetAuthor()}\n{video.GetNumberOfComment()} comments");
           List<string> comments=video.GetCommentList();
           foreach (string text in comments)
           {
            Console.WriteLine($"{text}");
           }
           
           Console.WriteLine($"");
        }
       
    }
}