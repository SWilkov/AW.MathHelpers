using AW.MathHelpers.Interfaces;
using AW.MathHelpers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AW.MathHelperTests
{
  public class RandomNumberServiceTests
  {
    private IRandomNumberService _service;
    public RandomNumberServiceTests()
    {
      _service = new RandomNumberService();
    }

    [Fact]
    public void get_correct_number_of_random_numbers()
    {
      var myNumbers = new int[] { 1, 5, 2, 7, 8, 3, 9 };
      var random = _service.GetRandom(myNumbers, 2);
      var random4 = _service.GetRandom(myNumbers, 4);
      var random6 = _service.GetRandom(myNumbers, 6);
      var random22 = _service.GetRandom(myNumbers, 22);

      Assert.Equal(2, random.Length);
      Assert.Equal(4, random4.Length);
      Assert.Equal(6, random6.Length);
      Assert.Equal(7, random22.Length); // expect 7 as myNumbers.Length = 7

      Assert.True(random.All(x => myNumbers.Contains(x)));
      Assert.True(random4.All(x => myNumbers.Contains(x)));
      Assert.True(random6.All(x => myNumbers.Contains(x)));
      Assert.True(random22.All(x => myNumbers.Contains(x)));
    }

    [Fact]
    public void min_max_is_respected_by_random_number()
    {
      int min = 1;
      int max = 10;
      int take = 3;
      var random = _service.GetRandom(min, max, take); //min 1, max 3, take 3

      Assert.Equal(3, random.Length);
      Assert.True(random.All(x => x >= min && x <= max));
    }
    
  }
}
