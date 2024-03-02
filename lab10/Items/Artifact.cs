using lab10.Items;

public class Artifact
{
    public string Name { get; }

    public Artifact(ArtifactsEnums name)
    {
        Name = name.ToString().Replace("_", " ");
    }
}
