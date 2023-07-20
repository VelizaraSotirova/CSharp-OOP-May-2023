using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Call(string phoneNumber)
        {
            if (!ValidatePhoneNumber(phoneNumber))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {phoneNumber}";
        }
        public string Browse(string url)
        {
            if (!ValidateURL(url))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(c => char.IsDigit(c));

        private bool ValidateURL(string url)
            => url.All(c => !char.IsDigit(c));
    }
}
