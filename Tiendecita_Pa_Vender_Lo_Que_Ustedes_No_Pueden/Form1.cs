using System.Collections;

namespace Tiendecita_Pa_Vender_Lo_Que_Ustedes_No_Pueden
{
    public partial class Form1 : Form
    {
        static string[] Producto = { "Razer Viper v2 PRO", "Logitech G502 HERO", "HyperX Pulsefire Haste", "ASUS TUF Gaming M4", "Glorious Model O y D", "Corsair SABRE RGB PRO", "BenQ Zowie EC3-C", "Endgame GEAR XM1", "Corsair Harpoon RGB PRO / Wireless", "Logitech G203 LightSync", "MSI CLUTCH GM41 LIGHTWEIGHT V2", "Krom Kaiyu", "Trust Gaming GXT 980 REDEX", "Corsair M55 RGB PRO" };
        ArrayList productos = new ArrayList(Producto);
        Ventas venta = new Ventas();

        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            llenarProductos();
            InicializarTemporizador();
            limpiarCampos();
        }

        private void llenarProductos()
        {
            foreach (string i in productos)
            {
                cmbProducto.Items.Add(i);
            }
        }

        private void limpiarCampos()
        {
            txtCliente.Clear();
            cmbProducto.Text = "Seleccione un producto";
            txtCliente.Clear();
            lblPrecio.Text = "0,00";
            lblTotalNeto.Text = "0,00";
            txtCantidad.Clear();
            txtCliente.Focus();
        }

        private void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void InicializarTemporizador()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            mostrarFecha();
            mostrarHora();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarHora();
        }

        private void actualizarTotalNeto()
        {
            double totalNeto = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                string producto = item.SubItems[0].Text;
                venta.Producto = producto;
                double neto = venta.calcularNeto();

                totalNeto += neto;
            }
            lblTotalNeto.Text = totalNeto.ToString("0.00");
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            venta.Producto = cmbProducto.Text;
            lblPrecio.Text = venta.asignarPrecios().ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                venta.Cantidad = cantidad;

                double precio = venta.asignarPrecios();
                double subtotal = venta.calcularSubtotal();
                double descuento = venta.calcularDescuento();
                double neto = venta.calcularNeto();

                ListViewItem item = new ListViewItem(venta.Producto);
                item.SubItems.Add(cantidad.ToString());
                item.SubItems.Add(precio.ToString("0.00"));
                item.SubItems.Add(subtotal.ToString("0.00"));
                item.SubItems.Add(descuento.ToString("0.00"));
                item.SubItems.Add(neto.ToString("0.00"));

                listView1.Items.Add(item);

                limpiarCampos();
                actualizarTotalNeto();
            }
            else
            {
                MessageBox.Show("Por favor ingresa una cantidad válida.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente deseas cerrar el programa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("La buen mostro", "Hasta luego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
