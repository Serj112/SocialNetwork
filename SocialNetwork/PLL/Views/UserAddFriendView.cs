using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserAddFriendView
    {
        UserService userService;
        public UserAddFriendView(UserService userService)
        {
            this.userService = new UserService();
        }

        public void Show(User user)
        {
            try
            {
                var userAddFriendData = new UserAddFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя, которого добавляете в друзья: ");

                userAddFriendData.FriendEmail = Console.ReadLine();
                userAddFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddFriendData);

                SuccessMessage.Show("Пользователь добавлен в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с указанным почтовым адресом не найден.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Ошибка при добавлении в друзья!");
            }
        }
    }
}
