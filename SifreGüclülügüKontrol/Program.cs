Console.Write("Şifrenizi girin: ");
string sifre = Console.ReadLine();

if (sifre.Length <= 8)
{
    Console.WriteLine("Hata: Şifre en az 8 karakter olmalıdır!");
    return;
}

if (!(sifre.Contains("%") || sifre.Contains("&") || sifre.Contains("*")))
{
    Console.WriteLine("Hata: Şifre en az bir özel karakter (% , & , *) içermelidir!");
    return;
}

if (!sifre.Any(char.IsUpper))
{
    Console.WriteLine("Hata: Şifre en az bir büyük harf içermelidir!");
    return;
}

Console.WriteLine("Şifre Güçlü. Şifre başarıyla oluşturuldu.");
