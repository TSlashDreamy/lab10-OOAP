using lab10.Artifacts;
using lab10.Items;
using lab10.Scenarios.Interfaces;

namespace lab10.Scenarios;

class ForestScenario : IScenarioStrategy
{
    public void PlayScenario(Unit unit)
    {
        List<Artifact> requiredArtifacts = new List<Artifact>() { ArtifactsList.Items[ArtifactsEnums.Magic_Lantern], ArtifactsList.Items[ArtifactsEnums.Wand_Of_Fireballs] };

        if (!unit.HasRequiredArtifacts(requiredArtifacts))
        {
            Console.WriteLine("Unit does not have required artifacts for traversing the Forest");
            return;
        }

        Console.WriteLine("Unit traversed the Forest");
    }
}
