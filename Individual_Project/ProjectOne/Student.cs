
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectOne
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public string RegNo { get; set; }

        public double Gpa{ get; set; }

        public int Age { get; set; }

        public BitmapImage Image { get; set; }

        public string ImagePath
        {
            get
            {
                return $"/Images/{Image}";
            }
        }

        public Student(string regNo, string firstName, string lastName, int age, string dateOfBirth,  double gpa,  BitmapImage image)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            RegNo = regNo;
            Gpa = gpa;
            Age = age;
            Image = image;
        }

        public Student()
        {


            
            
        }
    }


   
}


