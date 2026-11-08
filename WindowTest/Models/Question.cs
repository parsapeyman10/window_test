using System.Windows;
using System.Windows.Controls;
using WindowTest.Models;
using WindowTest.Services;

namespace WindowTest;

public partial class MainWindow : Window
{
    private readonly List<Question> _questions = QuestionCatalog.GetQuestions();
    private readonly Dictionary<string, QuizStrategyModel> _strategyMap = new()
    {
        ["Base Quiz"] = QuizStrategyModel.BASE_QUIZ,
        ["Parsa 52 Line Turn"] = QuizStrategyModel.PARSA_52_LINE_TURN,
        ["BTC 52 Candle Regime"] = QuizStrategyModel.BTC_52_CANDLE_REGIME,
        ["Drive Book Master"] = QuizStrategyModel.DRIVE_BOOKS_1_TO_9_UNIFIED_MASTER,
    };

    private QuizSession _session = new();
    private bool _hasAnswered;

    public MainWindow()
    {
        InitializeComponent();
        PopulateStrategyComboBox();
        StrategyComboBox.SelectionChanged += (_, _) => RefreshStrategySummary();
        SubmitButton.Click += SubmitAnswer_Click;
        NextButton.Click += NextQuestion_Click;
        NextButton.IsEnabled = false;
        _session = new QuizSession(_questions);
        RefreshStrategySummary();
        RenderCurrentQuestion();
    }

    private void PopulateStrategyComboBox()
    {
        StrategyComboBox.ItemsSource = _strategyMap.Keys.ToList();
        StrategyComboBox.SelectedIndex = 0;
    }

    private void RefreshStrategySummary()
    {
        var selected = StrategyComboBox.SelectedItem?.ToString();
        if (selected is null) return;

        var model = _strategyMap[selected];
        var spec = QuizStrategyCatalog.GetSpec(model);
        QuestionCategoryText.Text = spec.TitleFa;
    }

    private void RenderCurrentQuestion()
    {
        ResultPanel.Visibility = Visibility.Collapsed;
        var q = _session.CurrentQuestion;
        if (q is null)
        {
            DisplayFinalResult();
            return;
        }

        MetaLabel.Text = $"Question {_session.CurrentIndex + 1} / {_questions.Count}";
        ScoreLabel.Text = $"Score: {_session.Score}";
        QuestionText.Text = q.Text;
        AnswerListBox.ItemsSource = q.Answers;
        AnswerListBox.SelectedIndex = -1;
        _hasAnswered = false;
        SubmitButton.IsEnabled = true;
        NextButton.IsEnabled = false;
    }

    private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
    {
        if (_hasAnswered) return;

        var current = _session.CurrentQuestion;
        if (current is null) return;

        var selected = AnswerListBox.SelectedIndex;
        if (selected < 0)
        {
            MessageBox.Show("Please choose an answer before submitting.", "Window Test", MessageBoxButton.OK, MessageBoxImage.Information);
            return;
        }

        _hasAnswered = true;
        _session.RecordAnswer(selected);
        SubmitButton.IsEnabled = false;
        NextButton.IsEnabled = true;

        var isCorrect = selected == current.CorrectIndex;
        if (isCorrect)
        {
            _session.Score += 1;
            ScoreLabel.Text = $"Score: {_session.Score}";
            MessageBox.Show("Correct answer. Good work.", "Window Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        else
        {
            MessageBox.Show($"Incorrect. Correct answer: {current.Answers[current.CorrectIndex]}", "Window Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    private void NextQuestion_Click(object sender, RoutedEventArgs e)
    {
        if (!_session.MoveNext())
        {
            DisplayFinalResult();
            return;
        }

        RenderCurrentQuestion();
    }

    private void DisplayFinalResult()
    {
        var total = _questions.Count;
        var percent = total > 0 ? (double)_session.Score / total * 100.0 : 0;
        var strategyName = StrategyComboBox.SelectedItem?.ToString() ?? "Base Quiz";
        var profile = QuizStrategyCatalog.GetSpec(_strategyMap[strategyName]);

        ResultSummaryText.Text = $"Final score: {_session.Score} / {total} ({percent:F1}%)\n" +
                                 $"Strategy: {profile.TitleFa}\n" +
                                 $"Summary: {profile.SpecialEdgeAdvantageFa}";

        ResultPanel.Visibility = Visibility.Visible;
        QuestionText.Text = "Test completed";
        AnswerListBox.ItemsSource = null;
        MetaLabel.Text = "Completed";
        ScoreLabel.Text = $"Score: {_session.Score}";
        SubmitButton.IsEnabled = false;
        NextButton.IsEnabled = false;
    }
}
