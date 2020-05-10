using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_From_The_Woods
{
    public partial class Form1 : Form
    {
        List<boom> bomen = new List<boom>();
        int boomId = 0;
        Random rand = new Random();
        List<Aap> apen = new List<Aap>();
        int aapId = 0;
        List<boom> bezetteBomen = new List<boom>();
        List<boom> dichstbijzijndeBomen = new List<boom>();
        public Form1()
        {
            InitializeComponent();
            pcbBos.BackColor = Color.Black;
            Bos nieuwBos = new Bos(bomen);
            for (int x = 0; x < 300; x++)
            {
                VullBos();
            }
            VullBosMetApen();
            apenVerspringen();
        }



        public void VullBos()
        {
           
            int xCo = rand.Next(0,pcbBos.Width);
            int yCo = rand.Next(0,pcbBos.Height);
            boom nieuweBoom = new boom (xCo,yCo,boomId);

            bool bestaatBoom = false;

            foreach (boom b in bomen)
            {
                if (nieuweBoom._x == b._x && nieuweBoom._y == b._y)
                {
                    bestaatBoom = true;
                    break;
                }
                else
                {
                    bestaatBoom = false;
                }
            }

            if (bestaatBoom)
            {
                VullBos();
            }
            else
            {
                bomen.Add(nieuweBoom);
                boomId++;
            }
        }

        public void VullBosMetApen()
        {
            for (int x = 0; x < 5; x++)
            {
                boom gekozenBoom;
                gekozenBoom = bomen[rand.Next(0, bomen.Count())];
                bool boomBestaat = false;
                Aap nieuweAap = new Aap(aapId, "Aap", gekozenBoom._x, gekozenBoom._y, gekozenBoom);
                foreach(boom b in bezetteBomen)
                {
                    if (gekozenBoom == b)
                    {
                        boomBestaat = true;
                        break;
                    }
                    else
                    {
                        boomBestaat = false;
                    }
                }
                if (boomBestaat)
                {
                    VullBosMetApen();
                }
                else
                {
                    apen.Add(nieuweAap);
                    bezetteBomen.Add(gekozenBoom);
                    aapId++;
                }
            }
        }

        private void pcbBos_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach(boom b in bomen)
            {
                Pen bic = new Pen(Color.Green);
                g.DrawEllipse(bic, b._x, b._y,3, 3);
            }
            foreach(Aap a in apen)
            {
                Pen pennetje = new Pen(Color.Red);
                Brush br = new SolidBrush(Color.Red);
                g.FillEllipse(br, a._startBoom._x, a._startBoom._y, 3, 3);
                for (int x = 0; x < apen.Count; x++)
                {
                    g.DrawLine(pennetje,a._X,a._Y, dichstbijzijndeBomen[x]._x, dichstbijzijndeBomen[x]._y);
                }
            }
        }

        public void apenVerspringen()
        {
            double dichtsbijzijndePunt = 10000;
            double afstand;
            foreach(Aap a in apen)
            {
                boom dichtsbijzijndeBoom = new boom(0,0,0);
                foreach(boom b in bomen)
                {
                    var afstand1 = Math.Pow((a._x - b._X), 2);
                    var afstand2 = Math.Pow((a._y - b._Y), 2);
                    afstand = Math.Sqrt(afstand1 + afstand2);
                    if (afstand < dichtsbijzijndePunt)
                    {
                        dichtsbijzijndePunt = afstand;
                        dichtsbijzijndeBoom = b;
                    }

                    dichstbijzijndeBomen.Add(dichtsbijzijndeBoom);
                }

            }
        }
    }
}
