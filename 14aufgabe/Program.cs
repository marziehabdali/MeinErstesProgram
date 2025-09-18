class BankkontoTest
{
    static void Main()
    {
        // حساب با مقدار اولیه و نام صاحب حساب
        Bankkonto konto = new Bankkonto("Max Schmidt", 1000, 0.015);

        // اطلاعات اولیه حساب
        konto.KontoInfoAnzeigen();

        // عملیات ساده
        konto.Einzahlen(500);
        konto.Abheben(200);
        konto.ZinsenGutschreiben();

        // نمایش اطلاعات و تراکنش‌ها
        konto.KontoInfoAnzeigen();
        konto.TransaktionshistorieAnzeigen();

        Console.ReadKey();
    }
}

