namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           PrintStory();
        }

        public static void PrintStory()
        {
            string yourName = " ";
            string friendName = " ";
            string yourFavoriteFood = " ";
            string hatedFood = " ";
            string streetName = " ";
            string otherStreetName = " ";
            
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            
            Console.WriteLine("What is the name of your best friend?");
            friendName = Console.ReadLine();
            
            Console.WriteLine("What is your favorite food?");
            yourFavoriteFood = Console.ReadLine();
            
            Console.WriteLine("What is your most hated food?");
            hatedFood = Console.ReadLine();
            
            Console.WriteLine("What is the name of a street near where you live?");
            streetName = Console.ReadLine();
            
            Console.WriteLine("What is the name of another street near where you live?");
            otherStreetName = Console.ReadLine();

            
            Console.WriteLine("\tFeeling a mild pang of hunger, you decide it's time to go grab some lunch.  You set off down ");
            Console.WriteLine($"to the corner market on {streetName} to see if they have your all-time favorite, {yourFavoriteFood}. ");
            Console.WriteLine("After a moderate walk, and feeling hungrier by the moment, you finally arrive at your destination ");
            Console.WriteLine($"on the corner of {streetName} and {otherStreetName}.  It's a small, unimpressive joint but it serves ");
            Console.WriteLine("the local community well.");
            Console.WriteLine("\tAs you walk through the front door of the shop, the bell attached to the door sounds a jingle");
            Console.WriteLine("of greeting, causing the counter clerk to glance up momentarily before returning to reading a ");
            Console.WriteLine("rather thick book.");
            Console.WriteLine($"\t\"Hello, {friendName}, how's it going?\" you call out pleasantly as you walk past the counter on");
            Console.WriteLine("your way to inspect the various food items on offer for the day.");
            Console.WriteLine($"\t\"Fine, and how about you, {yourName}?  Haven't seen you down here in awhile.\"  {friendName} doesn't");
            Console.WriteLine("bother looking up from the book as the courteous reply issues forth.");
            Console.WriteLine("\t\"Yeah sorry about that, I've been working hard on a special project lately.  You should come over to");
            Console.WriteLine($"my place sometime so we can catch up.\"");
            Console.WriteLine("\t\"Yeah sure, that sounds great.\"");
            Console.WriteLine($"\t\"By the way, do you happen to have any {yourFavoriteFood} left?  I can't seem to find any.\"");
            Console.WriteLine($"\t\"No, sorry we're all out.  All we've got left is {hatedFood}.\"");
            Console.WriteLine("\t\"Thanks anyways\" you say, wrinkling your nose in disgust.  It looks like it's going to be one of those days.");
        }
    }
}
