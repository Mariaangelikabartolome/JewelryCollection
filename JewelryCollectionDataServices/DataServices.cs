using System;
using JewelryCollection;
using System.Collections.Generic;
namespace MyJewelryCollectionDataServices
    {
        public class DataServices
        {
            List<userlogin> dummyData = new List<userlogin>();

            public DataServices()
            {
                CreateJewelryUserData();
            }

            private void CreateJewelryUserData()
            {
                userlogin Firstuser = new userlogin() { username = "Maria", password = "MariaAngelika" };
                userlogin Seconduser = new userlogin() { username = "Nina", password = "Astillero" };
                userlogin Thirduser = new userlogin() { username = "Liam", password = "Edwards" };

                dummyData.Add(Firstuser);
                dummyData.Add(Seconduser);
                dummyData.Add(Thirduser);
            }
            public userlogin GetUserLogin(string username, string password)
            {
                userlogin foundUser = new userlogin();
                foreach (var user in dummyData)
                {
                    if (user.username == username && password == user.password)
                    {
                        foundUser = user;
                    }
                }

                return foundUser;
            }

            }
        }
    

