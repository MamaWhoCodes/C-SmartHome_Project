//Author: Sharon Mutugi
//Date  July 8th  2021

/* This Windows app, demonstrates the  use of Windows Forms
    by simulating smart home lighting controls. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHome
{
    public partial class Form1 : Form
    {

        private int ImageNumber { get; set; }  //keeps track of toggle images to display. 
        private int PicNumber { get; set; }  //light bulb on/off images to display


        public Form1()
        {
            InitializeComponent();
        }

        /*
         * When the toggle image is clicked, the light and toggle images change  to the opposite image,
         * simulating the light has been turned on or turned off.
         */
        private void PorchToggleButton_Click(object sender, EventArgs e)
        {

            ImageNumber = (ImageNumber + 1) % 2;  // cycles from 0 to 1. 
            PicNumber = (PicNumber + 1) % 2;  // cycles from 0 to 1. 

            { 
            PorchToggleButton.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));

            Porch.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"picNumber{PicNumber}"));
            }
        }

        private void FrontYdToggle_Click(object sender, EventArgs e)
            {
            ImageNumber = (ImageNumber + 1) % 2;  // cycles from 0 to 1. 
            PicNumber = (PicNumber + 1) % 2;  // cycles from 0 to 1. 

            FrontYdToggle.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));

            FrontYard.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"picNumber{PicNumber}"));
         }

        private void BackYdToggle_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 2;  // cycles from 0 to 1. 
            PicNumber = (PicNumber + 1) % 2;  // cycles from 0 to 1. 

            BackYdToggle.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));

            BackYard.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"picNumber{PicNumber}"));
        }

        private void BedroomToggle_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 2;  // cycles from 0 to 1. 
            PicNumber = (PicNumber + 1) % 2;  // cycles from 0 to 1. 

            BedroomToggle.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));

            Bedroom.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"picNumber{PicNumber}"));
        }

        private void KitchenToggle_Click(object sender, EventArgs e)
        {
            ImageNumber = (ImageNumber + 1) % 2;  // cycles from 0 to 1. 
            PicNumber = (PicNumber + 1) % 2;  // cycles from 0 to 1. 

            KitchenToggle.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"image{ImageNumber}"));

            Kitchen.Image = (Image)(Properties.Resources.ResourceManager.GetObject(
                $"picNumber{PicNumber}"));
        }


        /*
         * There is a  “Scenes” section on the form which utilizes the  play button to display the following scenes:
        All On (Turns on all lights)
        All Off (Turns off all lights)
        Outside On (Turns on all outside lights)
        Outside Off (Turns off all outside lights)
        Inside On (Turns on all inside lights)
        Inside Off (Turns off all inside lights)
         */


        private void AllOnButton_Click(object sender, EventArgs e)
        {
            Porch.Image = LightOnPicture.Image;
            PorchToggleButton.Image = ToggleOn.Image;

            FrontYard.Image = LightOnPicture.Image;
            FrontYdToggle.Image = ToggleOn.Image;

            BackYard.Image = LightOnPicture.Image;
            BackYdToggle.Image = ToggleOn.Image;

            Bedroom.Image = LightOnPicture.Image;
            BedroomToggle.Image = ToggleOn.Image;

            Kitchen.Image = LightOnPicture.Image;
            KitchenToggle.Image = ToggleOn.Image;

        }

        private void AllOffButton_Click(object sender, EventArgs e)
        {
            Porch.Image = LightOffPicture.Image;
            PorchToggleButton.Image = ToggleOff.Image;

            FrontYard.Image = LightOffPicture.Image;
            FrontYdToggle.Image = ToggleOff.Image;

            BackYard.Image = LightOffPicture.Image;
            BackYdToggle.Image = ToggleOff.Image;

            Bedroom.Image = LightOffPicture.Image;
            BedroomToggle.Image = ToggleOff.Image;

            Kitchen.Image = LightOffPicture.Image;
            KitchenToggle.Image = ToggleOff.Image;

        }

        private void OutsideOnButton_Click(object sender, EventArgs e)
        {
            Porch.Image = LightOnPicture.Image;
            PorchToggleButton.Image = ToggleOn.Image;

            FrontYard.Image = LightOnPicture.Image;
            FrontYdToggle.Image = ToggleOn.Image;

            BackYard.Image = LightOnPicture.Image;
            BackYdToggle.Image = ToggleOn.Image;

        }

        private void OutsideOffButton_Click(object sender, EventArgs e)
        {
            Porch.Image = LightOffPicture.Image;
            PorchToggleButton.Image = ToggleOff.Image;

            FrontYard.Image = LightOffPicture.Image;
            FrontYdToggle.Image = ToggleOff.Image;

            BackYard.Image = LightOffPicture.Image;
            BackYdToggle.Image = ToggleOff.Image;

        }

        private void InsideOnButton_Click(object sender, EventArgs e)
        {
            Bedroom.Image = LightOnPicture.Image;
            BedroomToggle.Image = ToggleOn.Image;

            Kitchen.Image = LightOnPicture.Image;
            KitchenToggle.Image = ToggleOn.Image;
        }

        private void InsideOffButton_Click(object sender, EventArgs e)
        {
            Bedroom.Image = LightOffPicture.Image;
            BedroomToggle.Image = ToggleOff.Image;

            Kitchen.Image = LightOffPicture.Image;
            KitchenToggle.Image = ToggleOff.Image;

        }
    }  // ends   public partial class Form1 : Form
}
