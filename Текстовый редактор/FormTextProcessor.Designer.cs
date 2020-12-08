﻿namespace Текстовый_редактор
{
    partial class FormTextProcessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextProcessor));
            this.open_fd = new System.Windows.Forms.OpenFileDialog();
            this.save_fd = new System.Windows.Forms.SaveFileDialog();
            this.button_open = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.text_editor = new System.Windows.Forms.TextBox();
            this.text_pattern = new System.Windows.Forms.TextBox();
            this.text_replace = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.label_pattern = new System.Windows.Forms.Label();
            this.label_replace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // open_fd
            // 
            this.open_fd.FileName = "openFileDialog1";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(13, 13);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(96, 34);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Открыть файл";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(115, 13);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(97, 34);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Сохранить файл";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // text_editor
            // 
            this.text_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_editor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_editor.Location = new System.Drawing.Point(1, 53);
            this.text_editor.Multiline = true;
            this.text_editor.Name = "text_editor";
            this.text_editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_editor.Size = new System.Drawing.Size(663, 356);
            this.text_editor.TabIndex = 2;
            this.text_editor.WordWrap = false;
            // 
            // text_pattern
            // 
            this.text_pattern.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_pattern.Location = new System.Drawing.Point(218, 26);
            this.text_pattern.Name = "text_pattern";
            this.text_pattern.Size = new System.Drawing.Size(100, 23);
            this.text_pattern.TabIndex = 3;
            // 
            // text_replace
            // 
            this.text_replace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_replace.Location = new System.Drawing.Point(324, 26);
            this.text_replace.Name = "text_replace";
            this.text_replace.Size = new System.Drawing.Size(100, 23);
            this.text_replace.TabIndex = 4;
            // 
            // button_replace
            // 
            this.button_replace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_replace.Location = new System.Drawing.Point(430, 13);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(234, 34);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "Заменить";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // label_pattern
            // 
            this.label_pattern.AutoSize = true;
            this.label_pattern.Location = new System.Drawing.Point(218, 7);
            this.label_pattern.Name = "label_pattern";
            this.label_pattern.Size = new System.Drawing.Size(64, 13);
            this.label_pattern.TabIndex = 6;
            this.label_pattern.Text = "Что искать";
            // 
            // label_replace
            // 
            this.label_replace.AutoSize = true;
            this.label_replace.Location = new System.Drawing.Point(321, 9);
            this.label_replace.Name = "label_replace";
            this.label_replace.Size = new System.Drawing.Size(80, 13);
            this.label_replace.TabIndex = 7;
            this.label_replace.Text = "На что менять";
            // 
            // FormTextProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.label_replace);
            this.Controls.Add(this.label_pattern);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.text_replace);
            this.Controls.Add(this.text_pattern);
            this.Controls.Add(this.text_editor);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FormTextProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open_fd;
        private System.Windows.Forms.SaveFileDialog save_fd;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox text_editor;
        private System.Windows.Forms.TextBox text_pattern;
        private System.Windows.Forms.TextBox text_replace;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Label label_pattern;
        private System.Windows.Forms.Label label_replace;
    }
}

