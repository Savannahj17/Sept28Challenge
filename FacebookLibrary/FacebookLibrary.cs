using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLibrary
{
    public enum FavoriteMovieGenre { Action, Comedy, Romance, Documentary, Horror }

    public class FacebookLibrary
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FavoriteMovieGenre Genre { get; set; }
        public int AgeInYears { get; set; }
        public string FavoriteMusic { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName};"}
        }

        public DateTime DateOfBirth { get; set; }
        public int AgeInYears
        {
            get
            {
                DateOfBirth = dateOfBirth;
                TimeSpan ageSpan = DateTime.Now - dateOfBirth;
                double totalAgeInyears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor())
            }
        }

        public FacebookLibrary()
        {

        }

        public FacebookLibrary(string firstName, lastName, FavoriteMovieGenre, favoriteMusic)
        {
            //set equal to props (parameters)
            FirstName = firstName;
            LastName = lastName;
            FavoriteMusic = favoriteMusic;



        }

    }

}
