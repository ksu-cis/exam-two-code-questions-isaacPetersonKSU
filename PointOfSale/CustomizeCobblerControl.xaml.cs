using ExamTwoCodeQuestions.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        private void Blueberry_Checked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Cobbler)
            {
                ((Cobbler)DataContext).Fruit = FruitFilling.Blueberry;
            }
        }

        private void Cherry_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler)
            {
                ((Cobbler)DataContext).Fruit = FruitFilling.Cherry;
            }
        }

        private void Peach_Checked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler)
            {
                ((Cobbler)DataContext).Fruit = FruitFilling.Peach;
            }
        }
    }
}
