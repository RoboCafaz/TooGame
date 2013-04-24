using TooGame.MapEngine;
using System;
using System.Windows.Forms;
namespace TooGame
{
    partial class GenSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkCarve = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericIterations = new System.Windows.Forms.NumericUpDown();
            this.numericNeighbors = new System.Windows.Forms.NumericUpDown();
            this.numericProbability = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboMapType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeighbors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProbability)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // checkCarve
            // 
            this.checkCarve.AutoSize = true;
            this.checkCarve.Location = new System.Drawing.Point(80, 58);
            this.checkCarve.Name = "checkCarve";
            this.checkCarve.Size = new System.Drawing.Size(54, 17);
            this.checkCarve.TabIndex = 4;
            this.checkCarve.Text = "Carve";
            this.checkCarve.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iterations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Neighbors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Probability";
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(124, 186);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 11;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(79, 7);
            this.numericWidth.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(120, 20);
            this.numericWidth.TabIndex = 12;
            this.numericWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(79, 32);
            this.numericHeight.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
            this.numericHeight.TabIndex = 13;
            this.numericHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericIterations
            // 
            this.numericIterations.Location = new System.Drawing.Point(79, 77);
            this.numericIterations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIterations.Name = "numericIterations";
            this.numericIterations.Size = new System.Drawing.Size(120, 20);
            this.numericIterations.TabIndex = 14;
            this.numericIterations.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // numericNeighbors
            // 
            this.numericNeighbors.Location = new System.Drawing.Point(79, 103);
            this.numericNeighbors.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericNeighbors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNeighbors.Name = "numericNeighbors";
            this.numericNeighbors.Size = new System.Drawing.Size(120, 20);
            this.numericNeighbors.TabIndex = 15;
            this.numericNeighbors.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericProbability
            // 
            this.numericProbability.Location = new System.Drawing.Point(79, 129);
            this.numericProbability.Name = "numericProbability";
            this.numericProbability.Size = new System.Drawing.Size(120, 20);
            this.numericProbability.TabIndex = 16;
            this.numericProbability.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "MapType";
            // 
            // comboMapType
            // 
            this.comboMapType.FormattingEnabled = true;
            this.comboMapType.Location = new System.Drawing.Point(78, 155);
            this.comboMapType.Name = "comboMapType";
            this.comboMapType.Size = new System.Drawing.Size(121, 21);
            this.comboMapType.TabIndex = 18;
            this.comboMapType.DataSource = new BindingSource(MapType.MapTypes.Keys,null);
            // 
            // GenSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 221);
            this.Controls.Add(this.comboMapType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericProbability);
            this.Controls.Add(this.numericNeighbors);
            this.Controls.Add(this.numericIterations);
            this.Controls.Add(this.numericHeight);
            this.Controls.Add(this.numericWidth);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkCarve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GenSettings";
            this.Text = "GenSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNeighbors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProbability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkCarve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericIterations;
        private System.Windows.Forms.NumericUpDown numericNeighbors;
        private System.Windows.Forms.NumericUpDown numericProbability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboMapType;
    }
}