internal class Program
{
    private static void Main(string[] args)
    {
        //Intro();

        string sentence = "My name is Engin Demiroğ";
        var result = sentence.Length; //metnin kaç karakterden oluştuğunu verir.
        var result2 = sentence.Clone(); //aynısını alıp yeni referans oluşturur.
        sentence = "My name is Derin Demiroğ";

        bool result3 = sentence.EndsWith("ğ"); // metin "ğ" ile bitiyor mu?
        bool result4 = sentence.StartsWith("My name"); // my name ile başlıyor mu

        var result5 = sentence.IndexOf("name"); // name ifadesini arar.
        var result6 = sentence.IndexOf(" "); // boşluğu arar. ilk boşlukta durur.
        var result7 = sentence.LastIndexOf(" "); //karakteri sondan aramaya başlar.
        var result8 = sentence.Insert(0, "Hello, ");// metin yerleştir.
        var result9 = sentence.Substring();// metni parçalar.
        var result10 = sentence.ToLower();//bütün karakterleri küçük harfe çevirir.
        var result11 = sentence.ToUpper();//büyük harfe çevirir.
        var result12 = sentence.Replace(" ", "-");// örn: metindeki boşluklar yerine çizgi koyar.
        var result13 = sentence.Remove();//belli bir indexten sonrasını atar.

          Console.WriteLine(result7);
        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "Ankara";
        //Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "İstanbul";
        //string result = city + city2;
        //Console.WriteLine(result);

        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}