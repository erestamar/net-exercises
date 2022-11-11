using UserLoginOperation_Test.Models;
using UserLoginOperation_Test.Repo;

namespace UserLoginOperation_Test.View
{
    public class UserConsoleView
    {
        public static void Input()
        {
            Console.WriteLine("Введите номер операции: \n 1 - Создать аккаунт; \n 2 - Удалить Аккаунт \n 3 - Вывести информацию об всех имеющихся аккаунтах \n 4 - Найти инфо об аккаунте");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: InputForCreation(); break;
                case 2: InputForDelete(); break;
            }
        }

        private static void InputForCreation()
        {
            try
            {
                Console.WriteLine("Введите через пробел информацию: Логин Пароль Емайл");
                string userInfo = Console.ReadLine();
                var listOfUserInfo = userInfo.Split(" ");

                var user = new User
                {
                    UserLogin = listOfUserInfo[0],
                    UserPassword = listOfUserInfo[1],
                    UserEmail = listOfUserInfo[2]
                };


                var repo = new UserRepo();
                repo.ValidateUserLogin(listOfUserInfo[0]);
                repo.Create(user);
                Console.WriteLine($"Аккаунт {user.UserLogin} успешно добавлен");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }
        }
        private static void InputForDelete()
        {
            try
            {
                Console.WriteLine("Введите login Клиента, чей аккаунт хотите удалить: ");
                string userLogin = Console.ReadLine();
                var repo = new UserRepo();
                var userId = repo.GetIdByLogin(userLogin);
                repo.Delete(userId);
                Console.WriteLine($"Аккаунт {userLogin} успешно удалён");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка {ex.Message}");
            }
        }
    }
}
