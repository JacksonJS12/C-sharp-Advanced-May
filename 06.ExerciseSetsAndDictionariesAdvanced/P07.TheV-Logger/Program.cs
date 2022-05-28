
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new SortedSet<string>();
            var followers = new Dictionary<string, HashSet<string>>();
            followers.OrderBy(entry => entry.Value.Count);

            var followings = new Dictionary<string, HashSet<string>>();
            followings.OrderByDescending(entry => entry.Value.Count)
                .ThenBy(entry => entry.Key);

            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] inputInfo = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string vloggerName = inputInfo[0];
                string vloggerFollowed = inputInfo[2];

                if (inputInfo[1] == "joined")
                {
                    vloggers.Add(vloggerName);

                    followers.Add(vloggerName, new HashSet<string>());
                    followings.Add(vloggerName, new HashSet<string>());
                }
                else if (vloggerName != vloggerFollowed)
                {
                    if (inputInfo[1] == "followed")
                    {

                        followings[vloggerName].Add(vloggerFollowed);

                        followers[vloggerFollowed].Add(vloggerName);

                    }
                }

                input = Console.ReadLine();
            }
           
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            foreach (var item in followers)
            {
                for (int i = 1; i <= followers.Count; i++)
                {
                    if (i - 1 == 0)
                    {
                        Console.WriteLine($"1. {item.Key} : {followers.Values.Count} followers, {followings.Values.Count} following");
                        foreach (var follower in followers.Values)
                        {
                            Console.WriteLine($"* {follower}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{i}. {item.Key} : {followers.Values.Count} followers, {followings.Values.Count} following");
                    }
                }
               
               
            }
        }
    }
}
