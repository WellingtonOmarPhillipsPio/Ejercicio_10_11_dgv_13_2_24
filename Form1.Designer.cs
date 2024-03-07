namespace Ejercicio_10_11_dgv_13_2_24
{
    partial class Form1
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
            btn_Agregar=new Button();
            btn_Eliminar=new Button();
            btn_Salir=new Button();
            btn_Limpiar=new Button();
            lbl_Nombre=new Label();
            lbl_Correo=new Label();
            txt_Nombre=new TextBox();
            txt_Correo=new TextBox();
            backgroundWorker1=new System.ComponentModel.BackgroundWorker();
            correo=new DataGridViewTextBoxColumn();
            nombre=new DataGridViewTextBoxColumn();
            dgv_datos=new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_datos).BeginInit();
            SuspendLayout();
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor=Color.Moccasin;
            btn_Agregar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agregar.Location=new Point(602, 87);
            btn_Agregar.Name="btn_Agregar";
            btn_Agregar.Size=new Size(75, 28);
            btn_Agregar.TabIndex=1;
            btn_Agregar.Text="Agregar";
            btn_Agregar.UseVisualStyleBackColor=false;
            btn_Agregar.Click+=btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor=Color.Moccasin;
            btn_Eliminar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.Location=new Point(602, 138);
            btn_Eliminar.Name="btn_Eliminar";
            btn_Eliminar.Size=new Size(75, 28);
            btn_Eliminar.TabIndex=2;
            btn_Eliminar.Text="Eliminar";
            btn_Eliminar.UseVisualStyleBackColor=false;
            btn_Eliminar.Click+=btn_Eliminar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=Color.Moccasin;
            btn_Salir.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(602, 193);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(75, 28);
            btn_Salir.TabIndex=3;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=Color.Moccasin;
            btn_Limpiar.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(602, 243);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(75, 28);
            btn_Limpiar.TabIndex=4;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize=true;
            lbl_Nombre.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Nombre.Location=new Point(74, 32);
            lbl_Nombre.Name="lbl_Nombre";
            lbl_Nombre.Size=new Size(63, 19);
            lbl_Nombre.TabIndex=5;
            lbl_Nombre.Text="Nombre";
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize=true;
            lbl_Correo.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Correo.Location=new Point(74, 82);
            lbl_Correo.Name="lbl_Correo";
            lbl_Correo.Size=new Size(56, 19);
            lbl_Correo.TabIndex=6;
            lbl_Correo.Text="Correo";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location=new Point(152, 32);
            txt_Nombre.Name="txt_Nombre";
            txt_Nombre.Size=new Size(298, 23);
            txt_Nombre.TabIndex=7;
            // 
            // txt_Correo
            // 
            txt_Correo.Location=new Point(152, 82);
            txt_Correo.Name="txt_Correo";
            txt_Correo.Size=new Size(298, 23);
            txt_Correo.TabIndex=8;
            // 
            // correo
            // 
            correo.HeaderText="Correo";
            correo.Name="correo";
            correo.ReadOnly=true;
            correo.Width=250;
            // 
            // nombre
            // 
            nombre.HeaderText="Nombre";
            nombre.Name="nombre";
            nombre.ReadOnly=true;
            nombre.Width=200;
            // 
            // dgv_datos
            // 
            dgv_datos.AllowUserToAddRows=false;
            dgv_datos.AllowUserToDeleteRows=false;
            dgv_datos.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_datos.Columns.AddRange(new DataGridViewColumn[] { nombre, correo });
            dgv_datos.Location=new Point(42, 138);
            dgv_datos.Name="dgv_datos";
            dgv_datos.ReadOnly=true;
            dgv_datos.RowTemplate.Height=25;
            dgv_datos.Size=new Size(484, 195);
            dgv_datos.TabIndex=0;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Nombre);
            Controls.Add(lbl_Correo);
            Controls.Add(lbl_Nombre);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Agregar);
            Controls.Add(dgv_datos);
            Name="Form1";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_datos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Agregar;
        private Button btn_Eliminar;
        private Button btn_Salir;
        private Button btn_Limpiar;
        private Label lbl_Nombre;
        private Label lbl_Correo;
        private TextBox txt_Nombre;
        private TextBox txt_Correo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridView dgv_datos;
    }
}