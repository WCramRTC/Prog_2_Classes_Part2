using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog_2_Classes_Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Bass bass = new Bass(); // Single Instance of Bass
        //Bass[] basses = new Bass[5]; // And ARRAY of 5 Bass

        List<Show> shows = new List<Show>
        {
            new Show("Breaking Bad", "Pilot", "English", "A high school chemistry teacher turned methamphetamine manufacturer teams up with a former student.", 49, "Season 1", 9.5f),
            new Show("Game of Thrones", "Winter Is Coming", "English", "A sprawling fantasy epic set in the mythical land of Westeros.", 57, "Season 1", 9.3f),
            new Show("Stranger Things", "Chapter One: The Vanishing of Will Byers", "English", "A group of kids in a small town encounter supernatural forces and government conspiracies.", 51, "Season 1", 8.7f),
            new Show("The Crown", "Wolferton Splash", "English", "A historical drama about the reign of Queen Elizabeth II.", 58, "Season 1", 8.7f),
            new Show("The Mandalorian", "Chapter 1: The Mandalorian", "English", "A lone bounty hunter navigates the outer reaches of the Star Wars galaxy.", 39, "Season 1", 8.8f),
            new Show("Black Mirror", "The National Anthem", "English", "An anthology series exploring the dark side of technology and society.", 44, "Season 1", 8.8f),
            new Show("Sherlock", "A Study in Pink", "English", "Modern-day adaptation of Arthur Conan Doyle's classic detective stories.", 88, "Season 1", 9.1f),
            new Show("Friends", "The One Where Monica Gets a Roommate", "English", "A sitcom about a group of six friends living in New York City.", 22, "Season 1", 8.5f),
            new Show("Breaking Bad", "Pilot", "English", "A high school chemistry teacher turned methamphetamine manufacturer teams up with a former student.", 49, "Season 1", 9.5f),
            new Show("The Witcher", "The End's Beginning", "English", "Based on the book series, follows Geralt of Rivia, a monster hunter.", 61, "Season 1", 8.2f),
            new Show("The Office", "Pilot", "English", "A mockumentary-style sitcom about office life at Dunder Mifflin.", 23, "Season 1", 8.9f),
            new Show("The Big Bang Theory", "Pilot", "English", "Follows the lives of two physicists and their friends.", 22, "Season 1", 8.1f),
            new Show("Stranger Things", "Chapter One: The Vanishing of Will Byers", "English", "A group of kids in a small town encounter supernatural forces and government conspiracies.", 51, "Season 1", 8.7f),
            new Show("The Crown", "Wolferton Splash", "English", "A historical drama about the reign of Queen Elizabeth II.", 58, "Season 1", 8.7f),
            new Show("The Mandalorian", "Chapter 1: The Mandalorian", "English", "A lone bounty hunter navigates the outer reaches of the Star Wars galaxy.", 39, "Season 1", 8.8f),
            new Show("Black Mirror", "The National Anthem", "English", "An anthology series exploring the dark side of technology and society.", 44, "Season 1", 8.8f),
            new Show("Sherlock", "A Study in Pink", "English", "Modern-day adaptation of Arthur Conan Doyle's classic detective stories.", 88, "Season 1", 9.1f),
            new Show("Friends", "The One Where Monica Gets a Roommate", "English", "A sitcom about a group of six friends living in New York City.", 22, "Season 1", 8.5f),
            new Show("The Witcher", "The End's Beginning", "English", "Based on the book series, follows Geralt of Rivia, a monster hunter.", 61, "Season 1", 8.2f),
            new Show("The Office", "Pilot", "English", "A mockumentary-style sitcom about office life at Dunder Mifflin.", 23, "Season 1", 8.9f),
            new Show("The Big Bang Theory", "Pilot", "English", "Follows the lives of two physicists and their friends.", 22, "Season 1", 8.1f),
        };

        public MainWindow()
        {
            InitializeComponent();

            //// How To Declare and Initialize a Class
            //Bass rogue = new Bass("Yamaha", "LX200B", "5", "Orange");
            //Bass fender = new Bass("Fender", "Player Jazz Bass Pau Ferro Fingerboard", "4", "Polar White");

            //rogue.Price = 170;
            //rogue.Count = 5;
            //fender.Count = 2;
            //fender.Price = 800;


            //decimal roguePrice = rogue.Price * rogue.Count;



            ////rogue._brand = "Rogue";
            ////rogue._name = "LX200b";
            ////rogue._numberOfStrings = "5";
            ////rogue._color = "Orange";

            //rogue.Brand = "Rogue";

            //FormatBass(rogue);
            //FormatBass(fender);

            foreach (Show show in shows)
            {
                DisplayShow(show);
            }

        } // MainWindow()

        //public decimal CalculateBass(Bass bass)
        //{
        //    return bass.Count * bass.Price;
        //}

        public void FormatBass(Bass bass)
        {
            rtbDisplay.Text += $"Brand: {bass.Brand}\n";
            rtbDisplay.Text += $"Name: {bass.Name}\n";
            rtbDisplay.Text += $"Strings: {bass.NumberOfStrings}\n";
            rtbDisplay.Text += $"Price: {bass.Price}\n";
            rtbDisplay.Text += $"Color: {bass.Color}\n";
            rtbDisplay.Text += $"Count: {bass.Count}\n";
            rtbDisplay.Text += $"Total Cost On Hand: {bass.CalculateCost()}\n";

            rtbDisplay.Text += "\n";
        }

        public void DisplayShow(Show show)
        {
            rtbDisplay.Text += $"Show Name: {show.Name}\n";
            rtbDisplay.Text += $"Show Episode: {show.NameOfEpisode}\n";
            rtbDisplay.Text += $"Show Captions: {show.Captions}\n";
            rtbDisplay.Text += $"Show Description: {show.Descrption}\n";
            rtbDisplay.Text += $"Show Runtime: {show.Runtime}\n";
            rtbDisplay.Text += $"Show Season: {show.Season}\n";
            rtbDisplay.Text += $"Show Raiting: {show.Ratings}\n";
            rtbDisplay.Text += $"\n";
        }

    } // class

} // namespace
