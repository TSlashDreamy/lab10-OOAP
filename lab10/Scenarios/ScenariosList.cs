using lab10.Scenarios.Interfaces;

namespace lab10.Scenarios;

public static class ScenariosList
{
    private static List<IScenarioStrategy> scenariosList = new List<IScenarioStrategy>();

    static ScenariosList()
    {
        scenariosList.Add(new ForestScenario());
        scenariosList.Add(new MountainScenario());
        scenariosList.Add(new RiverScenario());
        scenariosList.Add(new HomeScenario());
    }

    public static List<IScenarioStrategy> Scenarios
    {
        get { return scenariosList; }
    }
}
