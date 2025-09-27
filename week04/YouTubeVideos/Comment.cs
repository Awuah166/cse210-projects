using System;

public class Comment
{
    public string _commenterName;
    public string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }
}