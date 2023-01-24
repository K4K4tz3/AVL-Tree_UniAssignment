namespace AVL_Tree
{
    public partial class StartWindow : Form
    {
        AVLTree _avl;
        private string _dataPath;
        public StartWindow()
        {
            InitializeStartComponent();
            _dataPath = Path.GetFullPath("AVL-Tree/saveData/");
        }

        private void LoadAVLMenu(object sender, EventArgs e)
        {
            Hide();
            InitiliazeAVLComponent();
        }
        private void ImportList(object sender, EventArgs e)
        {
            // ToDo Import function
        }
        private void Hide()
        {
            _pbLogo.Dispose();
            _startButton.Dispose();
            _importButton.Dispose();
        }
        private void AddNode(object sender, EventArgs e)
        {
            if (_nodeValueInput.Text == "") return;
            if(_avl == null)
            {
                if(int.TryParse(_nodeValueInput.Text, out int input))
                {
                    _avl = new AVLTree(input.GetType());
                    _avl.Add(input);
                }
                else
                {
                    _avl = new AVLTree(_nodeValueInput.Text.GetType());
                    _avl.Add(_nodeValueInput.Text);
                }
            }
            else
            {
                if (int.TryParse(_nodeValueInput.Text, out int input)) _avl.Add(input);
                else _avl.Add(_nodeValueInput.Text);
            }

            Label tempLabel = new Label();
            tempLabel.Text = _nodeValueInput.Text;
            tempLabel.BackColor = Color.LightCoral;
            tempLabel.Margin = new Padding(2); 
            _nodeList.Controls.Add(tempLabel);
        }
        private async void Save(object sender, EventArgs e)
        {
            if (_avl == null) return;
            string name = _avl.ListName == "" ? _avl.CreationDate.ToString("d") : _avl.ListName;
            name = name.Replace('/', '-');
            string path = _dataPath + $"{name}.txt";
            using (StreamWriter sw = File.CreateText(path)) ;

            List<string> linesToSave = new List<string>{ _avl.ListName, _avl.CreationDate.ToString("d"), _avl.ModificationDate.ToString("d") };
            foreach (Node item in _avl.Nodes)
            {

                if(item.Data.GetType() == typeof(string)) linesToSave.Add(item.Data);
                else linesToSave.Add(item.Data.ToString());
            }

            string[] saveData = linesToSave.ToArray();

            await File.WriteAllLinesAsync(path, linesToSave);
        }
        
        private void InitializeComponent()
        {
            this._nodeAddButton = new System.Windows.Forms.Button();
            this._nodeList = new System.Windows.Forms.FlowLayoutPanel();
            this._nodeValueInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button: Add Node
            // 
            this._nodeAddButton.Location = new System.Drawing.Point(428, 256);
            this._nodeAddButton.Name = "AddNode";
            this._nodeAddButton.Size = new System.Drawing.Size(75, 23);
            this._nodeAddButton.TabIndex = 0;
            this._nodeAddButton.Text = "AddNode";
            this._nodeAddButton.UseVisualStyleBackColor = true;
            this._nodeAddButton.Click += new EventHandler(this.AddNode);
            // 
            // flowLayoutPanel: Node List
            // 
            this._nodeList.Location = new System.Drawing.Point(27, 36);
            this._nodeList.Name = "NodeList";
            this._nodeList.Size = new System.Drawing.Size(280, 525);
            this._nodeList.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(1083, 593);
            this.Controls.Add(this._nodeValueInput);
            this.Controls.Add(this._nodeList);
            this.Controls.Add(this._nodeAddButton);
            this.Name = "StartWindow";
            this.ResumeLayout(false);
            this.PerformLayout();


        }
    }
}