namespace Tasks
{
    public class Person
    {
        // ППоле
        private int pole;

        // Конструктор класса
        public Person(int pole)
        {
            this.pole = ++pole;
            Console.WriteLine("Вызван конструктор");
        }

        // Стаатический конструктор
        static Person()
        {
            Console.WriteLine("Вызван статический конструктор");
        }

        // Метод
        public void Method()
        {
            Console.WriteLine($"Поле равно: {pole}" );
        }

    }
}
