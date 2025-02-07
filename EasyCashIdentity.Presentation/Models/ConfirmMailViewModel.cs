using System.Reflection.Metadata.Ecma335;

namespace EasyCashIdentity.Presentation.Models
{
    public class ConfirmMailViewModel
    {
        public string Mail { get; set; }
        public int ConfirmCode { get; set; }
    }
}
