using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setPixelColorForArduino
{
    public partial class FormSetPixelColor : Form
    {
        public FormSetPixelColor()
        {
            InitializeComponent();
        }


        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openImageFileDialog = new OpenFileDialog())
            {
                openImageFileDialog.Filter = "Archivos bmp (*.bmp)| *.bmp | Todos los Archivos(*.*) | *.*";
                openImageFileDialog.RestoreDirectory = true;
                if (openImageFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxPathFile.Text = openImageFileDialog.FileName;
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxImagen.ClientSize = new Size(200, 200);
                    this.pictureBoxImagen.Image = new Bitmap(openImageFileDialog.FileName);
                }
            }
        }

        private void buttonGenerarCodigo_Click(object sender, EventArgs e)
        {
            Bitmap imageDisplay;
            try
            {
                string fileImageDisplay = this.textBoxPathFile.Text.Trim();
                // Retrieve the image.
                if (!File.Exists(fileImageDisplay))
                {
                    return;
                }
                imageDisplay = new Bitmap(fileImageDisplay, true);
                int x, y;
                string setPixelColor = string.Empty;
                int myCount = 0;
                string prefijoObjeto = !string.IsNullOrEmpty(textBoxPrefijoObjeto.Text) ? textBoxPrefijoObjeto.Text : "tira";
                // Loop through the images pixels to reset color.
                for (y = 0; y < imageDisplay.Height; y++)
                {
                    for (x = 0; x < imageDisplay.Width; x++)
                    {
                        Color pixelColor = imageDisplay.GetPixel(x, y);
                        setPixelColor += $"{prefijoObjeto }.setPixelColor({myCount},{pixelColor.R},{pixelColor.G},{pixelColor.B});";
                        myCount++;
                    }
                }
                this.textBoxCodigoArduinio.Text = setPixelColor;
            }
            catch (Exception except)
            {

                Console.WriteLine("Error : " + except.InnerException.Message);
            }
        }

        private void textBoxPathFile_Leave(object sender, EventArgs e)
        {
            // Retrieve the image.
            //    if (!File.Exists(this.textBoxPathFile.Text.Trim()))
            //    {
            //        this.pictureBoxImagen.Image = new Bitmap(this.textBoxPathFile.Text.Trim());
            //    }
            //
        }

        private void buttonCopiarClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBoxCodigoArduinio.Text);
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
