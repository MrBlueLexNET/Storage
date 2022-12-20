using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

namespace Storage.Models
{
    
    public enum Classification
    {
        None = 0, Dog = 1, Cat = 2, Bird = 4, Rodent = 8,
        Reptile = 16, Other = 32
    };
}
