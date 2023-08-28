using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendecita_Pa_Vender_Lo_Que_Ustedes_No_Pueden
{
    internal class Ventas
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }

        public double asignarPrecios()
        {
            switch (Producto)
            {
                case "Razer Viper v2 PRO": return 560000;
                case "Logitech G502 HERO": return 250000;
                case "HyperX Pulsefire Haste": return 200000;
                case "ASUS TUF Gaming M4": return 220000;
                case "Glorious Model O y D": return 300000;
                case "Corsair SABRE RGB PRO": return 250000;
                case "BenQ Zowie EC3-C": return 350000;
                case "Endgame GEAR XM1": return 300000;
                case "Corsair Harpoon RGB PRO / Wireless": return 150000;
                case "Logitech G203 LightSync": return 100000;
                case "MSI CLUTCH GM41 LIGHTWEIGHT V2": return 200000;
                case "Krom Kaiyu": return 110000;
                case "Trust Gaming GXT 980 REDEX": return 150000;
                case "Corsair M55 RGB PRO": return 170000;
            }
            return 0;
        }

        public double calcularSubtotal()
        {
            return asignarPrecios() * Cantidad; 
        }

        public double calcularDescuento()
        {
            double subtotal = calcularSubtotal();

            if (subtotal <= 1000000) return 10.0 / 100 * subtotal;
            else if (subtotal > 1000000 && subtotal <= 3000000) return 15.0 / 100 * subtotal;
            else return 20.0 / 100 * subtotal;
        }

        public double calcularNeto()
        {
            return calcularSubtotal() - calcularDescuento();
        }
    }
}

