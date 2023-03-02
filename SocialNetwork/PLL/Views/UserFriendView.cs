using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class UserFriendView
    {
        public void Show(IEnumerable<User> friends)
        {
            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас 0 друзей.");
                return;
            }
            else Console.WriteLine("Количество ваших друзей: {0}", friends.Count());

            Console.WriteLine("Информация о друзьях");

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine("Почтовый адрес друга: {0}. Имя и фамилия друга: {1} {2}", friend.Email, friend.FirstName, friend.LastName);
            });
        }
    }
}
