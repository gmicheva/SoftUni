using System;
using System.Collections.Generic;
using System.Linq;


namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split('-').ToList();

                string creator = data[0];
                string teamName = data[1];

                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    bool isFound = false;
                    foreach (KeyValuePair<string, Team> coder in teams)
                    {
                        if (coder.Value.CreatorName == creator)
                        {
                            Console.WriteLine($"{creator} cannot create another team!");
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        teams[teamName] = new Team(teamName, creator);
                    }
                }
            }
            List<string> teamInput = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (teamInput[0] != "end of assignment")
            {
                string coderName = teamInput[0];
                string teamName = teamInput[1];

                if (!teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    bool isFound = false;
                    foreach (KeyValuePair<string, Team> members in teams)
                    {
                        if (members.Value.Members.Contains(coderName))
                        {
                            Console.WriteLine($"Member {coderName} cannot join team {teamName}!");
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        teams[teamName].Members.Add(coderName);
                    }
                }
                teamInput = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            List<string> bandedTeam = new List<string>();

            foreach (KeyValuePair<string, Team> team in teams.OrderByDescending(x => x.Value.Members.Count).ThenBy(x => x.Key))
            {
                if (team.Value.Members.Count > 1)
                {
                    Console.WriteLine($"{team.Key}");
                    Console.WriteLine($"- {team.Value.CreatorName}");
                    team.Value.Members = team.Value.Members.Skip(1).ToList();
                    team.Value.Members.Sort();

                    foreach (string name in team.Value.Members)
                    {
                        Console.WriteLine($"-- {name}");
                    }
                }
                else
                {
                    bandedTeam.Add(team.Key);
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (string item in bandedTeam)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

    class Team
    {
        public string Name;
        public string CreatorName;
        public List<string> Members;

        public Team(string name, string creator)
        {
            this.Name = name;
            this.CreatorName = creator;
            this.Members = new List<string>();
            this.Members.Add(creator);

            Console.WriteLine($"Team {this.Name} has been created by {this.CreatorName}!");
        }
    }
}
