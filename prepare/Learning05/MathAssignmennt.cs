public class MathAssignment : Assignment
{
   string _textbookSection;
   string _problem;

   public MathAssignment(string studentName,string topic,string textbookSection,string problem) : base(studentName,topic)
   {
     _textbookSection = textbookSection;
     _problem=problem;
   }


   public string GetHomeworkList()
   {
     return $"Section {_textbookSection} problem {_problem}";
   }

}