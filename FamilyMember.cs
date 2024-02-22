using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Gender Gender { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $" Имя - {Name}\n Фамилия - {SurName}\n Пол - {Gender}\n Дата рождения - {BirthDate.ToShortDateString()}";
        }
    }
}
