Console.Title = "VKI (vücut kitle indeksi) hesaplama";
VKIHesapla();

void TekrarHesapMi()
{
    Console.Write("Yeni bir hesaplama yapmak istiyor musunuz ? (E / H)");
    string tamamDevam=Console.ReadLine().ToLower();
    if (tamamDevam == "e") { 
        Console.Clear();
        VKIHesapla();
    }
    else if(tamamDevam=="h")
        Environment.Exit(0);
    else
    {
        TekrarHesapMi();
    }
}

string VKISiniflandir(double vki)
{
    if (vki >= 25 && vki < 30)
        return "HAFIF KILOLU";
    else if (vki >= 18.5 && vki < 25)
        return "IDEAL";
    else if (vki >= 30)
        return "OBEZ";
    else if (vki < 18.5)
        return "ZAYIF";
    return "";
}

void VKIHesapla()
{
    var vucutOlculeri= BoyKiloAl();
    double vki = vucutOlculeri.kilo / (vucutOlculeri.boy/100 * vucutOlculeri.boy/100);
    Console.WriteLine("Hastanın boyu: " + vucutOlculeri.boy + "cm\tkilosu: " + vucutOlculeri.kilo + "kg\t" +
        "VKI indeksi: " + Math.Round(vki, 2)+ "\tTeşhis: " + VKISiniflandir(vki));
    TekrarHesapMi();
}

static (double boy,double kilo) BoyKiloAl()
{
    Console.Clear();
    Console.Write("Hastanin boyu (cm): ");
    double boy = Convert.ToDouble(Console.ReadLine());
    Console.Write("Hastanin kilosu (kg): ");
    double kilo = Convert.ToDouble(Console.ReadLine());
    return (boy, kilo);
}