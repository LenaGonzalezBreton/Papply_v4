
using DynamicData;
using Microsoft.Data.SqlClient;
using Papply.Models;
using System.Collections.Generic;
using System.Linq;

namespace Papply.Storage
{
    public class BDDInteraction
    {
        public SqlConnection bdo = new SqlConnection("Data Source=172.20.11.32;Initial Catalog=Papply;Integrated Security=SSPI");
        public BDDInteraction() { }
    
        public void ExtractStudent()
        {
            SqlCommand extraction = bdo.CreateCommand();
            extraction.CommandText = "SELECT * FROM STUDENT";
            extraction.ExecuteNonQuery();
            SqlDataReader r = extraction.ExecuteReader();
            if (r.HasRows)
            {
                while(r.Read())
                {
                    //Renseigner les colonnes ""
                    string IdStudent = r.GetFieldValue<string>(r.GetOrdinal("IdStudent"));
                    string Nom = r.GetFieldValue<string>(r.GetOrdinal("NomStudent"));
                    string Prenom = r.GetFieldValue<string>(r.GetOrdinal("PrenomStudent"));
                    string IdPromotion = r.GetFieldValue<string>(r.GetOrdinal("IdPromotion"));


                    // Utilisez les valeurs pour créer une instance 
                    Student stoadd = new Student(IdStudent,Nom, Prenom, IdPromotion);
                    DataStorage.Students.AddOrUpdate(stoadd);
                }
            }
        }

        public void ExtractPromo()
        {
            SqlCommand extraction = bdo.CreateCommand();
            List<Student> students = new List<Student>();
            extraction.CommandText = "SELECT * FROM PROMOTION";
            extraction.ExecuteNonQuery();
            SqlDataReader r = extraction.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    //Renseigner les colonnes ""
                    string IdPromotion = r.GetFieldValue<string>(r.GetOrdinal("IdPromotion"));
                    string NomPromotion = r.GetFieldValue<string>(r.GetOrdinal("NomPromotion"));
                    SqlCommand extraction_elevepromo = bdo.CreateCommand();
                    extraction_elevepromo.CommandText = "SELECT * FROM STUDENT WHERE IdPromotion = '"+IdPromotion.ToString()+"';";
                    extraction_elevepromo.ExecuteNonQuery();
                    SqlDataReader releve = extraction_elevepromo.ExecuteReader();
                    if(releve.HasRows)
                    {
                        while (releve.Read())
                        {
                            string IdStudent = releve.GetFieldValue <string>(r.GetOrdinal("IdStudent"));
                            string NomStudent = releve.GetFieldValue<string>(r.GetOrdinal("NomStudent"));
                            string PrenomStudent = releve.GetFieldValue<string>(r.GetOrdinal("PrenomStudent"));
                            string FkIdPromotion = releve.GetFieldValue<string>(r.GetOrdinal("IdPromotion"));
                            students.Add(new Student(IdStudent, NomStudent, PrenomStudent, FkIdPromotion));
                        }
                    }
                    // Utilisez les valeurs pour créer une instance
                    Promotion ptoadd = new Promotion(IdPromotion,NomPromotion,students);
                    DataStorage.Promotions.AddOrUpdate(ptoadd);
                }
            }
        }

        public void ExtractTask()
        {
            SqlCommand extraction = bdo.CreateCommand();
            extraction.CommandText = "SELECT * FROM TASK";
            extraction.ExecuteNonQuery();
            SqlDataReader r = extraction.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    //Renseigner les colonnes ""
                    string IdTask = r.GetFieldValue<string>(r.GetOrdinal("IdTask"));
                    double PointTask  = r.GetFieldValue<double>(r.GetOrdinal("PointTask"));
                    string TitleTask = r.GetFieldValue<string>(r.GetOrdinal("TitleTask"));
                    string DescriptionTask = r.GetFieldValue<string>(r.GetOrdinal("DescriptionTask"));
                    string IdTp = r.GetFieldValue<string>(r.GetOrdinal("FkIdTp"));


                    // Utilisez les valeurs pour créer une instance
                    Task ttoadd = new Task(IdTask, PointTask, TitleTask, DescriptionTask, IdTp);
                    DataStorage.Tasks.AddOrUpdate(ttoadd);
                }
            }
        }

        public void ExtractTp()
        {
            SqlCommand extraction = bdo.CreateCommand();
            extraction.CommandText = "SELECT * FROM TP";
            extraction.ExecuteNonQuery();
            SqlDataReader r = extraction.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    //Renseigner les colonnes ""
                    string IdTp = r.GetFieldValue<string>(r.GetOrdinal("IdTp"));
                    string TitreTp = r.GetFieldValue<string>(r.GetOrdinal("NomTp"));
                    string DescriptionTp = r.GetFieldValue<string>(r.GetOrdinal("DescriptionTp"));



                    // Utilisez les valeurs pour créer une instance
                    Tp tptoadd = new Tp(IdTp,TitreTp,DescriptionTp);
                    DataStorage.Tps.AddOrUpdate(tptoadd);
                }
            }
        }

        public void InsertAllStudents(List<Student> students)
        {
            using (SqlCommand insertion = bdo.CreateCommand())
            {
                insertion.CommandText = "INSERT INTO STUDENT (IdStudent, Nom, Prenom, IdPromotion) VALUES (@IdStudent, @Nom, @Prenom, @IdPromotion)";
                bdo.Open();
                foreach (var student in students)
                {
                    insertion.Parameters.Clear();
                    insertion.Parameters.AddWithValue("@IdStudent", student.IdStudent);
                    insertion.Parameters.AddWithValue("@Nom", student.NomStudent);
                    insertion.Parameters.AddWithValue("@Prenom", student.PrenomStudent);
                    insertion.Parameters.AddWithValue("@IdPromotion", student.IdPromotion);
                    insertion.ExecuteNonQuery();
                }
            }
        }

        public void InsertAllPromotions(List<Promotion> promotions)
        {
            using (SqlCommand insertion = bdo.CreateCommand())
            {
                insertion.CommandText = "INSERT INTO PROMOTION (IdPromotion, NomPromotion) VALUES (@IdPromotion, @NomPromotion)";
                bdo.Open();
                foreach (var promotion in promotions)
                {
                    insertion.Parameters.Clear();
                    insertion.Parameters.AddWithValue("@IdPromotion", promotion.IdPromotion);
                    insertion.Parameters.AddWithValue("@NomPromotion", promotion.NomPromotion);
                    insertion.ExecuteNonQuery();
                }
            }
        }

        public void InsertAllTasks(List<Task> tasks)
        {
            using (SqlCommand insertion = bdo.CreateCommand())
            {
                insertion.CommandText = "INSERT INTO TASK (IdTask, PointTask, TitleTask, DescriptionTask, IdTp) VALUES (@IdTask, @PointTask, @TitleTask, @DescriptionTask, @IdTp)";
                bdo.Open();
                foreach (var task in tasks)
                {
                    insertion.Parameters.Clear();
                    insertion.Parameters.AddWithValue("@IdTask", task.IdTask);
                    insertion.Parameters.AddWithValue("@PointTask", task.PointTask);
                    insertion.Parameters.AddWithValue("@TitleTask", task.TitleTask);
                    insertion.Parameters.AddWithValue("@DescriptionTask", task.DescriptionTask);
                    insertion.Parameters.AddWithValue("@IdTp", task.IdTp);
                    insertion.ExecuteNonQuery();
                }
            }
        }

        public void InsertAllTps(List<Tp> tps)
        {
            using (SqlCommand insertion = bdo.CreateCommand())
            {
                insertion.CommandText = "INSERT INTO TP (IdTp, TitreTp, DescriptionTp) VALUES (@IdTp, @TitreTp, @DescriptionTp)";
                bdo.Open();
                foreach (var tp in tps)
                {
                    insertion.Parameters.Clear();
                    insertion.Parameters.AddWithValue("@IdTp", tp.IdTp);
                    insertion.Parameters.AddWithValue("@TitreTp", tp.TitreTp);
                    insertion.Parameters.AddWithValue("@DescriptionTp", tp.DescriptionTp);
                    insertion.ExecuteNonQuery();
                }
            }
        }



    }
}
