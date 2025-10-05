using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Iphone meuIphone = new Iphone("1234-5678", "iPhone 14", "111222333");
        Nokia meuNokia = new Nokia("9876-5432", "Nokia 3310", "444555666");

        meuIphone.Ligar();
        meuIphone.InstalarAplicativo("WhatsApp");

        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Snake");
    }
}
