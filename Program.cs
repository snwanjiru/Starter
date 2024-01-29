using System;

class Program 
{
    static void Main()
    {


int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };


//initialise student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//initialise students' scores array
int[] studentScores = new int[10];

//determine current student letter grade
string currentStudentLetterGrade = "";

// Display the Report Header
Console.WriteLine("Student\t\tGrade\n");

//Assign Student names their scores from the arrays above
foreach(string name in studentNames)
{
    string currentStudent = name;

    if(currentStudent == "Sophia")
    studentScores = sophiaScores;

   else if(currentStudent == "Andrew")
    studentScores = andrewScores;

   else if(currentStudent == "Emma")
     studentScores = emmaScores;

   else if (currentStudent == "Logan")
     studentScores = loganScores;

// initialize/reset the sum of scored assignments
int sumAssignmentsScores = 0;

// initialize/reset the calculated average of exam + extra credit scores
decimal currentStudentGrade = 0;

// initialize/reset a counter for the number of assignment 
int gradedAssignments = 0;

//calculate the sum of assignments for the current student
foreach(int score in studentScores)
{
            // increment the assignment counter
    gradedAssignments += 1;

    if(gradedAssignments <= currentAssignments)
            // add the exam score to the sum and so by 5th assignment we will have the total score(sumassignmentScores) for student without credits
    sumAssignmentsScores += score;

    else
    // add the extra credit points to the sum - bonus points equal to 10% of an exam score (that is, to the total score divide by ten for the credits)
    sumAssignmentsScores += score / 10;
}
 
currentStudentGrade = (decimal)sumAssignmentsScores / currentAssignments;

if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
    currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else currentStudentLetterGrade = "F";

//Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine($"{name}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

    }
}


