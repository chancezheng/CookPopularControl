﻿using System;
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

namespace TestDemo.Demos
{
    /// <summary>
    /// ScrollViewerDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ScrollViewerDemo : UserControl
    {
        public ScrollViewerDemo()
        {
            InitializeComponent();

            new Button().Click += ScrollViewerDemo_Click;
        }

        private void ScrollViewerDemo_Click(object sender, RoutedEventArgs e)
        {
            
            //(sender as Button).Command.Execute()
        }
    }
}
