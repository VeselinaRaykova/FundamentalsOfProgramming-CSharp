using System;
using System.Collections.Generic;
using System.Linq;

namespace _24TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teams = CreateTeams(n);

            AddMembers(teams);
            PrintTeamsReport(teams.Values.ToList());
        }

        private static Dictionary<string, Team> CreateTeams(int n)
        {
            string[] commands;
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            for (int i = 0; i < n; i++)
            {
                commands = Console.ReadLine().Split('-').ToArray();
                string creator = commands[0];
                string teamName = commands[1];
                bool isTeamCreated = GetIsTeamCreated(teamName, teams);
                bool isCreator = GetIsCreator(creator, teams.Values.ToList());

                if (isTeamCreated)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreator)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(teamName, team);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            return teams;
        }

        private static bool GetIsTeamCreated(string teamName, Dictionary<string, Team> teams)
        {
            if (teams.ContainsKey(teamName))
            {
                return true;
            }

            return false;
        }

        private static bool GetIsCreator(string user, List<Team> teams)
        {
            foreach (Team team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }
            }

            return false;
        }

        private static void AddMembers(Dictionary<string, Team> teams)
        {
            string input = Console.ReadLine();
            string[] teamInfo;

            while (input.ToLower() != "end of assignment")
            {
                teamInfo = input
                    .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string user = teamInfo[0];
                string teamName = teamInfo[1];
                bool doesTeamExist = teams.ContainsKey(teamName);
                bool isAlreadyAMember = GetIsAMember(user, teams.Values.ToList());

                if (!doesTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isAlreadyAMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    teams[teamName].Members.Add(user);
                }

                input = Console.ReadLine();
            }
        }

        private static bool GetIsAMember(string user, List<Team> teams)
        {
            foreach (Team t in teams)
            {
                if (t.Members.Contains(user) || t.Creator == user)
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintTeamsReport(List<Team> teams)
        {

            List<Team> teamsWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count < 1)
                .OrderBy(t => t.Name)
                .ToList();

            foreach (Team t in teamsWithMembers)
            {
                t.Members.Sort();

                Console.WriteLine(t.Name);
                Console.WriteLine($"- {t.Creator}");
                foreach (string member in t.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team t in teamsToDisband)
            {
                Console.WriteLine(t.Name);
            }
        }

        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string name, string founder)
            {
                this.Name = name;
                this.Creator = founder;
                this.Members = new List<string>();
            }
        }
    }
}
