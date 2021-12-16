using AW.MathHelpers.Interfaces;

namespace AW.MathHelpers.Services
{
  public class RandomNumberService : IRandomNumberService
  {
    public int[] GetRandom(int min = 1, int max = 100, int take = 5)
    {
      var rnd = new Random();
      var randomNumbers = Enumerable.Range(min, max)
                                    .OrderBy(x => rnd.Next())
                                    .Take(take)
                                    .ToArray();
      return randomNumbers;
    }

    public int[] GetRandom(int[] numbers, int take = 5)
    {
      var rnd = new Random();
      var randomNumbers = numbers.OrderBy(x => rnd.Next())
                                 .Take(take)
                                 .ToArray();
      return randomNumbers;
    }
  }
}
