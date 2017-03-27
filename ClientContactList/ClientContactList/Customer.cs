using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientContactList
{
    public class Customer
    {
        public int Id { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public void setID(int id)
        {

            this.Id = id;
        }

        /// <summary>
        /// Customer Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        //public Customer(string firstName, string lastName)
        //{
        //    this.Id += IdCouter;
        //    IdCouter++;
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //}
    }
}
