using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpg
{
    public class HmacHash
    {
        //Generates a key for HMAC to use 
        public byte[] GenerateHMACKey()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var keyArray = new byte[32];
                randomNumberGenerator.GetBytes(keyArray);

                return keyArray;
            }
        }

        //Method to hash a message with SHA1 using HMAC
        public byte[] ComputeHashHmacSha1(byte[] hashArray, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(hashArray);
            }
        }

        //Method to hash a message with SHA256 using HMAC
        public byte[] ComputeHashHmacSha256(byte[] hashArray, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(hashArray);
            }
        }

        //Method to hash a message with MD5 using HMAC
        public byte[] ComputeHashHmacMd5(byte[] hashArray, byte[] key)
        {
            using (var hmac = new HMACMD5(key))
            {
                return hmac.ComputeHash(hashArray);
            }
        }
    }
}
