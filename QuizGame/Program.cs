namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3]
            {
                "1. What is the capital of Italy ?",
                "2. What is the red planet ?",
                "3. What is the largest animal ?"

            };

            string[] answers = new string[3]
            {
                "Rome",
                "Mars",
                "Whale"
            };
            var Score = 0;

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please answer the following questions");


            for(int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
              var userAnswer =  Console.ReadLine();
                try
                {
                    bool result = IsCorrect(userAnswer, answers[i]);
                    if (result is true)
                    {
                        Console.WriteLine("Correct Answer");
                        Score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, Incorrect Answer, Correctoed answer is {answers[i]}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine($"Your score is {Score}");
                Console.WriteLine("Quiz completed, thank you for youe time!");
            }


        }

        private static bool IsCorrect(string userInput,string correctAnswer)
        {
            if(string.IsNullOrEmpty(userInput))
            {
                throw new Exception("Answer cant be empty");
            }
            //if answer is right
            if(userInput == correctAnswer)
                return true;
            return false;
        }
    }
}
