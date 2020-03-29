using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyRidesChallenge.Models
{
    public class Rider
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public ImageSource Photo { get; set; }

        public Travel TravelHistory { get; set; }

        public string GetFullName
        {
            get => $"{Name} {LastName}";
        }
    }
}
