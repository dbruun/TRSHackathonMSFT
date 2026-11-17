using Trs.Intake;

namespace Trs.Intake.Tests;

public class IntakeReviewerTests
{
    private static readonly PortfolioRequest Complete =
        new("Demo", "Incomplete submissions delay discovery.", "Demo team", "20% fewer incomplete submissions.");

    [Fact]
    public void CompleteRequestIsReadyWithoutQuestions()
    {
        var result = IntakeReviewer.Assess(Complete);

        Assert.True(result.IsReady);
        Assert.Empty(result.Questions);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" \t")]
    public void MissingFieldsProduceOrderedQuestions(string? missing)
    {
        var result = IntakeReviewer.Assess(new(missing, missing, missing, missing));

        Assert.False(result.IsReady);
        Assert.Equal(new[]
        {
            "What is the request title?",
            "What problem should this solve, and for whom?",
            "Which team owns the business outcome?",
            "What measurable outcome would demonstrate success?"
        }, result.Questions);
    }

    [Theory]
    [InlineData("title")]
    [InlineData("problem")]
    [InlineData("owner")]
    [InlineData("metric")]
    public void EachRequiredFieldIndependentlyBlocksReadiness(string field)
    {
        var request = field switch
        {
            "title" => Complete with { Title = null },
            "problem" => Complete with { Problem = null },
            "owner" => Complete with { BusinessOwner = null },
            _ => Complete with { SuccessMetric = null }
        };

        var result = IntakeReviewer.Assess(request);

        Assert.False(result.IsReady);
        Assert.Single(result.Questions);
    }

    [Fact]
    public void NullRequestIsRejected()
    {
        Assert.Throws<ArgumentNullException>(() => IntakeReviewer.Assess(null!));
    }
}
