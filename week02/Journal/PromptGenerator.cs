public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "How was your day?",
        "What is something you would like to do tomorrow?",
        "What are you grateful for?",
        "What is something that made you smile today?",
        "What inspires you?",
        "What keeps you going?"
    };

    public Random _random = new Random();
    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}