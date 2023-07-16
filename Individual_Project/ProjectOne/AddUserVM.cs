using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Imaging;

namespace ProjectOne
{
    public partial class AddUserVM: ObservableObject
    {
        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string dateOfBirth;

        [ObservableProperty]
        public string regNo;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public int age;

        [ObservableProperty]
        public BitmapImage userimage;

        public AddUserVM( Student s) 
        {
            User = s;
            firstName = User.FirstName;
            lastName = User.LastName;
            dateOfBirth = User.DateOfBirth;
            regNo = User.RegNo;
            gpa = User.Gpa;
            age = User.Age;
            userimage= User.Image;
        }

        public AddUserVM()
        {
        }


        [RelayCommand]
        public void UploadPhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.bmp; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                userimage = new BitmapImage(new Uri(dialog.FileName));

                MessageBox.Show("Imgae successfuly uploded!", "successfull");
            }
        }

        public Action CloseAction { get; internal set; }
        public Student User { get; private set; }


        [RelayCommand]
        public void Save()
        {

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between  and 4", "Error");
                return;
            }


            if (User == null)
            {

                User = new Student()
                {
                    RegNo = regNo,
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    DateOfBirth = dateOfBirth,
                    Image = userimage,
                    Gpa = gpa,


                };


            }
            else
            {

                User.FirstName = firstName;
                User.LastName = lastName;
                User.RegNo = regNo;
                User.Age = age;
                User.Gpa = gpa;
                User.Image = userimage;
                User.DateOfBirth = dateOfBirth;



            }

            if (User.FirstName != null)
            {

                CloseAction();
            }

            Application.Current.MainWindow.Show();
        }


       
    }
}
