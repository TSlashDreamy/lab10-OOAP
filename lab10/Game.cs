using lab10.Scenarios.Interfaces;

namespace lab10;

class Game
{
    private IScenarioStrategy scenarioStrategy;
    private List<Artifact> artifacts;

    public Game(IScenarioStrategy strategy, List<Artifact> artifacts)
    {
        this.scenarioStrategy = strategy;
        this.artifacts = artifacts;
    }

    public void SetStrategy(IScenarioStrategy strategy)
    {
        this.scenarioStrategy = strategy;
    }

    public void Play()
    {
        Unit unit = new Unit(artifacts);
        unit.TraverseDarkForest();
        scenarioStrategy.PlayScenario(unit);
    }
}
