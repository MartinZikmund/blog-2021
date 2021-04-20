using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace UnoWasmGoogleMaps.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new UnoWasmGoogleMaps.App(), args);
            host.Run();
        }
    }
}
