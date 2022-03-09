using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }

        public Movie(){}

        public Movie(string title, string description, double starRating, MaturityRating maturityRating, GenreType type, double RunTime)
        : base(title,description,starRating,maturityRating,type)
        {
            this.RunTime = RunTime;
        }
    }
