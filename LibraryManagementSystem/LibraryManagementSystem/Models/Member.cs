using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string SubscriptionCode { get; set; }

        public Member()
        {


        }

        public Member(string firstName, string lastName, string cellPhone)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhone = cellPhone;


        }

         public Member(string firstName, string lastName, string cellPhone, string subscriptionCode)
        {
            FirstName = firstName;
            LastName = lastName;
            CellPhone = cellPhone;
            SubscriptionCode = subscriptionCode;

        }

    }







}

