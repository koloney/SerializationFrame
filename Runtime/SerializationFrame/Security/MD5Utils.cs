using System;
using System.Text;

public abstract class MD5Utils
{
    /// <summary>
    /// 加密
    /// </summary>
    /// <param name="buffer"></param>
    /// <returns></returns>
    public static string Encrypt(byte[] buffer)
    {
        System.Security.Cryptography.MD5 alg = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] data = alg.ComputeHash(buffer);
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));///X2的意思是保持字符长度一致。
        }
        return sBuilder.ToString();
    }
}
