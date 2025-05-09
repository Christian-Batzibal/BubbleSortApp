namespace BubbleSortApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEstablecerCantidad;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Panel panelAscendente;
        private System.Windows.Forms.Panel panelDescendente;
        private System.Windows.Forms.Label lblAscendente;
        private System.Windows.Forms.Label lblDescendente;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnEstablecerCantidad = new Button();
            txtCantidad = new TextBox();
            lblEstado = new Label();
            txtEntrada = new TextBox();
            btnIngresar = new Button();
            txtOriginal = new TextBox();
            btnOrdenar = new Button();
            panelAscendente = new Panel();
            panelDescendente = new Panel();
            btnReiniciar = new Button();
            lblAscendente = new Label();
            lblDescendente = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnEstablecerCantidad
            // 
            btnEstablecerCantidad.BackColor = Color.DeepSkyBlue;
            btnEstablecerCantidad.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEstablecerCantidad.ForeColor = Color.White;
            btnEstablecerCantidad.Location = new Point(20, 50);
            btnEstablecerCantidad.Name = "btnEstablecerCantidad";
            btnEstablecerCantidad.Size = new Size(249, 40);
            btnEstablecerCantidad.TabIndex = 0;
            btnEstablecerCantidad.Text = "Establecer Cantidad";
            btnEstablecerCantidad.UseVisualStyleBackColor = false;
            btnEstablecerCantidad.Click += btnEstablecerCantidad_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial", 12F);
            txtCantidad.Location = new Point(275, 55);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(50, 30);
            txtCantidad.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Arial", 12F);
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(20, 90);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(987, 40);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Ingrese la cantidad de numeros que quiere ordenar (Solo 10 numeros por consulta)";
            // 
            // txtEntrada
            // 
            txtEntrada.Enabled = false;
            txtEntrada.Font = new Font("Arial", 12F);
            txtEntrada.Location = new Point(236, 147);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(260, 30);
            txtEntrada.TabIndex = 3;
            txtEntrada.KeyDown += txtEntrada_KeyDown;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DodgerBlue;
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(20, 142);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(200, 40);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar Número";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtOriginal
            // 
            txtOriginal.Enabled = false;
            txtOriginal.Font = new Font("Arial", 12F);
            txtOriginal.Location = new Point(20, 256);
            txtOriginal.Multiline = true;
            txtOriginal.Name = "txtOriginal";
            txtOriginal.Size = new Size(270, 71);
            txtOriginal.TabIndex = 5;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.DodgerBlue;
            btnOrdenar.Enabled = false;
            btnOrdenar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnOrdenar.ForeColor = Color.White;
            btnOrdenar.Location = new Point(20, 348);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(200, 40);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // panelAscendente
            // 
            panelAscendente.Location = new Point(20, 432);
            panelAscendente.Name = "panelAscendente";
            panelAscendente.Size = new Size(625, 77);
            panelAscendente.TabIndex = 11;
            // 
            // panelDescendente
            // 
            panelDescendente.Location = new Point(20, 542);
            panelDescendente.Name = "panelDescendente";
            panelDescendente.Size = new Size(625, 87);
            panelDescendente.TabIndex = 10;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.DeepSkyBlue;
            btnReiniciar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(723, 758);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(317, 40);
            btnReiniciar.TabIndex = 7;
            btnReiniciar.Text = "Realizar Otro Ordenamiento";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblAscendente
            // 
            lblAscendente.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblAscendente.ForeColor = Color.DimGray;
            lblAscendente.Location = new Point(20, 402);
            lblAscendente.Name = "lblAscendente";
            lblAscendente.Size = new Size(400, 25);
            lblAscendente.TabIndex = 8;
            lblAscendente.Text = "Ordenamiento Ascendente";
            // 
            // lblDescendente
            // 
            lblDescendente.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDescendente.ForeColor = Color.DimGray;
            lblDescendente.Location = new Point(20, 512);
            lblDescendente.Name = "lblDescendente";
            lblDescendente.Size = new Size(400, 25);
            lblDescendente.TabIndex = 9;
            lblDescendente.Text = "Ordenamiento Descendente";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Enabled = false;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 210);
            button1.Name = "button1";
            button1.Size = new Size(305, 40);
            button1.TabIndex = 12;
            button1.Text = "Los numeros ingresados";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1060, 810);
            Controls.Add(button1);
            Controls.Add(lblDescendente);
            Controls.Add(lblAscendente);
            Controls.Add(btnReiniciar);
            Controls.Add(panelDescendente);
            Controls.Add(panelAscendente);
            Controls.Add(btnOrdenar);
            Controls.Add(txtOriginal);
            Controls.Add(btnIngresar);
            Controls.Add(txtEntrada);
            Controls.Add(lblEstado);
            Controls.Add(txtCantidad);
            Controls.Add(btnEstablecerCantidad);
            Name = "Form1";
            Text = "Aplicación de Ordenamiento (BubbleSort)";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
