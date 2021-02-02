using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataformXamarin
{
    public class ContactsInfo
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string contactNo;
        private string email;
        private DateTime? birthDate;

        public ContactsInfo()
        {

        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                this.middleName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }
    }
}

