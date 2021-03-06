﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;



namespace libraryManagement
{
    public partial class Form1 : Form
    {



        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);


        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(200, 188, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(253, 118, 241);
            public static Color color8 = Color.FromArgb(95, 138, 176);
            public static Color color9 = Color.FromArgb(249, 77, 114);
            public static Color color10 = Color.FromArgb(24, 88, 221);
            public static Color color11 = Color.FromArgb(253, 161, 155);
            public static Color color12 = Color.FromArgb(95, 118, 251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
             /*   leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();    */
                //main icon
                ıconPictureBoxCurrent.IconChar = currentBtn.IconChar;
                ıconPictureBoxCurrent.IconColor = color;
                LblHome.Text = currentBtn.Text;


            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopForm.Controls.Add(childForm);
            panelDesktopForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblHome.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ıconPictureBoxCurrent.IconChar = IconChar.Home;
            ıconPictureBoxCurrent.IconColor = Color.Gainsboro;
            LblHome.Text = "Home";
            OpenChildForm(new FrmLibrarian());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

      

        

        private void ıconButtonAddPublication_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new FrmAddPublication());
        }

        private void ıconButtonAddBook_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new FrmAddBook());
        }

        private void ıconButtonBookReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new FrmBookReport());
        }

        private void ıconButtonAddBranch_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new FrmAddBranch());
        }

        private void ıconButtonAddStudent_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new FrmAddStudent());
        }

        private void ıconButtonStudentReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new FrmStudentReport());
        }

        private void ıconButtonIssueBook_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color7);
            OpenChildForm(new FrmIssueBook());
        }

        private void ıconButtonIssueReport_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color8);
            OpenChildForm(new FrmIssueReport());
        }

        private void ıconButtonReturnBook_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color9);
            OpenChildForm(new FrmReturnBook());
        }

        private void ıconButtonPenalty_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color10);
            OpenChildForm(new FrmPenalty());
        }

        private void ıconButtonLogOut_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color11);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLibrarian());
        }
    }
}
