using FacebookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //set all values in constructor; 
            // Vehicle firstVehicle = new Vehicle(); - create a new instance
            FacebookLibrary fb = new FacebookLibrary();

            fb.FirstName = "Savannah";
            fb.LastName = "Jackson";
            fb.FavoriteMovieGenre= fb.FavoriteMovieGenre.Comedy;
            fb.AgeInYears = 24;
            fb.FavoriteMusic = "R&B";


            //empty because of empty constructor; allows user to set values
        }
    }
}
