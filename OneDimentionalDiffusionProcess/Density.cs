using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimentionalDiffusionProcess
{
    class Density
    {
        // First of all Data
        double xmin, xmax, delt, delx, D, sigma, t, x;
        // D = Diffusion Constant

        double[] rho;  // rho = density
        int num; // numbers of points to be taken between xmin and xmax
        // Define needed Function
        // First of All Constructor

        // Jo class k name ho ga wohi constructor ka name ho ga
        public Density(Graphics gg, Form1 frm, SolidBrush b)
        {
            t = 0.0001;
            xmin = -2;
            xmax = 2;
            D = 1;
            x = xmin;
            delt = 0.5; num = 1000;

            delx = (xmax - xmin) / (num - 1);
            sigma = Math.Sqrt(2 * D * t);
           
            float xc = frm.ClientSize.Width / 2;

            rho = new double[num]; // rho = density
            // store the starting values of the density

            for (int i = 0; i < num; i++)
            {
                x = xmin + i * delx;
                rho[i] = 1 / sigma * Math.Exp(-x * x / (2 * sigma * sigma));

                gg.FillEllipse(b, xc + (float)x * 400, 200 - (float)rho[i], 5, 5);
            }

           // first of all data 
        //double xmin, xmax, delt, delx, D, sigma,t,x;
        //double[] rho;
        //int num;//number of points to be taken between xmin and xmax
        ////define neeeded function
        ////first of all constructor
        //public Density(Graphics gg, Form1 frm, SolidBrush b)
        //{
        //    t = 0.0001; xmin = -2; xmax = 2; x = xmin; D = 1; delt = 0.5;  sigma = Math.Sqrt(2 * D * t);
        //    num = 7000; delx = (xmax - xmin) / (num - 1);
        //    rho = new double[num];
        //    float xc = frm.ClientSize.Width / 2;
        //    //store the starting values of density
        //    for (int i = 0; i < num; i++)
        //    {
        //        x = xmin + i*delx;
        //        rho[i]=1/sigma*Math.Exp(-x*x/(2*sigma*sigma));
        //        gg.FillEllipse(b, xc + (float)x * 200, 200 - (float)rho[i], 5, 5);
        //    }
        

        }

    }
}
