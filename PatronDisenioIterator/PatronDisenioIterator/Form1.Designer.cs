namespace PatronDisenioIterator
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.txtElemento = new System.Windows.Forms.TextBox();
      this.btn_guardar = new System.Windows.Forms.Button();
      this.dgv_elemento = new System.Windows.Forms.DataGridView();
      this.btn_mostrar = new System.Windows.Forms.Button();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_elemento)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(62, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ingrese elementos";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtElemento
      // 
      this.txtElemento.Location = new System.Drawing.Point(174, 51);
      this.txtElemento.Name = "txtElemento";
      this.txtElemento.Size = new System.Drawing.Size(100, 20);
      this.txtElemento.TabIndex = 1;
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(268, 350);
      this.btn_guardar.Name = "btn_guardar";
      this.btn_guardar.Size = new System.Drawing.Size(75, 23);
      this.btn_guardar.TabIndex = 2;
      this.btn_guardar.Text = "Guardar";
      this.btn_guardar.UseVisualStyleBackColor = true;
      this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
      // 
      // dgv_elemento
      // 
      this.dgv_elemento.AllowUserToDeleteRows = false;
      this.dgv_elemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_elemento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
      this.dgv_elemento.Location = new System.Drawing.Point(140, 158);
      this.dgv_elemento.Name = "dgv_elemento";
      this.dgv_elemento.Size = new System.Drawing.Size(240, 150);
      this.dgv_elemento.TabIndex = 3;
      // 
      // btn_mostrar
      // 
      this.btn_mostrar.Location = new System.Drawing.Point(500, 386);
      this.btn_mostrar.Name = "btn_mostrar";
      this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
      this.btn_mostrar.TabIndex = 4;
      this.btn_mostrar.Text = "Mostrar";
      this.btn_mostrar.UseVisualStyleBackColor = true;
      this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Elemento";
      this.Column1.Name = "Column1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btn_mostrar);
      this.Controls.Add(this.dgv_elemento);
      this.Controls.Add(this.btn_guardar);
      this.Controls.Add(this.txtElemento);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgv_elemento)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtElemento;
    private System.Windows.Forms.Button btn_guardar;
    private System.Windows.Forms.DataGridView dgv_elemento;
    private System.Windows.Forms.Button btn_mostrar;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
  }
}

