using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
using SharpDX;

namespace SmackBrosClient2.DirectX
{
    class CreateDevice : Window
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CreateDevice
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CreateDevice";
            this.Load += new System.EventHandler(this.CreateDevice_Load);
            this.ResumeLayout(false);

        }

        private void CreateDevice_Load(object sender, EventArgs e)
        {

        }
    }
}
