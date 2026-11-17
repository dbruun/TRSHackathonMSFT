namespace Trs.Intake;

public sealed record PortfolioRequest(
    string? Title, string? Problem, string? BusinessOwner, string? SuccessMetric);

public sealed record IntakeAssessment(bool IsReady, IReadOnlyList<string> Questions);

public static class IntakeReviewer
{
    public static IntakeAssessment Assess(PortfolioRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        var questions = new List<string>();
        if (string.IsNullOrWhiteSpace(request.Title))
        {
            questions.Add("What is the request title?");
        }

        if (string.IsNullOrWhiteSpace(request.Problem))
        {
            questions.Add("What problem should this solve, and for whom?");
        }

        if (string.IsNullOrWhiteSpace(request.BusinessOwner))
        {
            questions.Add("Which team owns the business outcome?");
        }

        if (string.IsNullOrWhiteSpace(request.SuccessMetric))
        {
            questions.Add("What measurable outcome would demonstrate success?");
        }

        return new IntakeAssessment(questions.Count == 0, questions.AsReadOnly());
    }
}
