namespace AW.MathHelpers.Interfaces
{
  public interface IRandomNumberService
  {
    int[] GetRandom(int min = 1, int max = 100, int take = 5);
    int[] GetRandom(int[] numbers, int take = 5);
  }
}