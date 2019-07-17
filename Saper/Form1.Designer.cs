namespace Saper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemnewgame = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветОкнаПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelborduser = new System.Windows.Forms.FlowLayoutPanel();
            this.imageListcells = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanelenemy = new System.Windows.Forms.FlowLayoutPanel();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelenemyname = new System.Windows.Forms.Label();
            this.labelusercellsleft = new System.Windows.Forms.Label();
            this.textBoxusercellsleft = new System.Windows.Forms.TextBox();
            this.textBoxenemycells = new System.Windows.Forms.TextBox();
            this.labellives = new System.Windows.Forms.Label();
            this.listViewchat = new System.Windows.Forms.ListView();
            this.labelchat = new System.Windows.Forms.Label();
            this.textBoxchat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxlogin = new System.Windows.Forms.TextBox();
            this.labellogin = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelgamenotcreate = new System.Windows.Forms.Label();
            this.изменитьIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemnewgame,
            this.подключитсяToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // ToolStripMenuItemnewgame
            // 
            this.ToolStripMenuItemnewgame.Name = "ToolStripMenuItemnewgame";
            this.ToolStripMenuItemnewgame.Size = new System.Drawing.Size(150, 22);
            this.ToolStripMenuItemnewgame.Text = "Новая игра";
            this.ToolStripMenuItemnewgame.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // подключитсяToolStripMenuItem
            // 
            this.подключитсяToolStripMenuItem.Name = "подключитсяToolStripMenuItem";
            this.подключитсяToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.подключитсяToolStripMenuItem.Text = "Подключится";
            this.подключитсяToolStripMenuItem.Click += new System.EventHandler(this.подключитсяToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветОкнаПрограммыToolStripMenuItem,
            this.изменитьIPToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // цветОкнаПрограммыToolStripMenuItem
            // 
            this.цветОкнаПрограммыToolStripMenuItem.Name = "цветОкнаПрограммыToolStripMenuItem";
            this.цветОкнаПрограммыToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.цветОкнаПрограммыToolStripMenuItem.Text = "Цвет окна программы";
            this.цветОкнаПрограммыToolStripMenuItem.Click += new System.EventHandler(this.цветОкнаПрограммыToolStripMenuItem_Click);
            // 
            // flowLayoutPanelborduser
            // 
            this.flowLayoutPanelborduser.Location = new System.Drawing.Point(32, 89);
            this.flowLayoutPanelborduser.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelborduser.Name = "flowLayoutPanelborduser";
            this.flowLayoutPanelborduser.Size = new System.Drawing.Size(320, 320);
            this.flowLayoutPanelborduser.TabIndex = 1;
            // 
            // imageListcells
            // 
            this.imageListcells.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListcells.ImageStream")));
            this.imageListcells.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListcells.Images.SetKeyName(0, "cell_itemmedium.png");
            // 
            // flowLayoutPanelenemy
            // 
            this.flowLayoutPanelenemy.Location = new System.Drawing.Point(434, 89);
            this.flowLayoutPanelenemy.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelenemy.Name = "flowLayoutPanelenemy";
            this.flowLayoutPanelenemy.Size = new System.Drawing.Size(320, 320);
            this.flowLayoutPanelenemy.TabIndex = 2;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Location = new System.Drawing.Point(38, 59);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(26, 13);
            this.labelusername.TabIndex = 3;
            this.labelusername.Text = "You";
            // 
            // labelenemyname
            // 
            this.labelenemyname.AutoSize = true;
            this.labelenemyname.Location = new System.Drawing.Point(431, 59);
            this.labelenemyname.Name = "labelenemyname";
            this.labelenemyname.Size = new System.Drawing.Size(39, 13);
            this.labelenemyname.TabIndex = 4;
            this.labelenemyname.Text = "Enemy";
            // 
            // labelusercellsleft
            // 
            this.labelusercellsleft.AutoSize = true;
            this.labelusercellsleft.Location = new System.Drawing.Point(133, 59);
            this.labelusercellsleft.Name = "labelusercellsleft";
            this.labelusercellsleft.Size = new System.Drawing.Size(46, 13);
            this.labelusercellsleft.TabIndex = 5;
            this.labelusercellsleft.Text = "Cells left";
            // 
            // textBoxusercellsleft
            // 
            this.textBoxusercellsleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxusercellsleft.Location = new System.Drawing.Point(220, 47);
            this.textBoxusercellsleft.Name = "textBoxusercellsleft";
            this.textBoxusercellsleft.ReadOnly = true;
            this.textBoxusercellsleft.Size = new System.Drawing.Size(43, 30);
            this.textBoxusercellsleft.TabIndex = 6;
            // 
            // textBoxenemycells
            // 
            this.textBoxenemycells.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxenemycells.Location = new System.Drawing.Point(518, 47);
            this.textBoxenemycells.Name = "textBoxenemycells";
            this.textBoxenemycells.ReadOnly = true;
            this.textBoxenemycells.Size = new System.Drawing.Size(43, 30);
            this.textBoxenemycells.TabIndex = 7;
            // 
            // labellives
            // 
            this.labellives.AutoSize = true;
            this.labellives.Location = new System.Drawing.Point(38, 32);
            this.labellives.Name = "labellives";
            this.labellives.Size = new System.Drawing.Size(35, 13);
            this.labellives.TabIndex = 9;
            this.labellives.Text = "label1";
            // 
            // listViewchat
            // 
            this.listViewchat.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewchat.HideSelection = false;
            this.listViewchat.Location = new System.Drawing.Point(32, 428);
            this.listViewchat.Name = "listViewchat";
            this.listViewchat.Size = new System.Drawing.Size(320, 222);
            this.listViewchat.TabIndex = 10;
            this.listViewchat.UseCompatibleStateImageBehavior = false;
            // 
            // labelchat
            // 
            this.labelchat.AutoSize = true;
            this.labelchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelchat.Location = new System.Drawing.Point(145, 409);
            this.labelchat.Name = "labelchat";
            this.labelchat.Size = new System.Drawing.Size(48, 22);
            this.labelchat.TabIndex = 11;
            this.labelchat.Text = "Chat";
            // 
            // textBoxchat
            // 
            this.textBoxchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxchat.Location = new System.Drawing.Point(393, 439);
            this.textBoxchat.Name = "textBoxchat";
            this.textBoxchat.Size = new System.Drawing.Size(361, 27);
            this.textBoxchat.TabIndex = 12;
            this.textBoxchat.TextChanged += new System.EventHandler(this.textBoxchat_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(464, 483);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(194, 37);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxlogin
            // 
            this.textBoxlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxlogin.Location = new System.Drawing.Point(473, 604);
            this.textBoxlogin.Name = "textBoxlogin";
            this.textBoxlogin.Size = new System.Drawing.Size(214, 30);
            this.textBoxlogin.TabIndex = 14;
            this.textBoxlogin.TextChanged += new System.EventHandler(this.textBoxlogin_TextChanged);
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Location = new System.Drawing.Point(520, 569);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(113, 13);
            this.labellogin.TabIndex = 15;
            this.labellogin.Text = "Your nickname in chat";
            // 
            // labelgamenotcreate
            // 
            this.labelgamenotcreate.AutoSize = true;
            this.labelgamenotcreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelgamenotcreate.ForeColor = System.Drawing.Color.Red;
            this.labelgamenotcreate.Location = new System.Drawing.Point(83, 32);
            this.labelgamenotcreate.Name = "labelgamenotcreate";
            this.labelgamenotcreate.Size = new System.Drawing.Size(575, 22);
            this.labelgamenotcreate.TabIndex = 16;
            this.labelgamenotcreate.Text = "No game detected, use menu to create new game or join existing game";
            // 
            // изменитьIPToolStripMenuItem
            // 
            this.изменитьIPToolStripMenuItem.Name = "изменитьIPToolStripMenuItem";
            this.изменитьIPToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.изменитьIPToolStripMenuItem.Text = "Изменить IP";
            this.изменитьIPToolStripMenuItem.Click += new System.EventHandler(this.изменитьIPToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 662);
            this.Controls.Add(this.labelgamenotcreate);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.textBoxlogin);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxchat);
            this.Controls.Add(this.labelchat);
            this.Controls.Add(this.listViewchat);
            this.Controls.Add(this.labellives);
            this.Controls.Add(this.textBoxenemycells);
            this.Controls.Add(this.textBoxusercellsleft);
            this.Controls.Add(this.labelusercellsleft);
            this.Controls.Add(this.labelenemyname);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.flowLayoutPanelenemy);
            this.Controls.Add(this.flowLayoutPanelborduser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Сапер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemnewgame;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelborduser;
        public System.Windows.Forms.ImageList imageListcells;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelenemy;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelenemyname;
        private System.Windows.Forms.Label labelusercellsleft;
        private System.Windows.Forms.TextBox textBoxusercellsleft;
        private System.Windows.Forms.TextBox textBoxenemycells;
        private System.Windows.Forms.ToolStripMenuItem подключитсяToolStripMenuItem;
        private System.Windows.Forms.Label labellives;
        private System.Windows.Forms.ListView listViewchat;
        private System.Windows.Forms.Label labelchat;
        private System.Windows.Forms.TextBox textBoxchat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxlogin;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.ToolStripMenuItem цветОкнаПрограммыToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelgamenotcreate;
        private System.Windows.Forms.ToolStripMenuItem изменитьIPToolStripMenuItem;
    }
}

