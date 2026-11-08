using WindowTest.Models;

namespace WindowTest.Services;

public static class QuestionCatalog
{
    public static List<Question> GetQuestions()
    {
        return new List<Question>
        {
            new()
            {
                Text = "Which of the following is the correct definition of a stable strategy in a smart test engine?",
                Category = "Strategy",
                Answers = new List<string>
                {
                    "A rule set that reduces noise and confirms intent before scoring.",
                    "A random set of answers used for speed only.",
                    "A timer without questions.",
                    "The same question repeated forever."
                },
                CorrectIndex = 0,
                Explanation = "A strategy should filter noise and clarify the decision path."
            },
            new()
            {
                Text = "What is the best purpose of an assessment summary page?",
                Category = "UX",
                Answers = new List<string>
                {
                    "To show results, score, and final interpretation.",
                    "To hide all outcomes from the user.",
                    "To slow down the app intentionally.",
                    "To remove the user identity from the session."
                },
                CorrectIndex = 0,
                Explanation = "The summary is the place where the system tells the user what happened."
            },
            new()
            {
                Text = "Which of the following is the best signal model for a responsive quiz?",
                Category = "Signals",
                Answers = new List<string>
                {
                    "Single answer with a confidence and evaluation state.",
                    "An empty list with no score.",
                    "A countdown only.",
                    "A fixed image on every screen."
                },
                CorrectIndex = 0,
                Explanation = "A proper signal contains actionable value, not just a visual placeholder."
            },
            new()
            {
                Text = "Why is a default config useful in an app like this?",
                Category = "Settings",
                Answers = new List<string>
                {
                    "It creates a safe baseline for evaluation and tuning.",
                    "It guarantees all users receive the same random questions.",
                    "It removes all user settings.",
                    "It disables the test permanently."
                },
                CorrectIndex = 0,
                Explanation = "Default configuration gives control and consistency while preserving flexibility."
            },
            new()
            {
                Text = "What is the correct idea behind a controlled question flow?",
                Category = "Flow",
                Answers = new List<string>
                {
                    "Move one question at a time with validation before continuing.",
                    "Show all questions at once with no order.",
                    "Lock the user out after the first click.",
                    "Use random text in place of answers."
                },
                CorrectIndex = 0,
                Explanation = "A controlled flow keeps the test coherent and reduces confusion."
            },
            new()
            {
                Text = "Which statement best matches a strong score board?",
                Category = "Reporting",
                Answers = new List<string>
                {
                    "It gives a clear percentage, result, and strategy context.",
                    "It hides percent and shows only a timer.",
                    "It contains no data at all.",
                    "It uses a hidden password field."
                },
                CorrectIndex = 0,
                Explanation = "A useful score board presents meaningful evaluation data to the user."
            }
        };
    }
}

public static class QuizStrategyCatalog
{
    public static DriveBookPlaybookSpec GetSpec(QuizStrategyModel model)
    {
        return model switch
        {
            QuizStrategyModel.BASE_QUIZ => new DriveBookPlaybookSpec
            {
                StrategyId = "BASE_QUIZ",
                TitleFa = "Base quiz: balanced logic + structure",
                IchimokuSettingsFa = "Default setup: standard stability, clean sequencing, readable answers.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Check the meaning of the question.",
                    "Evaluate the options against the rule set.",
                    "Confirm the best result before submitting."
                },
                StopLossFormulaFa = "Loss prevention via validation before scoring.",
                TakeProfitAndExitRulesFa = "Lock in a clean result once the answer is confirmed.",
                SpecialEdgeAdvantageFa = "Reduces hesitation and keeps the flow deterministic."
            },
            QuizStrategyModel.PARSA_52_LINE_TURN => new DriveBookPlaybookSpec
            {
                StrategyId = "PARSA_52_LINE_TURN",
                TitleFa = "Parsa 52 Line Turn",
                IchimokuSettingsFa = "52-bar context with plateau confirmation and turn detection.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Verify the question is in a valid context.",
                    "Look for the strongest answer under the rule set.",
                    "Use turn logic before locking the final choice."
                },
                StopLossFormulaFa = "Reject weak or noisy signal states.",
                TakeProfitAndExitRulesFa = "Take the strongest result once alignment is clear.",
                SpecialEdgeAdvantageFa = "Good for cases that require a turn-based decision and clear filters."
            },
            QuizStrategyModel.BTC_52_CANDLE_REGIME => new DriveBookPlaybookSpec
            {
                StrategyId = "BTC_52_CANDLE_REGIME",
                TitleFa = "BTC 52 Candle Regime",
                IchimokuSettingsFa = "64+ step context, long-window confirmation, and trend clarity.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Use the long view to validate context.",
                    "Check whether a short answer still matches the bigger picture.",
                    "Only submit when clarity is stronger than noise."
                },
                StopLossFormulaFa = "Do not act on short-window confusion.",
                TakeProfitAndExitRulesFa = "Capture the correct answer only after the pattern is confirmed.",
                SpecialEdgeAdvantageFa = "Designed for stronger, longer-horizon evaluation."
            },
            _ => new DriveBookPlaybookSpec
            {
                StrategyId = "DRIVE_BOOKS_1_TO_9_UNIFIED_MASTER",
                TitleFa = "Drive Book Master",
                IchimokuSettingsFa = "Multi-layer consistency and cross-checking for reliable outcomes.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Check all major cues.",
                    "Verify consistency across layers.",
                    "Submit only when the answer stands above all noise."
                },
                StopLossFormulaFa = "Limit uncertain or contradictory answers.",
                TakeProfitAndExitRulesFa = "Take the answer only when the full pattern aligns.",
                SpecialEdgeAdvantageFa = "Most conservative strategy: best for high-confidence test scoring."
            }
        };
    }
}

