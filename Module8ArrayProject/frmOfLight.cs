using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module8ArrayProject
{
    public partial class frmOfLight : Form
    {
        // Class Array
        long[] NumberArray;
        const int MAXARRAYSIZE = 13;
        int index = 0;
        long[] totals = new long[13];
        

               
        public frmOfLight()
        {
            InitializeComponent();
        }

       private void Clear_Array(long []NumberArray, long ClearValue)
        {
            for (int lcv = 0; lcv < MAXARRAYSIZE; lcv++)
            {
                NumberArray[lcv] = ClearValue;

            }


        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddArray_Click(object sender, EventArgs e)
        {

            lblMessage.Text = "";
            long lNumber = -1;
            
            bool Add_To_Array = true; 

            if(NumberArray.Length > 0)
            {

                if(NumberArray[NumberArray.Length -1] > 0)

                    //Array if Full
                    // -1 to find when the array is full. Subtracting from the end of the Array.
                {
                    lblMessage.Text = "The Array is full. Please do not try to add more numbers to Array.";
                    Add_To_Array = false; 
                }


            }
             
                         
                   if (txtNumberEntered.Text == "")
                     {
                // Text number not entered
                   lblMessage.Text = "You need to enter a number in the Number Entered textbox.";
                   Add_To_Array = false; 
                    }
                    else
                    {

                    try
                   {
                    // Validation for Number Ranges
                    lNumber = Convert.ToInt64(txtNumberEntered.Text);
                    decimal lnumber = 0m;
                    if (Decimal.TryParse(txtNumberEntered.Text, out lnumber))
                   {
                   ///return true;
                    }
                    else
                     {
                     lblMessage.Text = lblMessage.Text + "Number Entered" + " must be a whole number value." + "\n\n";
                   Add_To_Array = false;
                    }

                    
                    long number = Convert.ToInt64(txtNumberEntered.Text);
                   long min = -1000;
                   long max = 1000;

                if (number < min || number > max)

                  {
                    lblMessage.Text = ("Invalid range " + "Number Entered" + " must be between " + "-1,000" + " and " + "1,000" + ".");
                    txtNumberEntered.Focus();
                     Add_To_Array = false;
                 }
                

                 }


                 catch(Exception ex)
                   {
                     lblMessage.Text =ex.Message;  
                 }
                              

            }

            

               while(Add_To_Array)
                 {
                if (index >= NumberArray.Length)
                {
                    Add_To_Array = false;
                }
                else
                {
                    if (NumberArray[index] <= 0)
                    {
                        (NumberArray[index]) = lNumber;
                        Add_To_Array = false;

                    }

                }

                index++;

              }

        }


        private void frmOfLight_Load(object sender, EventArgs e)
        {
            //Creates an instance of the Array.
            NumberArray = new long[MAXARRAYSIZE];

            Clear_Array(NumberArray, -1);
        }

        private void btnShowArray_Click(object sender, EventArgs e)
        {


            bool Add_To_Array = false;
            int index = 0;
            long TotalofNumbers = 0;
            long NumberCount = 0;


            decimal Average = 0.0m;

            string NumberArrayContents = "";

            txtNumberEntered.Text = "";
            if (NumberArray.Length > 0)
            {
                if (NumberArray[0] > 0)
                {
                    Add_To_Array = true;
                }
                else
                {
                    NumberArrayContents = "The Array is empty.";

                }
            }

            while (Add_To_Array)
            {
                totals[index] += NumberArray[index];
                NumberArrayContents += (NumberArray[index].ToString() + "\n");
                
                TotalofNumbers += NumberArray[index];
               

                NumberCount++;
                index += 1;

                if (index >= NumberArray.Length)
                {
                    Add_To_Array = false;

                }

                else
                {

                    if (NumberArray[index] <= 0)
                    {



                        Add_To_Array = false;

                    }



                }

            }

             
                   
               
          //    Array.Sort(array);
            string totalString ="";
            decimal highvalue =0;
            decimal lowvalue = 999;
            Array.Sort(totals);
            foreach (decimal total in totals)
            {
               

                if (total > 0)
                {
                    highvalue = 0;
                    if (total > highvalue)
                    {
                        highvalue = total;
                    }

                                       
                }
                
            }

         //   Array.Sort(totals);
               foreach (decimal total in totals)
            
                {
                    if (total > 0)
                {
                    
                    if (total < lowvalue)
                    {
                        lowvalue = total;
                    }
                    
                }
                
            }

              
                  
          lblArrayDisplay.Text =  NumberArrayContents;
            
            lblArrayDisplay.Update();

            Average = (decimal)TotalofNumbers / (decimal)NumberCount;
            Average = Math.Round(Average, 3);
            
            lblMessage.Text = "The average of the number in the array is > " + Average.ToString() + "\n"
             + "The total of numbers in the array " + NumberCount + "\n"
             + "The lowest value in the array " + lowvalue + "\n" 
            + "The highest value in the array " + highvalue; 



        }

       
        private void btnResetArray_Click(object sender, EventArgs e)
        {
            Clear_Array(NumberArray, -1);
            Clear_Array(totals, 0);
            index = 0;
             
            lblArrayDisplay.Text = "";
            lblMessage.Text = "The Array has been cleared.";

        }
    }
}
