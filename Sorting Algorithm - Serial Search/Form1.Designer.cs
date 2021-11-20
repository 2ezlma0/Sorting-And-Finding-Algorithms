
namespace Sorting_Algorithm___Serial_Search
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
            this.linearButton = new System.Windows.Forms.Button();
            this.nudItem = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.binaryButton = new System.Windows.Forms.Button();
            this.bubbleButton = new System.Windows.Forms.Button();
            this.bubble2Button = new System.Windows.Forms.Button();
            this.insertionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem)).BeginInit();
            this.SuspendLayout();
            // 
            // linearButton
            // 
            this.linearButton.Location = new System.Drawing.Point(378, 71);
            this.linearButton.Name = "linearButton";
            this.linearButton.Size = new System.Drawing.Size(100, 50);
            this.linearButton.TabIndex = 0;
            this.linearButton.Text = "Linear Or Serial Search";
            this.linearButton.UseVisualStyleBackColor = true;
            this.linearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudItem
            // 
            this.nudItem.Location = new System.Drawing.Point(239, 71);
            this.nudItem.Name = "nudItem";
            this.nudItem.Size = new System.Drawing.Size(120, 23);
            this.nudItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select the number to find:";
            // 
            // binaryButton
            // 
            this.binaryButton.Location = new System.Drawing.Point(299, 173);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(199, 102);
            this.binaryButton.TabIndex = 3;
            this.binaryButton.Text = "Binary Search";
            this.binaryButton.UseVisualStyleBackColor = true;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // bubbleButton
            // 
            this.bubbleButton.Location = new System.Drawing.Point(33, 173);
            this.bubbleButton.Name = "bubbleButton";
            this.bubbleButton.Size = new System.Drawing.Size(184, 102);
            this.bubbleButton.TabIndex = 4;
            this.bubbleButton.Text = "Bubble Sort (BROKEN)";
            this.bubbleButton.UseVisualStyleBackColor = true;
            this.bubbleButton.Click += new System.EventHandler(this.bubbleButton_Click);
            // 
            // bubble2Button
            // 
            this.bubble2Button.Location = new System.Drawing.Point(33, 281);
            this.bubble2Button.Name = "bubble2Button";
            this.bubble2Button.Size = new System.Drawing.Size(184, 102);
            this.bubble2Button.TabIndex = 5;
            this.bubble2Button.Text = "Bubble Sort V2 (BROKEN)";
            this.bubble2Button.UseVisualStyleBackColor = true;
            this.bubble2Button.Click += new System.EventHandler(this.bubble2Button_Click);
            // 
            // insertionButton
            // 
            this.insertionButton.Location = new System.Drawing.Point(299, 281);
            this.insertionButton.Name = "insertionButton";
            this.insertionButton.Size = new System.Drawing.Size(199, 102);
            this.insertionButton.TabIndex = 6;
            this.insertionButton.Text = "Insertion Sort";
            this.insertionButton.UseVisualStyleBackColor = true;
            this.insertionButton.Click += new System.EventHandler(this.insertionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 414);
            this.Controls.Add(this.insertionButton);
            this.Controls.Add(this.bubble2Button);
            this.Controls.Add(this.bubbleButton);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudItem);
            this.Controls.Add(this.linearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linearButton;
        private System.Windows.Forms.NumericUpDown nudItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button binaryButton;
        private System.Windows.Forms.Button bubbleButton;
        private System.Windows.Forms.Button bubble2Button;
        private System.Windows.Forms.Button insertionButton;
    }
}

