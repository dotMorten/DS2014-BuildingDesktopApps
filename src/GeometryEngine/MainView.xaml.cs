﻿using Esri.ArcGISRuntime.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GeometryEngine
{
	public partial class MainView : Window
	{
		public MainView()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}