using System.ComponentModel.Design;

bool oduncteMi = false;
Console.WriteLine("Ödünç almak istediğiniz süreyi gün olarak girin");
string? giris = Console.ReadLine();
if (!int.TryParse(giris, out int gun) || gun < 1 || gun > 7)
{
    Console.WriteLine("Talep uygun değil, 1 ve 7 arasında sayı girin.");
}
else if(oduncteMi)
{
    Console.WriteLine("Zaten ödünçte, talep reddedildi.");
}
else
{
    Console.WriteLine("Ödünç verilebilir.");
}