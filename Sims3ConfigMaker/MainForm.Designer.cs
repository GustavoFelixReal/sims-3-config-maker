
namespace Sims3ConfigMaker
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tbWizard = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gpDrawDistance = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.rdDrawDistanceDefault = new System.Windows.Forms.RadioButton();
            this.rdDrawDistanceExtended = new System.Windows.Forms.RadioButton();
            this.gpRenderSimTexture = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rdRenderSimTextureDefault = new System.Windows.Forms.RadioButton();
            this.rdRenderSimTexture4K = new System.Windows.Forms.RadioButton();
            this.gpTextureSizeThreshold = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.rdTextureSizeThresholdDefault = new System.Windows.Forms.RadioButton();
            this.rdTextureSizeThreshold4K = new System.Windows.Forms.RadioButton();
            this.gpMemoryLimitUsage = new System.Windows.Forms.GroupBox();
            this.numMemoryLimit = new System.Windows.Forms.NumericUpDown();
            this.cbxDynamicAvoidance = new System.Windows.Forms.CheckBox();
            this.cbxPreloader = new System.Windows.Forms.CheckBox();
            this.gpTextureMemory = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gpShadowMapSize = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rdShadowMapSizeDefault = new System.Windows.Forms.RadioButton();
            this.rdShadowMapSize4K = new System.Windows.Forms.RadioButton();
            this.rdShadowMapSize8K = new System.Windows.Forms.RadioButton();
            this.cbxCPULevel = new System.Windows.Forms.CheckBox();
            this.cbxRemoveBloom = new System.Windows.Forms.CheckBox();
            this.cbxIncreaseStorageCache = new System.Windows.Forms.CheckBox();
            this.tbSystemInfo = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbWizard.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpDrawDistance.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.gpRenderSimTexture.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.gpTextureSizeThreshold.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gpMemoryLimitUsage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMemoryLimit)).BeginInit();
            this.gpTextureMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gpShadowMapSize.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbSystemInfo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 676);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.7449F));
            this.tableLayoutPanel1.Controls.Add(this.tbControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.88057F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 676);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tbWizard);
            this.tbControl.Controls.Add(this.tbSystemInfo);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbControl.Location = new System.Drawing.Point(3, 3);
            this.tbControl.Name = "tbControl";
            this.tbControl.Padding = new System.Drawing.Point(12, 6);
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(828, 670);
            this.tbControl.TabIndex = 1;
            // 
            // tbWizard
            // 
            this.tbWizard.AutoScroll = true;
            this.tbWizard.Controls.Add(this.tableLayoutPanel3);
            this.tbWizard.Location = new System.Drawing.Point(4, 28);
            this.tbWizard.Name = "tbWizard";
            this.tbWizard.Padding = new System.Windows.Forms.Padding(3);
            this.tbWizard.Size = new System.Drawing.Size(820, 638);
            this.tbWizard.TabIndex = 0;
            this.tbWizard.Text = "Wizard";
            this.tbWizard.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.gpDrawDistance, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.gpRenderSimTexture, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.gpTextureSizeThreshold, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.gpMemoryLimitUsage, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbxDynamicAvoidance, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxPreloader, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.gpTextureMemory, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.gpShadowMapSize, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbxCPULevel, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.cbxRemoveBloom, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.cbxIncreaseStorageCache, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 11);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 632);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // gpDrawDistance
            // 
            this.gpDrawDistance.Controls.Add(this.tableLayoutPanel6);
            this.gpDrawDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDrawDistance.Location = new System.Drawing.Point(3, 403);
            this.gpDrawDistance.Name = "gpDrawDistance";
            this.gpDrawDistance.Size = new System.Drawing.Size(808, 44);
            this.gpDrawDistance.TabIndex = 7;
            this.gpDrawDistance.TabStop = false;
            this.gpDrawDistance.Text = "Draw Distance";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.rdDrawDistanceDefault, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rdDrawDistanceExtended, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(802, 25);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // rdDrawDistanceDefault
            // 
            this.rdDrawDistanceDefault.AutoSize = true;
            this.rdDrawDistanceDefault.Location = new System.Drawing.Point(3, 3);
            this.rdDrawDistanceDefault.Name = "rdDrawDistanceDefault";
            this.rdDrawDistanceDefault.Size = new System.Drawing.Size(59, 17);
            this.rdDrawDistanceDefault.TabIndex = 0;
            this.rdDrawDistanceDefault.TabStop = true;
            this.rdDrawDistanceDefault.Text = "Default";
            this.rdDrawDistanceDefault.UseVisualStyleBackColor = true;
            // 
            // rdDrawDistanceExtended
            // 
            this.rdDrawDistanceExtended.AutoSize = true;
            this.rdDrawDistanceExtended.Location = new System.Drawing.Point(68, 3);
            this.rdDrawDistanceExtended.Name = "rdDrawDistanceExtended";
            this.rdDrawDistanceExtended.Size = new System.Drawing.Size(70, 17);
            this.rdDrawDistanceExtended.TabIndex = 1;
            this.rdDrawDistanceExtended.TabStop = true;
            this.rdDrawDistanceExtended.Text = "Extended";
            this.rdDrawDistanceExtended.UseVisualStyleBackColor = true;
            // 
            // gpRenderSimTexture
            // 
            this.gpRenderSimTexture.Controls.Add(this.tableLayoutPanel5);
            this.gpRenderSimTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpRenderSimTexture.Location = new System.Drawing.Point(3, 353);
            this.gpRenderSimTexture.Name = "gpRenderSimTexture";
            this.gpRenderSimTexture.Size = new System.Drawing.Size(808, 44);
            this.gpRenderSimTexture.TabIndex = 6;
            this.gpRenderSimTexture.TabStop = false;
            this.gpRenderSimTexture.Text = "Render Sim Textures Sizes";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.rdRenderSimTextureDefault, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rdRenderSimTexture4K, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(802, 25);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // rdRenderSimTextureDefault
            // 
            this.rdRenderSimTextureDefault.AutoSize = true;
            this.rdRenderSimTextureDefault.Location = new System.Drawing.Point(3, 3);
            this.rdRenderSimTextureDefault.Name = "rdRenderSimTextureDefault";
            this.rdRenderSimTextureDefault.Size = new System.Drawing.Size(49, 17);
            this.rdRenderSimTextureDefault.TabIndex = 0;
            this.rdRenderSimTextureDefault.TabStop = true;
            this.rdRenderSimTextureDefault.Text = "2048";
            this.rdRenderSimTextureDefault.UseVisualStyleBackColor = true;
            // 
            // rdRenderSimTexture4K
            // 
            this.rdRenderSimTexture4K.AutoSize = true;
            this.rdRenderSimTexture4K.Location = new System.Drawing.Point(58, 3);
            this.rdRenderSimTexture4K.Name = "rdRenderSimTexture4K";
            this.rdRenderSimTexture4K.Size = new System.Drawing.Size(49, 17);
            this.rdRenderSimTexture4K.TabIndex = 1;
            this.rdRenderSimTexture4K.TabStop = true;
            this.rdRenderSimTexture4K.Text = "4096";
            this.rdRenderSimTexture4K.UseVisualStyleBackColor = true;
            // 
            // gpTextureSizeThreshold
            // 
            this.gpTextureSizeThreshold.Controls.Add(this.tableLayoutPanel4);
            this.gpTextureSizeThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTextureSizeThreshold.Location = new System.Drawing.Point(3, 303);
            this.gpTextureSizeThreshold.Name = "gpTextureSizeThreshold";
            this.gpTextureSizeThreshold.Size = new System.Drawing.Size(808, 44);
            this.gpTextureSizeThreshold.TabIndex = 5;
            this.gpTextureSizeThreshold.TabStop = false;
            this.gpTextureSizeThreshold.Text = "Texture Size Threshold";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.rdTextureSizeThresholdDefault, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdTextureSizeThreshold4K, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(802, 25);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // rdTextureSizeThresholdDefault
            // 
            this.rdTextureSizeThresholdDefault.AutoSize = true;
            this.rdTextureSizeThresholdDefault.Location = new System.Drawing.Point(3, 3);
            this.rdTextureSizeThresholdDefault.Name = "rdTextureSizeThresholdDefault";
            this.rdTextureSizeThresholdDefault.Size = new System.Drawing.Size(49, 17);
            this.rdTextureSizeThresholdDefault.TabIndex = 0;
            this.rdTextureSizeThresholdDefault.TabStop = true;
            this.rdTextureSizeThresholdDefault.Text = "2048";
            this.rdTextureSizeThresholdDefault.UseVisualStyleBackColor = true;
            // 
            // rdTextureSizeThreshold4K
            // 
            this.rdTextureSizeThreshold4K.AutoSize = true;
            this.rdTextureSizeThreshold4K.Location = new System.Drawing.Point(58, 3);
            this.rdTextureSizeThreshold4K.Name = "rdTextureSizeThreshold4K";
            this.rdTextureSizeThreshold4K.Size = new System.Drawing.Size(49, 17);
            this.rdTextureSizeThreshold4K.TabIndex = 1;
            this.rdTextureSizeThreshold4K.TabStop = true;
            this.rdTextureSizeThreshold4K.Text = "4096";
            this.rdTextureSizeThreshold4K.UseVisualStyleBackColor = true;
            // 
            // gpMemoryLimitUsage
            // 
            this.gpMemoryLimitUsage.Controls.Add(this.numMemoryLimit);
            this.gpMemoryLimitUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpMemoryLimitUsage.Location = new System.Drawing.Point(3, 3);
            this.gpMemoryLimitUsage.Name = "gpMemoryLimitUsage";
            this.gpMemoryLimitUsage.Size = new System.Drawing.Size(808, 44);
            this.gpMemoryLimitUsage.TabIndex = 0;
            this.gpMemoryLimitUsage.TabStop = false;
            this.gpMemoryLimitUsage.Text = "Memory Limit Usage";
            // 
            // numMemoryLimit
            // 
            this.numMemoryLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMemoryLimit.Increment = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            this.numMemoryLimit.Location = new System.Drawing.Point(3, 16);
            this.numMemoryLimit.Maximum = new decimal(new int[] {
            40000000,
            0,
            0,
            0});
            this.numMemoryLimit.Minimum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numMemoryLimit.Name = "numMemoryLimit";
            this.numMemoryLimit.Size = new System.Drawing.Size(802, 20);
            this.numMemoryLimit.TabIndex = 2;
            this.numMemoryLimit.Value = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numMemoryLimit.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbxDynamicAvoidance
            // 
            this.cbxDynamicAvoidance.AutoSize = true;
            this.cbxDynamicAvoidance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDynamicAvoidance.Location = new System.Drawing.Point(3, 53);
            this.cbxDynamicAvoidance.Name = "cbxDynamicAvoidance";
            this.cbxDynamicAvoidance.Size = new System.Drawing.Size(808, 44);
            this.cbxDynamicAvoidance.TabIndex = 1;
            this.cbxDynamicAvoidance.Text = "Reduce Dynamic Avoidance";
            this.cbxDynamicAvoidance.UseVisualStyleBackColor = true;
            this.cbxDynamicAvoidance.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxPreloader
            // 
            this.cbxPreloader.AutoSize = true;
            this.cbxPreloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxPreloader.Location = new System.Drawing.Point(3, 103);
            this.cbxPreloader.Name = "cbxPreloader";
            this.cbxPreloader.Size = new System.Drawing.Size(808, 44);
            this.cbxPreloader.TabIndex = 2;
            this.cbxPreloader.Text = "Disable Preloader";
            this.cbxPreloader.UseVisualStyleBackColor = true;
            // 
            // gpTextureMemory
            // 
            this.gpTextureMemory.Controls.Add(this.numericUpDown1);
            this.gpTextureMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTextureMemory.Location = new System.Drawing.Point(3, 153);
            this.gpTextureMemory.Name = "gpTextureMemory";
            this.gpTextureMemory.Size = new System.Drawing.Size(808, 44);
            this.gpTextureMemory.TabIndex = 3;
            this.gpTextureMemory.TabStop = false;
            this.gpTextureMemory.Text = "Texture Memory";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown1.Location = new System.Drawing.Point(3, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(802, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // gpShadowMapSize
            // 
            this.gpShadowMapSize.Controls.Add(this.tableLayoutPanel2);
            this.gpShadowMapSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpShadowMapSize.Location = new System.Drawing.Point(3, 253);
            this.gpShadowMapSize.Name = "gpShadowMapSize";
            this.gpShadowMapSize.Size = new System.Drawing.Size(808, 44);
            this.gpShadowMapSize.TabIndex = 4;
            this.gpShadowMapSize.TabStop = false;
            this.gpShadowMapSize.Text = "Shadow Map Size";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSizeDefault, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSize4K, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSize8K, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(802, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rdShadowMapSizeDefault
            // 
            this.rdShadowMapSizeDefault.AutoSize = true;
            this.rdShadowMapSizeDefault.Location = new System.Drawing.Point(3, 3);
            this.rdShadowMapSizeDefault.Name = "rdShadowMapSizeDefault";
            this.rdShadowMapSizeDefault.Size = new System.Drawing.Size(49, 17);
            this.rdShadowMapSizeDefault.TabIndex = 0;
            this.rdShadowMapSizeDefault.TabStop = true;
            this.rdShadowMapSizeDefault.Text = "2048";
            this.rdShadowMapSizeDefault.UseVisualStyleBackColor = true;
            this.rdShadowMapSizeDefault.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdShadowMapSize4K
            // 
            this.rdShadowMapSize4K.AutoSize = true;
            this.rdShadowMapSize4K.Location = new System.Drawing.Point(58, 3);
            this.rdShadowMapSize4K.Name = "rdShadowMapSize4K";
            this.rdShadowMapSize4K.Size = new System.Drawing.Size(49, 17);
            this.rdShadowMapSize4K.TabIndex = 1;
            this.rdShadowMapSize4K.TabStop = true;
            this.rdShadowMapSize4K.Text = "4096";
            this.rdShadowMapSize4K.UseVisualStyleBackColor = true;
            // 
            // rdShadowMapSize8K
            // 
            this.rdShadowMapSize8K.AutoSize = true;
            this.rdShadowMapSize8K.Location = new System.Drawing.Point(113, 3);
            this.rdShadowMapSize8K.Name = "rdShadowMapSize8K";
            this.rdShadowMapSize8K.Size = new System.Drawing.Size(49, 17);
            this.rdShadowMapSize8K.TabIndex = 2;
            this.rdShadowMapSize8K.TabStop = true;
            this.rdShadowMapSize8K.Text = "7680";
            this.rdShadowMapSize8K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdShadowMapSize8K.UseVisualStyleBackColor = true;
            // 
            // cbxCPULevel
            // 
            this.cbxCPULevel.AutoSize = true;
            this.cbxCPULevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCPULevel.Location = new System.Drawing.Point(3, 203);
            this.cbxCPULevel.Name = "cbxCPULevel";
            this.cbxCPULevel.Size = new System.Drawing.Size(808, 44);
            this.cbxCPULevel.TabIndex = 5;
            this.cbxCPULevel.Text = "Adjust CPU Level Usage";
            this.cbxCPULevel.UseVisualStyleBackColor = true;
            // 
            // cbxRemoveBloom
            // 
            this.cbxRemoveBloom.AutoSize = true;
            this.cbxRemoveBloom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxRemoveBloom.Location = new System.Drawing.Point(3, 453);
            this.cbxRemoveBloom.Name = "cbxRemoveBloom";
            this.cbxRemoveBloom.Size = new System.Drawing.Size(808, 44);
            this.cbxRemoveBloom.TabIndex = 8;
            this.cbxRemoveBloom.Text = "Remove Bloom";
            this.cbxRemoveBloom.UseVisualStyleBackColor = true;
            // 
            // cbxIncreaseStorageCache
            // 
            this.cbxIncreaseStorageCache.AutoSize = true;
            this.cbxIncreaseStorageCache.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxIncreaseStorageCache.Location = new System.Drawing.Point(3, 503);
            this.cbxIncreaseStorageCache.Name = "cbxIncreaseStorageCache";
            this.cbxIncreaseStorageCache.Size = new System.Drawing.Size(808, 44);
            this.cbxIncreaseStorageCache.TabIndex = 9;
            this.cbxIncreaseStorageCache.Text = "Increase Storage Cache";
            this.cbxIncreaseStorageCache.UseVisualStyleBackColor = true;
            // 
            // tbSystemInfo
            // 
            this.tbSystemInfo.AutoScroll = true;
            this.tbSystemInfo.Controls.Add(this.richTextBox1);
            this.tbSystemInfo.Location = new System.Drawing.Point(4, 28);
            this.tbSystemInfo.Name = "tbSystemInfo";
            this.tbSystemInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbSystemInfo.Size = new System.Drawing.Size(820, 638);
            this.tbSystemInfo.TabIndex = 1;
            this.tbSystemInfo.Text = "System Info";
            this.tbSystemInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(814, 632);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbStatus,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pgbStatus
            // 
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Size = new System.Drawing.Size(100, 16);
            this.pgbStatus.Value = 100;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            this.lblStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(3, 553);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(808, 57);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 676);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 715);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sims 3 Config Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tbWizard.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gpDrawDistance.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.gpRenderSimTexture.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.gpTextureSizeThreshold.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.gpMemoryLimitUsage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numMemoryLimit)).EndInit();
            this.gpTextureMemory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gpShadowMapSize.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tbSystemInfo.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numMemoryLimit;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tbWizard;
        private System.Windows.Forms.TabPage tbSystemInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gpMemoryLimitUsage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pgbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox cbxDynamicAvoidance;
        private System.Windows.Forms.CheckBox cbxPreloader;
        private System.Windows.Forms.GroupBox gpTextureMemory;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gpShadowMapSize;
        private System.Windows.Forms.CheckBox cbxCPULevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rdShadowMapSizeDefault;
        private System.Windows.Forms.RadioButton rdShadowMapSize4K;
        private System.Windows.Forms.RadioButton rdShadowMapSize8K;
        private System.Windows.Forms.GroupBox gpTextureSizeThreshold;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton rdTextureSizeThresholdDefault;
        private System.Windows.Forms.RadioButton rdTextureSizeThreshold4K;
        private System.Windows.Forms.GroupBox gpDrawDistance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RadioButton rdDrawDistanceDefault;
        private System.Windows.Forms.RadioButton rdDrawDistanceExtended;
        private System.Windows.Forms.GroupBox gpRenderSimTexture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton rdRenderSimTextureDefault;
        private System.Windows.Forms.RadioButton rdRenderSimTexture4K;
        private System.Windows.Forms.CheckBox cbxRemoveBloom;
        private System.Windows.Forms.CheckBox cbxIncreaseStorageCache;
        private System.Windows.Forms.Button btnSave;
    }
}

