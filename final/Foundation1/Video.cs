using System;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"\nTitle:{_title} \nAuthor: {_author} \nLength in seconds: {_length} \nNumber of Comments: {_comments.Count}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    } 
}