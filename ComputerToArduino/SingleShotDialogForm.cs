using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComputerToArduino
{
    public class SingleShotDialogForm : Form
    {
        private readonly Dictionary<string, string> ListLaunchPad = new Dictionary<string, string>
        {
            { "Launch Pad 1", "LP1" },
            { "Launch Pad 2", "LP2" },
            { "Launch Pad 3", "LP3" },
            { "Launch Pad 4", "LP4" },
            { "Launch Pad 5", "LP5" },
            { "Launch Pad 6", "LP6" },
            { "Launch Pad 7", "LP7" },
            { "Launch Pad 8", "LP8" },
            { "Launch Pad 9", "LP9" },
            { "Launch Pad 10", "LP10" },
            { "Launch Pad 11", "LP11" },
            { "Launch Pad 12", "LP12" },
            { "Launch Pad 13", "LP13" },
            { "Launch Pad 14", "LP14" },
            { "Launch Pad 15", "LP15" },
            { "Launch Pad 16", "LP16" },
            { "Launch Pad 17", "LP17" },
            { "Launch Pad 18", "LP18" }

        };

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label1;

        public SingleShotDialogForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog; // Remove standard window border
            StartPosition = FormStartPosition.CenterScreen; // Control popup position
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Check1",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Check 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Check3");
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Shot";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select launch pad to shot";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(207, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(122, 85);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MultiSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Breakfast Item";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Key";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // SingleShotDialogForm
            // 
            this.ClientSize = new System.Drawing.Size(372, 165);
            this.Controls.Add(this.listView1);
            this.Name = "SingleShotDialogForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}