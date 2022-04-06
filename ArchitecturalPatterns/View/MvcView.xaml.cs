using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArchitecturalPatterns.View
{
    public partial class MvcView : Page
    {
        public MvcView()
        {
            InitializeComponent();
            _model = new Model();
        }

        private readonly Model _model;


        private void Button_Save(object sender, RoutedEventArgs e)
        {
            _model.Value = TextBox_Input.Text;
            Label_Value.Content = _model.Value;
        }


        private void Button_Load(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = _model.Value;
        }
    }
}
