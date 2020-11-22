﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Hobbies
{

    public class Hobbies
    {
        private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();

        public void Add(string hobbyist, params string[] hobbies)
        {
            this.hobbies.Add(hobbyist, hobbies);
        }

        public List<string> FindAllHobbyists(string hobby)
        {
            var result = hobbies.Where(x => x.Value.Contains(hobby)).Select(x=>x.Key);
            return result.ToList();
        }

        public static void Main(string[] args)
        {
            Hobbies hobbies = new Hobbies();
            hobbies.Add("Steve", "Fashion", "Piano", "Reading");
            hobbies.Add("Patty", "Drama", "Magic", "Pets");
            hobbies.Add("Chad", "Puzzles", "Pets", "Yoga");

            hobbies.FindAllHobbyists("Yoga").ForEach(item => Console.WriteLine(item));
        }
    }
}
