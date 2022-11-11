﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeruletKeruletTerfogat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Teglalap();
            Haromszog();
            Trapez();
            Paralelogramma();
            Deltoid();
            Rombusz();
            Negyzet();
            Kor();
            Gomb();
            Henger();
            Gula();
        }

        private void Gula()
        {
            
        }

        private void Henger()
        {
            
        }

        private void Gomb()
        {
            
        }

        private void Kor()
        {
            
        }

        private void Negyzet()
        {
            
        }

        private void Rombusz()
        {
            
        }

        private void Deltoid()
        {
            
        }

        private void Paralelogramma()
        {
            
        }

        private void Trapez()
        {
            
        }

        private void Haromszog()
        {
            
        }

        private void Teglalap()
        {
            aOldalLathato();
            aOldalNemLathato();
        }

        private void aOldalNemLathato()
        {
            aOldal.Visible = false;
            aOldalTextBox.Visible = false;
            aOldalMertekegyseg.Visible = false;
        }

        private void aOldalLathato()
        {
            aOldal.Visible = true;
            aOldalTextBox.Visible = true;
            aOldalMertekegyseg.Visible = true;
        }
        private void dOldalNemLathato()
        {
            dOldal.Visible = false;
            dOldalTextBox.Visible = false;
            dOldalMertekegyseg.Visible = false;
        }

        private void dOldalLathato()
        {
            dOldal.Visible = true;
            dOldalTextBox.Visible = true;
            dOldalMertekegyseg.Visible = true;
        }
        private void eOldalNemLathato()
        {
            eOldal.Visible = false;
            eOldalTextBox.Visible = false;
            eOldalMertekegyseg.Visible = false;
        }

        private void eOldalLathato()
        {
            eOldal.Visible = true;
            eOldalTextBox.Visible = true;
            eOldalMertekegyseg.Visible = true;
        }
        private void fOldalNemLathato()
        {
            fOldal.Visible = false;
            fOldalTextBox.Visible = false;
            fOldalMertekegyseg.Visible = false;
        }

        private void fOldalLathato()
        {
            fOldal.Visible = true;
            fOldalTextBox.Visible = true;
            fOldalMertekegyseg.Visible = true;
        }

        private void haromszogGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Háromszög.png");
            aOldalLathato();
            bOldalLathato();
            cOldalLathato();
            aOldalMagassagLathato();
            Torles();
        }

        private void Torles()
        {
            aOldalNemLathato();
            bOldalNemLathato();
            cOldalNemLathato();
            aOldalMagassagNemLathato();

        }

        private void aOldalMagassagNemLathato()
        {
            aOldalMagassag.Visible = false;
            aOldalMagassagTextBox.Visible = false;
            aOldalMagassagMertekegyseg.Visible = false;
        }
        private void bOldalNemLathato()
        {
            bOldal.Visible = false;
            bOldalTextBox.Visible = false;
            bOldalMertekegyseg.Visible = false;
        }
        private void cOldalNemLathato()
        {
            cOldal.Visible = false;
            cOldalTextBox.Visible = false;
            cOldalMertekegyseg.Visible = false;
        }

        private void aOldalMagassagLathato()
        {
            aOldalMagassag.Visible = true;
            aOldalMagassagTextBox.Visible = true;
            aOldalMagassagMertekegyseg.Visible = true;
        }

        private void cOldalLathato()
        {
            cOldal.Visible = true;
            cOldalTextBox.Visible = true;
            cOldalMertekegyseg.Visible = true;
        }

        private void bOldalLathato()
        {
            bOldal.Visible = true;
            bOldalTextBox.Visible = true;
            bOldalMertekegyseg.Visible = true;
        }

        private void trapezGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Trapéz.png");
        }

        private void paralelogrammaGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Paralelogramma.png");
        }

        private void teglalapGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Téglalap.png");
        }

        private void deltoidGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Deltoid.png");
        }

        private void rombuszGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Rombusz.png");
        }

        private void negyzetGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Négyzet.png");
        }

        private void korGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Kör.png");
        }

        private void gombGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Gömb.png");
        }

        private void hengerGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Henger.png");
        }

        private void gulaGomb_Click(object sender, EventArgs e)
        {
            alakzatPictureBox.Image = Image.FromFile(@"Gúla.png");
        }
    }
}