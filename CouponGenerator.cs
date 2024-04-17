namespace CouponGenerators;

public class CouponGenerator
{
    private const string Characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private readonly Random _random = new Random();

    public Coupon GenerateCoupon(decimal balance)
    {
        string code = GenerateCode();
        return new Coupon { Code = code, Balance = balance };
    }

    private string GenerateCode()
    {
        char[] code = new char[10];
        for (int i = 0; i < code.Length; i++)
        {
            code[i] = Characters[_random.Next(Characters.Length)];
        }
        return new string(code);
    }
}