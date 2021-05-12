using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace MyAccounts.Libraries.Security
{
    public static class RSASecurity
    {
        public static string Encrypt(string strText)
        {
            try
            {
                var publicKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
                var data = Encoding.UTF8.GetBytes(strText);

                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    rsa.FromXmlString(publicKey);
                    var encryptedData = rsa.Encrypt(data, true);
                    rsa.PersistKeyInCsp = false;
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (Exception ex)
            {
                Logging.Logging.Write(Logging.Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                return string.Empty;
            }
        }

        public static string Decrypt(string text)
        {
            try
            {
                var privateKey = "<RSAKeyValue><Modulus>21wEnTU+mcD2w0Lfo1Gv4rtcSWsQJQTNa6gio05AOkV/Er9w3Y13Ddo5wGtjJ19402S71HUeN0vbKILLJdRSES5MHSdJPSVrOqdrll/vLXxDxWs/U0UT1c8u6k/Ogx9hTtZxYwoeYqdhDblof3E75d9n2F0Zvf6iTb4cI7j6fMs=</Modulus><Exponent>AQAB</Exponent><P>/aULPE6jd5IkwtWXmReyMUhmI/nfwfkQSyl7tsg2PKdpcxk4mpPZUdEQhHQLvE84w2DhTyYkPHCtq/mMKE3MHw==</P><Q>3WV46X9Arg2l9cxb67KVlNVXyCqc/w+LWt/tbhLJvV2xCF/0rWKPsBJ9MC6cquaqNPxWWEav8RAVbmmGrJt51Q==</Q><DP>8TuZFgBMpBoQcGUoS2goB4st6aVq1FcG0hVgHhUI0GMAfYFNPmbDV3cY2IBt8Oj/uYJYhyhlaj5YTqmGTYbATQ==</DP><DQ>FIoVbZQgrAUYIHWVEYi/187zFd7eMct/Yi7kGBImJStMATrluDAspGkStCWe4zwDDmdam1XzfKnBUzz3AYxrAQ==</DQ><InverseQ>QPU3Tmt8nznSgYZ+5jUo9E0SfjiTu435ihANiHqqjasaUNvOHKumqzuBZ8NRtkUhS6dsOEb8A2ODvy7KswUxyA==</InverseQ><D>cgoRoAUpSVfHMdYXW9nA3dfX75dIamZnwPtFHq80ttagbIe4ToYYCcyUz5NElhiNQSESgS5uCgNWqWXt5PnPu4XmCXx6utco1UVH8HGLahzbAnSy6Cj3iUIQ7Gj+9gQ7PkC434HTtHazmxVgIR5l56ZjoQ8yGNCPZnsdYEmhJWk=</D></RSAKeyValue>";
                var data = Encoding.UTF8.GetBytes(text);

                using (var rsa = new RSACryptoServiceProvider(1024))
                {
                    rsa.FromXmlString(privateKey);
                    var resultBytes = Convert.FromBase64String(text);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    rsa.PersistKeyInCsp = false;
                    return decryptedData;
                }
            }
            catch (Exception ex)
            {
                Logging.Logging.Write(Logging.Logging.ERROR, new StackTrace(new StackFrame(0)).ToString().Substring(5, new StackTrace(new StackFrame(0)).ToString().Length - 5), ex.Message);
                return string.Empty;
            }
        }
    }
}
