/**
 * 
 *Program.cs 
 * 
 * 
 */
using System;

namespace _exam {

    public class Program
    {
        public static void Main(string[] args) {
            Examinee examinee = new Examinee();
            examinee.Name = "田中隆";
            examinee.Age = 19;
            examinee.Score = 90;
            examinee.Grade = "B";

            examinee.showinfo();
        }

    }
} 