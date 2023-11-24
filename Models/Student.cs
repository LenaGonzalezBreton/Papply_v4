using System.ComponentModel;

namespace Papply.Models
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string? NomStudent {  get; set; }
        public string? PrenomStudent {  get; set; }
        public Promotion? Promotion { get; set; }

    }
}
