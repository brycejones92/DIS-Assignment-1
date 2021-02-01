// Author Bryce Jones
// Assignment one
// Date: 1/31/2021



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace assignment1DIS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1 
            //Console.WriteLine("Q1 : Enter the number of rows for the triangle:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //PrintTriangle(n);
            //Console.WriteLine();

            // Question 2 
            //Console.WriteLine("Q2: Enter the number of terms in the pell series:");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //PrintPellSeries(n2);
            //Console.WriteLine();

            //Question 3
            //Console.WriteLine("Q3: Enter a number to check if squareSums exists:");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //bool flag = SquareSums(n3);
            //if(flag)
            //{
            //Console.WriteLine("Yes, the number can be expressed as the sum of squares of 2 integers");
            //}

            //else
            //{
            //Console.WriteLine("No the number cannot be expressed as the sume of squares of 2 integers");
            //}


            // Question 4
            //int[] arr = { 3, 1, 4, 1, 5 };
            //Console.WriteLine("Q4: Enter the absolute difference to check");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int n4 = DiffPairs(arr, k);
            //Console.WriteLine("There exists {0} pairs with the given difference", n4);


            // Question 5
            //List<string> emails = new List<string>();
            //emails.Add("dis.email+bull@usf.com");
            //emails.Add("dis.e.mail+bob.cathy@usf.com");
            //emails.Add("disemail+david@us.f.com");
            //int ans5 = UniqueEmails(emails);
            //Console.WriteLine("Q5");
            //Console.WriteLine("The number of unique emails is  " + ans5);


            //Question 6
            //string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" }, { "Delhi", "London" } };
            //string destination = DestCity(paths);
            //Console.WriteLine("Q6");
            //Console.WriteLine("Destination city is " + destination);

        }

        // Question 1 Method
        private static void PrintTriangle(int n)
        {
            // try catch
            try
            {
                //Declare variables
                int space;
                int number;


                // For loop for counter
                for (int i = 0; i <= n; i++)
                {
                    //for loop for spaces
                    for (space = 1; space <= n - i; space++)
                    {
                        Console.Write(" ");
                    }

                    // for loop for *
                    for (number = 1; number <= i; number++)
                    {
                        Console.Write("*");

                    }

                    for (number = i - 1; number >= 1; number--)
                    {
                        Console.Write("*");
                    }


                    Console.WriteLine();

                }

            }
            // Catch
            catch (Exception)
            {
                throw;

            }
        }

        // Question 2 Method
        private static void PrintPellSeries(int n2)
        {
            // Declare variables
            int pellMinus1 = 0;
            int pellMinus2 = 1;
            int pellNumber = 0;

            // Beginning of try catch
            try
            {
                // for loop for counter
                for (int i = 1; i <= n2; i++)
                {
                    pellNumber = pellMinus2 + (2 * pellMinus1); // Pellnumber equation

                    pellMinus2 = pellMinus1; // set these two variables equal to each other

                    pellMinus1 = pellNumber; // set these two variables equal to each other

                    Console.Write(pellNumber + " "); // print the computed pell number plus a space


                }
                Console.WriteLine();

            }

            // catch for incorrect input
            catch (Exception)
            {
                throw;
            }



        }

        // Question 3 Method
        private static bool SquareSums(int A)
        {
            // declare variable which is a boolean expression
            bool result = false;



            // Beginning of try catch
            try
            {
                // for loop for counter
                for (int i = 1; i * i <= A; i++)
                {
                    for (int j = 1; j * j <= A; j++)
                    {
                        //tests if there exists a sum of two squared numbers with the number provided by user
                        if (i * i + j * j == A)
                        {
                            result = false;
                        }

                        // Ends boolean variable 
                        else
                        {
                            result = true;
                        }
                    }

                }
                // returns results
                return result;

            }
            // catch part of try catch
            catch (Exception)
            {
                throw;
            }

        }

        // Question 4 Method
        private static int DiffPairs(int[] nums, int k)
        {
            //Declares count variable
            int count = 0;

            // Beginning of try catch
            try
            {

                // sorts arrays in nums 
                Array.Sort(nums);

                // Declare variables
                int i = 0;
                int j = 0;

                // While loop comparing first variable to lenght of nums
                while (j < nums.Length)
                {
                    // If statement that if i and j are equal to each other j increases by 1
                    if (i == j)
                    {
                        j++;
                    }

                    // if nums[i] + k is equal to nums[j] count increases by one
                    else if (nums[i] + k == nums[j])
                    {
                        count++;

                        // while loop stating if j increases by 1 is is than length of nums and nums[j] is equal to nums[j + i] j is increased by one
                        while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                        {
                            j++;
                        }

                        j++;
                    }

                    // if nums[i] + k is less than nums[j] i is increaed by one
                    else if (nums[i] + k < nums[j])
                    {
                        i++;
                    }

                    // if nums[i] + k is greater than nums[j] j is increased by one
                    else if (nums[i] + k > nums[j])
                    {
                        j++;
                    }


                }

                // variable count is returned
                return count;




            }


            // catch to check for incorrect input
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }

        // Question 5 method
        private static int UniqueEmails(List<string> emails)
        {
            // declare variables
            string domainPart;
            string localPart;
            string final_email;

            // create a new list
            List<string> final_email_list = new List<string>();

            // try catch block
            try
            {
                // for each statement
                foreach (string email in emails)
                {
                    // declare variable for index, local part of email, and domain part of email
                    int emailIndex = email.IndexOf("@");
                    localPart = email.Substring(0, emailIndex - 1);
                    domainPart = email.Substring(emailIndex + 1);

                    if (localPart.Contains("+"))
                    {
                        localPart = localPart.Substring(0, email.IndexOf("+"));
                    }

                    else
                    {
                        localPart = localPart;
                    }

                    if (localPart.Contains("."))
                    {
                        localPart.Replace(".", string.Empty);

                    }

                    else
                    {
                        localPart = localPart;



                    }



                    // Declares the final email variable with is the sum of loacl part, @ char and domain part 
                    final_email = localPart + "@" + domainPart;

                    // adds final_email varriable to final_email_list
                    final_email_list.Add(final_email);
                }

                // declares variable res
                int res = (from x in final_email_list select x).Distinct().Count();

                // returns variable res
                return res;


            }
            //catch part of try catch that checks for invalid input
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }

        // Question 6 method
        private static string DestCity(string[,] paths)
        {
            // declares variables
            int i;
            string res = " ";

            // beginning of try catch block
            try
            {
                // creating lists for beginning and destinations of trips
                List<string> beginningPoints = new List<string>();
                List<string> destinationPoints = new List<string>();

                for (i = 0; i < paths.GetLength(0); i++)
                {
                    beginningPoints.Add(paths[i, 0]);
                    destinationPoints.Add(paths[i, 1]);
                }

                foreach (string element in destinationPoints)
                {
                    if (beginningPoints.Contains(element))
                    {
                        continue;
                    }

                    else
                    {
                        res = element;
                        break;
                    }
                }
                // retuns res variable
                return res;
            }
            // catch that checks for invalid user input
            catch (Exception)
            {
                throw;
            }
        }


    }
}
