# Quiz-Application

Here’s a structured plan for your application, as well as the requested README content:

Biology Quiz App
Description:
A WPF-based Biology Quiz application with three windows:

Main Window: The welcome screen where users start the quiz.
Quiz Window: Displays the questions and lets users answer.
Results Window: Shows the final results and provides options to retake the quiz or return to the main menu.
Features:
User-friendly interface with dynamic question loading.
Instant feedback on answers.
Percentage-based scoring.
Retake quiz or navigate back to the main menu.
Modular design for easy updates.
Directory Structure
bash
Copy code
/BiologyQuizApp
    /BiologyQuizApp
        MainWindow.xaml
        MainWindow.xaml.cs
        QuizWindow.xaml
        QuizWindow.xaml.cs
        ResultsWindow.xaml
        ResultsWindow.xaml.cs
    /Properties
    /bin
    /obj
How to Run
Prerequisites:

Install Visual Studio with the .NET Desktop Development workload.
.NET Framework installed (version 4.7.2 or higher).
Steps to Run:

Clone or download the repository from GitHub.
Open the solution file BiologyQuizApp.sln in Visual Studio.
Build the solution (Ctrl+Shift+B).
Run the application (F5 or Debug > Start Debugging).
Usage Instructions:

Start the application.
Click Start Quiz to begin.
Answer each question by clicking on the desired option.
View results at the end, with an option to retake the quiz or go back to the main menu.
Adding Questions
To add more questions:

Open QuizWindow.xaml.cs.
Add a new Question object to the questions list:
csharp
Copy code
new Question("Your question here?",
             new string[] { "Option1", "Option2", "Option3", "Option4" }, correctOptionI
