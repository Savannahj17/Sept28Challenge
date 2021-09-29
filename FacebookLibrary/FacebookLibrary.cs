using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLibrary
{
    public class FacebookLibrary
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteMovies { get; set; }
        public int AgeInYears { get; set; }
        public string FavoriteMusic { get; set; }


        public enum FavoriteMovies(string Action, string Comedy, string Romance, string Documentary, string Horror)
        {
            Action = action;
            Comedy = comedy;
            Romance = romance;
            Documentary = documentary;
            Horror = horror;

        }

        public string FullName
        {
            get { return $"{FirstName} {LastName};"}
        }

        public DateTime DateOfBirth { get; set; }
        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - dateOfBirth;
                double totalAgeInyears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor())
                }
        }

    }
}
