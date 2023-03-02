﻿using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("Введите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("Вы успешно зашли в социальную сеть!");
                SuccessMessage.Show("Добро пожаловать, " + user.FirstName);

                Program.userMenuView.Show(user);
            }

            catch (WrongPasswordException)
            {
                AlertMessage.Show("Пароль не корректный!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
        }
    }
}
