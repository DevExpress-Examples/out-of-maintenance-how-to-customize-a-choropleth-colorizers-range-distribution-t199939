Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace RangeDistributions
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub factor_EditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
            Dim distribution = TryCast(colorizer.RangeDistribution, EquationRangeDistribution)
            If distribution Is Nothing Then
                Return
            End If

            distribution.Factor = CDbl(seFactor.Value)
        End Sub

        Private Sub rangeDistribution_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            seFactor.IsEnabled = If(rangeDistribution.SelectedItem.Equals(linear), False, True)

            Dim distribution = TryCast(colorizer.RangeDistribution, EquationRangeDistribution)
            If distribution Is Nothing Then
                Return
            End If

            seFactor.Value = CDec(distribution.Factor)
        End Sub
    End Class
End Namespace