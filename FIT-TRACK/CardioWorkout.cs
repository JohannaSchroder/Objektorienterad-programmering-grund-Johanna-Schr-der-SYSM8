using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK
{
    class CardioWorkout : Workout
    {
        public double Distance { get; set; }

        public CardioWorkout(string Date, string Type, string Duration, int CaloriesBurned, string Notes, double Distance) 
            : base(Date, Type, Duration, CaloriesBurned, Notes)
        { 
            this.Distance = Distance;
        }

        public override int CalculateCaloriesBurned()
        {
            
        }
    }
}
