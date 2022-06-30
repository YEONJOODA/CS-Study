using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.총정리
{
    class User
    {
        private string uid;
        private string name;
        private int age;
        private bool isMarried;

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool IsMarried { get => isMarried; set => isMarried = value; }

        public User(string uid, string name, int age, bool isMarried)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
            this.isMarried = isMarried;
        }

        public override string ToString()
        {
            return $"아이디 : {uid}, 이름 : {name}, 나이 : {age}, 결혼여부 : {isMarried}";
        }
    }

    class UserHashTable
    {
        private Hashtable users;

        public UserHashTable()
        {
            users = new Hashtable();
        }

        public void AddUser(User user)
        {
            users.Add(user.Uid, user);
        }

        public bool RemoveUser(string uid)
        {
            if (users.ContainsKey(uid))
            {
                users.Remove(uid);
                return true;
            }

            Console.WriteLine("아이디 '{0}'가 존재하지 않습니다.", uid);
            return false;
        }

        public void ShowAllUsers()
        {
            foreach (User user in users.Values)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", user.Uid,
                                                        user.Name,
                                                        user.Age,
                                                        user.IsMarried);
            }
        }
    }

    internal class _4_10
    {
        static void Main10(string[] args)
        {
            UserHashTable ht = new UserHashTable();

            User user1 = new User("a101", "김유신", 23, false);
            User user2 = new User("a102", "김춘추", 21, false);
            User user3 = new User("a103", "장보고", 31, true);
            User user4 = new User("a104", "강감찬", 42, false);
            User user5 = new User("a105", "이순신", 53, true);

            ht.AddUser(user1);
            ht.AddUser(user2);
            ht.AddUser(user3);
            ht.AddUser(user4);
            ht.AddUser(user5);

            ht.RemoveUser("kim");
            ht.RemoveUser("a103");

            ht.ShowAllUsers();
        }
    }
}
