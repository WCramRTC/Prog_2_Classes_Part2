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

        public MainWindow()
        {
            InitializeComponent();

            // How To Declare and Initialize a Class
            Bass rogue = new Bass("Yamaha", "LX200B", "5", "Orange");
            Bass fender = new Bass("Fender", "Player Jazz Bass Pau Ferro Fingerboard", "4", "Polar White");

            rogue.Price = 170;
            rogue.Count = 5;
            fender.Count = 2;
            fender.Price = 800;


            decimal roguePrice = rogue.Price * rogue.Count;



            //rogue._brand = "Rogue";
            //rogue._name = "LX200b";
            //rogue._numberOfStrings = "5";
            //rogue._color = "Orange";

            rogue.Brand = "Rogue";

            FormatBass(rogue);
            FormatBass(fender);

 

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



    } // class

} // namespace
