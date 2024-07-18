namespace DependencyInjectionAPI.Service
{
    public class RandomNumberServices: IRandomServices
    {
        private readonly int _randumber;
        public RandomNumberServices()
        {
            var num = new Random();
            _randumber = num.Next(1, 100);
        }
        public int GetNum() => _randumber;
    }
}
