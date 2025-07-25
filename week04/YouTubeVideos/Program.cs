using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create an instance of Youtube 
        Youtube youtube = new Youtube();

        // --------------------------------------------------------------------------------

        // Video 1
        // Create an instance of Video and set the values
        Video video1 = new Video();
        video1._title = "Doubt Not | Official Track Video feat. Dallin Hatch | 2025 Youth Album";
        video1._author = "Strive To Be";
        video1._length = 218;

        // Video 1 Comments

        Comment video1Comment1 = new Comment();
        video1Comment1._name = "@hiramc.9111";
        video1Comment1._text = "This is my favorite in this album";
        //Append the comment to the list of comments
        video1._comments.Add(video1Comment1);

        Comment video1Comment2 = new Comment();
        video1Comment2._name = "@rookisthebestbeacuseyes";
        video1Comment2._text = "Doubt not is a phrase that inspires me i may not be perfect but i know that i have jesus on my side thank you";
        //Append the comment to the list of comments
        video1._comments.Add(video1Comment2);



        Comment video1Comment3 = new Comment();
        video1Comment3._name = "@renzjosephadlaon9880";
        video1Comment3._text = "Thank youuu on thiss! Im Healing <3";
        //Append the comment to the list of comments
        video1._comments.Add(video1Comment3);


        //Append the video to the list of videos
        youtube._videos.Add(video1);


        // ---------------------------------------------------------------------------------------


        // Video 2
        // Create an instance of Video and set the values
        Video video2 = new Video();
        video2._title = "Fear Not (feat. Paige Anne) | Official Music Video | Christian Music";
        video2._author = "Strive To Be";
        video2._length = 204;

        // Video 2 Comments

        Comment video2Comment1 = new Comment();
        video2Comment1._name = "@isabellamahoney1928";
        video2Comment1._text = "Heavenly father showed me I wasn't alone in the darkest time of my life, even when I couldn't feel him their.";
        //Append the comment to the list of comments
        video2._comments.Add(video2Comment1);


        Comment video2Comment2 = new Comment();
        video2Comment2._name = "@rejeangican4768";
        video2Comment2._text = "Thank you so much for this powerful song. Thank you for reminding me that He is always there";
        //Append the comment to the list of comments
        video2._comments.Add(video2Comment2);


        Comment video2Comment3 = new Comment();
        video2Comment3._name = "@oddballschtuff";
        video2Comment3._text = "This was a good way to start the day";
        //Append the comment to the list of comments
        video2._comments.Add(video2Comment3);


        Comment video2Comment4 = new Comment();
        video2Comment4._name = "@durlkis";
        video2Comment4._text = "This needs to have a rap in the middle. Love it!";
        //Append the comment to the list of comments
        video2._comments.Add(video2Comment4);


        //Append the video to the list of videos
        youtube._videos.Add(video2);



        // ---------------------------------------------------------------------------------------


        // Video 3
        // Create an instance of Video and set the values
        Video video3 = new Video();
        video3._title = "Daughter of Light | Official Track Video feat. Ellie Barry | 2025 Youth Album";
        video3._author = "Strive To Be";
        video3._length = 223;

        // Video 3 Comments

        Comment video3Comment1 = new Comment();
        video3Comment1._name = "@embraceandbecome6621";
        video3Comment1._text = "At girls camp we listened to this song and I cried so hard.";
        //Append the comment to the list of comments
        video3._comments.Add(video3Comment1);


        Comment video3Comment2 = new Comment();
        video3Comment2._name = "@dianewilson3599";
        video3Comment2._text = "This is a beautiful song that reminds us that we are a daughter of a Heavenly Father and we have infinite worth.";
        //Append the comment to the list of comments
        video3._comments.Add(video3Comment2);


        Comment video3Comment3 = new Comment();
        video3Comment3._name = "@seiyasosaneko";
        video3Comment3._text = "Esta cancion me trae mucha paz";
        //Append the comment to the list of comments
        video3._comments.Add(video3Comment3);


        //Append the video to the list of videos
        youtube._videos.Add(video3);


        // ---------------------------------------------------------------------------------------

        // Video 4
        // Create an instance of Video and set the values
        Video video4 = new Video();
        video4._title = "Look Unto Christ – Reimagined | Official Track Video";
        video4._author = "Strive To Be";
        video4._length = 231;


        // Video 4 Comments

        Comment video4Comment1 = new Comment();
        video4Comment1._name = "@Senukamusic_channel";
        video4Comment1._text = "OMG. I'm not Christian but I just love this religion";
        //Append the comment to the list of comments
        video4._comments.Add(video4Comment1);


        Comment video4Comment2 = new Comment();
        video4Comment2._name = "@PascualZarate-k5f";
        video4Comment2._text = "I look unto Christ when I try to forgive others.";
        //Append the comment to the list of comments
        video4._comments.Add(video4Comment2);


        Comment video4Comment3 = new Comment();
        video4Comment3._name = "@GrantR-fv2hj";
        video4Comment3._text = "This was sang by Elder Morris, he was a missionary in my area. He was a great guy! I can remember his voice well. I hope he is doing well!";
        //Append the comment to the list of comments
        video4._comments.Add(video4Comment3);


        //Append the video to the list of videos
        youtube._videos.Add(video4);

        // -----------------------------------------------------------------------------------------

        //Display all the videos and their comments 
        youtube.DisplayAll();








    }
}