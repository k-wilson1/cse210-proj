using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("65 Burrow Lane", "Houston", "Texas", 77890);
        Outdoor outdoor= new Outdoor("Outdoor","Harry and Ginny Wedding","The marriage of Harry Potter and Ginny Weasley","September 19, 2009",2, "Sunny", address);
        Console.WriteLine(outdoor.GetFullOutdoorDetails());
        Console.WriteLine(outdoor.GetShortDescription());
        Console.WriteLine(outdoor.GetStandardDetails());

        Address address1 = new Address("100 Blue Street", "Idaho city","Idaho", 86758);
        Lectures lecture = new Lectures("Lecture", "The benefits of Potatoes", "Listen to Mr. Potatoe Head speak about the benefits of eating potatoes", "October 19, 2024", 2, "Mr. Potato Head", 100, address1);
        Console.WriteLine(lecture.GetFullLectureDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(lecture.GetStandardDetails());

        Address address2= new Address("9 Standard Lane", "Pittsburgh","Pennsylvania", 98765);
        Reception reception= new Reception("Reception", "Ann and Andy's Reception","Celebration reception for 50 years of marriage", "July 19, 2025", 3, "Event@eventsforus.com", address2);
        Console.WriteLine(reception.GetFullReceptionDetail());  
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(reception.GetStandardDetails());
    }
}