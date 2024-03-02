using lab10.Artifacts;
using lab10.Items;
using lab10.Scenarios.Interfaces;

namespace lab10.Scenarios;

class HomeScenario : IScenarioStrategy
{
    public void PlayScenario(Unit unit)
    {
        List<Artifact> requiredArtifacts = new List<Artifact>() { ArtifactsList.Items[ArtifactsEnums.Cloak_Of_Invisibility], ArtifactsList.Items[ArtifactsEnums.Shield_Of_Invincibility] };

        if (!unit.HasRequiredArtifacts(requiredArtifacts))
        {
            Console.WriteLine("Unit successfully stayed at Home. tried to stay home in peace and quite, but everyone started to disturb him. You don't have needed artifact to fix this");
            return;
        }

        Console.WriteLine("Unit successfully stayed at Home.");
    }
}
