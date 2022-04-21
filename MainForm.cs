using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*David Cox, Jason Xiao 
3-29-2022
Project 2 
Business 442 (001)
This app is meant to be a statistical caluclator for a txt file and a scientific calculator for user inputted numbers.
UI of app was built by David and polished by Jason. For each event the main devloper is listed. The opposing teamate
reviewed, polished, and helped with errors.
*/

namespace Project2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int[] fileNumbers = new int[30];

        //Declare a global array.
        //Variables for X and Y box. Using double if the user wants to input decimals as well.
        double xValue = 0;
        double yValue = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Declare global variables for array to be loaded in once, and stored in ram
            //Main code by Jason
            //Created a variable to hold the lines that streamreader is reading
            string currentLine;
            //Create an array that holds each line
            string[] fields = new string[5];
            StreamReader NumReader = new StreamReader("Numbers.txt");
            int count = 0;
            //Loop that continues read each until the end of the file
            while (NumReader.EndOfStream == false)
            {
                currentLine = NumReader.ReadLine();
                //Split the data by commas 
                fields = currentLine.Split(',');
                fileNumbers[count * 5] = Convert.ToInt32(fields[0]);
                fileNumbers[count * 5 + 1] = Convert.ToInt32(fields[1]);
                fileNumbers[count * 5 + 2] = Convert.ToInt32(fields[2]);
                fileNumbers[count * 5 + 3] = Convert.ToInt32(fields[3]);
                fileNumbers[count * 5 + 4] = Convert.ToInt32(fields[4]);
                count++;

            }
            //Close the file
            NumReader.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
            {
                //Main code by David
                // Exit confirmation for button
                DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //If yes, close
                if (dialog == DialogResult.Yes)
                    this.Close();
            }

            private void clearListBoxButton_Click(object sender, EventArgs e)
            {
              //Main code by David
              //Clears the listbox
                displayListBox.Items.Clear();

            }

            private void displayFileButton_Click(object sender, EventArgs e)
            {
            //Display built by Jason
            //Clears list box so it is empty 
            displayListBox.Items.Clear();
            //Rebuilds the array to be formatted and displayed in the listbox
            for (int row = 0; row < 6; row++)
                displayListBox.Items.Add(
                    fileNumbers[row * 5 + 0].ToString() +
                    ", " + fileNumbers[row * 5 + 1].ToString() +
                    ", " + fileNumbers[row * 5 + 2].ToString() +
                    ", " + fileNumbers[row * 5 + 3].ToString() +
                    ", " + fileNumbers[row * 5 + 4].ToString()
                    );
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Clears the listbox. Counts the numbers in the file and displays it.
            displayListBox.Items.Clear();
            var numberCount = fileNumbers.Count();
            displayListBox.Items.Add(string.Format("{0}{1}", "Count: ", numberCount));
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            //Warnings built by David. Factorial display built by Jason
            //Gets the values the user typed in the X and Y textbox.
            double.TryParse(xTextBox.Text, out double xValue);
            double.TryParse(yTextBox.Text, out double yValue);
            yTextBox.Text = null;

            //Checks to make sure there is an x value in the textbox. If not, displays error message.
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (xValue > 10)
            {
                MessageBox.Show("Please make sure x is 10 or less.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (xValue < 0)
            {
                MessageBox.Show("Please make sure x is 0 or greater.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }

            //Clears the listbox. 

            displayListBox.Items.Clear();
            double i, fact;
            //Calculations for factorial. Multiply the number times itself - 1 until 1. Displays it.
            fact = xValue;
            for (i = xValue - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            displayListBox.Items.Add(string.Format("{0}{1} {2}", xValue, "!: ", fact));

        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Checks to make sure there is an x value in the textbox. If not, displays error message.
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            //Checks to make sure there is an y value in the textbox. If not, displays error message.
            if (yTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a y value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
            //Clear the listbox. Gets the value from the x and y textbox
                displayListBox.Items.Clear();
                double.TryParse(xTextBox.Text, out double xValue);
                double.TryParse(yTextBox.Text, out double yValue);
                double xRaised, answer;
                //Calculations. Raises the x value to the y value using the Pow function. Displays it.
                xRaised = xValue;
                answer = (long)(Math.Pow(xRaised, yValue));
                displayListBox.Items.Add(string.Format("{0}{1} {2}{3}{4}", xValue, " raised to the power of", yValue, ": ", answer));
            
        }

        private void reciprocalButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Checks to make sure there is an x value in the textbox. If not, displays error message.
            yTextBox.Text = null;
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            //Gets the x value from the textbox. 
            displayListBox.Items.Clear();
            double.TryParse(xTextBox.Text, out double xValue);
            //Calculations. 1/X is the reciprocal of a number.
            double reciprocal;         
            reciprocal = 1 / xValue;
            displayListBox.Items.Add(string.Format("{0}{1}{2}{3}", "Reciprocal of ", xValue, ": ", reciprocal));
        }

        private void primeButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
            int.TryParse(xTextBox.Text, out int xValue);
            int.TryParse(yTextBox.Text, out int yValue);
            //Main code by Jason
            //Checks to make sure there is an x and y value in the textbox. If not, displays error message.
            //Limits the x and y range so the program does not lag out.
            if (xValue < -20000)
            {
                MessageBox.Show("Please make sure x is -20,000 or larger.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (xValue > 20000)
            {
                MessageBox.Show("Please make sure x is 20,000 or less.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (yValue > 20000)
            {
                MessageBox.Show("Please make sure y is 20,000 or less.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
            if (yValue < -20000)
            {
                MessageBox.Show("Please make sure y is -20,000 or larger.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }

            if (yTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a y value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
           
            //Makes sure the X value is greater than the Y value
            if (xValue > yValue)
            {
                MessageBox.Show("The x value should be less than the y value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;                
            }
            //Keep iterating X value until it is greater than Y value
            for (int i = xValue; i <= yValue; i++)
            {
                //Creates a special case for 1, since it is NOT prime
                if (i == 1)
                {
                    displayListBox.Items.Add(string.Format("{0}{1}", i.ToString(), " is not a prime number"));
                    continue;
                }
                //Assume a number passes every case until it is contradicted
                bool is_prime = true;

                //Checks if the numbers are divisible by any number less than it besides 1
                for (int j = 2; j < i; j++)
                {
                    //If it is divisible by another number, then that number is not prime and it will display that result in the list box
                    // with the formatted message
                    if (i % j == 0)
                    {
                        displayListBox.Items.Add(string.Format("{0}{1}", i.ToString(), " is not a prime number"));
                        is_prime = false;
                        break;
                    }
                }
                //If the number passes all of the cases, then it is prime, the number will be displayed with the following format
                if (is_prime)
                    displayListBox.Items.Add(string.Format("{0}{1}", i.ToString(), " is a prime number"));
            }
        }

        private void sumSquaresButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            long.TryParse(xTextBox.Text, out long xValue);
            long.TryParse(yTextBox.Text, out long yValue);
            //Limit x and y so the program runs smoothly.
            if (xValue < -1000000)
            {
                MessageBox.Show("Please make sure x is -1,000,000 or larger.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (xValue > 1000000)
            {
                MessageBox.Show("Please make sure x is 1,000,000 or smaller.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (yValue < -1000000)
            {
                MessageBox.Show("Please make sure y is -1,000,000 or larger.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
            if (yValue > 1000000)
            {
                MessageBox.Show("Please make sure y is 1,000,000 or smaller.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }

            //Checks to make sure there is an x and y value in the textbox. If not, displays error message.
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (yTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a y value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                yTextBox.Focus();
                return;
            }
            if (xValue == 0 && yValue == 0)
            {
                MessageBox.Show("Both x and y cannot be 0.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            if (xValue > yValue)
            {
                MessageBox.Show("X must be less than y.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }

            displayListBox.Items.Clear();

            //Calculations. Displays answer. Declare variables for calculations
            long xSquared, ySquared, sum, sumSquared;
            //Square each value. Then add squares together.
            xSquared = xValue * xValue;
            ySquared = yValue * yValue;
            sum = xValue + yValue;
            sumSquared = xSquared + ySquared;
            //Display values with format
            displayListBox.Items.Add(string.Format("{0}{1}{2}{3}", "The number is: ", xValue, " and its square is : ", xSquared));
            displayListBox.Items.Add(string.Format("{0}{1}{2}{3}", "The number is: ", yValue, " and its square is : ", ySquared));
            displayListBox.Items.Add(string.Format("{0}{1}{2}{3}", "Sum of numbers: ", sum, " Sum of squares: ", sumSquared));
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            ////Main code by Jason
            //Checks to make sure there is an x value in the textbox. If not, displays error message.
            if (xTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter an x value.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            //If the input in X is greater than 30, show the error message
            int.TryParse(xTextBox.Text, out int xValue);
            if (xValue > 30)
            {
                MessageBox.Show("Please make sure x is 30 or less.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            //If the input in X is less than 0, show the error message
            else if (xValue < 0)
            {
                MessageBox.Show("Please make sure x is 0 or greater.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                xTextBox.Focus();
                return;
            }
            
            displayListBox.Items.Clear();
            yTextBox.Text = null;

            int number, n1 = 0, n2 = 1, nexterm;

            number = xValue;

            //Makes a new variable to convert the variables to strings, so they can be displayed
            string fibOut = "";
            for (int counter = 1; counter <= number; counter++)
            {
                //Adds value to a string and repeats
                fibOut += n1.ToString() + " ";
                nexterm = n1 + n2;
                n1 = n2;
                n2 = nexterm;
            }
            //Displays the answers for each sequence with the following format
            displayListBox.Items.Add(string.Format("{0}{1}{2}{3}", "Fibonacci sequence for ", xValue, ": ", fibOut));
        }


        //For all of the zero through nine button clicks, it adds the respective number to the x textbox unless the y checkbox is checked. 
        //If the y checkbox is checked, it adds the respective number to the y textbox.

        //Zero through nine buttons built by David

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "1";
            }
            else
            { 
                yTextBox.Text += "1";
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "2";
            }
            else
            {
                yTextBox.Text += "2";
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {           
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "3";
            }
            else
            {
                yTextBox.Text += "3";
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {          
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "4";
            }
            else
            {
                yTextBox.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {           
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "5";
            }
            else
            {
                yTextBox.Text += "5";
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {           
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "6";
            }
            else
            {
                yTextBox.Text += "6";
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "7";
            }
            else
            {
                yTextBox.Text += "7";
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "8";
            }
            else
            {
                yTextBox.Text += "8";
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "9";
            }
            else
            {
                yTextBox.Text += "9";
            }
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text += "0";
            }
            else
            {
                yTextBox.Text += "0";
            }
        }

        
        private void cButton_Click(object sender, EventArgs e)
        {
            //Built by Jason
            //Clears the x textbox unless the y checkbox is checked. If it is, it clears the y textbox.
            if (yCheckBox.Checked == false)
            {
                xTextBox.Text = null;
            }
            else
            {
                yTextBox.Text = null;    
            }
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            //Built by David
            //This subtracts 1 from the string length in the x textbox and displays it.
            if (yCheckBox.Checked == false)
            {
                if (xTextBox.Text != string.Empty)
                {
                    string entryMinusOne = xTextBox.Text.Substring(0, xTextBox.Text.Length - 1);
                    xTextBox.Text = entryMinusOne;
                }                              
            }
            //This subtracts 1 from the string length in the y textbox and displays it.
            else
            {
                if (yTextBox.Text != string.Empty)
                {
                    string entryMinusOne = yTextBox.Text.Substring(0, yTextBox.Text.Length - 1);
                    yTextBox.Text = entryMinusOne;
                }
            }
        }

        private void meanButton_Click(object sender, EventArgs e)
        {
            //Main code by Jason
            displayListBox.Items.Clear();
            //Gets count to use in average
            var numberCount = fileNumbers.Count(); 
            float numberTotal = 0, average;
            //Mean calculations. Numbers added together / number count. Displays the answer.
            foreach (int fileNumbers in fileNumbers)
            {
                numberTotal += fileNumbers;                
            }
            //Average is total of the numbers divided by the count of the values
            average = numberTotal / numberCount;
            displayListBox.Items.Add(string.Format("{0}{1}", "Mean: ", average.ToString("N2")));
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Gets the max and min value.
            displayListBox.Items.Clear();
            var max = fileNumbers.Max();
            var min = fileNumbers.Min();
            //Finds the range by subtracting the min from the max. Displays the answer.
            int range = max - min;
            displayListBox.Items.Add(string.Format("{0}{1}", "Range: ", range));
        }

        private void stdButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            displayListBox.Items.Clear();
            double std = 0;
            //Calculations. Gets the average and sum. Squareroots the sum calculation / the count - 1 of the file. 
            if (fileNumbers.Any())
            {
            double avg = fileNumbers.Average();

            double sum = fileNumbers.Sum(d => Math.Pow(d - avg, 2));

            std = Math.Sqrt((sum) / (fileNumbers.Count() - 1));

            }
            //Display the standard deviation
            displayListBox.Items.Add(string.Format("{0}{1}", "Standard Deviation: ", std.ToString("N3")));


        }

        private void medianButton_Click(object sender, EventArgs e)
        {
            //Main code by Jason
            //This line is repeated throughout. Clears the listbox.
            displayListBox.Items.Clear();
            //Sorts the fileNumbers array by ascending order
            Array.Sort(fileNumbers);
            //Declare variables for median calculations
            double median;
            //Count all numbers in fileNumbers array
            int n = fileNumbers.Count();
            //If the variable n is even, then add the middle two numbers together, and divide by 2
            //First number is -1 because the array is zero based
            if (n % 2 == 0)
                median = (fileNumbers[n / 2 - 1] + fileNumbers[n / 2]) / 2.0;
            //If number is median, then take that number -1, because array is 0 based, and that is the median
            else
                median = fileNumbers[n / 2 - 1];
            //Display the output in the displayListBox with the following format
            displayListBox.Items.Add(string.Format("{0}{1}", "Median: ", median));
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            //Main code by Jason
            //Gets the max value of the file and displays it.
            displayListBox.Items.Clear();
            var max = fileNumbers.Max();
            displayListBox.Items.Add(string.Format("{0}{1}", "Max: ", max));
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            //Main code by Jason
            //Gets the min value of the file and displays it.
            displayListBox.Items.Clear();
            var min = fileNumbers.Min();
            displayListBox.Items.Add(string.Format("{0}{1}", "Min: ", min));
        }

        private void modeButton_Click(object sender, EventArgs e)
        {
            //Main code by Jason
            displayListBox.Items.Clear();
            //Dictionary tracks how many of each number is in the fileNumbers Array
            IDictionary<int, int> numbersDict = new Dictionary<int, int>();

            //Loop through fileNumbers array, adds number to Dictionary as the key if it doesn't exst. Otherwise increment value by 1
            for (int i = 0; i < 30; i++)
            {
                if (!numbersDict.ContainsKey(fileNumbers[i]))
                {
                    numbersDict.Add(fileNumbers[i], 1);
                }
                else
                {
                    numbersDict[fileNumbers[i]]++;
                }
            }
            //Declare values to find mode
            int maxCount = 0;
            int mode = fileNumbers[0];

            //Loops through items in the Dictionary and tracking the number with the highest value
            foreach (var item in numbersDict)
            {
                if (item.Value > maxCount)
                {
                    mode = item.Key;
                    maxCount = item.Value;
                }
            }
            //Formats the output to be displayed
            displayListBox.Items.Add(string.Format("{0}{1}", "Mode: ", mode));

        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Gets the sum of fileNumbers and displays it
            displayListBox.Items.Clear();
            int sum = fileNumbers.Sum();
            displayListBox.Items.Add(string.Format("{0}{1}", "Sum: ", sum));
        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            //Main code by David
            //Sets the max lenght of the x textbox and clears the listbox.
            xTextBox.MaxLength = 10;          
            displayListBox.Items.Clear();
        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            //Main code by David
            //Sets the max length of the y textbox and clears the listbox.
            yTextBox.MaxLength = 10;
            displayListBox.Items.Clear();
        }
        //For x and y textbox clicks, selects all and focuses. 
        private void xTextBox_Click(object sender, EventArgs e)
        {
            //Main code by David
            //Select all the text in te textbox. Focus on the textbox
            xTextBox.SelectAll();
            xTextBox.Focus();
        }

        private void yTextBox_Click(object sender, EventArgs e)
        {
            //Main code by David
            yTextBox.SelectAll();
            yTextBox.Focus();
        }

        private void xTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Main code by Jason
            //Filters what can be typed into the textbox. Only allows numbers, and -.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void yTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Main code by Jason
            //Filters what can be typed into the textbox. Only allows numbers, and -.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void xTextBox_Enter(object sender, EventArgs e)
        {
            //Main code by Jason
            xTextBox.SelectAll();
            xTextBox.Focus();
        }

        private void yTextBox_Enter(object sender, EventArgs e)
        {
            //Main code by Jason
            yTextBox.SelectAll();
            yTextBox.Focus();
        }
        //All of the MouseHover and MouseLeave events change the color of their respective button when hovered.
        //It changes the color back when the mouse leaves
        //All MouseHover and MouseLeave events built by Jason
        private void countButton_MouseHover(object sender, EventArgs e)
        {
            countButton.BackColor = Color.WhiteSmoke;

        }

        private void meanButton_MouseHover(object sender, EventArgs e)
        {
            meanButton.BackColor = Color.WhiteSmoke;

        }

        private void rangeButton_MouseHover(object sender, EventArgs e)
        {
            rangeButton.BackColor = Color.WhiteSmoke;

        }

        private void stdButton_MouseHover(object sender, EventArgs e)
        {
            stdButton.BackColor = Color.WhiteSmoke;

        }

        private void medianButton_MouseHover(object sender, EventArgs e)
        {
            medianButton.BackColor = Color.WhiteSmoke;

        }

        private void maxButton_MouseHover(object sender, EventArgs e)
        {
            maxButton.BackColor = Color.WhiteSmoke;

        }

        private void minButton_MouseHover(object sender, EventArgs e)
        {
            minButton.BackColor = Color.WhiteSmoke;

        }

        private void modeButton_MouseHover(object sender, EventArgs e)
        {
            modeButton.BackColor = Color.WhiteSmoke;

        }

        private void sumButton_MouseHover(object sender, EventArgs e)
        {
            sumButton.BackColor = Color.WhiteSmoke;

        }

        private void factorialButton_MouseHover(object sender, EventArgs e)
        {
            factorialButton.BackColor = Color.WhiteSmoke;

        }

        private void powerButton_MouseHover(object sender, EventArgs e)
        {
            powerButton.BackColor = Color.WhiteSmoke;

        }

        private void reciprocalButton_MouseHover(object sender, EventArgs e)
        {
            reciprocalButton.BackColor = Color.WhiteSmoke;

        }

        private void primeButton_MouseHover(object sender, EventArgs e)
        {
            primeButton.BackColor = Color.WhiteSmoke;

        }

        private void sumSquaresButton_MouseHover(object sender, EventArgs e)
        {
            sumSquaresButton.BackColor = Color.WhiteSmoke;

        }

        private void fibonacciButton_MouseHover(object sender, EventArgs e)
        {
            fibonacciButton.BackColor = Color.WhiteSmoke;

        }

        private void displayFileButton_MouseHover(object sender, EventArgs e)
        {
            displayFileButton.BackColor = Color.WhiteSmoke;

        }

        private void clearListBoxButton_MouseHover(object sender, EventArgs e)
        {
            clearListBoxButton.BackColor = Color.WhiteSmoke;

        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.WhiteSmoke;

        }

        private void countButton_MouseLeave(object sender, EventArgs e)
        {
            countButton.BackColor = Color.Gainsboro;

        }

        private void meanButton_MouseLeave(object sender, EventArgs e)
        {
            meanButton.BackColor = Color.Gainsboro;

        }

        private void rangeButton_MouseLeave(object sender, EventArgs e)
        {
            rangeButton.BackColor = Color.Gainsboro;

        }

        private void stdButton_MouseLeave(object sender, EventArgs e)
        {
            stdButton.BackColor = Color.Gainsboro;

        }

        private void medianButton_MouseLeave(object sender, EventArgs e)
        {
            medianButton.BackColor = Color.Gainsboro;
        }

        private void maxButton_MouseLeave(object sender, EventArgs e)
        {
            maxButton.BackColor = Color.Gainsboro;

        }

        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            minButton.BackColor = Color.Gainsboro;

        }

        private void modeButton_MouseLeave(object sender, EventArgs e)
        {
            modeButton.BackColor = Color.Gainsboro;

        }

        private void sumButton_MouseLeave(object sender, EventArgs e)
        {
            sumButton.BackColor = Color.Gainsboro;

        }

        private void factorialButton_MouseLeave(object sender, EventArgs e)
        {
            factorialButton.BackColor = Color.Gainsboro;

        }

        private void powerButton_MouseLeave(object sender, EventArgs e)
        {
            powerButton.BackColor = Color.Gainsboro;

        }

        private void reciprocalButton_MouseLeave(object sender, EventArgs e)
        {
            reciprocalButton.BackColor = Color.Gainsboro;

        }

        private void primeButton_MouseLeave(object sender, EventArgs e)
        {
            primeButton.BackColor = Color.Gainsboro;

        }

        private void sumSquaresButton_MouseLeave(object sender, EventArgs e)
        {
            sumSquaresButton.BackColor = Color.Gainsboro;

        }

        private void fibonacciButton_MouseLeave(object sender, EventArgs e)
        {
            fibonacciButton.BackColor = Color.Gainsboro;

        }

        private void displayFileButton_MouseLeave(object sender, EventArgs e)
        {
            displayFileButton.BackColor = Color.Gainsboro;

        }

        private void clearListBoxButton_MouseLeave(object sender, EventArgs e)
        {
            clearListBoxButton.BackColor = Color.Gainsboro;

        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.Gainsboro;

        }

        private void sevenButton_MouseHover(object sender, EventArgs e)
        {
            sevenButton.BackColor = Color.DimGray;
        }

        private void eightButton_MouseHover(object sender, EventArgs e)
        {
            eightButton.BackColor = Color.DimGray;
        }

        private void nineButton_MouseHover(object sender, EventArgs e)
        {
            nineButton.BackColor = Color.DimGray;
        }

        private void fourButton_MouseHover(object sender, EventArgs e)
        {
            fourButton.BackColor = Color.DimGray;
        }

        private void fiveButton_MouseHover(object sender, EventArgs e)
        {
            fiveButton.BackColor = Color.DimGray;
        }

        private void sixButton_MouseHover(object sender, EventArgs e)
        {
            sixButton.BackColor = Color.DimGray;
        }

        private void oneButton_MouseHover(object sender, EventArgs e)
        {
            oneButton.BackColor = Color.DimGray;
        }

        private void twoButton_MouseHover(object sender, EventArgs e)
        {
            twoButton.BackColor = Color.DimGray;
        }

        private void threeButton_MouseHover(object sender, EventArgs e)
        {
            threeButton.BackColor = Color.DimGray;
        }

        private void zeroButton_MouseHover(object sender, EventArgs e)
        {
            zeroButton.BackColor = Color.DimGray;
        }

        private void cButton_MouseHover(object sender, EventArgs e)
        {
            cButton.BackColor = Color.Firebrick;
        }

        private void ceButton_MouseHover(object sender, EventArgs e)
        {
            ceButton.BackColor = Color.Firebrick;
        }

        private void sevenButton_MouseLeave(object sender, EventArgs e)
        {
            sevenButton.BackColor = Color.Black;
        }

        private void eightButton_MouseLeave(object sender, EventArgs e)
        {
            eightButton.BackColor = Color.Black;
        }

        private void nineButton_MouseLeave(object sender, EventArgs e)
        {
            nineButton.BackColor = Color.Black;
        }

        private void fourButton_MouseLeave(object sender, EventArgs e)
        {
            fourButton.BackColor = Color.Black;
        }

        private void fiveButton_MouseLeave(object sender, EventArgs e)
        {
            fiveButton.BackColor = Color.Black;
        }

        private void sixButton_MouseLeave(object sender, EventArgs e)
        {
            sixButton.BackColor = Color.Black;
        }

        private void oneButton_MouseLeave(object sender, EventArgs e)
        {
            oneButton.BackColor = Color.Black;
        }

        private void twoButton_MouseLeave(object sender, EventArgs e)
        {
            twoButton.BackColor = Color.Black;
        }

        private void threeButton_MouseLeave(object sender, EventArgs e)
        {
            threeButton.BackColor = Color.Black;
        }

        private void zeroButton_MouseLeave(object sender, EventArgs e)
        {
            zeroButton.BackColor = Color.Black;
        }

        private void cButton_MouseLeave(object sender, EventArgs e)
        {
            cButton.BackColor = Color.DarkRed;
        }

        private void ceButton_MouseLeave(object sender, EventArgs e)
        {
            ceButton.BackColor = Color.DarkRed;
        }
    }
    }

