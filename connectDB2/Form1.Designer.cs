namespace connectDB2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtActualiser = new System.Windows.Forms.Button();
            this.BTdelete = new System.Windows.Forms.Button();
            this.BTadd = new System.Windows.Forms.Button();
            this.bsUtilisateurs = new System.Windows.Forms.BindingSource(this.components);
            this.MaintableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelItems = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.LbNom = new System.Windows.Forms.Label();
            this.LbPrenom = new System.Windows.Forms.Label();
            this.LbNaiss = new System.Windows.Forms.Label();
            this.dtpDtNaiss = new System.Windows.Forms.DateTimePicker();
            this.FLP_BT = new System.Windows.Forms.FlowLayoutPanel();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.userDataView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsUtilisateurs)).BeginInit();
            this.MaintableLayoutPanel.SuspendLayout();
            this.TableLayoutPanelItems.SuspendLayout();
            this.FLP_BT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtActualiser
            // 
            this.BtActualiser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtActualiser.AutoSize = true;
            this.BtActualiser.Location = new System.Drawing.Point(158, 3);
            this.BtActualiser.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.BtActualiser.Name = "BtActualiser";
            this.BtActualiser.Size = new System.Drawing.Size(132, 56);
            this.BtActualiser.TabIndex = 7;
            this.BtActualiser.Text = "Read";
            this.BtActualiser.UseVisualStyleBackColor = true;
            this.BtActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // BTdelete
            // 
            this.BTdelete.Location = new System.Drawing.Point(464, 3);
            this.BTdelete.Name = "BTdelete";
            this.BTdelete.Size = new System.Drawing.Size(139, 56);
            this.BTdelete.TabIndex = 6;
            this.BTdelete.Text = "Delelete";
            this.BTdelete.UseVisualStyleBackColor = true;
            this.BTdelete.Click += new System.EventHandler(this.BTdelete_Click);
            // 
            // BTadd
            // 
            this.BTadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTadd.Location = new System.Drawing.Point(30, 3);
            this.BTadd.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.BTadd.Name = "BTadd";
            this.BTadd.Size = new System.Drawing.Size(95, 56);
            this.BTadd.TabIndex = 5;
            this.BTadd.Text = "create";
            this.BTadd.UseVisualStyleBackColor = true;
            this.BTadd.Click += new System.EventHandler(this.BTadd_Click);
            // 
            // MaintableLayoutPanel
            // 
            this.MaintableLayoutPanel.ColumnCount = 1;
            this.MaintableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MaintableLayoutPanel.Controls.Add(this.TableLayoutPanelItems, 0, 1);
            this.MaintableLayoutPanel.Controls.Add(this.FLP_BT, 0, 2);
            this.MaintableLayoutPanel.Controls.Add(this.userDataView, 0, 0);
            this.MaintableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MaintableLayoutPanel.Name = "MaintableLayoutPanel";
            this.MaintableLayoutPanel.RowCount = 3;
            this.MaintableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MaintableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MaintableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MaintableLayoutPanel.Size = new System.Drawing.Size(664, 361);
            this.MaintableLayoutPanel.TabIndex = 0;
            // 
            // TableLayoutPanelItems
            // 
            this.TableLayoutPanelItems.AutoSize = true;
            this.TableLayoutPanelItems.ColumnCount = 2;
            this.TableLayoutPanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanelItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelItems.Controls.Add(this.TxtNom, 1, 0);
            this.TableLayoutPanelItems.Controls.Add(this.TxtPrenom, 1, 1);
            this.TableLayoutPanelItems.Controls.Add(this.LbNom, 0, 0);
            this.TableLayoutPanelItems.Controls.Add(this.LbPrenom, 0, 1);
            this.TableLayoutPanelItems.Controls.Add(this.LbNaiss, 0, 2);
            this.TableLayoutPanelItems.Controls.Add(this.dtpDtNaiss, 1, 2);
            this.TableLayoutPanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelItems.Location = new System.Drawing.Point(3, 203);
            this.TableLayoutPanelItems.Name = "TableLayoutPanelItems";
            this.TableLayoutPanelItems.RowCount = 3;
            this.TableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelItems.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelItems.Size = new System.Drawing.Size(658, 87);
            this.TableLayoutPanelItems.TabIndex = 3;
            // 
            // TxtNom
            // 
            this.TxtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNom.Location = new System.Drawing.Point(109, 3);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(546, 23);
            this.TxtNom.TabIndex = 2;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrenom.Location = new System.Drawing.Point(109, 32);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(546, 23);
            this.TxtPrenom.TabIndex = 3;
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbNom.Location = new System.Drawing.Point(3, 0);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(100, 29);
            this.LbNom.TabIndex = 4;
            this.LbNom.Text = "nom";
            this.LbNom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LbPrenom
            // 
            this.LbPrenom.AutoSize = true;
            this.LbPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbPrenom.Location = new System.Drawing.Point(3, 29);
            this.LbPrenom.Name = "LbPrenom";
            this.LbPrenom.Size = new System.Drawing.Size(100, 29);
            this.LbPrenom.TabIndex = 5;
            this.LbPrenom.Text = "prénom";
            this.LbPrenom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LbNaiss
            // 
            this.LbNaiss.AutoSize = true;
            this.LbNaiss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbNaiss.Location = new System.Drawing.Point(3, 58);
            this.LbNaiss.Name = "LbNaiss";
            this.LbNaiss.Size = new System.Drawing.Size(100, 29);
            this.LbNaiss.TabIndex = 6;
            this.LbNaiss.Text = "date de naissance";
            this.LbNaiss.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDtNaiss
            // 
            this.dtpDtNaiss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDtNaiss.Location = new System.Drawing.Point(109, 61);
            this.dtpDtNaiss.Name = "dtpDtNaiss";
            this.dtpDtNaiss.Size = new System.Drawing.Size(546, 23);
            this.dtpDtNaiss.TabIndex = 4;
            // 
            // FLP_BT
            // 
            this.FLP_BT.AutoSize = true;
            this.FLP_BT.Controls.Add(this.BTadd);
            this.FLP_BT.Controls.Add(this.BtActualiser);
            this.FLP_BT.Controls.Add(this.BtUpdate);
            this.FLP_BT.Controls.Add(this.BTdelete);
            this.FLP_BT.Location = new System.Drawing.Point(3, 296);
            this.FLP_BT.Name = "FLP_BT";
            this.FLP_BT.Size = new System.Drawing.Size(606, 62);
            this.FLP_BT.TabIndex = 1;
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(323, 3);
            this.BtUpdate.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(108, 56);
            this.BtUpdate.TabIndex = 8;
            this.BtUpdate.Text = "Update";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // userDataView
            // 
            this.userDataView.AllowUserToAddRows = false;
            this.userDataView.AllowUserToDeleteRows = false;
            this.userDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDataView.EnableHeadersVisualStyles = false;
            this.userDataView.Location = new System.Drawing.Point(3, 3);
            this.userDataView.MultiSelect = false;
            this.userDataView.Name = "userDataView";
            this.userDataView.ReadOnly = true;
            this.userDataView.RowHeadersVisible = false;
            this.userDataView.RowTemplate.Height = 25;
            this.userDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataView.Size = new System.Drawing.Size(658, 194);
            this.userDataView.StandardTab = true;
            this.userDataView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 361);
            this.Controls.Add(this.MaintableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(680, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bsUtilisateurs)).EndInit();
            this.MaintableLayoutPanel.ResumeLayout(false);
            this.MaintableLayoutPanel.PerformLayout();
            this.TableLayoutPanelItems.ResumeLayout(false);
            this.TableLayoutPanelItems.PerformLayout();
            this.FLP_BT.ResumeLayout(false);
            this.FLP_BT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtActualiser;
        private BindingSource bsUtilisateurs;
        private Button BTadd;
        private Button BTdelete;
        private TableLayoutPanel MaintableLayoutPanel;
        private TableLayoutPanel TableLayoutPanelItems;
        private TextBox TxtNom;
        private TextBox TxtPrenom;
        private DateTimePicker dtpDtNaiss;
        private FlowLayoutPanel FLP_BT;
        private Label LbNom;
        private Label LbPrenom;
        private Label LbNaiss;
        private DataGridView userDataView;
        private Button BtUpdate;
    }
}