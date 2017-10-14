using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Manpreet Rajpal 
//September 29, 2017
//This displays the Pascal's triangle on a 10 by 10 grid

namespace PascalsTriangle
{
    public partial class Form1 : Form
    {
        int[,] PascalsTriangle; // place holder for the 2D array
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            PascalsTriangle = new int[10, 9]; //10 rows, 10 columns
            string Output = string.Empty; //""

            for (int i = 0; i < PascalsTriangle.GetLength(0); i++) //rows
            {
                for (int j = 0; j < PascalsTriangle.GetLength(1); j++) //columns
                {
                    //assigning column 0 and row 0 to 1
                    if (PascalsTriangle[0, j] == 0)
                    {
                        PascalsTriangle[0, j] = 1;
                    }
                    else if (PascalsTriangle[i, 0] == 0)
                    {
                        PascalsTriangle[i, 0] = 1;
                    } 
                    //sets the rest of the numbers by adding the number on left plus number on top
                    else if (i > 0 | j > 0)
                    {
                        PascalsTriangle[i, j] = PascalsTriangle[i - 1, j] + PascalsTriangle[i, j - 1] ;
                    }
                }
            }

            for (int i = 0; i < PascalsTriangle.GetLength(0); i++)
            { //loop through all the rows
                Output += "\n";

                for (int j = 0; j < PascalsTriangle.GetLength(1); j++)
                {
                    Output += PadSpaces(PascalsTriangle[i, j].ToString(), 10);
                }
            }

                lblOutput.Text = Output;
        }
         private string PadSpaces(string Word, int ColumnSize)
        {

            //this method returns a Word (text) padded with 
            //the number of spaces for a column 
            string NewWord = string.Empty;
            int Length = ColumnSize - Word.Length;

            for (int i = 0; i < Length; i++)
            {
                NewWord += " ";
            }
            NewWord = NewWord + Word;

            return NewWord;
        }
        
    }
       
 }

