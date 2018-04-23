using System;
using System.Windows.Forms;

namespace CustomLayoutAlgorithmSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            treeMap.LayoutAlgorithm = new CustomLayoutAlgorithm();
        }
    }
}
