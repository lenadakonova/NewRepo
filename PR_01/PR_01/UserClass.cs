using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_01
{
    public class UserClass
    {
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public UserClass(string surname, string name,string patronymic)
        { UserSurname = surname;
          UserName= name;
          UserPatronymic= patronymic;
        }
    }
}
