using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using KleinesBeispiel.Model;

namespace KleinesBeispiel.ViewModel
{
    class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();

            students.Add(new Student { FirstName = "Leo", LastName = "Haas" });
            students.Add(new Student { FirstName = "Noah", LastName = "Zemljic" });
            students.Add(new Student { FirstName = "Noah", LastName = "Horlacher" });
            students.Add(new Student { FirstName = "David", LastName = "Peric" });

            Students = students;
        }
    }
}
