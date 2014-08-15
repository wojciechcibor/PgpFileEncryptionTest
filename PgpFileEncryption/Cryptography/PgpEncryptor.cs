using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PgpFileEncryption.Cryptography
{
    public interface IPgpEncryptor
    {
        Stream Encrypt(Stream inputFile, Stream publicKey, bool asciiArmor = true);

        Stream Decrypt(Stream inputFile, Stream pgpFile);
    }

    public class PgpEncryptor : IPgpEncryptor
    {
        public Stream Encrypt(Stream inputFile, Stream publicKey, bool asciiArmor = true)
        {
            throw new NotImplementedException();
        }

        public Stream Decrypt(Stream inputFile, Stream pgpFile)
        {
            throw new NotImplementedException();
        }
    }
}
