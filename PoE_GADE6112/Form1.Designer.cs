
namespace PoE_GADE6112
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Attack = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.minWidth = new System.Windows.Forms.TextBox();
            this.maxWidth = new System.Windows.Forms.TextBox();
            this.minHeight = new System.Windows.Forms.TextBox();
            this.maxHeight = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(232, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 527);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Up
            // 
            this.Up.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Up.Location = new System.Drawing.Point(1280, 469);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(46, 38);
            this.Up.TabIndex = 1;
            this.Up.Text = "^";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Down.Location = new System.Drawing.Point(1280, 576);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(46, 38);
            this.Down.TabIndex = 2;
            this.Down.Text = "v";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Left.Location = new System.Drawing.Point(1188, 522);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(46, 38);
            this.Left.TabIndex = 3;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Right.Location = new System.Drawing.Point(1363, 522);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(46, 38);
            this.Right.TabIndex = 4;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Attack
            // 
            this.Attack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Attack.Location = new System.Drawing.Point(99, 204);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(137, 31);
            this.Attack.TabIndex = 5;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(13, 241);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(305, 123);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.Attack);
            this.panel2.Location = new System.Drawing.Point(1137, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 379);
            this.panel2.TabIndex = 11;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox3.Location = new System.Drawing.Point(15, 48);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(303, 148);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Goblin [X, Y] 10 HP (10)",
            "",
            "Hero [X, Y] 10 HP (10)"});
            this.comboBox1.Location = new System.Drawing.Point(15, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // minWidth
            // 
            this.minWidth.Location = new System.Drawing.Point(848, 80);
            this.minWidth.Name = "minWidth";
            this.minWidth.Size = new System.Drawing.Size(125, 27);
            this.minWidth.TabIndex = 12;
            // 
            // maxWidth
            // 
            this.maxWidth.Location = new System.Drawing.Point(848, 151);
            this.maxWidth.Name = "maxWidth";
            this.maxWidth.Size = new System.Drawing.Size(125, 27);
            this.maxWidth.TabIndex = 13;
            // 
            // minHeight
            // 
            this.minHeight.Location = new System.Drawing.Point(848, 221);
            this.minHeight.Name = "minHeight";
            this.minHeight.Size = new System.Drawing.Size(125, 27);
            this.minHeight.TabIndex = 14;
            // 
            // maxHeight
            // 
            this.maxHeight.Location = new System.Drawing.Point(848, 298);
            this.maxHeight.Name = "maxHeight";
            this.maxHeight.Size = new System.Drawing.Size(125, 27);
            this.maxHeight.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 724);
            this.Controls.Add(this.maxHeight);
            this.Controls.Add(this.minHeight);
            this.Controls.Add(this.maxWidth);
            this.Controls.Add(this.minWidth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private new System.Windows.Forms.Button Left;
        private new System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox minWidth;
        private System.Windows.Forms.TextBox maxWidth;
        private System.Windows.Forms.TextBox minHeight;
        private System.Windows.Forms.TextBox maxHeight;
    }
}

