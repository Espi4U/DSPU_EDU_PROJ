using DSPU_EDU_PROJ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace DSPU_EDU_PROJ
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public NameIndexModel Selected_Ir { get; set; }

        public NameIndexModel Selected_If { get; set; }

        public NameIndexModel Selected_Is { get; set; }

        public List<NameIndexModel> Ir { get; set; }

        public List<NameIndexModel> If { get; set; }

        public List<NameIndexModel> Is { get; set; }

        public double N_srfk { get; set; }

        public double N_srfkj { get; set; }

        public double P_srfkj { get; set; }

        public double FZVD { get; set; }

        public double Q_srfkj { get; set; }

        public double Q_srfk { get; set; }

        public double T_d { get; set; }

        public double Z_d { get; set; }

        public double Z_v { get; set; }

        public double T_v { get; set; }

        public double S { get; set; }

        public double R { get; set; }

        public double F { get; set; }

        public double K { get; set; }

        public double J { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Ir = Data.Ir;
            If = Data.If;
            Is = Data.Is;

            Selected_Ir = Ir.FirstOrDefault();
            Selected_If = If.FirstOrDefault();
            Selected_Is = Is.FirstOrDefault();
        }

        private double CalcFZSP_srfk(double m_srfk, double m)
        {
            var result = FZVD * (m_srfk / m);
            return result;
        }

        private double CalcM_srfk()
        {
            var result = N_srfk * Selected_Is.Index * Selected_Ir.Index * Selected_If.Index;
            return result;
        }

        private double CalcFZVDK_srfkj(double fzsp_srfk)
        {
            var result = fzsp_srfk * (Q_srfkj / Q_srfk) * (N_srfkj / N_srfk) * P_srfkj;
            return result;
        }

        private double CalcT_v(double fzvdk)
        {
            var result = (fzvdk - T_d * Z_d) / Z_v;
            return result;
        }

        private double CalcFZVDK_srfk(double fzvdk_srfkj)
        {
            var sum = fzvdk_srfkj;
            var currPlus = fzvdk_srfkj;

            for (int i = 0; i < J; i++)
            {
                sum += currPlus;
            }

            return sum;
        }

        private double CalcBy_KFRS(double val)
        {
            var sum = val;
            var currPlus = val;

            for(int i = 0; i < K; i++)
            {
                sum += currPlus;
            }
            currPlus = sum;
            for(int i=0; i < F; i++)
            {
                sum += currPlus;
            }
            currPlus = sum;
            for (int i = 0; i < R; i++)
            {
                sum += currPlus;
            }
            currPlus = sum;
            for (int i = 0; i < S; i++)
            {
                sum += currPlus;
            }

            return sum;
        }

        // OnPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var m_srfk = CalcM_srfk();

            var m = CalcBy_KFRS(m_srfk);

            var fzsp_srfk = CalcFZSP_srfk(m_srfk, m);

            var fzvdk_srfkj = CalcFZVDK_srfkj(fzsp_srfk);

            var fzvdk_srfk = CalcFZVDK_srfk(fzvdk_srfkj);

            var fzvdk = CalcBy_KFRS(fzvdk_srfk);

            var res = CalcT_v(fzvdk);
            T_v = Math.Round(res, 2);

            OnPropertyChanged(nameof(T_v));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int res = 0;
            var result = int.TryParse(textBox.Text, out res);
            if (result)
            {
                textBox.Text = res.ToString();
                textBox.SelectionStart = textBox.Text.Length;
            }
            else
            {
                textBox.Text = "0";
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
