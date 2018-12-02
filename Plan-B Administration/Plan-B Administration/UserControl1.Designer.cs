namespace Plan_B_Administration
{
    partial class todo_item
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.todolbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelTask = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelTask)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.Checked = false;
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(49, 11);
            this.check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 0;
            this.check.OnChange += new System.EventHandler(this.check_OnChange);
            // 
            // todolbl
            // 
            this.todolbl.AutoSize = true;
            this.todolbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todolbl.Location = new System.Drawing.Point(115, 6);
            this.todolbl.Name = "todolbl";
            this.todolbl.Size = new System.Drawing.Size(98, 25);
            this.todolbl.TabIndex = 1;
            this.todolbl.Text = "to do item";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnDelTask
            // 
            this.btnDelTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelTask.Image = global::Plan_B_Administration.Properties.Resources.Waste_48px;
            this.btnDelTask.ImageActive = null;
            this.btnDelTask.Location = new System.Drawing.Point(427, 3);
            this.btnDelTask.Name = "btnDelTask";
            this.btnDelTask.Size = new System.Drawing.Size(35, 36);
            this.btnDelTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelTask.TabIndex = 2;
            this.btnDelTask.TabStop = false;
            this.btnDelTask.Zoom = 10;
            this.btnDelTask.Click += new System.EventHandler(this.btnDelTask_Click);
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnDelTask);
            this.Controls.Add(this.todolbl);
            this.Controls.Add(this.check);
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(484, 42);
            this.Load += new System.EventHandler(this.todo_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox check;
        private Bunifu.Framework.UI.BunifuCustomLabel todolbl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnDelTask;
    }
}
