
namespace Currensy_cours
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.currency_converted = new System.Windows.Forms.TextBox();
            this.currency = new System.Windows.Forms.TextBox();
            this.cooseValute_2 = new System.Windows.Forms.Label();
            this.cooseValute_1 = new System.Windows.Forms.Label();
            this.valute_1 = new System.Windows.Forms.Label();
            this.valute_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currency_converted
            // 
            this.currency_converted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currency_converted.Location = new System.Drawing.Point(255, 71);
            this.currency_converted.Name = "currency_converted";
            this.currency_converted.Size = new System.Drawing.Size(122, 22);
            this.currency_converted.TabIndex = 0;
            this.currency_converted.Text = "0";
            this.currency_converted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currency_converted.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currency_converted_KeyPress);
            // 
            // currency
            // 
            this.currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currency.Location = new System.Drawing.Point(55, 71);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(122, 22);
            this.currency.TabIndex = 1;
            this.currency.Text = "0";
            this.currency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currency_KeyPress);
            // 
            // cooseValute_2
            // 
            this.cooseValute_2.AutoSize = true;
            this.cooseValute_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cooseValute_2.Location = new System.Drawing.Point(252, 141);
            this.cooseValute_2.Name = "cooseValute_2";
            this.cooseValute_2.Size = new System.Drawing.Size(125, 17);
            this.cooseValute_2.TabIndex = 4;
            this.cooseValute_2.Text = "Выберите валюту";
            this.cooseValute_2.Click += new System.EventHandler(this.cooseValute_2_Click);
            // 
            // cooseValute_1
            // 
            this.cooseValute_1.AutoSize = true;
            this.cooseValute_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cooseValute_1.Location = new System.Drawing.Point(52, 141);
            this.cooseValute_1.Name = "cooseValute_1";
            this.cooseValute_1.Size = new System.Drawing.Size(125, 17);
            this.cooseValute_1.TabIndex = 5;
            this.cooseValute_1.Text = "Выберите валюту";
            this.cooseValute_1.Click += new System.EventHandler(this.cooseValute_1_Click);
            // 
            // valute_1
            // 
            this.valute_1.AutoSize = true;
            this.valute_1.Location = new System.Drawing.Point(96, 109);
            this.valute_1.Name = "valute_1";
            this.valute_1.Size = new System.Drawing.Size(46, 17);
            this.valute_1.TabIndex = 6;
            this.valute_1.Text = "label1";
            // 
            // valute_2
            // 
            this.valute_2.AutoSize = true;
            this.valute_2.Location = new System.Drawing.Point(298, 109);
            this.valute_2.Name = "valute_2";
            this.valute_2.Size = new System.Drawing.Size(46, 17);
            this.valute_2.TabIndex = 7;
            this.valute_2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(435, 234);
            this.Controls.Add(this.valute_2);
            this.Controls.Add(this.valute_1);
            this.Controls.Add(this.cooseValute_1);
            this.Controls.Add(this.cooseValute_2);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.currency_converted);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currency_converted;
        private System.Windows.Forms.TextBox currency;
        private System.Windows.Forms.Label cooseValute_2;
        private System.Windows.Forms.Label cooseValute_1;
        private System.Windows.Forms.Label valute_1;
        private System.Windows.Forms.Label valute_2;
    }
}

