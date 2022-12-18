Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace RangeDistributions

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub factor_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            Dim distribution = TryCast(Me.colorizer.RangeDistribution, EquationRangeDistribution)
            If distribution Is Nothing Then Return
            distribution.Factor = CDbl(Me.seFactor.Value)
        End Sub

        Private Sub rangeDistribution_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.seFactor.IsEnabled = If(Me.rangeDistribution.SelectedItem.Equals(Me.linear), False, True)
            Dim distribution = TryCast(Me.colorizer.RangeDistribution, EquationRangeDistribution)
            If distribution Is Nothing Then Return
            Me.seFactor.Value = CDec(distribution.Factor)
        End Sub
    End Class
End Namespace
