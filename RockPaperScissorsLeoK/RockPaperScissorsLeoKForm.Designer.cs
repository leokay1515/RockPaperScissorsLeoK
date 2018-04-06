namespace RockPaperScissorsLeoK
{
    partial class frmRockPaperScissorsLeoK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbUsersChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsUser = new System.Windows.Forms.RadioButton();
            this.radPaperUser = new System.Windows.Forms.RadioButton();
            this.radRockUser = new System.Windows.Forms.RadioButton();
            this.grbComputersChoice = new System.Windows.Forms.GroupBox();
            this.radScissorsComputer = new System.Windows.Forms.RadioButton();
            this.radRockComputer = new System.Windows.Forms.RadioButton();
            this.radPaperComputer = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grbUsersChoice.SuspendLayout();
            this.grbComputersChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUsersChoice
            // 
            this.grbUsersChoice.Controls.Add(this.radScissorsUser);
            this.grbUsersChoice.Controls.Add(this.radPaperUser);
            this.grbUsersChoice.Controls.Add(this.radRockUser);
            this.grbUsersChoice.Location = new System.Drawing.Point(47, 12);
            this.grbUsersChoice.Name = "grbUsersChoice";
            this.grbUsersChoice.Size = new System.Drawing.Size(200, 130);
            this.grbUsersChoice.TabIndex = 0;
            this.grbUsersChoice.TabStop = false;
            this.grbUsersChoice.Text = "User\'s Choice";
            // 
            // radScissorsUser
            // 
            this.radScissorsUser.AutoSize = true;
            this.radScissorsUser.Location = new System.Drawing.Point(6, 97);
            this.radScissorsUser.Name = "radScissorsUser";
            this.radScissorsUser.Size = new System.Drawing.Size(64, 17);
            this.radScissorsUser.TabIndex = 6;
            this.radScissorsUser.TabStop = true;
            this.radScissorsUser.Text = "Scissors";
            this.radScissorsUser.UseVisualStyleBackColor = true;
            // 
            // radPaperUser
            // 
            this.radPaperUser.AutoSize = true;
            this.radPaperUser.Location = new System.Drawing.Point(6, 65);
            this.radPaperUser.Name = "radPaperUser";
            this.radPaperUser.Size = new System.Drawing.Size(53, 17);
            this.radPaperUser.TabIndex = 5;
            this.radPaperUser.TabStop = true;
            this.radPaperUser.Text = "Paper";
            this.radPaperUser.UseVisualStyleBackColor = true;
            // 
            // radRockUser
            // 
            this.radRockUser.AutoSize = true;
            this.radRockUser.Location = new System.Drawing.Point(6, 32);
            this.radRockUser.Name = "radRockUser";
            this.radRockUser.Size = new System.Drawing.Size(51, 17);
            this.radRockUser.TabIndex = 4;
            this.radRockUser.TabStop = true;
            this.radRockUser.Text = "Rock";
            this.radRockUser.UseVisualStyleBackColor = true;
            // 
            // grbComputersChoice
            // 
            this.grbComputersChoice.Controls.Add(this.radScissorsComputer);
            this.grbComputersChoice.Controls.Add(this.radRockComputer);
            this.grbComputersChoice.Controls.Add(this.radPaperComputer);
            this.grbComputersChoice.Location = new System.Drawing.Point(47, 148);
            this.grbComputersChoice.Name = "grbComputersChoice";
            this.grbComputersChoice.Size = new System.Drawing.Size(200, 139);
            this.grbComputersChoice.TabIndex = 1;
            this.grbComputersChoice.TabStop = false;
            this.grbComputersChoice.Text = "Computer\'s Choice";
            // 
            // radScissorsComputer
            // 
            this.radScissorsComputer.AutoSize = true;
            this.radScissorsComputer.Location = new System.Drawing.Point(8, 98);
            this.radScissorsComputer.Name = "radScissorsComputer";
            this.radScissorsComputer.Size = new System.Drawing.Size(64, 17);
            this.radScissorsComputer.TabIndex = 9;
            this.radScissorsComputer.TabStop = true;
            this.radScissorsComputer.Text = "Scissors";
            this.radScissorsComputer.UseVisualStyleBackColor = true;
            // 
            // radRockComputer
            // 
            this.radRockComputer.AutoSize = true;
            this.radRockComputer.Location = new System.Drawing.Point(8, 33);
            this.radRockComputer.Name = "radRockComputer";
            this.radRockComputer.Size = new System.Drawing.Size(51, 17);
            this.radRockComputer.TabIndex = 7;
            this.radRockComputer.TabStop = true;
            this.radRockComputer.Text = "Rock";
            this.radRockComputer.UseVisualStyleBackColor = true;
            // 
            // radPaperComputer
            // 
            this.radPaperComputer.AutoSize = true;
            this.radPaperComputer.Location = new System.Drawing.Point(8, 66);
            this.radPaperComputer.Name = "radPaperComputer";
            this.radPaperComputer.Size = new System.Drawing.Size(53, 17);
            this.radPaperComputer.TabIndex = 8;
            this.radPaperComputer.TabStop = true;
            this.radPaperComputer.Text = "Paper";
            this.radPaperComputer.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(103, 304);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 28);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(43, 386);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 3;
            // 
            // frmRockPaperScissorsLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 443);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputersChoice);
            this.Controls.Add(this.grbUsersChoice);
            this.Name = "frmRockPaperScissorsLeoK";
            this.Text = "Rock, Paper, Scissors by Leo Kay";
            this.grbUsersChoice.ResumeLayout(false);
            this.grbUsersChoice.PerformLayout();
            this.grbComputersChoice.ResumeLayout(false);
            this.grbComputersChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUsersChoice;
        private System.Windows.Forms.RadioButton radScissorsUser;
        private System.Windows.Forms.RadioButton radPaperUser;
        private System.Windows.Forms.RadioButton radRockUser;
        private System.Windows.Forms.GroupBox grbComputersChoice;
        private System.Windows.Forms.RadioButton radScissorsComputer;
        private System.Windows.Forms.RadioButton radRockComputer;
        private System.Windows.Forms.RadioButton radPaperComputer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResult;
    }
}

