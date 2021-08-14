
namespace WindowsFormsApp1
{
    partial class frmprestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadquirir = new System.Windows.Forms.Button();
            this.gbdetalle = new System.Windows.Forms.GroupBox();
            this.btndevoluciòn = new System.Windows.Forms.Button();
            this.txtnombrelibro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbdetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(335, 178);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(97, 28);
            this.btnborrar.TabIndex = 19;
            this.btnborrar.Text = "Limpiar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(317, 18);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(97, 28);
            this.btnbuscar.TabIndex = 18;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(137, 20);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(172, 22);
            this.txtbuscar.TabIndex = 16;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Libreria MMXXI\r\nPréstamo de Libro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnadquirir
            // 
            this.btnadquirir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadquirir.Location = new System.Drawing.Point(17, 178);
            this.btnadquirir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadquirir.Name = "btnadquirir";
            this.btnadquirir.Size = new System.Drawing.Size(97, 28);
            this.btnadquirir.TabIndex = 29;
            this.btnadquirir.Text = "Adquirir";
            this.btnadquirir.UseVisualStyleBackColor = true;
            this.btnadquirir.Click += new System.EventHandler(this.btnadquirir_Click);
            // 
            // gbdetalle
            // 
            this.gbdetalle.Controls.Add(this.btndevoluciòn);
            this.gbdetalle.Controls.Add(this.btnborrar);
            this.gbdetalle.Controls.Add(this.txtnombrelibro);
            this.gbdetalle.Controls.Add(this.label2);
            this.gbdetalle.Controls.Add(this.btnadquirir);
            this.gbdetalle.Controls.Add(this.label6);
            this.gbdetalle.Controls.Add(this.label3);
            this.gbdetalle.Controls.Add(this.txtbuscar);
            this.gbdetalle.Controls.Add(this.txtautor);
            this.gbdetalle.Controls.Add(this.btnbuscar);
            this.gbdetalle.Controls.Add(this.label4);
            this.gbdetalle.Controls.Add(this.txtestado);
            this.gbdetalle.Controls.Add(this.txtgenero);
            this.gbdetalle.Controls.Add(this.label5);
            this.gbdetalle.Location = new System.Drawing.Point(5, 69);
            this.gbdetalle.Name = "gbdetalle";
            this.gbdetalle.Size = new System.Drawing.Size(450, 221);
            this.gbdetalle.TabIndex = 32;
            this.gbdetalle.TabStop = false;
            this.gbdetalle.Text = "DETALLES DE LIBRO";
            // 
            // btndevoluciòn
            // 
            this.btndevoluciòn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndevoluciòn.Location = new System.Drawing.Point(177, 178);
            this.btndevoluciòn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndevoluciòn.Name = "btndevoluciòn";
            this.btndevoluciòn.Size = new System.Drawing.Size(97, 28);
            this.btndevoluciòn.TabIndex = 30;
            this.btndevoluciòn.Text = "Devolución";
            this.btndevoluciòn.UseVisualStyleBackColor = true;
            this.btndevoluciòn.Click += new System.EventHandler(this.btndevoluciòn_Click);
            // 
            // txtnombrelibro
            // 
            this.txtnombrelibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrelibro.Location = new System.Drawing.Point(137, 80);
            this.txtnombrelibro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombrelibro.Name = "txtnombrelibro";
            this.txtnombrelibro.ReadOnly = true;
            this.txtnombrelibro.Size = new System.Drawing.Size(172, 22);
            this.txtnombrelibro.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Autor";
            // 
            // txtautor
            // 
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(137, 110);
            this.txtautor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtautor.Name = "txtautor";
            this.txtautor.ReadOnly = true;
            this.txtautor.Size = new System.Drawing.Size(172, 22);
            this.txtautor.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestado.Location = new System.Drawing.Point(137, 140);
            this.txtestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(172, 22);
            this.txtestado.TabIndex = 23;
            // 
            // txtgenero
            // 
            this.txtgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgenero.Location = new System.Drawing.Point(137, 50);
            this.txtgenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.ReadOnly = true;
            this.txtgenero.Size = new System.Drawing.Size(172, 22);
            this.txtgenero.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Género";
            // 
            // frmprestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 302);
            this.Controls.Add(this.gbdetalle);
            this.Controls.Add(this.label1);
            this.Name = "frmprestamo";
            this.Text = "Préstamo Sistema Biblioteca V.10";
            this.Load += new System.EventHandler(this.frmprestamo_Load);
            this.gbdetalle.ResumeLayout(false);
            this.gbdetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadquirir;
        private System.Windows.Forms.GroupBox gbdetalle;
        private System.Windows.Forms.TextBox txtnombrelibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndevoluciòn;
    }
}