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
using System.Windows.Shapes;

namespace Translator.SyntaxAnalyser.AscendingAnalysis
{
    /// <summary>
    /// Interaction logic for ParsingTableWindows.xaml
    /// </summary>
    public partial class ParsingTableWindows : Window
    {
        public ParsingTableWindows(System.Collections.IEnumerable enumerable)
        {
            InitializeComponent();

            ParsingTable.ItemsSource = enumerable;
        }

        public ParsingTableWindows(List<Snap> snapList)
        {
            InitializeComponent();

            ParsingTable.ItemsSource = snapList;
        }
    }
}
