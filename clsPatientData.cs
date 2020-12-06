using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorStrange
{
    class clsPatientData
    {

        private Int32 _id;
        private string _pName;
        private string _fName;
        private DateTime _dateOfBirth;
        private string _phone;

        public Int32 ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string PName
        {
            get
            {
                return _pName;
            }
            set
            {
                _pName = value;
            }
        }


        public string FName
        {
            get
            {
                return _fName;
            }
            set
            {
                _fName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }


        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
    }
}
