
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new HashSet<string>();
            var followers = new Dictionary<string, List<string>>();
            
            var followings = new Dictionary<string, List<string>>();
            

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
                    if (!followings.ContainsKey(inputInfo[0]))
                    {
                        vloggers.Add(vloggerName);
                        followings.Add(vloggerName, new List<string>());
                        continue;
                    }
                    else if (!followers.ContainsKey(inputInfo[0]))
                    {
                        vloggers.Add(vloggerName);
                        followers.Add(vloggerName, new List<string>());
                        continue;
                    }
                    else if (!followings.ContainsKey(inputInfo[0]) &&
                        !followers.ContainsKey(inputInfo[0]))
                    {
                        vloggers.Add(vloggerName);

                        followers.Add(vloggerName, new List<string>());
                        followings.Add(vloggerName, new List<string>());
                        continue;
                    }
                    
                   
                }
                else if (vloggerName != vloggerFollowed)
                {
                    if (inputInfo[1] == "followed")
                    { 
                        if (!followings.ContainsValue(followings.Any(x => x.Value = inputInfo[0])))
                        {
                            followings[vloggerName].Add(vloggerFollowed);
                            continue;
                        }
                        else if (!followers.ContainsValue(inputInfo[0]))
                        {
                            followers[vloggerFollowed].Add(vloggerName);
                            continue;
                        }
                        else if (!followings.ContainsValue(inputInfo[0]) &&
                            !followers.ContainsKey(inputInfo[0]))
                        {
                            followings[vloggerName].Add(vloggerFollowed);
                            followers[vloggerFollowed].Add(vloggerName);
                            continue;
                        }

                    }
                }

                input = Console.ReadLine();
            }

            followers.OrderBy(entry => entry.Value.Count);
            followings.OrderByDescending(entry => entry.Value.Count)
                .ThenBy(entry => entry.Key);

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
