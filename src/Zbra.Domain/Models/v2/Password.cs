using Zbra.Domain.Enums;

namespace Zbra.Domain.Models.v2
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
            var count = 1;
            var hasDouble = false;

            for (int i = 1; i < password.Length; i++)
            {
                if (password[i] < digitPrevious)
                {
                    return false;
                }
                else if (password[i] == digitPrevious)
                {
                    count++;
                }
                else
                {
                    if (count == 2)
                    {
                        hasDouble = true;
                    }
                    count = 1;
                }

                digitPrevious = password[i];
            }

            return hasDouble || count == 2;
        }
    }
}
