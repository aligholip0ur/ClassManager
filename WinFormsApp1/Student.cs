using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    internal class Student
    {
      
        public int Id { get; set; }
        public string Fname { get; set; }
        public  string Lname { get; set; }
        public bool IsPersent { get; set; }
        public int RowNumber { get; set; } 
        public string GetStudentState()
        {
            return IsPersent switch
            {
                true => "✔",
                false => "❌",

            };
        }
       
        public string DisplayStudentInfo => $"{RowNumber}==>{Fname}-{Lname} - {GetStudentState()} ";
    }
}
