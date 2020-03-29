using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyRidesChallenge.Models;

namespace MyRidesChallenge.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            list.ItemsSource = new List<Rider>()
            {
                new Rider()
                {
                    Name = "Elias",
                    LastName = "Pujols",
                    Title = "Junior-Junior Developer",
                    TravelHistory = new Travel()
                    {
                        Seats = 1,
                        StreetNamePickUp = "Santa Rosa Dr, La Habana",
                        StreetNameDestination = "Central Park, La Habana",
                        ColorPickUp = Color.FromHex("#725EF3"),
                        ColorDestination = Color.FromHex("#33CCCC"),
                        TotalAmount = 34.12
                    },

                    Photo = FileImageSource.FromResource("MyRidesChallenge.Images.profile-1.png")
                },

                new Rider()
                {
                    Name = "Kara",
                    LastName = "Dewilbow",
                    Title = "Photographer",
                    TravelHistory = new Travel()
                    {
                        Seats = 3,
                        StreetNamePickUp = "Laguna ST, San Francisco",
                        StreetNameDestination = "Polk ST, San Francisco",
                        ColorPickUp = Color.FromHex("#725EF3"),
                        ColorDestination = Color.FromHex("#33CCCC"),
                        TotalAmount = 31.56
                    },

                    Photo = FileImageSource.FromResource("MyRidesChallenge.Images.profile-4.jpg")
                },

                new Rider()
                {
                    Name = "Mike",
                    LastName = "Winslow",
                    Title = "Character Design",
                    TravelHistory = new Travel()
                    {
                        Seats = 2,
                        StreetNamePickUp = "Lombard Street, San Francisco",
                        StreetNameDestination = "Greenwitch, La Habana",
                        ColorPickUp = Color.FromHex("#725EF3"),
                        ColorDestination = Color.FromHex("#33CCCC"),
                        TotalAmount = 23.4
                    },

                    Photo = FileImageSource.FromResource("MyRidesChallenge.Images.profile-2.jpeg")
                }
            };
        }
    }
}
