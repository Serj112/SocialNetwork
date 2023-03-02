using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var registrationData = new UserRegistrationData();

            Console.WriteLine("Для создания профиля введите ваше имя:");
            registrationData.FirstName = Console.ReadLine();

            Console.WriteLine("Ваша фамилия:");
            registrationData.LastName = Console.ReadLine();

            Console.WriteLine("Введите почтовый адрес:");
            registrationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            registrationData.Password = Console.ReadLine();

            try
            {
                userService.Register(registrationData);

                SuccessMessage.Show("Ваш профиль успешно создан. Теперь Вы можете войти в систему под своими учетными данными.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при регистрации.");
            }
        }
    }
}
