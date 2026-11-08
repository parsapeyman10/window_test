using System.Collections.ObjectModel;

namespace WindowTest.Models;

public enum QuizStrategyModel
{
    BASE_QUIZ,
    BTC_52_CANDLE_REGIME,
    PARSA_52_LINE_TURN,
    DRIVE_BOOKS_1_TO_9_UNIFIED_MASTER,
}

public enum SignalAction
{
    BUY,
    SELL,
    NO_TRADE,
}

public sealed class Question
{
    public string Text { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public List<string> Answers { get; set; } = new();
    public int CorrectIndex { get; set; }
    public string Explanation { get; set; } = string.Empty;
}

public sealed class QuizSession
{
    private readonly List<Question> _questions;
    private int _index;

    public QuizSession(List<Question>? questions = null)
    {
        _questions = questions ?? new List<Question>();
        Score = 0;
        _index = 0;
    }

    public int Score { get; set; }
    public int CurrentIndex => _index;
    public Question? CurrentQuestion => _index >= 0 && _index < _questions.Count ? _questions[_index] : null;

    public void RecordAnswer(int selectedIndex)
    {
        if (CurrentQuestion is null) return;

        if (selectedIndex == CurrentQuestion.CorrectIndex)
        {
            Score += 1;
        }
    }

    public bool MoveNext()
    {
        if (_index < _questions.Count - 1)
        {
            _index += 1;
            return true;
        }

        return false;
    }
}

public sealed class AppSettings
{
    public string Title { get; set; } = "Window Test";
    public double MinConfidence { get; set; } = 85.0;
    public bool NotifyOnSignal { get; set; } = true;
    public QuizStrategyModel SelectedStrategy { get; set; } = QuizStrategyModel.BASE_QUIZ;
}

public sealed class BaseStrategyConfig
{
    public string MacroIntervalLabel { get; set; } = "4H";
    public string StrategyIntervalLabel { get; set; } = "1H";
    public string TriggerIntervalLabel { get; set; } = "15m";
    public int MinRiskReward { get; set; } = 150;
    public bool RequireHigherTfAlignment { get; set; } = true;
}

public sealed class DriveBookPlaybookSpec
{
    public string StrategyId { get; set; } = string.Empty;
    public string TitleFa { get; set; } = string.Empty;
    public string IchimokuSettingsFa { get; set; } = string.Empty;
    public List<string> EntryChecklistStepsFa { get; set; } = new();
    public string StopLossFormulaFa { get; set; } = string.Empty;
    public string TakeProfitAndExitRulesFa { get; set; } = string.Empty;
    public string SpecialEdgeAdvantageFa { get; set; } = string.Empty;
}
