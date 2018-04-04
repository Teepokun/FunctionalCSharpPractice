using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LaYumba.Functional;
using static LaYumba.Functional.F;

// 3 Write a type Email that wraps an underlying string, enforcing that it’s in a valid
// format. Ensure that you include the following:
// - A smart constructor
// - Implicit conversion to string, so that it can easily be used with the typical API
// for sending emails
namespace Chapter3
{
    public static class EmailExtensions
    {
        private static readonly Regex Regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public static bool IsValid(this string email)
            => Regex.IsMatch(email);
    }
    public class Email
    {
        private readonly string _underlyingValue;

        protected Email(string underlyingType)
        {
            this._underlyingValue = underlyingType;
        }

        public static Option<Email> CreateEmail(string s)
            => s.IsValid() ? Some(new Email(s)) : None;

        public static implicit operator string(Email email)
            => email._underlyingValue;
    }
}
