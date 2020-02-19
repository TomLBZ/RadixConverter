using System;
using System.Windows.Forms;

namespace RedixConverter
{
    public partial class RadixConverter : Form
    {
        public RadixConverter()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RadixNumber number = new RadixNumber(txtInput.Text, txtInRadix.Text, txtOriginalEncoding.Text);
                number.PreConvert(Convert.ToInt32(txtCutoffdp.Text), Convert.ToInt32(txtTargetRadix.Text), txtTargetEncoding.Text);
                txtResult.Text = number.Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class RadixNumber
    {
        private bool pre = false;
        public int IntValue { get; private set; }
        public double DpValue { get; private set; }
        public double Value
        {
            get { return DpValue + IntValue; }
            set
            {
                IntValue = value > 0 ? (int)Math.Floor(value) : (int)Math.Ceiling(value);
                DpValue = value - IntValue;
            }
        }
        public int TargetRadix { get; set; }
        public string TargetEncoding { get; set; }
        public int Cutoffdp { get; set; }
        public double NumberResult
        {
            get
            {
                if (!pre) { return double.NaN; }
                if (TargetRadix <= 10)
                {
                    return Convert.ToDouble(Result);
                }
                else
                {
                    return double.NaN;
                }           
            }
        }
        public string Result
        {
            get
            {
                if (pre)
                {
                    return RadixConvert();
                }
                else
                {
                    return "Lacking Pre-Convert Information.";
                }
            }
        }
        public RadixNumber(double InputValue, int FromRadix, string FromEncoding = "0123456789ABCDEF")
        {
            LoadNumber(Convert.ToString(InputValue), FromRadix, FromEncoding);
        }
        public RadixNumber(string InputValue, string FromRadix, string FromEncoding = "0123456789ABCDEF")
        {
            LoadNumber(InputValue, Convert.ToInt32(FromRadix), FromEncoding);
        }
        public void LoadNumber(string Number, int Radix, string FromEncoding = "0123456789ABCDEF")
        {
            if (FromEncoding.Length < Radix)
            {
                throw new Exception("Error: Encoding Length is shorter than the Radix.");
            }
            bool isMinus = false;
            double output = 0.0;
            if (Number[0]=='-')
            {
                Number = Number.Remove(0, 1);
                isMinus = true;
            }
            if (!Number.Contains("."))
            {
                Number += ".0";
            }
            string[] spNum = Number.Split('.');
            for (int i = spNum[0].Length-1; i >= 0; i--)
            {
                output += FromEncoding.IndexOf(spNum[0][i]) * Math.Pow(Radix, spNum[0].Length - 1 - i);
            }
            for (int i = spNum[1].Length-1; i >= 0; i--)
            {
                output += FromEncoding.IndexOf(spNum[1][i]) * Math.Pow(1.0 / Radix, i + 1);
            }
            Value = isMinus ? -output : output;
        }
        public void PreConvert(int Cutoff_dp, int Target_Radix, string Target_Encoding = "0123456789ABCDEF")
        {
            Cutoffdp = Cutoff_dp;
            TargetRadix = Target_Radix;
            TargetEncoding = Target_Encoding;
            pre = true;
        }
        private string RadixConvert()
        {
            if (TargetEncoding.Length < TargetRadix)
            {
                throw new Exception("Error: Encoding Length is shorter than the Radix.");
            }
            bool isMinus = (IntValue < 0);
            string output = radix_int(Math.Abs(IntValue), TargetRadix);
            output += ".";
            output += radix_decimal(Math.Abs(DpValue), TargetRadix, Cutoffdp);
            return isMinus ? "-" + output : output;
        }
        private string RadixEncode(int digit)
        {
            return Convert.ToString(TargetEncoding[digit]);
        }
        private string radix_int(int num, int radix)
        {
            if (num < radix) { return RadixEncode(num); }
            int rem = num % radix;
            return radix_int((num - rem) / radix, radix) + RadixEncode(rem);
        }
        private string radix_decimal(double num, int radix, int cutoff)
        {
            if (cutoff == 0) { return ""; }
            double timed = num * radix;
            int i = (int)Math.Floor(timed);
            double dec = timed - i;
            return RadixEncode(i) + radix_decimal(dec, radix, cutoff - 1);
        }
    }
}
