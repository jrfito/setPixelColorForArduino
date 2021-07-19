
namespace setPixelColorForArduino
{
    partial class FormSetPixelColor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openImageFile = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPathFile = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxCodigoArduinio = new System.Windows.Forms.TextBox();
            this.groupBoxImagen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrefijoObjeto = new System.Windows.Forms.TextBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.buttonGenerarCodigo = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonCopiarClipBoard = new System.Windows.Forms.Button();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // openImageFile
            // 
            this.openImageFile.FileName = "openImageFile";
            // 
            // textBoxPathFile
            // 
            this.textBoxPathFile.Location = new System.Drawing.Point(8, 21);
            this.textBoxPathFile.Name = "textBoxPathFile";
            this.textBoxPathFile.Size = new System.Drawing.Size(583, 23);
            this.textBoxPathFile.TabIndex = 0;
            this.textBoxPathFile.Leave += new System.EventHandler(this.textBoxPathFile_Leave);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(594, 21);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(23, 23);
            this.buttonSelectFile.TabIndex = 1;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxCodigoArduinio
            // 
            this.textBoxCodigoArduinio.Enabled = false;
            this.textBoxCodigoArduinio.Location = new System.Drawing.Point(8, 287);
            this.textBoxCodigoArduinio.Multiline = true;
            this.textBoxCodigoArduinio.Name = "textBoxCodigoArduinio";
            this.textBoxCodigoArduinio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCodigoArduinio.Size = new System.Drawing.Size(606, 234);
            this.textBoxCodigoArduinio.TabIndex = 3;
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.Controls.Add(this.label1);
            this.groupBoxImagen.Controls.Add(this.textBoxPrefijoObjeto);
            this.groupBoxImagen.Controls.Add(this.pictureBoxImagen);
            this.groupBoxImagen.Location = new System.Drawing.Point(8, 50);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(606, 231);
            this.groupBoxImagen.TabIndex = 4;
            this.groupBoxImagen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(414, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prefijo Objeto Adafruit_NeoPixel";
            // 
            // textBoxPrefijoObjeto
            // 
            this.textBoxPrefijoObjeto.Location = new System.Drawing.Point(414, 40);
            this.textBoxPrefijoObjeto.Name = "textBoxPrefijoObjeto";
            this.textBoxPrefijoObjeto.Size = new System.Drawing.Size(178, 23);
            this.textBoxPrefijoObjeto.TabIndex = 4;
            this.textBoxPrefijoObjeto.Text = "tira";
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagen.Location = new System.Drawing.Point(203, 19);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImagen.TabIndex = 3;
            this.pictureBoxImagen.TabStop = false;
            // 
            // buttonGenerarCodigo
            // 
            this.buttonGenerarCodigo.Location = new System.Drawing.Point(458, 544);
            this.buttonGenerarCodigo.Name = "buttonGenerarCodigo";
            this.buttonGenerarCodigo.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerarCodigo.TabIndex = 5;
            this.buttonGenerarCodigo.Text = "Código";
            this.buttonGenerarCodigo.UseVisualStyleBackColor = true;
            this.buttonGenerarCodigo.Click += new System.EventHandler(this.buttonGenerarCodigo_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(539, 544);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonCopiarClipBoard
            // 
            this.buttonCopiarClipBoard.Location = new System.Drawing.Point(336, 544);
            this.buttonCopiarClipBoard.Name = "buttonCopiarClipBoard";
            this.buttonCopiarClipBoard.Size = new System.Drawing.Size(116, 23);
            this.buttonCopiarClipBoard.TabIndex = 7;
            this.buttonCopiarClipBoard.Text = "Copiar a ClipBoard";
            this.buttonCopiarClipBoard.UseVisualStyleBackColor = true;
            this.buttonCopiarClipBoard.Click += new System.EventHandler(this.buttonCopiarClipBoard_Click);
            // 
            // FormSetPixelColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 571);
            this.Controls.Add(this.buttonCopiarClipBoard);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonGenerarCodigo);
            this.Controls.Add(this.textBoxCodigoArduinio);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxPathFile);
            this.Controls.Add(this.groupBoxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSetPixelColor";
            this.Text = "Set Pixel Color";
            this.groupBoxImagen.ResumeLayout(false);
            this.groupBoxImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openImageFile;
        private System.Windows.Forms.TextBox textBoxPathFile;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox textBoxCodigoArduinio;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button buttonGenerarCodigo;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.TextBox textBoxPrefijoObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCopiarClipBoard;
    }
}

