using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace os
{
    public partial class frmMapa : Form
    {
        frmRelatorios relatorios;
        public frmMapa()
        {
            InitializeComponent();
        }

        public frmMapa(frmRelatorios r)
        {
            InitializeComponent();
            relatorios = r;
        }
        
        private void frmMapa_Load(object sender, EventArgs e)
        {
            double lat, longi;
            var endereco = "Rua Olavo Bilac, Ibiporã";

            GeoCoderStatusCode statusCode;
            var pointLatLng = GoogleMapProvider.Instance.GetPoint(endereco, out statusCode);

            if (statusCode == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                lat = Convert.ToDouble(pointLatLng?.Lat.ToString());
                longi = Convert.ToDouble(pointLatLng?.Lng.ToString());
            }
            else
            {
                lat = -23.324297;
                longi = -51.2021166;
            }

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(lat,longi);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 14;
            map.AutoScroll = true;

            PointLatLng point = new PointLatLng(lat,longi);
            GMapMarker Marker = new GMarkerGoogle(point, GMarkerGoogleType.purple);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(Marker);
            map.Overlays.Add(markers);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            relatorios.VoltarMenu();
        }
    }
}
