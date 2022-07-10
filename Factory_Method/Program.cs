using System;


namespace Factory_Method
{
    internal interface ICar
    {
        string Name { get; } 
        int Speed { get;  } 
        int Price { get;  } 

        void Release();
    }
    internal class Mersedes : ICar
    {
        private readonly string _name = "Mersedes";
        private readonly int _speed = 300;
        private readonly int _price = 100000;
        public void Release()
        {
            Console.WriteLine(_name+" Speed : "+ _speed+" Price : " + _price);
        }
        public string Name { get { return _name; } }
        public int Speed { get { return _speed; } }
        public int Price { get { return _price; } }

    }
    internal class BMW : ICar
    {
        private readonly string _name = "BMW";
        private readonly int _speed = 290;
        private readonly int _price = 90000;
        public void Release()
        {
            Console.WriteLine(_name + " Speed : " + _speed + " Price : " + _price);
        }
        public string Name { get { return _name; } }
        public int Speed { get { return _speed; } }
        public int Price { get { return _price; } }
    }
    internal class Audi : ICar
    {
        private readonly string _name = "Audi";
        private readonly int _speed = 295;
        private readonly int _price = 80000;
        public void Release()
        {
            Console.WriteLine(_name + " Speed : " + _speed + " Price : " + _price);
        }
        public string Name { get { return _name; } }
        public int Speed { get { return _speed; } }
        public int Price { get { return _price; } }
    }
    internal abstract class INewCar 
    {
        public abstract ICar Create();
    }
    internal  class BMWNew : INewCar
    {
        public override ICar Create() { return new BMW();  }
    }
    internal class AudiNew : INewCar
    {
        public override ICar Create() { return new Audi(); }
    }
    internal class MersedesNew : INewCar
    {
        public override ICar Create() { return new Mersedes(); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            INewCar car = new BMWNew();
            ICar bmw = car.Create();

            car = new MersedesNew();
            ICar mersedes = car.Create();

            car = new AudiNew();
            ICar audi = car.Create();


            bmw.Release();
            mersedes.Release();
            audi.Release();


            /*
             Фабричный метод(создание класса который в свою очередь будет помогать создавать нам 
                                                определённые объекты на основании входных данных)
             Суть паттерна(когда нужно создавать множество однотипных элементов, то есть объекты с 
                                                        одинаковой структурой но разними данными)

             Фабричный метод — это порождающий паттерн проектирования, который определяет общий интерфейс 
               для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.
 
             Преимущества 
             •	 Избавляет класс от привязки к конкретным классам продуктов.
             •	 Выделяет код производства продуктов в одно место, упрощая поддержку кода.
             •	 Упрощает добавление новых продуктов в программу.
             •	 Реализует принцип открытости/закрытости.(код легко расширяемый)
             •	 Повторное использование наработаного функционала
             Недостатки
             • Может привести к созданию больших параллельных иерархий классов, так как для каждого класса продукта 
                                                                              надо создать свой подкласс создателя.
             • семейные классы
             • сильная связь с классом фабрики

             Когда надо применять паттерн
             •	Когда заранее неизвестно, объекты каких типов необходимо создавать
             •	Когда система должна быть независимой от процесса создания новых 
                объектов и расширяемой: в нее можно легко вводить новые классы, 
                объекты которых система должна создавать.
             •	Когда создание новых объектов необходимо делегировать из базового класса классам наследникам

             
             */

        }
    }
}