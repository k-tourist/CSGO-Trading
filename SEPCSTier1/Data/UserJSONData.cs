using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEPCSTier1.Graphql;
using SEPCSTier1.Models;
using StrawberryShake;

namespace SEPCSTier1.Data
{
    public class UserJSONData : IUserData
    {
        private GraphqlClient graphqlClient;
        private List<User> userList = new List<User>();


        public UserJSONData(GraphqlClient graphqlClient)
        {
            this.graphqlClient = graphqlClient;
        }


        public async void RemoveAccount(long UserId)
        {
            await graphqlClient.DeleteUser.ExecuteAsync(UserId);
        }

        public async Task<IList<User>> GetUsers()
        {
            var result = await graphqlClient.GetUsers.ExecuteAsync();

            userList = result.Data.Users.Select(users => new User
            {
                id = users.Id,
                username = users.Username,
                password = users.Password
            }).ToList();

            return userList;
        }

        public async Task<User> ValidateUser(string userName, string passWord)
        {
           
                var result = await graphqlClient.ValidateUser.ExecuteAsync(userName, passWord);

                if (result.IsErrorResult())
                {
                    throw new Exception("User not found");
                }

                User user = new User
                {
                    username = result.Data.ValidateUser.Username,
                    password = result.Data.ValidateUser.Password
                };
                
                return user;
                
        }

        public async void AddUser(User user)
        {
            await graphqlClient.AddUser.ExecuteAsync(user.username, user.password);
        }
    }
}