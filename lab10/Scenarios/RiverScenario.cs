using lab10.Artifacts;
using lab10.Items;
using lab10.Scenarios.Interfaces;

namespace lab10.Scenarios;

class RiverScenario : IScenarioStrategy
{
    public void PlayScenario(Unit unit)
    {
        List<Artifact> requiredArtifacts = new List<Artifact>() { ArtifactsList.Items[ArtifactsEnums.Amulet_Of_Water_Breathing], ArtifactsList.Items[ArtifactsEnums.Boots_Of_Speed] };

        if (!unit.HasRequiredArtifacts(requiredArtifacts))
        {
            Console.WriteLine("Unit does not have required artifacts for traversing the River");
            return;
        }

        Console.WriteLine("Unit traversed the River");
    }
}
