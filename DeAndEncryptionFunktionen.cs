using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;

namespace AzureVault
{
	public partial class DeAndEncryptionFunktionen
	{
		public static void EncryptText(string text, string fileName, string key)
		{
			byte[] encrypted = EncryptStringToBytes_Aes(text, Encoding.UTF8.GetBytes(key));
			File.WriteAllBytes(fileName, encrypted);
		}

		public static string DecryptText(string filename, string key)
		{
			byte[] encrypted = File.ReadAllBytes(filename);
			return DecryptStringFromBytes_Aes(encrypted, Encoding.UTF8.GetBytes(key));
		}
		static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key)
		{
			byte[] encrypted;
			using(Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;
				aesAlg.GenerateIV();

				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				using(MemoryStream msEncrypt = new MemoryStream())
				{
					msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
					msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
					using(CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using(StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							swEncrypt.Write(plainText);
						}
					}
                    encrypted = msEncrypt.ToArray();
                }
			}

			return encrypted;
		}

		static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key)
		{
			string plaintext = null;

			using(Aes aesAlg = Aes.Create())
			{
				aesAlg.Key = Key;

				using(MemoryStream msDecrypt = new MemoryStream(cipherText))
				{
					byte[] rawLenght = new byte[sizeof(int)];
					if(msDecrypt.Read(rawLenght, 0, rawLenght.Length) != rawLenght.Length)
					{
						throw new CryptographicException("Ciphertext too short");
					}
					int ivLenght = BitConverter.ToInt32(rawLenght, 0);

					byte[] buffer = new byte[BitConverter.ToInt32(rawLenght, 0)];
					msDecrypt.Read(buffer, 0, buffer.Length);
					if(buffer.Length > 16)
					{
						aesAlg.IV = buffer.Take(16).ToArray();
					}
					else if(buffer.Length < 16)
					{
						byte[] newBuffer = new byte[16];
						Buffer.BlockCopy(buffer, 0, newBuffer, 0, buffer.Length);
						aesAlg.IV = newBuffer;
					}
					else
					{
						aesAlg.IV = buffer;
					}

					ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
					using(CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using(StreamReader srDecrypt = new StreamReader(csDecrypt))
						{
							plaintext = srDecrypt.ReadToEnd();
						}
					}
				}
			}
			return plaintext;
		}
	}
}