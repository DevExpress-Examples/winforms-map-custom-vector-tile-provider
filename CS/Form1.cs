using DevExpress.XtraMap;
using System.IO;
using System.Windows.Forms;

namespace WinFormsMap {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            var layer = new ImageLayer();
            var provider = new CustomVectorTileStreamProvider();

            layer.DataProvider = provider;
            mapControl1.Layers.Add(layer);
        }
    }
    public class CustomVectorTileStreamProvider : VectorTileDataProviderBase {
        public override Stream GetStream(long x, long y, long level) {
            string path = Path.GetFullPath("..\\..\\Data\\test.data");
            return File.OpenRead(path);
        }
    }
}
