using CouponGenerators;

CouponGenerator generator = new CouponGenerator();
Dictionary<string, decimal> valetBalances = new Dictionary<string, decimal>();

// Generate 5 coupons with random balances
for (int i = 0; i < 5; i++)
{
    Coupon coupon = generator.GenerateCoupon(GenerateRandomBalance());
    valetBalances.Add(coupon.Code, coupon.Balance);
    Console.WriteLine($"Coupon Code: {coupon.Code}, Balance: {coupon.Balance:C}");
}

// Simulate applying coupons to valet balances
string appliedCouponCode = "ABC123";
if (valetBalances.ContainsKey(appliedCouponCode))
{
    decimal appliedBalance = valetBalances[appliedCouponCode];
    Console.WriteLine($"Applied coupon code: {appliedCouponCode}, Balance applied: {appliedBalance:C}");
}
else
{
    Console.WriteLine($"Coupon code {appliedCouponCode} not found.");
}

private static decimal GenerateRandomBalance()
{
    // Generate random balance between $10 and $100
    return Math.Round((decimal)(10 + new Random().NextDouble() * (100 - 10)), 2);
}