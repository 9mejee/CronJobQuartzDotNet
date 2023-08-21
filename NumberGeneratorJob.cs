using Quartz;

namespace QuartzSample
{
    public class NumberGeneratorJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Your # is: {RandomNumber(1000000, 999999999)}");
            await Task.CompletedTask;
        }

        private int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }
    }
}