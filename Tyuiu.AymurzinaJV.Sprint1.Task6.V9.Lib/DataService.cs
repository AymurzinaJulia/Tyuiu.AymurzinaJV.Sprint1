using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AymurzinaJV.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string res = "";
            string[] sep = value.Split(' ');
            foreach (string s in sep)
            {
                string ans = s[s.Length - 1] + s;
                string ans1 = ans.Remove(ans.Length - 1);
                res += " " + ans1;
            }
            return res.Trim();

        }
    }
}
