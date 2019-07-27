using System;
using System.Collections.Generic;
using System.Linq;

namespace _04DotaTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (input != "Tournament end")
            {
                string[] data = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = data[0];
                string teamName = data[1];

                if (command == "New team")
                {
                    List<string> players = data[2].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (!teams.ContainsKey(teamName) && players.Count == 5)
                    {
                        Team team = new Team(teamName, players);
                        teams.Add(teamName, team);
                    }
                }
                else if (command == "Disqualification")
                {
                    if (teams.ContainsKey(teamName))
                    {
                        teams.Remove(teamName);
                    }
                }
                else if (command == "Win")
                {
                    if (teams.ContainsKey(teamName))
                    {
                        teams[teamName].Wins += 1;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Teams:");

            foreach (var team in teams.Values.OrderByDescending(t => t.Wins))
            {
                Console.WriteLine($"{team.Name} - {string.Join(", ", team.Players)} -> {team.Wins} wins");
            }
        }
    }

    public class Team
    {

        public string Name { get; set; }
        public List<string> Players { get; set; }
        public int Wins { get; set; }

        public Team(string teamName, List<string> players)
        {
            this.Name = teamName;
            this.Players = players;
            this.Wins = 0;
        }


    }
}
