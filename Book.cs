using System;
class Book
{
    public string Title;
    public string Writer;    
    public int TotalCopies;
    public int AvailableCopies;
    public DateTime DueDate;

    public Book(string title, string writer, int totalCopies)
    {
        Title = title;
        Writer = writer;        
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
        DueDate = DateTime.MinValue;
    }
}

