using Trs.Intake;

if (args.Length > 1 || (args.Length == 1 && args[0] != "--complete"))
{
    Console.Error.WriteLine("Usage: dotnet run --project src/Trs.Intake [-- --complete]");
    return 2;
}

var request = args.Length == 1
    ? new PortfolioRequest(
        "Improve intake", "Requests arrive without measurable outcomes.",
        "Demo portfolio team", "Reduce incomplete submissions by 20% in a pilot.")
    : new PortfolioRequest("Improve intake", "Make intake better.", null, null);

var assessment = IntakeReviewer.Assess(request);
Console.WriteLine(assessment.IsReady
    ? "Ready for discovery (not an approval or prioritization decision)."
    : "Needs clarification:");

foreach (var question in assessment.Questions)
{
    Console.WriteLine($"- {question}");
}

return 0;
