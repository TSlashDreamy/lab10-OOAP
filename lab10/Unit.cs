namespace lab10;

public class Unit
{
    private List<Artifact> artifacts;

    public Unit(List<Artifact> artifacts)
    {
        if (artifacts.Count > 2)
        {
            throw new ArgumentException("A unit can only have up to two artifacts.");
        }
        this.artifacts = artifacts;
    }

    public bool HasRequiredArtifacts(List<Artifact> requiredArtifacts)
    {
        foreach (var artifact in requiredArtifacts)
        {
            if (!artifacts.Contains(artifact))
            {
                return false;
            }
        }
        return true;
    }

    public void TraverseDarkForest()
    {
        foreach (var artifact in artifacts)
        {
            Console.WriteLine($"Using artifact: {artifact.Name}");
        }
        Console.WriteLine("Traversing the dark forest...");
    }
}
