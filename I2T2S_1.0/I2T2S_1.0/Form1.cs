using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace I2T2S_1._0
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader; // Declare object for T2S
        bool isPause = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new SpeechSynthesizer(); // Create a new object for T2S
            PauseButton.Enabled = false;
            StopButton.Enabled = false; // Disable stop and pause buttons as no audio is playing now
            UpdateLabel.Text = "Select Image (Browse) to begin";
            UpdateLabel.Refresh(); // Update label to guide user
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog(); // File dialog to be opened for file selection
            fdlg.Title = "Select Image to be converted to Text"; 
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All Images Files |*.jpeg*; *.jpg*; *.jif*; *.jfif*;*.png*;*.tif*;*.tiff*;|TIFF (*.tif*;*.tiff*)|*.tif*;*.tiff*;|JPEG (*.jpeg*; *.jpg*; *.jif*; *.jfif*)|*.jpeg*; *.jpg*; *.jif*; *.jfif*;|PNG (*.png*)|*.png*";
            fdlg.FilterIndex = 1; // Starting index is "All Image Files"
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK) // If a file is selected
            {
                BrowseLabel.Text = fdlg.FileName;
                String path = fdlg.FileName; // Store path in String
                PictureBox.Image = Image.FromFile(BrowseLabel.Text); // Display image
                UpdateLabel.Text = "Displaying Image from" + path;
                await Task.Delay(200);
                UpdateLabel.Refresh();
                var image = new Bitmap(PictureBox.Image); // Convert image into Bitmap
                var ocr = new tessnet2.Tesseract(); // Declare and create object for I2T
                UpdateLabel.Text = "Image to Text conversion...";
                UpdateLabel.Refresh(); // Update label to show status
                ocr.Init(null, "eng", false);
                var result = (ocr.DoOCR(image, Rectangle.Empty)); // Conversion of image to text
                Console.WriteLine("{0} ", finalword);
                TextBox.Refresh();
                UpdateLabel.Text = "Press play for audio...";
                UpdateLabel.Refresh(); // Update label to show new status
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PauseButton.Enabled = true;
            StopButton.Enabled = true; // Enable other buttons as audio start playing
            UpdateLabel.Text = ""; // Diable user help text as he knows what to do
            if (isPause && reader.State == SynthesizerState.Paused)
            {
                reader.Resume(); // if audio is paused, resume
            }
            else
            {
                reader.Dispose();
                if (TextBox.Text != "")    //if text area is not empty
                {

                    reader = new SpeechSynthesizer();
                    reader.SpeakAsync(TextBox.Text); // start playing text
                }
                else
                {
                    MessageBox.Show("Please select image with Text to play Audio", "No Text", MessageBoxButtons.OK);
                    // Display error if no text in text feild
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            isPause = false;
            PauseButton.Enabled = false;
            if (reader != null)
            {
                reader.Dispose(); // stop audio from playing
            }
            UpdateLabel.Text = "Press play for audio...";
            UpdateLabel.Refresh(); // Update label to guide user
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            isPause = true;
            if (reader.State == SynthesizerState.Speaking)
            {
                reader.Pause(); // Pause if audio is playing
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox.Text); // Copy text in text box to clipboard
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null; // Clear picture box
            isPause = false; // set not pause
            PauseButton.Enabled = false;
            StopButton.Enabled = false; // disable buttons that are not needed currently
            if (reader != null)
            {
                reader.Dispose(); // close audio if playing
            }
            TextBox.Text = "";
            BrowseLabel.Text = ""; // empty text box and browser label
            UpdateLabel.Text = "Select Image (Browse) to begin";
            UpdateLabel.Refresh(); // Update label to guide user
        }
    }
}
