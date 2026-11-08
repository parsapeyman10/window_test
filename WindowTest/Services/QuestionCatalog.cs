namespace WindowTest.Models;

public enum QuizModelType
{
    BASE_QUIZ,
    BTC_52_CANDLE_REGIME,
    PARSA_52_LINE_TURN,
    DRIVE_BOOKS_1_TO_9_UNIFIED_MASTER,
}

public sealed class Question
{
    public string Text { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public List<string> Answers { get; set; } = new();
    public int CorrectIndex { get; set; }
    public string CorrectAnswer => Answers.Count > CorrectIndex ? Answers[CorrectIndex] : string.Empty;
    public string Explanation { get; set; } = string.Empty;
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
