namespace ValegoProject
{
    partial class Principal
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
            btnGet = new Button();
            btnGuardar = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(40, 37);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(82, 35);
            btnGet.TabIndex = 37;
            btnGet.Text = "API Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(649, 37);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 35);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar DB";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(40, 87);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(753, 415);
            dgvData.TabIndex = 39;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 529);
            Controls.Add(dgvData);
            Controls.Add(btnGuardar);
            Controls.Add(btnGet);
            Name = "Principal";
            Text = "Ventana Principal";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnGet;
        private Button btnGuardar;
        private DataGridView dgvData;
    }
}