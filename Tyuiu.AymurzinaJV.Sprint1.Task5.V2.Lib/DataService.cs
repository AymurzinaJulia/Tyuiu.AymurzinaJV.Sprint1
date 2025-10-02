using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AymurzinaJV.Sprint1.Task5.V2.Lib

{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            var res = (temp - 32) / 1.8;
            return Convert.ToInt32(res);
        }
    }
}
