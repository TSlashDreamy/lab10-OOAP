using lab10.Artifacts;
using lab10.Items;
using lab10.Scenarios.Interfaces;

namespace lab10.Scenarios;

class MountainScenario : IScenarioStrategy
{
    public void PlayScenario(Unit unit)
    {
        List<Artifact> requiredArtifacts = new List<Artifact>() { ArtifactsList.Items[ArtifactsEnums.Orb_Of_Teleportation], ArtifactsList.Items[ArtifactsEnums.Winged_Boots] };

        if (!unit.HasRequiredArtifacts(requiredArtifacts))
        {
            Console.WriteLine("Unit does not have required artifacts for traversing the Mountain");
            return;
        }

        Console.WriteLine("Unit traversed the Mountain");
    }
}
