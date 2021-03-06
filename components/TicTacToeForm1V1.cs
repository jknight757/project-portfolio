﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Jeffrey Knight
//Project and portfolio 3 8/16/17
//TicTacToe
namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        int imgIndex=-1; //will hold the image index which is seleted when the player chooses X or O
        int numPlays = 0; //counter which holds th number of squares that have been played
        List<bool> tilesPlayed = new List<bool> { false, false, false, false, false, false, false, false, false };
        

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgIndex = 1;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgIndex = 0;
        }

        private void r1c1button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[0])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[0] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r1c1button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r1c2button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[1])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[1] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r1c2button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r1c3button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[2])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[2] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r1c3button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r2c1button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[3])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[3] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r2c1button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r2c2button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[4])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[4] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r2c2button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r2c3button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[5])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[5] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r2c3button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r3c1button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[6])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[6] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r3c1button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r3c2button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[7])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[7] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r3c2button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        private void r3c3button_Click(object sender, EventArgs e)
        {
            if (imgIndex > -1)                                          //checks to make sure someone selected X or O
            {
                if (!tilesPlayed[8])                                    //checks if this tile has been selected already
                {

                    tilesPlayed[8] = true;                              //sets bool list value to true at button Number index to show button has already been selected
                    r3c3button.ImageIndex = (numPlays + imgIndex) % 2;  //sets image index to X or O based on whose turn and is X or O
                    numPlays++;
                }
                else
                {
                    MessageBox.Show("Tile already selected");           //returns message to tell user that this tile has been selected already
                }
            }
            else
            {
                MessageBox.Show("Select X or O");                       //returns message to tell user that they havent selected X or O
            }
        }

        
    }
}
