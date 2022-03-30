using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_03_2022_Classwork_Again.Models
{
    internal class Student : Person
    {
        private int _iqRank;
        private int _languageRank;
        public Student(string name, string surname, int age, int iqRank, int languageRank)
        {
            Name = name;
            Surname = surname;
            if (age > 0 && age <= 30) Age = age;
            IqRank = iqRank;
            LanguageRank = languageRank;
        }
        public int IqRank { get { return _iqRank; }
            set
            {
                if (value >= 0 && value <= 100) _iqRank = value;
            } 
        }
        public int LanguageRank { get { return _languageRank; } 
            set
            {
                if (value >= 0 && value <= 100) _languageRank = value;
            }
        }
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override int Age { get; set ; }
        public int ExamResult()
        {
            return IqRank + LanguageRank;
        }
        public override void GetInfo()
        {
            if (ExamResult() >= 120) Console.WriteLine($"Name - {Name}\nSurname - {Surname}\nAge - {Age}\n{Name}'s IQ Rank  and Language Rank values are {IqRank} and {LanguageRank}\nRESULT: Student have passed the exam with {ExamResult()} point!");
            else if (ExamResult() < 120) Console.WriteLine($"Name - {Name}\nSurname - {Surname}\nAge - {Age}\n{Name}'s IQ Rank  and Language Rank values are {IqRank} and {LanguageRank}\nRESULT: Student have failed the exam! The total score was {ExamResult()} point!");
        }
    }
}
