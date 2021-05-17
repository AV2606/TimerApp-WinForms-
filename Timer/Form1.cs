using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using GImage = Tools.Imageing.GenericImage;


namespace Timer
{
    public partial class Timer : Form
    {
        /// <summary>
        /// Creates an instance of the timer
        /// </summary>
        public Timer()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            StopperWatch = new Watch();
            var reset = new GImage(Width, Height);
            reset.Gradient(new Point(0, 0), Values.background_point1_color, new Point(Width, Height), Color.FromArgb(255, 25, 0, 0));
            this.reset = reset.ToBitmap();
            Hours_textbox.TextChanged += this.KeepOnlyNumbers;
            Minutes_textbox.TextChanged += this.KeepOnlyNumbers;
            Seconds_textbox.TextChanged += this.KeepOnlyNumbers;
            timer_layout_button_Click(null, null);
        }
        #region StopperRegion
        int lapCount = 0;
        Thread StopperRender;
        Watch StopperWatch;
        Bitmap reset;
        private void InitializeStopperSetup()
        {
            Text = "Stopper";
            Action Init = new Action(() =>
              {
                  GImage image = new GImage(Width, Height);
                  image.Gradient(new Point(0, 0), Values.background_point1_color, new Point { X = Width, Y = Height }, Values.background_point2_stopper_color);
                  this.BackgroundImage = image.ToBitmap();
                  Lap.Location = new Point(Lap.Location.X, (Start.Location.Y + Reset.Location.Y) / 2);
                  LapInstance.Text = "";
                  Laps.Controls.Clear();
                  StopperRender?.Abort();
                  StopperRender = new Thread(new ThreadStart(Rend));
                  StopperRender.Start();
                  Laps.ControlAdded += MaxScroll;
                  Timer_Panel.Visible = false;
                  Timer_Panel.Enabled = false;
                  Stoper_Panel.Visible = true;
                  Stoper_Panel.Enabled = true;
                  Stoper_Panel.Location = new Point(0, 0);
                  Stoper_Panel.Parent = this;
                  ChangeTimerStopperState(false);
              });
            try
            {
                this.BeginInvoke(Init);
            }
            catch(Exception)
            {
                Init.Invoke();
            }
        }
        /// <summary>
        /// moves the scroll of the <seealso cref="Laps"/> to the bottom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxScroll(object sender, EventArgs e)
        {
            Laps.AutoScrollPosition = new Point(0, Laps.VerticalScroll.Maximum);
        }
        private void TimerWindow_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// renders the time count.
        /// </summary>
        private void Rend()
        {
        Start:
            while (StopperWatch.IsTicking)
            {
                TimerWindow.Text = ToWatchFormat(StopperWatch.GetMillisecondsPast());
                Thread.Sleep(1);
            }
            TimerWindow.Text = ToWatchFormat(StopperWatch.GetMillisecondsPast());
            while (StopperWatch.IsTicking == false)
                Thread.Sleep(7);
            goto Start;
        }
        /// <summary>
        /// updates the time count for only one time.
        /// </summary>
        private void Rend1()
        {
            TimerWindow.Text = ToWatchFormat(StopperWatch.GetMillisecondsPast());
        }
        /// <summary>
        /// Convert '<paramref name="t"/>' to HH:MM:SS.mm format.
        /// </summary>
        /// <param name="t">The time in miliseconds</param>
        /// <returns></returns>
        private string ToWatchFormat(long t)
        {
            t /= 10; ;
            long mili = t % 100, sec = (t / 100) % 60, min = (t / 6000) % 60, hours = t / 360000;
            string ret = "";
            ret += HArrange(hours) + MArrange(min) + SArrange(sec) + MiArrange(mili);
            return ret;

        }
        /// <summary>
        /// arrange hours to HH:MM:SS.mm format.
        /// </summary>
        /// <param name="h">The hours</param>
        /// <returns></returns>
        private string HArrange(long h)
        {
            if (h < 10)
            {
                return "0" + h + ":";
            }
            return h + ":";
        }
        /// <summary>
        /// arranges minutes to HH:MM:SS.mm format.
        /// </summary>
        /// <param name="m">the minutes</param>
        /// <returns></returns>
        private string MArrange(long m)
        {
            if (m < 10)
            {
                return "0" + m + ":";
            }
            if (m > 60)
            {
                return (m % 60) + ":";
            }
            return m + ":";
        }
        /// <summary>
        /// arranges seconds to H:MM:SS.mm format.
        /// </summary>
        /// <param name="s">the seconds</param>
        /// <returns></returns>
        private string SArrange(long s)
        {
            if (s < 10)
            {
                return "0" + s + ".";
            }
            if (s > 60)
            {
                return (s % 60) + ".";
            }
            return s + ".";
        }
        /// <summary>
        /// arranges miliseconds to HH:MM:SS.mm format.
        /// </summary>
        /// <param name="mi">the miliseconds</param>
        /// <returns></returns>
        private string MiArrange(long mi)
        {
            if (mi < 10)
            {
                return "0" + mi;
            }
            if (mi > 100)
            {
                return (mi % 100) + "";
            }
            return mi + "";
        }

        /// <summary>
        /// Changes the start/continue button state.
        /// </summary>
        private void ChangeStartState()
        {
            if (Start.Text == Values.start_button_text)
            {
                Start.Text = Values.pause_button_text;
                Start.BackColor = Values.pause_button_color;
                return;
            }
            if (Start.Text == Values.pause_button_text)
            {
                Start.Text = Values.continue_button_text;
                Start.BackColor = Values.continue_button_color;
                return;
            }
            if (Start.Text == Values.continue_button_text)
            {
                Start.Text = Values.pause_button_text;
                Start.BackColor = Values.pause_button_color;
                return;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            lapCount = 0;
            Laps.Controls.Clear();
            StopperWatch.Reset();
            if (Start.Text == Values.continue_button_text)
            {
                Start.Text = Values.start_button_text;
                Start.BackColor = Values.start_button_color;
            }
            Rend1();
            var img = BackgroundImage;
            BackgroundImage = reset;
            this.Refresh();
            Thread.Sleep(222);
            BackgroundImage = img;
            return;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == Values.start_button_text || Start.Text == Values.continue_button_text)
            {
                StopperWatch.StartCon();
            }
            else
            {
                StopperWatch.Pause();
            }
            ChangeStartState();
        }
        private void Lap_Click(object sender, EventArgs e)
        {
            Label a = new Label
            {
                Font = Values.lap_label_font,
                ForeColor = Values.odd_lap_label_color,
                RightToLeft = RightToLeft.No,
                Name = lapCount + "  " + ToWatchFormat(StopperWatch.GetMillisecondsPast()) + "\n"
            };
            lapCount++;
            if (lapCount % 2 == 0)
                a.ForeColor = Values.even_lap_label_color;
            if (lapCount % 5 == 0)
                a.ForeColor = Values._5th_lap_label_color;
            if (lapCount % 10 == 0)
                a.ForeColor = Values._10th_lap_label_color;
            a.AutoSize = true;
            string temp = ToWatchFormat(StopperWatch.GetMillisecondsPast());
            a.Text = lapCount + "  " + temp + "\n";
            a.Visible = true;
            a.Enabled = true;
            Laps.Controls.Add(a);
        }
        #endregion
        #region TimerRegion
        bool rendering = false;
        Label TimerTimeLabel;
        Thread TimerRender;
        Watch TimerWatch;
        /// <summary>
        /// Changes the start buttons state (start, pause, continue).
        /// </summary>
        private void InitializeTimerSetup()
        {
            Text = "Timer";
            TimerWatch = new Watch();
            TimerWatch.Pause();
            Action Init=new Action(() =>
            {
                TimerRender?.Abort();
                GImage image = new GImage(Width, Height);
                image.Gradient(new Point(0, 0), Values.background_point1_color, new Point { X = Width, Y = Height }, Values.background_point2_timer_color);
                this.BackgroundImage = image.ToBitmap();
                Timer_Panel.Visible = true;
                Timer_Panel.Enabled = true;
                Timer_Panel.Location = new Point(0, 0);
                Stoper_Panel.Visible = false;
                Stoper_Panel.Enabled = false;
                CenterHorizontal(ProgressBar);
                CenterVertical(ProgressBar);
                CenterVertical(TimerWatchFLP);
                ProgressBar.Value = 0;
                TimerWatchFLP.Location = new Point
                {
                    X = TimerWatchFLP.Location.X,
                    Y = ProgressBar.Location.Y + (ProgressBar.Height - TimerWatchFLP.Height) / 2//ProgressBar.Location.Y+TimerWatchFLP.Height/2+ProgressBar.Height/2
                };
                rendering = false;
                TimerTimeLabel = new Label
                {
                    Font = TimerWindow.Font,
                    ForeColor = TimerWindow.ForeColor,
                    BackColor = TimerWindow.BackColor,
                    Location = TimerWatchFLP.Location
                };
                TimerTimeLabel.Visible = false;
                TimerTimeLabel.AutoSize = true;
                TimerTimeLabel.Enabled = false;
                Timer_Panel.Controls.Add(TimerTimeLabel);
                ChangeTimerStopperState();
            });
            try
            {
                this.BeginInvoke(Init);
            }
            catch (Exception)
            {
                Init.Invoke();
            }
            Hours_textbox.GotFocus += SelectWhenFocus;
            Minutes_textbox.GotFocus += SelectWhenFocus;
            Seconds_textbox.GotFocus += SelectWhenFocus;
            TimerWatchFLP.Focus();
            Hours_textbox.Focus();
        }
        /// <summary>
        /// Handles the rendering of the timer.
        /// <param name="startTime">The time to count from in seconds</param>
        /// </summary>
        private void TimerRendT(int startTime)
        {
            TimerWatchFLP.Enabled = false;
            TimerWatchFLP.Visible = false;
            ProgressBar.BarColor1 = Color.Transparent;
            startTime *= 1000;
            var a=new Action(()=> { TimerTimeLabel.Visible = true; 
            TimerTimeLabel.BringToFront();
            long milpast = StopperWatch.GetMillisecondsPast();
            if (milpast <= startTime)
                TimerTimeLabel.Text = ToWatchFormat(startTime - milpast);
            CenterVertical(TimerTimeLabel);
            });
            TimerTimeLabel.BeginInvoke(a);
            ProgressBar.Maximum = long.MaxValue;
            var timeout = TimeSpan.FromSeconds(0.00425);
            Start:
            while (rendering)
            {
                long milpast = TimerWatch.GetMillisecondsPast();
                if (milpast > startTime)
                    break;
                this.BeginInvoke(new Action(() =>
                {
                    TimerTimeLabel.Text = ToWatchFormat(startTime - milpast);
                    ProgressBar.Value = (long)((double)ProgressBar.Maximum * (1.0 - milpast / (double)startTime));
                    if (ProgressBar.Value <= 0.3*ProgressBar.Maximum)
                        ProgressBar.BarColor1 = Color.FromArgb(100,Color.LightSeaGreen);
                }));
                Thread.Sleep(timeout);
            }
            while (rendering == false) {
                
            }
            goto Start;
            
        }
        /// <summary>
        /// Returns the time that was given from the user in total seconds.
        /// </summary>
        /// <returns></returns>
        private int GetTimeFromTB()
        {
            var Hstring = Hours_textbox.Text;
            var Mstring = Minutes_textbox.Text;
            var Sstring = Seconds_textbox.Text;
            int hours, minutes, seconds, timeInSeconds;
            int.TryParse(Hstring, out hours);
            int.TryParse(Mstring, out minutes);
            int.TryParse(Sstring, out seconds);
            timeInSeconds = seconds + minutes * 60 + hours * 3600;
            return timeInSeconds;
        }
        /// <summary>
        /// Changes the <see cref="Timer.Timer_start_button"/> status between start, pause and continue.
        /// </summary>
        private void ChangeTimerStartStatus()
        {
            var btn = Timer_start_button;
            if(btn.Text==Values.start_button_text)
            {
                btn.Text = Values.pause_button_text;
                btn.BackColor = Values.pause_button_color;
                return;
            }
            if(btn.Text==Values.pause_button_text)
            {
                btn.Text = Values.start_button_text;
                btn.BackColor = Values.start_button_color;
                return;
            }
        }
        /// <summary>
        /// Selects all the text in sender.Text.
        /// </summary>
        /// <param name="sender">Should be <see cref="TextBox"/></param>
        /// <param name="e"></param>
        private void SelectWhenFocus(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            tb.SelectAll();
        }

        /// <summary>
        /// Restricts the sender.Text to 2 last chars.
        /// </summary>
        /// <param name="sender">should be <seealso cref="System.Windows.Forms.TextBox"/>.</param>
        /// <param name="e"></param>
        private void RestrictTo2Chars(object sender, EventArgs e)
        {
            var me = sender as TextBox;
            if (me.Text.Length > 2)
                me.Text = me.Text.Substring(me.Text.Length - 2, 2);
        }
        /// <summary>
        /// Removes all non-number chars from sender.Text.
        /// </summary>
        /// <param name="sender">Should be <see cref="TextBox"/>.</param>
        /// <param name="e"></param>
        private void KeepOnlyNumbers(object sender, EventArgs e)
        {
            var me = sender as TextBox;
            string nt;
            if (KeepOnlyNumbers(me.Text, out nt))
                me.Text = nt;
            RestrictTo2Chars(sender, e);
        }
        private void Timer_start_button_Click(object sender, EventArgs e)
        {
            var txt = Timer_start_button.Text;
            ChangeTimerStartStatus();
            if (txt == Values.start_button_text)
            {
                if (rendering == false)
                {
                    rendering = true;
                    if (TimerWatch.IsPaused&&TimerWatch.GetMillisecondsPast()==0)
                    {
                        TimerRender?.Abort();
                        TimerRender = new Thread(() =>
                        {
                            TimerRendT(GetTimeFromTB());
                        });
                        TimerWatch = new Watch();
                        TimerRender.Start();
                    }
                    TimerWatch.StartCon();
                }
                return;
            }
            else if(txt == Values.pause_button_text)
            {
                TimerWatch.Pause();
                rendering = false;
            }

        }
        private void Timer_reset_button_Click(object sender, EventArgs e)
        {
            Minutes_textbox.Text = "00";
            Hours_textbox.Text = "00";
            Seconds_textbox.Text = "00";
            TimerRender?.Abort();
            InitializeTimerSetup();
            TimerWatchFLP.Visible = true;
            TimerWatchFLP.Enabled = true;
            TimerTimeLabel.Visible = false;
            TimerTimeLabel.Enabled = false;
            Minutes_textbox.GotFocus -= SelectWhenFocus;
            Seconds_textbox.GotFocus -= SelectWhenFocus;
            Hours_textbox.GotFocus -= SelectWhenFocus;
            if (Timer_start_button.Text == Values.pause_button_text)
                ChangeTimerStartStatus();
        }
        #endregion
        #region GeneralRegion
        /// <summary>
        /// Sets the controls location to the middle width of its parent.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="Parent"></param>
        private void CenterVertical(Control control,Control Parent=null)
        {
            if (Parent is null)
                Parent = control.Parent;
            control.Location = new Point
            {
                X = (Parent.Width - control.Width) / 2,
                Y = control.Location.Y
            };
        }
        /// <summary>
        /// Sets the control location to the middle height of its parent.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="Parent"></param>
        private void CenterHorizontal(Control control, Control Parent=null)
        {
            if (Parent is null)
                Parent = control.Parent;
            control.Location = new Point
            {
                Y = (Parent.Height - control.Height) / 2,
                X = control.Location.X
            };
        }
        /// <summary>
        /// Returns true if changed at least one character, false otherwise.
        /// </summary>
        /// <param name="original">The text to remove non-numbers from it.</param>
        /// <param name="_new">The new only numbers contained text.</param>
        /// <returns></returns>
        private bool KeepOnlyNumbers(string original,out string _new)
        {
            _new = "";
            foreach (char c in original)
                if (c > 47 && c < 58)
                    _new += c;
            return _new.Length != original.Length;
        }
        private void ChangeTimerStopperState(bool TimerOn = true)
        {
            if (TimerOn)
            {
                timer_layout_button.ForeColor = Values.selected_timer_layout_button_color;
                timer_layout_button.BackColor = Color.Transparent;
                stopper_layout_button.BackColor = Values.unselected_stopper_layout_button_color;
                stopper_layout_button.ForeColor = Color.Black;  
            }
            else
            {
                timer_layout_button.ForeColor = Color.Black;
                timer_layout_button.BackColor = Values.unselected_timer_layout_button_color;
                stopper_layout_button.BackColor = Color.Transparent;
                stopper_layout_button.ForeColor = Values.selected_stopper_layout_button_color;
            }
        }
        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void Timer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                StopperRender?.Abort();
                
            }
            catch(Exception)
            {
                //return;
            }
            try
            {
                TimerRender?.Abort();
            }
            catch(Exception)
            {

            }
        }

        private void stopper_button_click(object sender, EventArgs e)
        {
            InitializeStopperSetup();
            Hours_textbox.GotFocus -= SelectWhenFocus;
            Minutes_textbox.GotFocus -= SelectWhenFocus;
            Seconds_textbox.GotFocus -= SelectWhenFocus;
        }

        private void timer_layout_button_Click(object sender, EventArgs e)
        {
            InitializeTimerSetup();
        }
        #endregion
    }
}
