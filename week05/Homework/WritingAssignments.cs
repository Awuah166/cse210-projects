using System;
// WritingAssignment class inherits from Assignment and adds writing-specific functionality
public class WritingAssignment : Assignment
{
     // Private field to store the title of the writing assignment
    private string _title;

    // Constructor that takes student name, topic, and title
    // Calls the base Assignment constructor with studentName and topic
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Initialize the writing-specific title field
        _title = title;
    }

    // Method to get detailed information about the writing assignment
    public string GetWritingInformation()
    {
        return $"{GetSummary()}\nTitle: {_title}";
    }
}