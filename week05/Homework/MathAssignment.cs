using System;
// Inheritance from Assignment class
public class MathAssignment : Assignment
{
    // Private fields to store specific information for math assignments
    private string _textbookSection;
    private string _problems;

    // Constructor that takes student name, topic, textbook section, and problems
    // Calls the base Assignment constructor with studentName and topic
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Initialize the math-specific fields
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get detailed information about the math assignment
    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection: {_textbookSection} Problems: {_problems}";
    }
}