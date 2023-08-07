using Zbra.Domain.Enums;

namespace Zbra.Domain.Models.v1
{
    public class Password
    {
        public Password() { }

        public int GetPasswordsValid()
        {
            var numberPasswordsValid = 0;

            for (int password = (int)PasswordRange.Initial; password <= (int)PasswordRange.Final; password++)
            {
                if (IsValid(password.ToString()))
                {
                    numberPasswordsValid++;
                }
            }

            return numberPasswordsValid;
        }

        private bool IsValid(string password)
        {
            var digitPrevious = password[0];
            var hasDouble = false;

            for (int i = 1; i < password.Length; i++)
            {
                if (password[i] < digitPrevious)
                {
                    return false;
                }
                else if (password[i] == digitPrevious)
                {
                    hasDouble = true;
                }

                digitPrevious = password[i];
            }

            return hasDouble;
        }
    }
}
