using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class ValidationRegex
    {
        public static string NAME_REGEX = "^[A-Z]{1}[A-Za-z]{3,}$";
        public static string MOBILENUMBER_REGEX = @"\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})";
        public static string EMAIL_REGEX = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public static string PASSWORD_REGEX = "^(?=.?[A-Z])(?=.?[a-z])(?=.?[0-9])(?=.?[#?!@$%^&*-]).{8,}$";


        public bool ValidateFirstName(string name)
        {

            //if (Regex.IsMatch(name, NAME_REGEX))
            //    return true;
            //else
            //    throw new InvalidNameException("InvalidNameException Generated: Name is Invalid");
            //    //return false;

           Regex regex = new Regex(NAME_REGEX);
           return ValidateFirstName(name);

            bool ValidateFirstName(string name) => regex.IsMatch(name) ? true : throw new InvalidNameException("your name is invalid");
        }

        public bool ValidateMobileNumber(string mobileNumber)
        {


            if (Regex.Equals(mobileNumber, MOBILENUMBER_REGEX))
                return true;
            else
                throw new InvalidMobileNumberException("InvalidMobileNumberException Generated: Number is Invalid");
        }

        public bool validateEmail(string email)
        {


            if (Regex.IsMatch(email, EMAIL_REGEX))
                return true;
            else
                throw new InvalidEmailException("InvalidEmailException Generated: Email is Invalid");

        }

        public bool ValidatePassword(string password)
        {

            if (Regex.IsMatch(password, PASSWORD_REGEX))
                return true;
            else
                throw new InvalidPasswordException("InvalidEmailException Generated: Email is Invalid");
        }
    }
}