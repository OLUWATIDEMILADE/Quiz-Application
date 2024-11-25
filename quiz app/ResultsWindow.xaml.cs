
using System.Windows;

namespace BiologyQuizApp
{
    public partial class ResultsWindow : Window
    {
        private int totalQuestions;

        public ResultsWindow(int correctAnswers, int totalQuestions)
        {
            InitializeComponent();
            this.totalQuestions = totalQuestions;

            int percentage = (correctAnswers * 100) / totalQuestions;
            ResultsText.Text = $"You answered {correctAnswers} out of {totalQuestions} questions correctly.\n" +
                               $"Your score is {percentage}%.";
        }

        private void RetakeQuiz_Click(object sender, RoutedEventArgs e)
        {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
