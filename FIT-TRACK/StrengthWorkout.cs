using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_TRACK
{
    class StrengthWorkout : Workout
    {
        public int Repitation { get; set; }

        public StrengthWorkout(string Date, string Type, string Duration, int CaloriesBurned, string Notes, int Repitation) :
            base(Date, Type, Duration, CaloriesBurned, Notes)
        { 
            this.Repitation = Repitation;
        }

        public override int CalculateCaloriesBurned()//FYLL I KOD HÄR!!
        {
            return 0;
        }
    }
}
