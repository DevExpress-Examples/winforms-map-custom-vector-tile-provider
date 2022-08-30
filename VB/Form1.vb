Imports DevExpress.XtraMap
Imports System.IO
Imports System.Windows.Forms

Namespace WinFormsMap

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim layer = New ImageLayer()
            Dim provider = New CustomVectorTileStreamProvider()
            layer.DataProvider = provider
            mapControl1.Layers.Add(layer)
        End Sub
    End Class

    Public Class CustomVectorTileStreamProvider
        Inherits VectorTileDataProviderBase

        Public Overrides Function GetStream(ByVal x As Long, ByVal y As Long, ByVal level As Long) As Stream
            Dim path As String = System.IO.Path.GetFullPath("..\..\Data\test.data")
            Return File.OpenRead(path)
        End Function
    End Class
End Namespace
