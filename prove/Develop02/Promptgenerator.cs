public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was your favorite part of the day?",
        "What have you done to help someone today?",
        "If you could change something about today, what would it be?",
        "Did you meet anyone new today?",
        "What was the most beautiful thing you saw today?",
    };

    public string GeneratePrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }
}