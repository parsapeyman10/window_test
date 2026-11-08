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
                Text = "Which of the following best defines a well-structured testing app?",
                Category = "Strategy",
                Answers = new List<string>
                {
                    "A system that validates intent, shows results clearly, and keeps the flow consistent.",
                    "A random list of buttons with no context.",
                    "A timer without scoring logic.",
                    "A static image shown on every screen."
                },
                CorrectIndex = 0,
                Explanation = "Clean flow and structured evaluation are essential for reliable digital testing."
            },
            new()
            {
                Text = "What makes a strategy selection screen useful in a Windows desktop app?",
                Category = "UX",
                Answers = new List<string>
                {
                    "It exposes different assessment profiles without confusing the user.",
                    "It hides all options from the user.",
                    "It is unnecessary for desktop apps.",
                    "It should always be disabled in production."
                },
                CorrectIndex = 0,
                Explanation = "Strategy profiling improves context and makes a test feel intentional and adaptable."
            },
            new()
            {
                Text = "Which of these is the most modern Microsoft-supported stack for a new Windows 10 desktop app?",
                Category = "Technology",
                Answers = new List<string>
                {
                    "C# + .NET 8 + WPF or WinUI 3 + MSIX",
                    "Classic Flash with HTML layers",
                    "Only JavaScript without desktop packaging",
                    "A random Python script with no UI"
                },
                CorrectIndex = 0,
                Explanation = "This is the current recommended Microsoft stack for modern Windows desktop apps."
            },
            new()
            {
                Text = "Why is a summary screen important after the test ends?",
                Category = "Results",
                Answers = new List<string>
                {
                    "It tells the user what they scored and how they performed.",
                    "It should remain hidden from the user.",
                    "It delays the app but adds no value.",
                    "It is only useful for debugging code."
                },
                CorrectIndex = 0,
                Explanation = "Reports and score summaries are essential to make the result meaningful."
            },
            new()
            {
                Text = "Which approach is best for a scalable desktop test application?",
                Category = "Architecture",
                Answers = new List<string>
                {
                    "Models + ViewModels + Services + UI separation",
                    "One giant form with everything in the same class",
                    "Hardcoded UI only with no reusable state",
                    "Random generated content without structure"
                },
                CorrectIndex = 0,
                Explanation = "Separation of concerns creates maintainable, extensible applications."
            },
            new()
            {
                Text = "What is the main advantage of using MVVM-style patterns in WPF?",
                Category = "Design",
                Answers = new List<string>
                {
                    "Cleaner UI logic, testability, and easier future changes.",
                    "Slower runtime and reduced control.",
                    "A requirement only for websites.",
                    "It removes the need for any user interaction."
                },
                CorrectIndex = 0,
                Explanation = "MVVM improves readability, separation, and maintainability in desktop app development."
            },
            new()
            {
                Text = "What is the ideal final step before releasing a Windows desktop app?",
                Category = "Delivery",
                Answers = new List<string>
                {
                    "Package, test, verify installation, and validate user flow.",
                    "Ship immediately without testing.",
                    "Skip validation and rely on assumptions.",
                    "Only check if the app opens once."
                },
                CorrectIndex = 0,
                Explanation = "Real deployment requires packaging, verification, and usability checks."
            }
        };
    }
}

public static class QuizStrategyCatalog
{
    public static DriveBookPlaybookSpec GetSpec(QuizModelType model)
    {
        return model switch
        {
            QuizModelType.BASE_QUIZ => new DriveBookPlaybookSpec
            {
                StrategyId = "BASE_QUIZ",
                TitleFa = "Base quiz: balanced logic + structure",
                IchimokuSettingsFa = "Standard default test configuration with cleaner decision flow.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Read the question carefully.",
                    "Compare the available options.",
                    "Select the best answer with confidence."
                },
                StopLossFormulaFa = "Reject low-confidence and misleading answers.",
                TakeProfitAndExitRulesFa = "Lock the correct answer when the logic is clear.",
                SpecialEdgeAdvantageFa = "Optimized for clean and predictable comprehension."
            },
            QuizModelType.PARSA_52_LINE_TURN => new DriveBookPlaybookSpec
            {
                StrategyId = "PARSA_52_LINE_TURN",
                TitleFa = "Parsa 52 Line Turn",
                IchimokuSettingsFa = "Long-context turn model with plateau recognition.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Verify context.",
                    "Check the most likely answer.",
                    "Confirm the turn before final submission."
                },
                StopLossFormulaFa = "Avoid weak or ambiguous choices.",
                TakeProfitAndExitRulesFa = "Convert only when the answer is strongly supported.",
                SpecialEdgeAdvantageFa = "Excellent for decisive, turn-based analysis."
            },
            QuizModelType.BTC_52_CANDLE_REGIME => new DriveBookPlaybookSpec
            {
                StrategyId = "BTC_52_CANDLE_REGIME",
                TitleFa = "BTC 52 Candle Regime",
                IchimokuSettingsFa = "Long-view and regime confirmation for high-context decisions.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Use the broader context.",
                    "Validate the signal against the larger pattern.",
                    "Commit to the answer only when the pattern is coherent."
                },
                StopLossFormulaFa = "Reject noisy and short-term confusion.",
                TakeProfitAndExitRulesFa = "Capture only confident and consistent decisions.",
                SpecialEdgeAdvantageFa = "Best for broader, more deliberate evaluation."
            },
            _ => new DriveBookPlaybookSpec
            {
                StrategyId = "DRIVE_BOOKS_1_TO_9_UNIFIED_MASTER",
                TitleFa = "Drive Book Master",
                IchimokuSettingsFa = "Multi-layer validation and all-cues review for maximum confidence.",
                EntryChecklistStepsFa = new List<string>
                {
                    "Review all relevant cues.",
                    "Check consistency across layers.",
                    "Submit only when the final answer is fully supported."
                },
                StopLossFormulaFa = "Block weak or contradictory answers.",
                TakeProfitAndExitRulesFa = "Take the result only when all layers agree.",
                SpecialEdgeAdvantageFa = "The most conservative and confidence-driven mode."
            }
        };
    }
}
