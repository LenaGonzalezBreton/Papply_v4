using System;

namespace Papply.Models
{
    public class Student
    {
        public string IdStudent { get; set; }
        public string NomStudent { get; set; }
        public string PrenomStudent { get; set; }
        public string IdPromotion { get; set; }

        public Student(string idStudent, string nomStudent, string prenomStudent, string idPromotion)
        {
            this.IdStudent = idStudent;
            this.NomStudent = nomStudent;
            this.PrenomStudent = prenomStudent;
            this.IdPromotion = idPromotion;
        }

        public static Models.Student Create()
        {
            var guid = Guid.NewGuid();
            return new Student(guid.ToString(), "", "", "");
        }
    }

}
