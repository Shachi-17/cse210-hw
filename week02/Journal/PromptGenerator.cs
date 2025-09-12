using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Have I done my 'Come Follow Me' assignment today?",
            "What spiritual experience did I gain from the Book of Mormon today?",
            "How did my prayers today improve my relationship with God?",
            "What step did I take today to be more temple worthy?",
            "What did I do today to hear more from the Lord?",
            "How did I minister to others today?",
            "What did I do to strengthen my financial future?",
            "What spiritual impressions did I feel from general authorities today?",
            "What did I do today to follow President Nelson’s admonition to ‘Think Celestial’?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}