using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What made me smile today?",
    "What challenge did I overcome today?",
    "What is something new I learned today?",
    "What is something I am grateful for today?",
    "What was the most surprising thing that happened today?",
    "How did I help someone today?",
    "What goal did I work on today?",
    "What is something that made today special?",
    "What is something I want to improve tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
