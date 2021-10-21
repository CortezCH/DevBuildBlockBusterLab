using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildBlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string incomingTitle, string incomingCategory, int incomingRunTime, List<string> incomingScenes)
            : base(incomingTitle, incomingCategory, incomingRunTime, incomingScenes)
        {

        }

        public override void Play()
        {
            try
            {
                int userSceneChoice = int.Parse(GetUserInput($"Which Scene of the DVD \"{Title}\" would you like to watch? Select 1 to {scenes.Count}: "));
                Console.WriteLine($"Scene {userSceneChoice}: {scenes[userSceneChoice-1]}");

                if (WatchAnotherScene())
                {
                    Play();
                }
            }
            catch
            {
                Console.WriteLine("That scene index is invalid. please try again.");
                Play();
            }
            
        }
    }
}
