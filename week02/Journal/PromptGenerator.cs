public class PromptGenerator
{
    Random random = new Random();
    public List<string> _prompts = new List<string>

    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What challenges did you face, and how did you overcome them?",
        "What progress did you make towards your goals today?",
        "Take a few deep breaths and focus on the present moment. What do you notice?"
    };
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}