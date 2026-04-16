using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Analyzer
{
    internal class Program
    {
        static void Main()
        {
            ProcessJson();
            ProcessCsv();
            Console.WriteLine("Censorship completed successfully!");
        }

        //JSON PROCESSING
        static void ProcessJson()
        {
            string jsonText = File.ReadAllText("input.json");
            JArray matches = JArray.Parse(jsonText);

            foreach (JObject match in matches)
            {
                string team1 = match["team1"].ToString();
                string team2 = match["team2"].ToString();

                string maskedTeam1 = MaskTeam(team1);
                string maskedTeam2 = MaskTeam(team2);

                match["team1"] = maskedTeam1;
                match["team2"] = maskedTeam2;
                match["winner"] = MaskTeam(match["winner"].ToString());
                match["player_of_match"] = "REDACTED";

                JObject score = (JObject)match["score"];
                JObject newScore = new JObject
                {
                    [maskedTeam1] = score[team1],
                    [maskedTeam2] = score[team2]
                };
                match["score"] = newScore;
            }

            File.WriteAllText("output_censored.json",
                JsonConvert.SerializeObject(matches, Formatting.Indented));
        }

        //CSV PROCESSING
        static void ProcessCsv()
        {
            var lines = File.ReadAllLines("input.csv").ToList();
            List<string> output = new List<string>();
            output.Add(lines[0]); // header

            foreach (var line in lines.Skip(1))
            {
                var cols = line.Split(',');

                cols[1] = MaskTeam(cols[1]); // team1
                cols[2] = MaskTeam(cols[2]); // team2
                cols[5] = MaskTeam(cols[5]); // winner
                cols[6] = "REDACTED";         // player_of_match

                output.Add(string.Join(",", cols));
            }

            File.WriteAllLines("output_censored.csv", output);
        }

        //CENSORSHIP RULE
        static string MaskTeam(string team)
        {
            var parts = team.Split(' ');
            if (parts.Length >= 2)
                return parts[0] + " ***" + (parts.Length > 2 ? " " + parts[2] : "");
            return team;
        }
    }
}
