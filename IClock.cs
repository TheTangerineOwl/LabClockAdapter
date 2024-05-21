// Паттерн Адаптер для класса. Решение на языке C#
using System;
using static System.Console;

namespace Clock
{
    // Адаптирует класс Adaptee к интерфейсу IClock через промежуточный класс Adapter
    // Інтерфейс IClock
    interface IClock
    {
        public void GetTime();
        public void TickMin(int min);
    }
    // Класс, метод которого нужно адаптировать к другой системе.
    // В данном случае адаптируется имя метода PrintTime() в метод GetTime()
    //class Adaptee
    //{
    //    // Некоторый специфический метод
    //    public void PrintTime()
    //    {
    //        WriteLine("Adaptee.PrintTime()");
    //    }
    //}
    //// Класс Adapter - реализует интерфейс IClock и наследует класс Adaptee
    //class Adapter : Adaptee, IClock
    //{
    //    // Реализация метода GetTime() интерфейса IClock
    //    public void GetTime()
    //    {
    //        // В середине метода вызывается метод PrintTime() класса Adaptee()
    //        PrintTime();
    //    }
    //}
    // Класс Client - получает ссылку на интерфейс IClock
    //class Client
    //{
    //    // некоторый метод класса Client
    //    public void TellTime(IClock clock)
    //    {
    //        clock.GetTime();
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Демонстрация паттерна Adapter для класса.
    //        // Задание.
    //        // Нужно адаптировать экземпляр класса Adaptee к потребностям экземпляра класса Client.
    //        // 1 Создать экземпляр класса Client
    //        Client client = new Client();
    //        // 2 Создать экземпляр класса Adapter, который ссылается на интерфейс IClock
    //        IClock clock = new Adapter();
    //        // 3 Передать клиенту clock
    //        client.TellTime(clock);
    //    }
    //}
}