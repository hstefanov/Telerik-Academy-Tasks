using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpMenu
{
    class War
    {
        static List<int> usedQuestions = new List<int>();
        static string[] GetRandomQuestion()
        {
            string filePath = System.IO.Path.GetFullPath("questions.txt");
            Encoding currentEncoding = Encoding.GetEncoding("Windows-1251"); //edit
            StreamReader readQuestions = new StreamReader(filePath, currentEncoding);
            
            using (readQuestions)
            {
                int totalLines = 0;
                try
                {
                    totalLines = File.ReadAllLines(filePath, currentEncoding).Length;
                }
                catch (IOException)
                {
                    Console.WriteLine("Sorry, but Questions file is unavailable!");
                }
                Random randomQuestion = new Random();
                int selectedQuestion = 0;
                do
                {
                    selectedQuestion = randomQuestion.Next(totalLines) + 1;                    
                } while (usedQuestions.Contains(selectedQuestion));
                                
                //Console.WriteLine(selectedQuestion);

                int currentRow = 1;

                //we have an array with 5 cells: question, answers A B C and the last cell is a number. the number shows the 
                //index where the correct answer is (1 = A, 2 = B, 3 = C)
                string[] questionAndAnswers;
                while (true)
                {
                    string currentLine = readQuestions.ReadLine();
                    if (currentRow == selectedQuestion)
                    {
                        questionAndAnswers = currentLine.Split('|');
                        break;
                    }
                    currentRow++;
                }
                usedQuestions.Add(selectedQuestion);
                return questionAndAnswers;
            }
        }

        public static void CurrentQuestion()
        {
            try
            {
            string[] currentQuestion = GetRandomQuestion();
            Question.Content = currentQuestion;
            Question.CorrectAnswer = int.Parse(currentQuestion[4]);
            Question.PrintQuestion(); 
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("We apologize for inconvenience, but there no questions available!"); 
            }
        }
    }
}
