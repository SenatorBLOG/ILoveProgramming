/*
Programmer: Mikhail Senatorov
Date: Fall 2024
Purpose: 
*/

using System;

namespace Assigmentsrba
{
	class Program
	{
		static void Main(string[] args)
		{
			//constants becaause always same, goes first 
			const float ASSIGMENTS_PERCENT = 0.2f;
			const float QUIZZES_PERCENT = 0.2f;
			const float MIDTERM_PERCENT = 0.3f;
			const float FINALEXAM_PERCENT = 0.3f;
			const float WEIGHTED_PERCENT = 1;
			
			// variables change depend on students
			float Assignments = 53;
			float Quizzes = 90.3f;
			float MidtermExam = 85.5f;
			float FinalExam = 80;
			//float WeightedTotal = weightedExams;
			
			weightedAvarege = (Assignments*ASSIGMENTS_PERCENT + Quizzes*QUIZZES_PERCENT + MidtermExam*MIDTERM_PERCENT + FinalExam*FINALEXAM_PERCENT) / 0.8f ;
			
			Console.Write("\\**********************************************\\\n");
			Console.Write("\\                                              \\\n");
			Console.Write("\\     \"Total Weighted Average Calculator\"      \\\n");
			Console.Write("\\                                              \\\n");	
			Console.Write("\\**********************************************\\\n\n\n");
			Console.Write("    Assignments       Percentage      Your Grade\n");
			Console.Write("    -----------       ----------      ----------\n");
			Console.WriteLine("{0,15} {1,16:P0}      {2,-1}", "Assignments", ASSIGMENTS_PERCENT, Assignments);
			Console.WriteLine("{0,15} {1,16:P0}      {2,-1}", "MidtermExam", MIDTERM_PERCENT, MidtermExam);
			Console.WriteLine("{0,15} {1,16:P0}      {2,-1}", "Quizzes", QUIZZES_PERCENT, Quizzes);
			Console.WriteLine("{0,15} {1,16:P0}      {2,-1}", "FinalExam", FINALEXAM_PERCENT, FinalExam);
			Console.Write("    --------------------------------------------\n");
			Console.WriteLine("{0,15} {1,16:P0}      {2,-1}", "Weighted Total", WEIGHTED_PERCENT, weightedAvarege);

		}
	}
}