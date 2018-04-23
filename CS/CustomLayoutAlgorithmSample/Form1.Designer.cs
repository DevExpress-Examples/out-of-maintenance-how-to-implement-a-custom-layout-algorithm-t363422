namespace CustomLayoutAlgorithmSample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapItemStorage treeMapItemStorage1 = new DevExpress.XtraTreeMap.TreeMapItemStorage();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem1 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem2 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem3 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem4 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem5 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem6 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem7 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem8 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem9 = new DevExpress.XtraTreeMap.TreeMapItem();
            DevExpress.XtraTreeMap.TreeMapItem treeMapItem10 = new DevExpress.XtraTreeMap.TreeMapItem();
            this.treeMap = new DevExpress.XtraTreeMap.TreeMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMap
            // 
            this.treeMap.BackColor = System.Drawing.Color.White;
            treeMapPaletteColorizer1.ColorizeGroups = true;
            treeMapPaletteColorizer1.Palette = DevExpress.XtraTreeMap.Palette.Office2016Palette;
            this.treeMap.Colorizer = treeMapPaletteColorizer1;
            treeMapItem1.Label = "United States";
            treeMapItem1.Value = 17.418D;
            treeMapItem2.Label = "Brazil";
            treeMapItem2.Value = 2.353D;
            treeMapItem3.Label = "China";
            treeMapItem3.Value = 10.38D;
            treeMapItem4.Label = "Japan";
            treeMapItem4.Value = 4.616D;
            treeMapItem5.Label = "India";
            treeMapItem5.Value = 2.049D;
            treeMapItem6.Label = "Germany";
            treeMapItem6.Value = 3.859D;
            treeMapItem7.Label = "United Kingdom";
            treeMapItem7.Value = 2.945D;
            treeMapItem8.Label = "France";
            treeMapItem8.Value = 2.846D;
            treeMapItem9.Label = "Italy";
            treeMapItem9.Value = 2.147D;
            treeMapItem10.Label = "Russia";
            treeMapItem10.Value = 1.857D;
            treeMapItemStorage1.Items.AddRange(new DevExpress.XtraTreeMap.TreeMapItem[] {
            treeMapItem1,
            treeMapItem2,
            treeMapItem3,
            treeMapItem4,
            treeMapItem5,
            treeMapItem6,
            treeMapItem7,
            treeMapItem8,
            treeMapItem9,
            treeMapItem10});
            this.treeMap.DataAdapter = treeMapItemStorage1;
            this.treeMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMap.GroupStyle.Fill = System.Drawing.Color.White;
            this.treeMap.GroupStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMap.LeafStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMap.LeafTextPattern = "{L} : {V:C1} trillions";
            this.treeMap.Location = new System.Drawing.Point(0, 0);
            this.treeMap.Name = "treeMap";
            this.treeMap.Size = new System.Drawing.Size(624, 321);
            this.treeMap.TabIndex = 0;
            this.treeMap.ToolTipGroupPattern = "";
            this.treeMap.ToolTipLeafPattern = "{L} : {V:C1} trillions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.treeMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeMap.TreeMapControl treeMap;
    }
}

