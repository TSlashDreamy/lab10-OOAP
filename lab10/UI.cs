using lab10.Artifacts;
using lab10.Items;
using lab10.Scenarios;
using lab10.Scenarios.Interfaces;
using System.Text.RegularExpressions;

namespace lab10;

internal class UI
{
    public void Initialize()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Select your artifacts: ");
            ShowItemList();

            Console.Write("\nFirst artifact (Type a number): ");
            Artifact artifact1 = GetItem();
            Console.Write("\nSecond artifact (Type a number): ");
            Artifact artifact2 = GetItem();

            Console.Clear();
            Console.WriteLine("Select your path: ");
            ShowScenarios();
            Console.Write("\nYour path (Type a number): ");
            IScenarioStrategy path = GetScenario();

            Console.Clear();
            Console.WriteLine($"Your artifacts: {artifact1.Name} and {artifact2.Name}\n\n");
            PlayGame(new List<Artifact>() { artifact1, artifact2 }, path);

            Console.Write("\n\nWanna try again? (y/n): ");
            bool enought = Console.ReadLine().Trim().ToLower() == "n";
            if (enought) break;
        } while (true);

        Console.WriteLine("\n\n~~~~ Game over ~~~~");
    }

    void ShowItemList()
    {
        foreach (ArtifactsEnums item in Enum.GetValues(typeof(ArtifactsEnums)))
        {
            Console.WriteLine($"{(int)item + 1}. {item.ToString().Replace("_", " ")}");
        }
    }

    void ShowScenarios()
    {
        int id = 1;

        foreach (var scenario in ScenariosList.Scenarios)
        {
            Console.WriteLine($"{id++}. {Regex.Replace(scenario.GetType().Name, "(\\B[A-Z])", " $1")}");
        }
    }

    Artifact GetItem()
    {
        while (true)
        {
            string artifactString = Console.ReadLine();
            try
            {
                int itemNum = int.Parse(artifactString);

                if (itemNum < 0 || itemNum > ArtifactsList.Items.Count) throw new ArgumentOutOfRangeException();
                Array enumValues = Enum.GetValues(typeof(ArtifactsEnums));
                return ArtifactsList.Items[(ArtifactsEnums)enumValues.GetValue(itemNum - 1)];
            }
            catch
            {
                Console.Clear();
                ShowItemList();
                Console.Write($"Looks like {artifactString} is not a correct artifact number.\nTry again: ");
            }
        }
    }

    IScenarioStrategy GetScenario()
    {

        while (true)
        {
            string scenarioString = Console.ReadLine();
            try
            {
                int scenarioNum = int.Parse(scenarioString);

                switch (scenarioNum)
                {
                    case 1:
                        return new ForestScenario();
                    case 2:
                        return new MountainScenario();
                    case 3:
                        return new RiverScenario();
                    case 4:
                        return new HomeScenario();
                    default:
                        throw new ArgumentOutOfRangeException();

                }
            }
            catch
            {
                Console.Clear();
                ShowScenarios();
                Console.Write($"Looks like {scenarioString} is not a correct scenario number.\nTry again: ");
            }
        }
    }

    void PlayGame(List<Artifact> artifacts, IScenarioStrategy scenario)
    {
        Game game = new Game(scenario, artifacts);
        game.Play();
    }
}
