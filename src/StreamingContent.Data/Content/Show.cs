using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Show : StreamingContent
    {

        List<Episode> episodes = new List<Episode>();

        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageTime { get; set; }

        public Show(){}

        public Show(int SeasonCount, int episodeCount, double AverageTime, string title, string duration, double starRating, MaturityRating rating, GenreType type)
        :base(title,duration,starRating,rating,type)
        {
            SeasonCount=SeasonCount;
            EpisodeCount=episodeCount;
            AverageTime=AverageTime;
        }
    }
