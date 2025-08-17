using mcp2221_dll_m;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
using System.Diagnostics;

namespace MCP2221A
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int DEFAULT_VID = 0x04D8;
        const int DEFAULT_PID = 0x00DD;
        static int result = 0;
        static uint numberOfDevices = 0;

        public MainWindow()
        {
            InitializeComponent();

            String libVersion = MCP2221.M_Mcp2221_GetLibraryVersion();

            result = MCP2221.M_Mcp2221_GetConnectedDevices(DEFAULT_VID, DEFAULT_PID, ref numberOfDevices);
            if (result == MCP2221.M_E_NO_ERR)
            {
                Debug.WriteLine($"Number of connected devices: {numberOfDevices}");
            }
        }
    }
}
