
public class PromptGenerator
{
    public List<string>_prompts=new List<string>(new string[]{"what is the most important thing you have done today? ","What is the most interesting thing you have done today? ","How are you feeling today (how)?","What did you learn from your scripture study today?","What did you do for some to show love today?"});
        

    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        Random _r=new Random();
        int index=_r.Next(0,_prompts.Count());
        string prompt= _prompts[index];

        return prompt;
    }
}