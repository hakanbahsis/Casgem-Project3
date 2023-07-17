﻿using Microsoft.AspNetCore.Identity;

namespace Pizzapan.WebUI.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code="PasswordToShort",
                Description=($"Parola en az {length} karakter olmalıdır!")
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code="PasswordRequiresLower",
                Description="Lütfen en az 1 tane küçük harf giriniz!"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Lütfen en az 1 tane büyük harf giriniz!"
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresDigit",
                Description = "Lütfen en az 1 tane sayı giriniz!"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Lütfen en az 1 tane sembol giriniz!"
            };
        }
    }
}
