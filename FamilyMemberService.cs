using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class FamilyMemberService
    {
        public List<FamilyMember> Family { get; set; }

        public FamilyMemberService() 
        {
            Family = new List<FamilyMember>();
        }
        public void AddPerson(params FamilyMember[] member)
        {
            if (member != null && member.Length>0)
            {
                Family.AddRange(member);
            }
        }

        public FamilyMember FindHusbandOrWife(FamilyMember member)
        {
            FamilyMember fatherOrMother = null;
            if (member.Gender == Gender.Male)
            {
                foreach (FamilyMember familyMember in Family)
                {
                    if (familyMember.Father == member)
                    {
                        fatherOrMother = familyMember.Mother;
                        Console.WriteLine("ЖЕНА: ");
                        Console.WriteLine(fatherOrMother.ToString());                          
                        break; 
                    }

                }
            }
            if (member.Gender == Gender.Female)
            {
                foreach (FamilyMember familyMember in Family)
                {
                    if (familyMember.Mother == member)
                    {
                        fatherOrMother = familyMember.Father;
                        Console.WriteLine("МУЖ: ");
                        Console.WriteLine(fatherOrMother.ToString());                    
                        break;
                    }
                }
            }
            return fatherOrMother;
        }
        public void GetParents(FamilyMember member)
        {
            Console.WriteLine();
            Console.WriteLine("Родители супруга/супруги: ");
            Console.WriteLine($"Отец: \n{member.Father.ToString()}");
            Console.WriteLine($"Мать: \n{member.Mother.ToString()}");
        }
    }
}
