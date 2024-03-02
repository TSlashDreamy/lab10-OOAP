using lab10;

/* === if you prefer the good old way ===

Artifact artifact1 = ArtifactsList.Items[ArtifactsEnums.Magic_Lantern];
Artifact artifact2 = ArtifactsList.Items[ArtifactsEnums.Wand_Of_Fireballs];
List<Artifact> artifacts = new List<Artifact>() { artifact1, artifact2 };

Game game = new Game(new ForestScenario(), artifacts);
game.Play();

*/

UI ui = new UI();
ui.Initialize();
