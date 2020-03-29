using System;
using Xamarin.Forms;

namespace MyRidesChallenge.Models
{
    public class Travel
    {
        public string StreetNamePickUp { get; set; }

        public string StreetNameDestination { get; set; }

        public Color ColorPickUp { get; set; }

        public Color ColorDestination { get; set; }

        public DateTime Date { get; set; }

        public int Seats { get; set; }

        public double TotalAmount { get; set; }

        public string GetAmountDolarFormat
        {
            get => $"$ { TotalAmount }";
        }

        public string GetSeatsFormat
        {
            get
            {
                var format = (Seats > 1) ? $"{Seats} Seats" : $"{Seats} Seat";
                return format;
            }
        }
    }
}
