using System;

namespace OOP6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            treug proverka1 = new treug(666, 666, 666);
            proverka1.Display();
            treug proverka2 = new treug(20, 15, 15);
            proverka2.Display();
            treug proverka3 = new treug(666, 0, 0);
            proverka3.Display();
            Console.ReadKey();
        }
    }
}
class treug
{
    private bool status;
    private double storona1;
    private double storona2;
    private double storona3;
    public treug(int l1, int l2, int l3)
    {
        storona1 = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
        storona2 = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
        storona3 = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);
        if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
        {
            status = true;

        }
        else
        {
            status = false;
        }
    }
    public void Display()

    {
        if (status == true)
        {
            Console.WriteLine($"\nКоординаты треугольника: \n" +$"Первая сторона: {storona1.ToString("##.#")}" +$"\nВторая сторона : {storona2.ToString("##.#")}" +$"\nТретья сторона: {storona3.ToString("##.#")}");
        }
        else
            Console.WriteLine("\nДанные введены не верно");
    }
}
