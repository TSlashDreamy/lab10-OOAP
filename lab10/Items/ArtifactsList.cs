using lab10.Items;
namespace lab10.Artifacts;

public static class ArtifactsList
{
    private static Dictionary<ArtifactsEnums, Artifact> artifactList = new Dictionary<ArtifactsEnums, Artifact>();

    static ArtifactsList()
    {
        foreach (ArtifactsEnums artifact in Enum.GetValues(typeof(ArtifactsEnums)))
        {
            string name = Enum.GetName(typeof(ArtifactsEnums), artifact);
            artifactList.Add(artifact, new Artifact((ArtifactsEnums)Enum.Parse(typeof(ArtifactsEnums), name)));
        }
    }

    public static Dictionary<ArtifactsEnums, Artifact> Items
    {
        get { return artifactList; }
    }
}
