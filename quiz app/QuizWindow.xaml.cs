using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using quiz_app;

namespace BiologyQuizApp
{
    public partial class QuizWindow : Window
    {
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        private List<Question> questions = new List<Question>
        {

            new Question("What is the powerhouse of the cell?",
                         new string[] { "Nucleus", "Mitochondria", "Ribosome", "Chloroplast" }, 1),
            new Question("What is the main function of red blood cells?",
                         new string[] { "Fighting infections", "Transporting oxygen", "Clotting blood", "Digesting food" }, 1),
            new Question("Which organ is primarily responsible for detoxifying chemicals in the blood?",
                         new string[] { "Kidney", "Liver", "Lungs", "Heart" }, 1),
            new Question("What is the basic structural and functional unit of the nervous system?",
                         new string[] { "Neuron", "Axon", "Synapse", "Dendrite" }, 0),
            new Question("Which part of the brain controls balance and coordination?",
                         new string[] { "Cerebrum", "Cerebellum", "Brainstem", "Hypothalamus" }, 1),
            new Question("What is the largest organ of the human body?",
                         new string[] { "Liver", "Brain", "Heart", "Skin" }, 3),
            new Question("What type of joint is found in the shoulder and hip?",
                         new string[] { "Hinge joint", "Ball-and-socket joint", "Pivot joint", "Saddle joint" }, 1),
            new Question("Which hormone regulates blood sugar levels?",
                         new string[] { "Insulin", "Adrenaline", "Thyroxine", "Cortisol" }, 0),
            new Question("Which part of the human body produces bile?",
                         new string[] { "Stomach", "Gallbladder", "Liver", "Pancreas" }, 2),
            new Question("What is the main function of the small intestine?",
                         new string[] { "Breaking down fats", "Absorbing nutrients", "Producing enzymes", "Storing waste" }, 1)

        };

        public QuizWindow()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                QuestionText.Text = question.Text;
                AnswersPanel.Children.Clear();

                for (int i = 0; i < question.Options.Length; i++)
                {
                    var button = new Button
                    {
                        Content = question.Options[i],
                        Tag = i,
                        Margin = new Thickness(5),
                        Width = 300,
                        Background = System.Windows.Media.Brushes.White,
                        Foreground = System.Windows.Media.Brushes.Black
                    };

                    button.Click += Answer_Click;
                    AnswersPanel.Children.Add(button);
                }

                FeedbackText.Text = "";
            }
            else
            {
                ShowResults();
            }
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int selectedOption = (int)button.Tag;

            if (selectedOption == questions[currentQuestionIndex].CorrectOption)
            {
                correctAnswers++;
                FeedbackText.Text = "Correct!";
            }
            else
            {
                FeedbackText.Text = "Wrong!";
            }

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void ShowResults()
        {
            ResultsWindow resultsWindow = new ResultsWindow(correctAnswers, questions.Count);
            resultsWindow.Show();
            this.Close();
        }
    }

    public class Question
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectOption { get; }

        public Question(string text, string[] options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }
}



