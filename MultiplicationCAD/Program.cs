using System;

namespace MultiplicationCAD
{
    class Program
    {
        private static Random rand = new Random();
        
        static void Main(string[] args)
        {
            //Ex 7.39(Computer Assisted Instruction) The use of computers in education is referred to as computer assisted instruction (CAD.
            //Write a program that will help an elementary-school student learn multiplication.
            //Use a Random object to produce two positive one-digit integers.
            //The program should then prompt the user with a question, such as How much is 6 times 7?
            //The student then inputs the answer. Next, the program checks the student's answer.
            //If it's correct, display the message "Very good!" and ask another multiplication question.
            //If the answer is wrong, display the message "No. Please try again."
            //and let the student try the same question repeatedly until the student gets it right.
            //A separate method should be used to generate each new question.
            //This method should be called once when the app begins execution and each time the user answers the question correctly.




            //Ex 7.40(Computer - Assisted Instruction: Reducing Student Fatigue) One problem in CAI environ-ments is student fatigue.
            //This can be reduced by varying the computer's responses to hold the stu- dent's attention.
            //Modify the program of Exercise 7.39 so that various comments are displayed for each answer.
            //Possible responses to a correct answer: Very good! Excellent! Nice work! Keep up the good work!
            //Possible responses to an incorrect answer: No.Please try again.Wrong.Try once more.Don't give up! No. Keep trying.
            //Use random-number generation to choose a number from 1 to 4 that will be used to select one of the four appropriate
            //responses to each correct or incorrect answer. Use a switch statement to issue the responses.

            int correctAnswer = GenerateQuestion();
            int NumInput = int.Parse(Console.ReadLine());

            do
            {
                if (NumInput == correctAnswer)
                {
                    //Console.WriteLine("Very good!\n");
                    RightAnswer(); //call the method to display the responses
                    correctAnswer = GenerateQuestion(); //call the method to generate and display new question
                    NumInput = int.Parse(Console.ReadLine());
                }
                else
                {
                    //Console.WriteLine("No. Please try again");
                    WrongAnswer();

                    Console.Write("Write your answer again ==> ");
                    NumInput = int.Parse(Console.ReadLine());
                }
            } while (NumInput != -1);
        }

        static int GenerateQuestion()
        {
            //Generate 2 random integers between 1-9
            int num1 = rand.Next(0, 11);
            int num2 = rand.Next(0, 11);

            //Calculating Correct Answer
            int CorrectAns = num1 * num2;

            //Display Question
            Console.WriteLine($"How much is {num1} times {num2}: \nEnter -1 to exit. ");

            return CorrectAns;
        }

        static void RightAnswer()
        {
            int ans = rand.Next(1, 5);

            switch (ans)
            {
                case 1:
                    Console.WriteLine("Well done!\n");
                    break;
                case 2:
                    Console.WriteLine("Excellent work!\n"); 
                    break;
                case 3:
                    Console.WriteLine("Correct. Keep up the good work!\n"); 
                    break;
                case 4:
                    Console.WriteLine("Nice work!\n"); 
                    break;
            }
        
        }
        static void WrongAnswer()
        {
            int ans = rand.Next(1, 5);

            switch (ans)
            {
                case 1:
                    Console.WriteLine("Incorrect. Please try again!\n");
                    break;
                case 2:
                    Console.WriteLine("Wrong. Try once more.\n");
                    break;
                case 3:
                    Console.WriteLine("Don't give up\n");
                    break;
                case 4:
                    Console.WriteLine("No, keep trying\n");
                    break;
            }
        }

    }
}
