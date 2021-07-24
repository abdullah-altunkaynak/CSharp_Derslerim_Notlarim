
namespace Ders_9_
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPageCurrentUser = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPageLocaleMachine = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabPageClassesRoot = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.tabPageCurrentConfig = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPageCurrentUser.SuspendLayout();
            this.tabPageLocaleMachine.SuspendLayout();
            this.tabPageClassesRoot.SuspendLayout();
            this.tabPageCurrentConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL KEYS AND SUBKEYS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPageCurrentUser);
            this.tabControl1.Controls.Add(this.tabPageLocaleMachine);
            this.tabControl1.Controls.Add(this.tabPageClassesRoot);
            this.tabControl1.Controls.Add(this.tabPageCurrentConfig);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.listView1);
            this.tabPageUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 29);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(768, 344);
            this.tabPageUsers.TabIndex = 0;
            this.tabPageUsers.Text = "HKEY_USERS";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 305);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tabPageCurrentUser
            // 
            this.tabPageCurrentUser.Controls.Add(this.listView2);
            this.tabPageCurrentUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageCurrentUser.Location = new System.Drawing.Point(4, 29);
            this.tabPageCurrentUser.Name = "tabPageCurrentUser";
            this.tabPageCurrentUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentUser.Size = new System.Drawing.Size(768, 344);
            this.tabPageCurrentUser.TabIndex = 1;
            this.tabPageCurrentUser.Text = "HKEY_CURRENT_USER";
            this.tabPageCurrentUser.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(32, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(713, 297);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // tabPageLocaleMachine
            // 
            this.tabPageLocaleMachine.Controls.Add(this.listView3);
            this.tabPageLocaleMachine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageLocaleMachine.Location = new System.Drawing.Point(4, 29);
            this.tabPageLocaleMachine.Name = "tabPageLocaleMachine";
            this.tabPageLocaleMachine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocaleMachine.Size = new System.Drawing.Size(768, 344);
            this.tabPageLocaleMachine.TabIndex = 2;
            this.tabPageLocaleMachine.Text = "HKEY_LOCAL_MACHİNE";
            this.tabPageLocaleMachine.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(50, 40);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(691, 285);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // tabPageClassesRoot
            // 
            this.tabPageClassesRoot.Controls.Add(this.listView4);
            this.tabPageClassesRoot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageClassesRoot.Location = new System.Drawing.Point(4, 29);
            this.tabPageClassesRoot.Name = "tabPageClassesRoot";
            this.tabPageClassesRoot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassesRoot.Size = new System.Drawing.Size(768, 344);
            this.tabPageClassesRoot.TabIndex = 3;
            this.tabPageClassesRoot.Text = "HKEY_CLASSES_ROOT";
            this.tabPageClassesRoot.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(26, 22);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(716, 300);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            // 
            // tabPageCurrentConfig
            // 
            this.tabPageCurrentConfig.Controls.Add(this.listView5);
            this.tabPageCurrentConfig.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPageCurrentConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageCurrentConfig.Name = "tabPageCurrentConfig";
            this.tabPageCurrentConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrentConfig.Size = new System.Drawing.Size(768, 344);
            this.tabPageCurrentConfig.TabIndex = 4;
            this.tabPageCurrentConfig.Text = "HKEY_CURRENT_CONFİG";
            this.tabPageCurrentConfig.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(17, 24);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(734, 317);
            this.listView5.TabIndex = 0;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageCurrentUser.ResumeLayout(false);
            this.tabPageLocaleMachine.ResumeLayout(false);
            this.tabPageClassesRoot.ResumeLayout(false);
            this.tabPageCurrentConfig.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageCurrentUser;
        private System.Windows.Forms.TabPage tabPageLocaleMachine;
        private System.Windows.Forms.TabPage tabPageClassesRoot;
        private System.Windows.Forms.TabPage tabPageCurrentConfig;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
    }
}

