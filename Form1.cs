using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SEMANA4
{
    public partial class Form1 : Form
    {
        private int clicksLabel = 0;
        private int segundos = 0;

        public Form1()
        {
            InitializeComponent();
            SuscribirEventos();
            txtEstadoTimer.Text = "00:00:00";
        }

        private void SuscribirEventos()
        {
            Action cambiarClick = () =>
            {
                clicksLabel++;
                lblEstadoClick.Text = $"Clics: {clicksLabel}";
                lblEstadoClick.BackColor = (clicksLabel % 2 == 0) ? Color.LightGreen : Color.Khaki;
            };

            lblEstadoClick.Click += (sender, e) => cambiarClick();
            panel5.Click += (sender, e) => cambiarClick();
            txtSoloNumeros.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    txtAvisoKeyPress.Text = $"Bloqueado '{e.KeyChar}' (Solo dígitos)";
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    txtAvisoKeyPress.Text = $"Dígito '{e.KeyChar}' permitido";
                }
            };
            panel3.BackgroundImage?.Dispose();
            panel3.BackgroundImage = null;
            pnlImagen.AllowDrop = true;
            pnlImagen.BackgroundImageLayout = ImageLayout.Zoom;

            pnlImagen.DragEnter += (sender, e) =>
            {
                if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[]? archivos = e.Data.GetData(DataFormats.FileDrop) as string[];
                    if (archivos != null && archivos.Length > 0 && EsImagenValida(archivos[0]))
                    {
                        e.Effect = DragDropEffects.Copy;
                        txtEstadoImagen.Text = "Sueltame tu imagen aqui";
                        return;
                    }
                }
                e.Effect = DragDropEffects.None;
                txtEstadoImagen.Text = "Archivo no valido revisa bien";
            };

            pnlImagen.DragDrop += (sender, e) =>
            {
                string[]? archivos = e.Data?.GetData(DataFormats.FileDrop) as string[];
                if (archivos != null && archivos.Length > 0 && EsImagenValida(archivos[0]))
                {
                    pnlImagen.BackgroundImage?.Dispose();
                    pnlImagen.BackgroundImage = Image.FromFile(archivos[0]);
                    txtEstadoImagen.Text = Path.GetFileName(archivos[0]);
                }
            };
            btnIniciar.Click += (sender, e) => tmrContador.Start();
            btnDetener.Click += (sender, e) => tmrContador.Stop();
            btnReiniciar.Click += (sender, e) =>
            {
                tmrContador.Stop();
                segundos = 0;
                txtEstadoTimer.Text = "00:00:00";
            };
            tmrContador.Tick += (sender, e) =>
            {
                segundos++;
                txtEstadoTimer.Text = TimeSpan.FromSeconds(segundos).ToString(@"hh\:mm\:ss");
            };
        }

        private bool EsImagenValida(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo)) return false;

            string[] extensionesPermitidas = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp" };
            string extension = Path.GetExtension(rutaArchivo).ToLowerInvariant();

            if (extensionesPermitidas.Contains(extension))
                return true;
            try
            {
                using var img = Image.FromFile(rutaArchivo);
                return img.Width > 0 && img.Height > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
