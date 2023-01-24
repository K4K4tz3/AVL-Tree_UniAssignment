using System.Windows.Forms;

namespace AVL_Tree
{
    partial class StartWindow
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
        private void InitializeStartComponent()
        {
            this._pbLogo = new System.Windows.Forms.PictureBox();
            this._startButton = new System.Windows.Forms.Button();
            this._importButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox: AppLogo
            // 
            this._pbLogo.ImageLocation = "D:\\Programming\\projects\\AVL-Tree\\rsz_1rsz_avl_logo.png";
            this._pbLogo.Location = new System.Drawing.Point(this.Width/2, 49);
            this._pbLogo.Name = "AppLogo";
            this._pbLogo.Size = new System.Drawing.Size(541, 351);
            this._pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._pbLogo.TabIndex = 2;
            this._pbLogo.TabStop = false;
            // 
            // Button: Start
            // 
            this._startButton.Location = new System.Drawing.Point(296, 353);
            this._startButton.Name = "Start";
            this._startButton.Size = new System.Drawing.Size(154, 47);
            this._startButton.TabIndex = 3;
            this._startButton.Text = "Start";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new EventHandler(this.LoadAVLMenu);
            // 
            // Button: Import
            // 
            this._importButton.Location = new System.Drawing.Point(296, 410);
            this._importButton.Name = "Import";
            this._importButton.Size = new System.Drawing.Size(154, 47);
            this._importButton.TabIndex = 3;
            this._importButton.Text = "Import";
            this._importButton.UseVisualStyleBackColor = true;
            this._importButton.Click += new EventHandler(this.ImportList);
            // 
            // Window
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.MinimumSize = new Size(800, 530);
            this.MaximumSize = new Size(800, 530);
            this.Controls.Add(this._startButton);
            this.Controls.Add(this._importButton);
            this.Controls.Add(this._pbLogo);
            this.Name = "Window";
            ((System.ComponentModel.ISupportInitialize)(this._pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitiliazeAVLComponent()
        {
            this._nodeAddButton = new System.Windows.Forms.Button();
            this._nodeList = new System.Windows.Forms.FlowLayoutPanel();
            this._nodeValueInput = new System.Windows.Forms.TextBox();
            this._nodeSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button: Add Node
            // 
            this._nodeAddButton.Location = new System.Drawing.Point(428, 256);
            this._nodeAddButton.Name = "AddNode";
            this._nodeAddButton.Size = new System.Drawing.Size(75, 23);
            this._nodeAddButton.TabIndex = 0;
            this._nodeAddButton.Text = "Add Item";
            this._nodeAddButton.UseVisualStyleBackColor = true;
            this._nodeAddButton.Click += new EventHandler(this.AddNode);
            // 
            // button: Save
            // 
            this._nodeSaveButton.Location = new System.Drawing.Point(428, 279);
            this._nodeSaveButton.Name = "Save";
            this._nodeSaveButton.Size = new System.Drawing.Size(75, 23);
            this._nodeSaveButton.TabIndex = 0;
            this._nodeSaveButton.Text = "Save";
            this._nodeSaveButton.UseVisualStyleBackColor = true;
            this._nodeSaveButton.Click += new EventHandler(this.Save);
            // 
            // flowLayoutPanel: Node List
            // 
            this._nodeList.Location = new System.Drawing.Point(27, 30);
            this._nodeList.Name = "NodeList";
            this._nodeList.Size = new System.Drawing.Size(280, 500);
            this._nodeList.TabIndex = 1;
            this._nodeList.BackColor = Color.LightGray;
            // 
            // textBox: Node Value Input
            // 
            this._nodeValueInput.Location = new System.Drawing.Point(392, 194);
            this._nodeValueInput.Name = "NodeValueInput";
            this._nodeValueInput.Size = new System.Drawing.Size(147, 23);
            this._nodeValueInput.TabIndex = 2;
            // 
            // StartWindow
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            this.Controls.Add(this._nodeValueInput);
            this.Controls.Add(this._nodeList);
            this.Controls.Add(this._nodeAddButton);
            this.Controls.Add(this._nodeSaveButton);
            this.Name = "StartWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private PictureBox _pbLogo;
        private Button _startButton;
        private Button _importButton;
        private Button _nodeAddButton;
        private FlowLayoutPanel _nodeList;
        private TextBox _nodeValueInput;
        private Button _nodeSaveButton;
    }
}