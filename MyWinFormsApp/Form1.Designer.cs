namespace MyWinFormsApp;

partial class Form1
{
    private void InitializeComponent()
{
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.button1 = new System.Windows.Forms.Button();
    this.labelTemperature = new System.Windows.Forms.Label();
    this.labelCondition = new System.Windows.Forms.Label();
    this.SuspendLayout();
    // 
    // textBox1
    // 
    this.textBox1.Location = new System.Drawing.Point(80, 20);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(150, 23);
    this.textBox1.TabIndex = 0;
    // 
    // button1
    // 
    this.button1.Location = new System.Drawing.Point(80, 60);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(150, 23);
    this.button1.TabIndex = 1;
    this.button1.Text = "Fetch Weather";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
    // 
    // labelTemperature
    // 
    this.labelTemperature.AutoSize = true;
    this.labelTemperature.Location = new System.Drawing.Point(80, 100);
    this.labelTemperature.Name = "labelTemperature";
    this.labelTemperature.Size = new System.Drawing.Size(87, 15);
    this.labelTemperature.TabIndex = 2;
    this.labelTemperature.Text = "Temperature:";
    // 
    // labelCondition
    // 
    this.labelCondition.AutoSize = true;
    this.labelCondition.Location = new System.Drawing.Point(80, 130);
    this.labelCondition.Name = "labelCondition";
    this.labelCondition.Size = new System.Drawing.Size(67, 15);
    this.labelCondition.TabIndex = 3;
    this.labelCondition.Text = "Condition:";
    // 
    // Form1
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(300, 200);
    this.Controls.Add(this.labelCondition);
    this.Controls.Add(this.labelTemperature);
    this.Controls.Add(this.button1);
    this.Controls.Add(this.textBox1);
    this.Name = "Form1";
    this.Text = "Weather App";
    this.ResumeLayout(false);
    this.PerformLayout();
}

private System.Windows.Forms.TextBox textBox1;
private System.Windows.Forms.Button button1;
private System.Windows.Forms.Label labelTemperature;
private System.Windows.Forms.Label labelCondition;
}