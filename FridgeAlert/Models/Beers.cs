using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeAlert.Api;

namespace FridgeAlert.Models;

public class Beers
{
    public static string GenerateUrlRandom()
    {
        return ApiConstants.RANDOM_BEER;
    }
}
