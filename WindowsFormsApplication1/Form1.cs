using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        posiones b1 = new posiones();
        posiones b2 = new posiones();
        posiones b3 = new posiones();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSaldo.Text = "100";
            txtLagrima.Text = "10";
            txtSlagrimas.Text = "0";
            txtSdiente.Text = "0";
            txtTrompa.Text = "5";
            txtStrompa.Text = "0";
            txtAlas.Text = "15";
            txtSalas.Text = "0";
            txtOjo.Text = "20";
            txtSojo.Text = "0";
            txtDiente.Text = "5";
            txtSdiente.Text = "0";
            txtStockr.Text = "0";
            
        }
        // Bruja Sabrina

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Comprar lagrima de cocodrilo
            b1.comprar();
             double Saldo = Convert.ToDouble(txtSaldo.Text);
             double r = Saldo - 10;
               txtSaldo.Text = r.ToString();
             double Stock = Convert.ToDouble(txtSlagrimas.Text);
             double stock = Stock + 1;
               txtSlagrimas.Text = stock.ToString();
            
        }
                    private void btnComprarT_Click(object sender, EventArgs e)
                    {
                        //Comprar trompa de elefante
                        b1.comprar();
                        double Saldo = Convert.ToDouble(txtSaldo.Text);
                        double r = Saldo - 5;
                        txtSaldo.Text = r.ToString();
                        double Stock = Convert.ToDouble(txtStrompa.Text);
                        double stock = Stock + 1;
                        txtStrompa.Text = stock.ToString();
                    }
                    private void btnComprarA_Click(object sender, EventArgs e)
                    {
                        //Comprar alas de murcielago
                        b1.comprar();
                        double Saldo = Convert.ToDouble(txtSaldo.Text);
                        double r = Saldo - 15;
                        txtSaldo.Text = r.ToString();
                        double Stock = Convert.ToDouble(txtSalas.Text);
                        double stock = Stock + 1;
                        txtSalas.Text = stock.ToString();
                    }
                    private void btnComprarO_Click(object sender, EventArgs e)
                    {
                        //comprar ojo de sapo
                        b1.comprar();
                        double Saldo = Convert.ToDouble(txtSaldo.Text);
                        double r = Saldo - 15;
                        txtSaldo.Text = r.ToString();
                        double Stock = Convert.ToDouble(txtSojo.Text);
                        double stock = Stock + 1;
                        txtSojo.Text = stock.ToString();
                    }
                    private void btnComprarD_Click(object sender, EventArgs e)
                    {
                        //comprar diente de tigre
                        b1.comprar();
                        double Saldo = Convert.ToDouble(txtSaldo.Text);
                        double r = Saldo - 15;
                        txtSaldo.Text = r.ToString();
                        double Stock = Convert.ToDouble(txtSdiente.Text);
                        double stock = Stock + 1;
                        txtSdiente.Text = stock.ToString();
                    }
                            //Venta de posion rejuvenizante
                    private void btnVentar_Click(object sender, EventArgs e)
                    {
                        b1.comprar();
                        double Vender = Convert.ToDouble(txtStockr.Text);
                        double vender = Vender = 1;
                        txtStockr.Text = vender.ToString();
                        //double Stock = Convert.ToDouble(txtSalas.Text);
                        txtStockr.Text = txtSlagrimas.Text + txtSojo;
                         
                        double stockr = vender - 1;
                        txtStockr.Text = vender.ToString();
                        
                        //txtStockr.Text = txtSalas.Text + txtSojo.Text + txtStrompa ;
                    }
                    private void textBox1_TextChanged(object sender, EventArgs e){}
                    private void txtSaldo_TextChanged(object sender, EventArgs e)
                {
                  string Comprar;
                  Comprar = txtSaldo.Text;
                  if (Comprar == "0") 
                  { 
                      MessageBox.Show("No cuentas con saldo");
                  }
                }

                    private void txtStockr_TextChanged(object sender, EventArgs e)
                    {

                    }

                

                    

                    

                   

      
    }
}
