using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashingOpg
{
    public class Hash
    {

        //Method to hash a message with SHA1
        public byte[] ComputeHashSha1(byte[] hashArray)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(hashArray);
            }
        }

        //Method to hash a message with SHA1
        public byte[] ComputeHashSha256(byte[] hashArray)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(hashArray);
            }
        }

        //Method to hash a message with SHA1
        public byte[] ComputeHashMd5(byte[] hashArray)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(hashArray);
            }
        }
    }
}
