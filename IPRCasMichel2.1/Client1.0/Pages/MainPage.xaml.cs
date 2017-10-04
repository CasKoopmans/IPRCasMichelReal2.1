﻿using Client1._0.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Client1._0
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();   
            HamburberBox.SelectedItem = Home;
            ContentFrame.Navigate(typeof(HomePage), this);
        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            Split.IsPaneOpen = !Split.IsPaneOpen;
        }

        private void HamburgerBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected) ContentFrame.Navigate(typeof(HomePage), this);
            else if (Doctor.IsSelected) ContentFrame.Navigate(typeof(DoctorPage), this);
            else if (Session.IsSelected) ContentFrame.Navigate(typeof(SessionPage), this);
        }
    }
}
