using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Snake
{
    public class Users
    {
        public string username;
        public static int rate;

        public Users()
        {

        }

        public Users(string username)
        {
            this.username = username;
        }

        public static void Rate()
        {
            rate++;
            Text.WriteText("Очки: " + rate, 81, 1);

        }
        public static void ScoresSave(string name, int score)
        {
            string text;
            StreamWriter use = new StreamWriter(@"..\..\..\Users.txt", true);
            text = score + " " + name;
            use.WriteLine(text);
            use.Close();
        }

        public static void ShowRate(int xOffset, int yOffset)
        {
            using (StreamReader usefrom = new StreamReader(@"..\..\..\Users.txt"))
            {
                List<string> list = new List<string>();
                list = File.ReadAllLines(@"..\..\..\Users.txt").ToList();
                var sortedUsers = from u in list
                                  orderby u descending
                                  select u;
                foreach (var u in sortedUsers)
                {
                    Text.WriteText(u, xOffset, yOffset++);
                }
            }
        }
    }
}
