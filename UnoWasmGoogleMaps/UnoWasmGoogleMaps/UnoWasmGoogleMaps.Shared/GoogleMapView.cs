#if __WASM__
using System;
using Uno.UI.Runtime.WebAssembly;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace UnoWasmGoogleMaps
{
    [HtmlElement("div")]
    public class GoogleMapView : FrameworkElement
    {
        private readonly string _mapObjectName = "map_" + Guid.NewGuid().ToString().Replace("-", "");

        public GoogleMapView()
        {            
            Background = new SolidColorBrush(Colors.Transparent);
            LoadMap();
        }

        private void LoadMap()
        {
            var javascript = $@"var {_mapObjectName} = new google.maps.Map(element, {{ center: {{lat: -34.397, lng: 150.644}}, zoom: 8 }});";

            this.ExecuteJavascript(javascript);
        }
    }
}
#endif