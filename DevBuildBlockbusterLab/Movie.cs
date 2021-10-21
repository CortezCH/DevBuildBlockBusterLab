using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildBlockbusterLab
{
    class Movie
    {
        protected string title;
        protected string category;
        protected int runTime;
        protected List<string> scenes;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int RunTime
        {
            get { return runTime; }
            set { runTime = value; }
        }

        public List<string> Scenes
        {
            get { return scenes; }
            set { scenes = value; }
        }

        public Movie(string incomingTitle, string incomingCategory, int incomingRunTime, List<string> incomingScenes)
        {
            Title = incomingTitle;
            Category = incomingCategory;
            RunTime = incomingRunTime;
            Scenes = incomingScenes;
        }

        public virtual void Play()
        {
        }

        public virtual void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i + 1}: {Scenes[i]}");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return $"{Title}\n" +
                $"Category: {Category}\n" +
                $"Runtime: {RunTime}\n";
        }

        public virtual void PrintScenes()
        {

        }

        public bool WatchAnotherScene()
        {
            string userAnswer = GetUserInput("Would you like to watch another scene? (y/n): ");

            switch (userAnswer.Trim().ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    Console.WriteLine("That answer was invalid. Please enter Y or N");
                    return WatchAnotherScene();
            }
        }


        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            return output;
        }
    }
}
