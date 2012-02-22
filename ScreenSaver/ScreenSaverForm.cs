using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Net;
using System.IO;


namespace ScreenSaver
{
    public partial class ScreenSaverForm : Form
    {
        //the following imports several Windows APIs for later use
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        //class level variables
        private bool previewMode = false;
        private Random rand = new Random();
        private Point mouseLocation;

        //constructor that sets the form's bounds
        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        //constructor that accepts the window handle as an argument 
        //uses several Windows API functions
        //used for preview mode
        public ScreenSaverForm(IntPtr PreviewHandle)
        {
            InitializeComponent();

            //set the preview window as the parent of this window
            SetParent(this.Handle, PreviewHandle);

            //make this a child window so it will close when the parent dialog closes
            //GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            //places our window inside the parent
            Rectangle parentRect;
            GetClientRect(PreviewHandle, out parentRect);
            Size = parentRect.Size;
            Location = new Point(0, 0);

            //makes the text smaller for the preview screen
            textLabel.Font = new System.Drawing.Font("Calisto MT", 6);

            previewMode = true;
        }

         private Stream RssFeed()
         {
            // used to build entire input
            StringBuilder sb = new StringBuilder();

            // used on each read operation
            byte[] buf = new byte[8192];

            // prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)
                WebRequest.Create("https://linuxsandbox.coleman.edu/~pm34860/1-16-2012H8M16S31.xml");

            // execute the request
            HttpWebResponse response = (HttpWebResponse)
                request.GetResponse();

            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();

            string Response = null;
            int count = 0;

            while (count > 0)
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);

                // read data until there is none left to read
                if (count != 0)
                {
                    // translate from bytes to UTF8 text
                    Response = Encoding.UTF8.GetString(buf, 0, count);

                    // continue building the string
                    sb.Append(Response);

                    // build and printvthe toString
                    //Console.WriteLine(sb.ToString());
                    count++;
                }
            }

            return resStream;
           
        }

        //read XML file
        private void XmlReader()
        {
            XmlTextReader reader = new XmlTextReader(RssFeed());

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                        case XmlNodeType.Element: // The node is an element.
                            //MessageBox.Show("<" + reader.Name);
                            //MessageBox.Show(">");
                            //MessageBox.Show(reader.Value);
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            //i++;
                            //if (i == 2)      //2 because Hello is in second node.
                            //{
                                //MessageBox.Show(reader.Value); //will show Hello
                                textLabel.Text = reader.Value;
                           // }
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            //Console.Write("</" + reader.Name);
                            //MessageBox.Show(">");
                            break;
                }
            }
        }
        
        //loads the Registry values
        //also hides the cursor and brings the window to the front 
        private void LoadSettings()
        {
            Cursor.Hide();
            TopMost = true;
           

            // Get the text value stored in the Registry
            //Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo_ScreenSaver");
            //if (key.GetValue("text") == null)
            //{
            //    textLabel.Text = "Our Screensaver";
            //}
            //else
            //{
            //    textLabel.Text = (string)key.GetValue("text");
            //}

            //get the interval value stored in the Registry
            Microsoft.Win32.RegistryKey intervalKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Demo2_ScreenSaver");
            int interval = (int)intervalKey.GetValue("interval");
            if (interval == -1)
            {
                //default to 1000 milliseconds
                moveTimer.Interval = 1000;
            }
            else
            {
                //interval holds the selectedIndex of intervalComboBox
                //add 1 to the index and multiply by 1000 to get the desired number of milliseconds
               moveTimer.Interval = 1000 * (interval + 1);
            }

            //TODO: call readXML();
            XmlReader();


            //call moveTimer_Tick every 1000 milliseconds (1 second)
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }
        
        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        //randomly moves the text to a new location at the specified timer interval
        private void moveTimer_Tick(object sender, System.EventArgs e)
	    {
	        // Move text to new location
	        textLabel.Left = rand.Next(Math.Max(1, Bounds.Width - textLabel.Width));
	        textLabel.Top = rand.Next(Math.Max(1, Bounds.Height - textLabel.Height));           
	    }

        //terminates the screensaver when the mouse is moved more than 5 points
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            //only exit the application upon MouseMove if the screensaver is NOT in preview mode
            if (!previewMode)
            {
                if (!mouseLocation.IsEmpty)
                {
                    if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                        Math.Abs(mouseLocation.Y - e.Y) > 5)
                        Application.Exit();
                }
                // Update current mouse location
                mouseLocation = e.Location;
            }
        }

        //terminates the screensaver when the mouse is clicked (if the screensaver
        //is not in preview mode)
        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }

        //terminates the screensaver when a key is pressed (if the screensaver
        //is not in preview mode)
        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!previewMode)
            {
                Application.Exit();
            }
        }
    }
}