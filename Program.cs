try
{
    var a = "Ali";
    Console.WriteLine(int.Parse(a));
    Console.WriteLine("İşlem Başarı İle Sonuçlandı");
}
catch (Exception ex)
{
    Console.WriteLine("İşlemde " + ex.Message + " hatası oluştu.");
}
finally
{
    Console.WriteLine("İşlem sona erdi");
    Console.ReadLine();
}