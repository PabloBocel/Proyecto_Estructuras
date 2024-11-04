using System;
using System.Security.Cryptography;
using System.Text;

namespace Proyecto_Estructuras
{
    internal class EncriptacionPublica
    {
        public static string EncryptPasswordWithRSA(string password, string publicKey)
        {

            publicKey = publicKey.Replace("-----BEGIN PUBLIC KEY-----", "")
                                 .Replace("-----END PUBLIC KEY-----", "")
                                 .Replace("\n", "").Replace("\r", "").Trim();

            try
            {
                // Convertir la clave pública Base64 a bytes
                byte[] publicKeyBytes = Convert.FromBase64String(publicKey);

                // Crear un objeto RSACryptoServiceProvider
                using (var rsa = new RSACryptoServiceProvider())
                {
                    // Importar la clave pública desde el formato DER
                    rsa.ImportParameters(DecodeX509PublicKey(publicKeyBytes));

                    // Convertir la contraseña a un arreglo de bytes
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                    // Encriptar la contraseña usando la clave pública con PKCS#1 padding
                    byte[] encryptedBytes = rsa.Encrypt(passwordBytes, false);

                    // Convertir la contraseña encriptada a Base64
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato en la clave pública: ");
                return null;
            }
            catch (CryptographicException)
            {

                Console.WriteLine("Error al encriptar: ");
                return null;
            }
        }

        // Método auxiliar para convertir la clave pública en formato DER a RSAParameters
        private static RSAParameters DecodeX509PublicKey(byte[] x509Key)
        {
            // SEQUENCE { INTEGER modulus, INTEGER exponent }
            using (var reader = new System.IO.BinaryReader(new System.IO.MemoryStream(x509Key)))
            {
                byte bt = 0;
                ushort twoBytes = 0;

                // Read the Sequence OID
                twoBytes = reader.ReadUInt16();
                if (twoBytes == 0x8130) reader.ReadByte();
                else if (twoBytes == 0x8230) reader.ReadInt16();
                else throw new CryptographicException("Invalid X509 public key format");

                twoBytes = reader.ReadUInt16();
                if (twoBytes != 0x0102)
                    throw new CryptographicException("Invalid X509 public key format");

                bt = reader.ReadByte();
                if (bt != 0x00)
                    throw new CryptographicException("Invalid X509 public key format");

                RSAParameters rsaKeyInfo = new RSAParameters();
                rsaKeyInfo.Modulus = reader.ReadBytes(GetIntegerSize(reader));
                rsaKeyInfo.Exponent = reader.ReadBytes(GetIntegerSize(reader));

                return rsaKeyInfo;
            }
        }

        // Método auxiliar para obtener el tamaño del entero en el binario DER
        private static int GetIntegerSize(System.IO.BinaryReader reader)
        {
            byte bt = reader.ReadByte();
            if (bt != 0x02)
                throw new CryptographicException("Expected integer");

            bt = reader.ReadByte();

            int count;
            if (bt == 0x81)
                count = reader.ReadByte();
            else if (bt == 0x82)
            {
                byte highbyte = reader.ReadByte();
                byte lowbyte = reader.ReadByte();
                count = BitConverter.ToUInt16(new byte[] { lowbyte, highbyte }, 0);
            }
            else
            {
                count = bt;
            }

            while (reader.ReadByte() == 0x00)
                count--;

            reader.BaseStream.Seek(-1, System.IO.SeekOrigin.Current);
            return count;
        }
    }
}




