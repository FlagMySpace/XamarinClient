﻿using System;
using FlagMySpace.Agnostic.Resources;

namespace FlagMySpace.Agnostic.Utilities
{
    public class PasswordValidatorUtility
    {
        public void ValidatePassword(string password, string confirmPassword)
        {
            if (!password.Equals(confirmPassword))
            {
                throw new FormatException(Resource.PasswordValidatorUtility_ValidatePassword_Password_mismatch);
            }
        }
    }
}
