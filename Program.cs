using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Collections;

namespace ArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] studentRollNumbers = { 2, 5, 8, 10 };
            //for (int i = 0; i < studentRollNumber.Length; i++)
            //{
            //    Console.WriteLine("Student's Roll Number = {0}", studentRollNumber[i]);
            //}

            //string[] studentFirstNames = { "Atharva", "Amit", "Prasad", "Shantanu" };
            //for(int i = 0; i < studentFirstName.Length; i++)
            //{
            //    Console.WriteLine("Student's First Name = {0}",studentFirstName[i]);
            //}

            //foreach (int studentRollNumber in studentRollNumbers)
            //    Console.WriteLine("Student's Roll Number = {0}", studentRollNumber);

            //foreach (string studentName in studentFirstNames)
            //    Console.WriteLine("Student's First Name = {0}", studentName);

            //int[] randomNumberArray = { 2, 45, 67, 100, 12, 32, 78, 99 };

            //Console.WriteLine("The Maximum Number is : {0}", MaximumNumber(randomNumberArray));

            IDictionary environmentVariables = Environment.GetEnvironmentVariables();

            foreach (DictionaryEntry dictionaryEntry in environmentVariables)
            {
                Console.WriteLine("{0} = {1}",dictionaryEntry.Key,dictionaryEntry.Value);
            }
        }

        //static int MaximumNumber(int[] integers)
        //{
        //    int maximumNumber = 0;
        //    foreach (int number in integers)
        //    {
        //        if (number > maximumNumber)
        //            maximumNumber = number;
        //    }
        //    return maximumNumber;
        //}
    }
}
