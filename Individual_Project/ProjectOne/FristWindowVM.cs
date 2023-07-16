using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ProjectOne
{
    public partial class FristWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> students;

        [ObservableProperty]
        public Student selectedUser = null;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }


        [RelayCommand]
        public void AddStudent()
        {
            var vm = new AddUserVM();
            AddUserWindow window = new AddUserWindow(vm);
            window.ShowDialog();
           
           

            if (vm.User.FirstName != null)
            {
                students.Add(vm.User);
            }

        }

        [RelayCommand]
        public void Delete()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                students.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Plese Select Student before Delete.", "Error");


            }
        }


        [RelayCommand]
        public void ExecuteEditStudent()
        {
            if (selectedUser != null)
            {
                var vm = new AddUserVM(selectedUser);
                var window = new AddUserWindow(vm);
                window.ShowDialog();


             


            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }



        public FristWindowVM()
        {
            students = new ObservableCollection<Student>();
            BitmapImage image1 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            students.Add(new Student("EG/2020/0001", "Tom1", "Kane1", 24, "12/1/2000", 3.1, image1));
            BitmapImage image2 = new BitmapImage(new Uri("/Images/2.png", UriKind.Relative));
            students.Add(new Student("EG/2020/0001", "Tom1", "Kane1", 24, "12/1/2000", 3.0, image2));
        

        }

    }
}
