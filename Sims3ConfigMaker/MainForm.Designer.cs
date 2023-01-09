
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSystemInfo = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pgbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Name = "panel1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tbControl, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbControl
            // 
            resources.ApplyResources(this.tbControl, "tbControl");
            this.tbControl.Controls.Add(this.tbWizard);
            this.tbControl.Controls.Add(this.tbSystemInfo);
            this.tbControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            // 
            // tbWizard
            // 
            resources.ApplyResources(this.tbWizard, "tbWizard");
            this.tbWizard.Controls.Add(this.tableLayoutPanel3);
            this.tbWizard.Name = "tbWizard";
            this.tbWizard.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
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
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // gpDrawDistance
            // 
            resources.ApplyResources(this.gpDrawDistance, "gpDrawDistance");
            this.gpDrawDistance.Controls.Add(this.tableLayoutPanel6);
            this.gpDrawDistance.Name = "gpDrawDistance";
            this.gpDrawDistance.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.rdDrawDistanceDefault, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.rdDrawDistanceExtended, 1, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // rdDrawDistanceDefault
            // 
            resources.ApplyResources(this.rdDrawDistanceDefault, "rdDrawDistanceDefault");
            this.rdDrawDistanceDefault.Name = "rdDrawDistanceDefault";
            this.rdDrawDistanceDefault.TabStop = true;
            this.rdDrawDistanceDefault.UseVisualStyleBackColor = true;
            // 
            // rdDrawDistanceExtended
            // 
            resources.ApplyResources(this.rdDrawDistanceExtended, "rdDrawDistanceExtended");
            this.rdDrawDistanceExtended.Name = "rdDrawDistanceExtended";
            this.rdDrawDistanceExtended.TabStop = true;
            this.rdDrawDistanceExtended.UseVisualStyleBackColor = true;
            // 
            // gpRenderSimTexture
            // 
            resources.ApplyResources(this.gpRenderSimTexture, "gpRenderSimTexture");
            this.gpRenderSimTexture.Controls.Add(this.tableLayoutPanel5);
            this.gpRenderSimTexture.Name = "gpRenderSimTexture";
            this.gpRenderSimTexture.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.rdRenderSimTextureDefault, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.rdRenderSimTexture4K, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // rdRenderSimTextureDefault
            // 
            resources.ApplyResources(this.rdRenderSimTextureDefault, "rdRenderSimTextureDefault");
            this.rdRenderSimTextureDefault.Name = "rdRenderSimTextureDefault";
            this.rdRenderSimTextureDefault.TabStop = true;
            this.rdRenderSimTextureDefault.UseVisualStyleBackColor = true;
            // 
            // rdRenderSimTexture4K
            // 
            resources.ApplyResources(this.rdRenderSimTexture4K, "rdRenderSimTexture4K");
            this.rdRenderSimTexture4K.Name = "rdRenderSimTexture4K";
            this.rdRenderSimTexture4K.TabStop = true;
            this.rdRenderSimTexture4K.UseVisualStyleBackColor = true;
            // 
            // gpTextureSizeThreshold
            // 
            resources.ApplyResources(this.gpTextureSizeThreshold, "gpTextureSizeThreshold");
            this.gpTextureSizeThreshold.Controls.Add(this.tableLayoutPanel4);
            this.gpTextureSizeThreshold.Name = "gpTextureSizeThreshold";
            this.gpTextureSizeThreshold.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.rdTextureSizeThresholdDefault, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rdTextureSizeThreshold4K, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // rdTextureSizeThresholdDefault
            // 
            resources.ApplyResources(this.rdTextureSizeThresholdDefault, "rdTextureSizeThresholdDefault");
            this.rdTextureSizeThresholdDefault.Name = "rdTextureSizeThresholdDefault";
            this.rdTextureSizeThresholdDefault.TabStop = true;
            this.rdTextureSizeThresholdDefault.UseVisualStyleBackColor = true;
            // 
            // rdTextureSizeThreshold4K
            // 
            resources.ApplyResources(this.rdTextureSizeThreshold4K, "rdTextureSizeThreshold4K");
            this.rdTextureSizeThreshold4K.Name = "rdTextureSizeThreshold4K";
            this.rdTextureSizeThreshold4K.TabStop = true;
            this.rdTextureSizeThreshold4K.UseVisualStyleBackColor = true;
            // 
            // gpMemoryLimitUsage
            // 
            resources.ApplyResources(this.gpMemoryLimitUsage, "gpMemoryLimitUsage");
            this.gpMemoryLimitUsage.Controls.Add(this.numMemoryLimit);
            this.gpMemoryLimitUsage.Name = "gpMemoryLimitUsage";
            this.gpMemoryLimitUsage.TabStop = false;
            this.gpMemoryLimitUsage.Enter += new System.EventHandler(this.gpMemoryLimitUsage_Enter);
            // 
            // numMemoryLimit
            // 
            resources.ApplyResources(this.numMemoryLimit, "numMemoryLimit");
            this.numMemoryLimit.Increment = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
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
            this.numMemoryLimit.Value = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numMemoryLimit.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbxDynamicAvoidance
            // 
            resources.ApplyResources(this.cbxDynamicAvoidance, "cbxDynamicAvoidance");
            this.cbxDynamicAvoidance.Name = "cbxDynamicAvoidance";
            this.cbxDynamicAvoidance.UseVisualStyleBackColor = true;
            this.cbxDynamicAvoidance.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbxPreloader
            // 
            resources.ApplyResources(this.cbxPreloader, "cbxPreloader");
            this.cbxPreloader.Name = "cbxPreloader";
            this.cbxPreloader.UseVisualStyleBackColor = true;
            // 
            // gpTextureMemory
            // 
            resources.ApplyResources(this.gpTextureMemory, "gpTextureMemory");
            this.gpTextureMemory.Controls.Add(this.numericUpDown1);
            this.gpTextureMemory.Name = "gpTextureMemory";
            this.gpTextureMemory.TabStop = false;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // gpShadowMapSize
            // 
            resources.ApplyResources(this.gpShadowMapSize, "gpShadowMapSize");
            this.gpShadowMapSize.Controls.Add(this.tableLayoutPanel2);
            this.gpShadowMapSize.Name = "gpShadowMapSize";
            this.gpShadowMapSize.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSizeDefault, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSize4K, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdShadowMapSize8K, 2, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // rdShadowMapSizeDefault
            // 
            resources.ApplyResources(this.rdShadowMapSizeDefault, "rdShadowMapSizeDefault");
            this.rdShadowMapSizeDefault.Name = "rdShadowMapSizeDefault";
            this.rdShadowMapSizeDefault.TabStop = true;
            this.rdShadowMapSizeDefault.UseVisualStyleBackColor = true;
            this.rdShadowMapSizeDefault.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdShadowMapSize4K
            // 
            resources.ApplyResources(this.rdShadowMapSize4K, "rdShadowMapSize4K");
            this.rdShadowMapSize4K.Name = "rdShadowMapSize4K";
            this.rdShadowMapSize4K.TabStop = true;
            this.rdShadowMapSize4K.UseVisualStyleBackColor = true;
            // 
            // rdShadowMapSize8K
            // 
            resources.ApplyResources(this.rdShadowMapSize8K, "rdShadowMapSize8K");
            this.rdShadowMapSize8K.Name = "rdShadowMapSize8K";
            this.rdShadowMapSize8K.TabStop = true;
            this.rdShadowMapSize8K.UseVisualStyleBackColor = true;
            // 
            // cbxCPULevel
            // 
            resources.ApplyResources(this.cbxCPULevel, "cbxCPULevel");
            this.cbxCPULevel.Name = "cbxCPULevel";
            this.cbxCPULevel.UseVisualStyleBackColor = true;
            // 
            // cbxRemoveBloom
            // 
            resources.ApplyResources(this.cbxRemoveBloom, "cbxRemoveBloom");
            this.cbxRemoveBloom.Name = "cbxRemoveBloom";
            this.cbxRemoveBloom.UseVisualStyleBackColor = true;
            // 
            // cbxIncreaseStorageCache
            // 
            resources.ApplyResources(this.cbxIncreaseStorageCache, "cbxIncreaseStorageCache");
            this.cbxIncreaseStorageCache.Name = "cbxIncreaseStorageCache";
            this.cbxIncreaseStorageCache.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tbSystemInfo
            // 
            resources.ApplyResources(this.tbSystemInfo, "tbSystemInfo");
            this.tbSystemInfo.Controls.Add(this.richTextBox1);
            this.tbSystemInfo.Name = "tbSystemInfo";
            this.tbSystemInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbStatus,
            this.lblStatus});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // pgbStatus
            // 
            resources.ApplyResources(this.pgbStatus, "pgbStatus");
            this.pgbStatus.Name = "pgbStatus";
            this.pgbStatus.Value = 100;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
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

