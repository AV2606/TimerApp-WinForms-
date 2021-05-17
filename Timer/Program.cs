using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Timer());
        }
    }
    static class Values
    {
        public static readonly Color background_point1_color = Color.Black;
        public static readonly Color background_point2_stopper_color = Color.FromArgb(255, 0, 0, 25);
        public static readonly Color background_point2_timer_color = Color.FromArgb(255, 25, 0, 25);
        public static readonly Color start_button_color = Color.Green;
        public static readonly Color pause_button_color = Color.DarkOrange;
        public static readonly Color continue_button_color = Color.Cyan;
        public static readonly Color odd_lap_label_color =Color.CornflowerBlue;
        public static readonly Color even_lap_label_color = Color.DarkCyan;
        public static readonly Color _5th_lap_label_color = Color.MediumVioletRed;
        public static readonly Color _10th_lap_label_color = Color.MediumPurple;
        public static readonly Font lap_label_font = new Font("Arial Rounded MT Bold", 11);
        public static readonly string start_button_text = "Start";
        public static readonly string pause_button_text = "Pause";
        public static readonly string continue_button_text = "Continue";
        public static readonly Color unselected_stopper_layout_button_color = Color.Plum;
        public static readonly Color selected_timer_layout_button_color = Color.Chocolate;
        public static readonly Color selected_stopper_layout_button_color = Color.MediumOrchid;
        public static readonly Color unselected_timer_layout_button_color = Color.Peru;
    }
}
