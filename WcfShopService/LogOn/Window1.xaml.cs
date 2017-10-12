using LogOn.ServiceReference1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace LogOn
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        OpenFileDialog dialog = new OpenFileDialog();
        byte[] bytes;
        Service1Client channel;
        public Window1(Service1Client channel)
        {
            InitializeComponent();
            this.channel = channel;
        }

        private void browseButton_Click(object sender, RoutedEventArgs e)
        {
            if (dialog.ShowDialog() == true)
            {
                textBox.Text = dialog.FileName;
                bytes = File.ReadAllBytes(dialog.FileName);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<byte[]> file;
            try
            {
                if (bytes.Length <= 20000000)
                {
                    file = new List<byte[]>();
                    file.Add(bytes);
                }
                else file = bytesToPack(bytes);
                for (int i = 0; i < file.Count; i++)
                    channel.SaveFile(file[i], System.IO.Path.GetFileName(dialog.FileName));
                channel.SaveToFile(System.IO.Path.GetFileName(dialog.FileName));


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        List<byte[]> bytesToPack(byte[] from)
        {
            List<byte[]> file = new List<byte[]>();
            byte[] tmp = new byte[20000000];
            for(int i = 0,j=0; i < from.Length; i++,j++)
            {
                tmp[j] = from[i];
                if (j == tmp.Length - 1)
                {
                    file.Add(tmp);
                    j = -1;
                    if(from.Length-i< 20000000) tmp = new byte[from.Length - i];
                    else  tmp = new byte[20000000];
                }
            }

            file.Add(tmp);
            return file;
        }
        
    }
}
