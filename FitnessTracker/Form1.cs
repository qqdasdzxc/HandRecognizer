using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using FitnessTracker.Flop;

namespace FitnessTracker
{
    public partial class Form1 : Form
    {
        String basePath = "C:\\Users\\asdzxc\\Desktop\\testing recog\\";

        HandRecognizer handRecognizer = new HandRecognizer();
        FlopRecognizer flopRecognizer = new FlopRecognizer();

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

        public Form1() { InitializeComponent();}

        private void button1_Click(object sender, EventArgs e)
        {
            int leftx = Int32.Parse(left_x.Text);
            int lefty = Int32.Parse(left_y.Text);
            int width = Int32.Parse(capture_width.Text);
            int height = Int32.Parse(capture_height.Text);
            drawRect(leftx, lefty, width, height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rightx = Int32.Parse(right_x.Text);
            int righty = Int32.Parse(right_y.Text);
            int width = Int32.Parse(capture_width.Text);
            int height = Int32.Parse(capture_height.Text);
            drawRect(rightx, righty, width, height);
        }

        private void drawRect(int startx, int starty, int width, int height)
        {
            IntPtr desktop = GetDC(IntPtr.Zero);

            using (Graphics g = Graphics.FromHdc(desktop))
            {
                g.FillRectangle(Brushes.Red, startx, starty, width, height);
            }
        }

        private void capture_left_button_Click(object sender, EventArgs e)
        {
            int leftx = Int32.Parse(left_x.Text);
            int lefty = Int32.Parse(left_y.Text);
            int width = Int32.Parse(capture_width.Text);
            int height = Int32.Parse(capture_height.Text);
            Bitmap fullHand = capture(leftx, lefty, width, height);

            result_text_box.Text += handRecognizer.extractCardText(fullHand);
            fullHand.Dispose();
            Clipboard.SetText(result_text_box.Text);
        }

        private void capture_right_button_Click(object sender, EventArgs e)
        {
            int rightx = Int32.Parse(right_x.Text);
            int righty = Int32.Parse(right_y.Text);
            int width = Int32.Parse(capture_width.Text);
            int height = Int32.Parse(capture_height.Text);
            Bitmap fullHand = capture(rightx, righty, width, height);

            result_text_box.Text += handRecognizer.extractCardText(fullHand);
            fullHand.Dispose();
            Clipboard.SetText(result_text_box.Text);
        }

        private Bitmap capture(int startx, int starty, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(result as Image);
            graphics.CopyFromScreen(startx, starty, 0, 0, result.Size);
            return result;
        }

        private void ep_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "EP: ";
        }

        private void mp_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "MP: ";
        }

        private void co_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "CO: ";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "BTN: ";
        }

        private void sb_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "SB: ";
        }

        private void bb_Click(object sender, EventArgs e)
        {
            result_text_box.Text = "BB: ";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result_text_box.Text);
        }

        private void showFlopRects_Click(object sender, EventArgs e)
        {
            int startX = Int32.Parse(flopStartX.Text);
            int startY = Int32.Parse(flopStartY.Text);
            int width = Int32.Parse(flopWidth.Text);
            int height = Int32.Parse(flopHeight.Text);

            drawRect(startX, startY, width, height);
        }

        private void captureFlop_Click(object sender, EventArgs e)
        {
            int startX = Int32.Parse(flopStartX.Text);
            int startY = Int32.Parse(flopStartY.Text);
            int width = Int32.Parse(flopWidth.Text);
            int height = Int32.Parse(flopHeight.Text);
            Bitmap flop = capture(startX, startY, width, height);

            flopTextBox.Text += flopRecognizer.getFlopString(flop);
            flop.Dispose();
        }
    }
}
