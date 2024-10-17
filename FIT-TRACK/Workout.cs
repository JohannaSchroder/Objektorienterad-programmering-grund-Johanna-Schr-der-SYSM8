using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK
{
    public abstract class Workout
    {
        //egenskaper
        public string Date { get; set; }
        public string Type { get; set; }
        public string Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public string Notes { get; set; }

        //konstruktor
        public Workout(string Date, string Type, string Duration, int CaloriesBurned, string Notes)
        { 
            this.Date= Date;
            this.Type= Type;
            this.Duration = Duration;
            this.CaloriesBurned = CaloriesBurned;
            this.Notes = Notes;
        }

        //metoder
        public abstract int CalculateCaloriesBurned();
    }
}
