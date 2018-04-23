using System.Windows;
using DevExpress.Xpf.Map;

namespace RangeDistributions {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void factor_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e) {
            var distribution = colorizer.RangeDistribution as EquationRangeDistribution;
            if (distribution == null) return;

            distribution.Factor = (double)seFactor.Value;
        }

        private void rangeDistribution_SelectedIndexChanged(object sender, RoutedEventArgs e) {
            seFactor.IsEnabled = (rangeDistribution.SelectedItem.Equals(linear)) ? false : true;

            var distribution = colorizer.RangeDistribution as EquationRangeDistribution;
            if (distribution == null) return;

            seFactor.Value = (decimal)distribution.Factor;
        }
    }
}