public class Youtube
{
    public List<Video> _videos = new List<Video>();

    public Youtube()
    {

    }

    public void DisplayAll()
    {
        foreach (Video video in _videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}