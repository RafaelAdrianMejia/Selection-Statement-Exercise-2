namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject(); 
        }

        public static void FavSubject()
        {
            Console.Write("Enter your favorite subject: ");
            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math");
                    break;
                case "science":
                    Console.WriteLine("I love science");
                    break;
                case "pe":
                case "p.e.":
                case "physical science":
                case "phys ed":
                    Console.WriteLine("P.E. is awesome");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite");
                    break;
                case "english":
                    Console.WriteLine("I speak english");
                    break;
                default:
                    Console.WriteLine("I forgot about that one");
                    break;

            }
        }
    }
}