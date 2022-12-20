using static System.Net.WebRequestMethods;
using System.Text.RegularExpressions;

namespace Storage.Models
{
    
    public enum Classification
    {
        None = 0, Explosive = 1, Compressed = 2, Pressurized = 4, Flammable = 5,
        Infectious = 6, Radioactive = 7,  Other = 32
    };
}
