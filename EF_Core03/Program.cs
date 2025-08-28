using EF_Core03.Data.Models;
using EF_Core03.DataSeeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace EF_Core03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
            #region DataSeeding
            //ITIDataSeeding.DataSeeding(context);
            #endregion
            #region Egar Loading

            //var Result = from s in context.Students.Include(s => s.Department)
            //             select new
            //             {
            //                 StudentName = s.LName + " " + s.FName,
            //                 DepartmentName = s.Department.Name,



            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Student Name : {item.StudentName} , Department Name : {item.DepartmentName}");
            //}

            #endregion
            #region Explicit Loading

            //var student = context.Students.FirstOrDefault(s => s.Id == 1);
            //context.Entry(student).Reference(s => s.Department).Load();
            //Console.WriteLine($"Student Name : {student.LName} {student.FName} , Department Name : {student.Department.Name}");


            #endregion
            #region Lazy Loading

            //var student = context.Students.FirstOrDefault(s => s.Id == 1);
            //Console.WriteLine($"Student Name : {student.LName} {student.FName} , Department Name : {student.Department.Name}");

            #endregion

            






        }
    }
}
    

