using System;

namespace PlatformGame.Helper{
    public class ConvertTime{
        public static string ConvertedTime(float totalTime){
            string timeSpan = TimeSpan.FromSeconds(totalTime).ToString();
            string[] splittedTimeSpan = timeSpan.Split(":"[0]);
            return splittedTimeSpan[1] + ":" + splittedTimeSpan[2].Split("."[0])[0];
        }
    }
}