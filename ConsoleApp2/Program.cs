using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    public static List<Team> teams = new List<Team>();
    static void Main()
    {

        while (true)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Choose the action:");
            Console.WriteLine("1. Add team");
            Console.WriteLine("2. Add team member");
            Console.WriteLine("3. Display team's information");
            Console.WriteLine("4. Display team's detailed information");
            Console.WriteLine("5. Exit");

            string? choice = Console.ReadLine();

            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Team can't equal 0");
                return;
            }

            switch (choice)
            {
                case "1":
                    AddTeam();
                    break;
                case "2":
                    AddWorkerToTeam();
                    break;
                case "3":
                    DisplayAllTeamsInfo();
                    break;
                case "4":
                    DisplayAllDetailedTeamsInfo();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
    }
    static void AddTeam()
    {
    Console.Write("Enter team's name: ");

        string? teamName = Console.ReadLine();

        if (string.IsNullOrEmpty(teamName))
        {
            Console.WriteLine("The team name can't be empty");
            return;
        }

        var team = new Team(teamName);

        teams.Add(team);
    }
    static void AddWorkerToTeam()
    {
        if (teams.Count == 0)
        {
            Console.WriteLine("Firstly add a team");
            return;
        }

        Console.Write("Write worker's name: ");
        string? workerName = Console.ReadLine();

        Console.WriteLine("Choose worker's occupation:");
        Console.WriteLine("1. Developer");
        Console.WriteLine("2. Manager");
        string? positionChoice = Console.ReadLine();

        Worker? worker = null;

        switch (positionChoice)
        {
            case "1":
                worker = new Developer(workerName);
                worker.WorkDay = "Monday to Friday";
                break;
            case "2":
                worker = new Manager(workerName);
                worker.WorkDay = "Monday to Wednesday";
                break;
            default:
                Console.WriteLine("Unknown command");
                return;
        }

        Console.WriteLine("Choose team:");
        for (int i = 0; i < teams.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {teams[i].TeamName}");
        }
        int teamIndex = int.Parse(Console.ReadLine()) - 1;

        if (teamIndex >= 0 && teamIndex < teams.Count)
        {
            teams[teamIndex].AddWorker(worker);
            Console.WriteLine($"Worker {workerName} was added to the team {teams[teamIndex].TeamName}");
        }
        else
        {
            Console.WriteLine("Wrong team");
        }
    }

    static void DisplayAllTeamsInfo()

    {
        foreach (var team in teams)
        {
            team.GetTeamInfo();
        }
        Console.WriteLine();
    }

    static void DisplayAllDetailedTeamsInfo()
    {
        foreach (var team in teams)
        {
            team.GetFullTeamInfo();
        }
        Console.WriteLine();
    }

}

