﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {

        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA256())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));


            }



        }



        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {


            using (var hmac = new System.Security.Cryptography.HMACSHA256(passwordSalt))
            {


                var computerHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0;  i < computerHash.Length; i++)
                {

                    if (computerHash[i] != passwordHash[i])
                    {

                        return false;

                    }                    


                }

                return true;

            }
         
        }
    }
}
