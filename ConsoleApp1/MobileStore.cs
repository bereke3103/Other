namespace ConsoleApp1
{
    public class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        public void Process()
        {
            //Ввод данных
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену:");

            //ВАЛИДАЦИЯ
            bool result = int.TryParse(Console.ReadLine(), out var price);

            if (result == false || price <= 0 || string.IsNullOrEmpty(model))
            {
                throw new Exception("Некорректно были введен данные");
            }
            else
            {
                phones.Add(new Phone(model, price));
                using (StreamWriter stream = new StreamWriter("store.txt", true))
                {
                    stream.WriteLine(model);
                    stream.WriteLine(price);
                }
                Console.WriteLine("Данные успешно обработаны");
            }
        }
    }


}
