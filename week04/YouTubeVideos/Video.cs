public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public int GetNumberOfComments()
    {
        int num = _comments.Count;
        return num;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}