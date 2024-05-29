using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1= new Comment();
        comment1._name="Mike Wazowski";
        comment1._comment="Video was dumb";
        Comment comment2= new Comment();
        comment2._name="John Smith";
        comment2._comment="Wonderful Video";
        Comment comment3= new Comment();
        comment3._name="Natalie Claire";
        comment3._comment="Best video ever";

        Video video1= new Video();
        video1._author="Noah Alex";
        video1._title="Funny Bike Accident";
        video1._length=120;
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        
        video1.Display();

        Comment comment4= new Comment();
        comment4._name="Rylee";
        comment4._comment="I like this video";
        Comment comment5= new Comment();
        comment5._name="Zander";
        comment5._comment="Get a new camera";
        Comment comment6= new Comment();   
        comment6._name="Whit";
        comment6._comment="Cool video";
        Comment comment7= new Comment();
        comment7._name="Piano Guy";
        comment7._comment="Needs more music";

        Video video2 = new Video();
        video2._title="Cool guy playing piano";
        video2._author="Cucumber dude";
        video2._length=65;
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6); 
        video2._comments.Add(comment7);
        video2.Display();

        Comment comment8= new Comment();
        comment8._name="Banana man";
        comment8._comment="You split me from laughing so hard";
        Comment comment9= new Comment();
        comment9._name="Barbie Girl";
        comment9._comment="I've never seen anything like this before";
        Comment comment10= new Comment();   
        comment10._name="Albus P. W. B. Dumbledore";
        comment10._comment="1000 points to Gryffindor";

        Video video3 = new Video();
        video3._title="Guy falls on banana peel";
        video3._author="Muffin Man";
        video3._length=13;
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3.Display();
        
    }
}