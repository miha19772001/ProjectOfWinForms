using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Diagnostics;





namespace Application_1
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Inserts
            insertInMainMenu1.BringToFront();

        }

        private void MoveForm(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(183, 242, 151);
            public static Color color5 = Color.FromArgb(24, 161, 251);
        }


        //Method
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //iconButton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50, 49, 69);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border butten 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 49, 69);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        #region Button control
        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            insertHome1.BringToFront();
        }

        private void BtnNovelty_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            insertNovelty1.BringToFront();
        }

        private void BtnPopularly_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            insertPopularly1.BringToFront();
        }

        private void BtnDataBase_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            insertDataBase1.BringToFront();

        }

        private void BtnAboutMe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            insertAboutMe1.BringToFront();
        }

        #endregion 

        private void BtnBook_Click(object sender, EventArgs e)
        {
            Reset();

            insertInMainMenu1.BringToFront();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Compass;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Menu";
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Links
        private void BtnLinkFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://ru-ru.facebook.com");
        }

        private void BtnLinkInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com");
        }

        private void BtnLinkTwiter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com");
        }
        #endregion

    }
}
