using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        private static User _currentUser = null;
        private static List<Product> _cart = new List<Product>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ОНЛАЙН МАРКЕПЛЕЙС");
                if (_currentUser == null)
                {
                    Console.WriteLine("Вы вошли как гость");
                }
                else
                {
                    Console.WriteLine($"Вы вошли как {_currentUser.Login}");
                }
                Console.WriteLine("1. Просмотр товаров");
                Console.WriteLine("2. Просмотр корзины");
                if (_currentUser == null)
                {
                    Console.WriteLine("3. Регистрация нового аккаунта");
                    Console.WriteLine("4. Вход в аккаунт.");
                }
                else
                {
                    Console.WriteLine("3. Просмотр заказов.");
                    Console.WriteLine("4. Выход из аккацнта.");
                }
                Console.WriteLine("5. Выход из программы.");
                Console.WriteLine("Выберите пункт: ");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1": ShowProducts(); break;
                    case "2": ShowCart(); break;
                    case "3": if (_currentUser == null) RegisterUser(); else ShowMyOrders(); break;
                    case "4": if (_currentUser == null) LoginUser(); else LogoutUser(); break;
                    case "5": return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }

        }
    }
}
