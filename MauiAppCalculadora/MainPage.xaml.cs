
namespace MauiAppCalculadora
{
    public partial class MainPage : ContentPage
    {

        String? operacao = null;
        int count = 0;
        string aparecer_no_visor = "";

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor()
        {
            if (aparecer_no_visor == "+" ||
               aparecer_no_visor == "-" ||
               aparecer_no_visor == "*" ||
               aparecer_no_visor == "/")
            {
                aparecer_no_visor = "";
            }
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            aparecer_no_visor = "";
            memoria_calc_pos_operacao = 0;
            memoria_calc_pre_operacao = 0;
            operacao = null;
        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {
            double valor =  Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();
        }

        private void porcento_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = aparecer_no_visor;
        }

        private void num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num7.Text;
            visor.Text = aparecer_no_visor;
        }

        private void num8_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num8.Text;
            visor.Text = aparecer_no_visor;
        }

        private void num9_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num9.Text;
            visor.Text = aparecer_no_visor;
        }

        private void multiplicacao_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_no_visor = "*";
            operacao = "*";
            visor.Text = aparecer_no_visor;
        }

        private void num4_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num4.Text;
            visor.Text = aparecer_no_visor;
        }

        private void num5_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num5.Text;
            visor.Text = aparecer_no_visor;
        }
        private void num6_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num6.Text;
            visor.Text = aparecer_no_visor;
        }

        private void menos_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_no_visor = "-";
            operacao = "-";
            visor.Text = aparecer_no_visor;
        }

        private void num_1_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num_1.Text;
            visor.Text = aparecer_no_visor;
        }

        private void num_2_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num_2.Text;
            visor.Text = aparecer_no_visor;
        }

        private void num_3_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num_3.Text;
            visor.Text = aparecer_no_visor;
        }

        private void mais_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(visor.Text);
            aparecer_no_visor = "+";
            operacao = "+";
            visor.Text = aparecer_no_visor;
        }

        private void num_0_Clicked(System.Object sender, System.EventArgs e)
        {
            remover_sinais_visor();
            aparecer_no_visor += num_0.Text;
            visor.Text = aparecer_no_visor;
        }

        private void ponto_Clicked(System.Object sender, System.EventArgs e)
        {
            aparecer_no_visor = ponto.Text;
            visor.Text = aparecer_no_visor;
        }

        private void igual_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);

                double resultado = 0;

                switch(operacao)
                {
                    case "+":
                        resultado = memoria_calc_pre_operacao + memoria_calc_pos_operacao; 
                    break;
                    case "-":
                        resultado = memoria_calc_pre_operacao - memoria_calc_pos_operacao;
                    break;
                    case "*":
                        resultado = memoria_calc_pre_operacao * memoria_calc_pos_operacao;
                    break;
                    case "/":
                        resultado = memoria_calc_pre_operacao / memoria_calc_pos_operacao;
                    break;
                }

                visor.Text = resultado.ToString();
            }
            catch(Exception ex) 
            { 
                visor.Text = ex.Message;
            }
        }
    }

}
