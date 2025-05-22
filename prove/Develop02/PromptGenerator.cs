using System;
using System.Collections.Generic;

public class PromptGenerator
{
    List<string> _prompts = new List<string> {
        "How did I see the hand of the Lord in my life today?",
        "What was the best part of my day?",
        "What was the hardest part of my day?",
        "What part of today am I proud of?",
        "What am I most grateful for today?",
        "What did I learn from today?",
        "What did I do today that was kind?"
    };

    public string _prompt;

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        _prompt = _prompts[index];
        Console.WriteLine($"{index} {_prompt}");
        return _prompt;
    }
}