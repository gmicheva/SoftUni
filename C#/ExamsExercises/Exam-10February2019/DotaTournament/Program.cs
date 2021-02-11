using System;
using System.Collections.Generic;
using System.Linq;

namespace DotaTournament
{
    class Team
    {
        public string Teamname;
        public List<string> Players;
        public int Win;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Team> allTeams = new List<Team>();
            Dictionary<string, Team> teamPlayers = new Dictionary<string, Team>();
            Dictionary<string, int> winerScore = new Dictionary<string, int>();

            while (input != "Tournament end")
            {
                List<string> data = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = data[0];
                string teamName = data[1];
                int win = 0;

                switch (command)
                {
                    case "New team":

                        List<string> players = data[2].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        Team currentTeam = new Team();
                        currentTeam.Teamname = teamName;
                        currentTeam.Players = players;
                        currentTeam.Win = win;

                        if (players.Count == 5 && !allTeams.Any(x => x.Teamname == teamName))
                        {
                            allTeams.Add(currentTeam);
                        }
                        break;

                    case "Disqualification":
                        if (allTeams.Any(x => x.Teamname == teamName))
                        {
                            Team teamToRemove = allTeams.First(x => x.Teamname == teamName);
                            allTeams.Remove(teamToRemove);
                        }
                        break;

                    case "Win":
                        if (allTeams.Any(x => x.Teamname == teamName))
                        {
                            allTeams.First(x => x.Teamname == teamName).Win++;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Teams:");

            foreach (var team in allTeams.OrderByDescending(x => x.Win))
            {
                Console.WriteLine($"{team.Teamname} - {string.Join(", ", team.Players)} -> {team.Win} wins");
            }
        }
    }
}
