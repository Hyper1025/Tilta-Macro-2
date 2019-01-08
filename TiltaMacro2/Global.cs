using System.Windows.Controls;
using System.Windows.Input;

namespace TiltaMacro2
{
    public class Global
    {
        public static Grid GlobalGridPrincipal { get; set; }
        public static bool StatusConfigurando { get; set; } = false;
        public static Key EditandoKey { get; set; } = Key.None;
        public static Button EngrenagemButton { get; set; }
        public static Button CasinhaButton { get; set; }
    }
}
