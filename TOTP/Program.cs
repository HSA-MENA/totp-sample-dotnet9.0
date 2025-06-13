using OtpNet;

class Program
{
    static void Main(string[] args)
    {
        // Generate a secret key
        var secretKey = KeyGeneration.GenerateRandomKey(20);
        var base32Secret = Base32Encoding.ToString(secretKey);

        // Uncomment the following line to use a predefined Base32 secret key
        // var base32Secret = "JBSWY3DPEHPK3PXP"; // Example Base32 secret key
        // var secretKey = Base32Encoding.ToBytes(base32Secret);

        Console.WriteLine($"Secret Key (Base32): {base32Secret}");

        // Create a TOTP generator
        var totp = new Totp(secretKey);

        // Generate a TOTP code
        var totpCode = totp.ComputeTotp();
        Console.WriteLine($"TOTP Code: {totpCode}");

        // Validate the TOTP code
        bool isValid = totp.VerifyTotp(totpCode, out long timeStepMatched);
        Console.WriteLine($"Is Valid: {isValid},  Time Step Matched: {timeStepMatched}");
    }
}