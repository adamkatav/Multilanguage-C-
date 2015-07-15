namespace רואה_חד_IDE
{
    partial class Form1
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
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.Compile = new System.Windows.Forms.Button();
            this.AllCS = new System.Windows.Forms.RadioButton();
            this.MainOnly = new System.Windows.Forms.RadioButton();
            this.Namespace = new System.Windows.Forms.TextBox();
            this.INS1 = new System.Windows.Forms.TextBox();
            this.INS2 = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(12, 12);
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CodeTextBox.Size = new System.Drawing.Size(552, 620);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.TextChanged += new System.EventHandler(this.CodeTextBox_TextChanged);
            // 
            // Compile
            // 
            this.Compile.Location = new System.Drawing.Point(571, 13);
            this.Compile.Name = "Compile";
            this.Compile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Compile.Size = new System.Drawing.Size(207, 23);
            this.Compile.TabIndex = 1;
            this.Compile.Text = "הדר!";
            this.Compile.UseVisualStyleBackColor = true;
            this.Compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // AllCS
            // 
            this.AllCS.AutoSize = true;
            this.AllCS.Location = new System.Drawing.Point(693, 59);
            this.AllCS.Name = "AllCS";
            this.AllCS.Size = new System.Drawing.Size(92, 17);
            this.AllCS.TabIndex = 2;
            this.AllCS.TabStop = true;
            this.AllCS.Text = "כול קובץ אח";
            this.AllCS.UseVisualStyleBackColor = true;
            // 
            // MainOnly
            // 
            this.MainOnly.AutoSize = true;
            this.MainOnly.Location = new System.Drawing.Point(693, 83);
            this.MainOnly.Name = "MainOnly";
            this.MainOnly.Size = new System.Drawing.Size(87, 17);
            this.MainOnly.TabIndex = 3;
            this.MainOnly.TabStop = true;
            this.MainOnly.Text = "רק את ראשי";
            this.MainOnly.UseVisualStyleBackColor = true;
            // 
            // Namespace
            // 
            this.Namespace.Location = new System.Drawing.Point(685, 159);
            this.Namespace.Name = "Namespace";
            this.Namespace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Namespace.Size = new System.Drawing.Size(100, 20);
            this.Namespace.TabIndex = 4;
            // 
            // INS1
            // 
            this.INS1.Location = new System.Drawing.Point(685, 133);
            this.INS1.Name = "INS1";
            this.INS1.ReadOnly = true;
            this.INS1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.INS1.Size = new System.Drawing.Size(100, 20);
            this.INS1.TabIndex = 5;
            this.INS1.Text = "הכנס שם";
            // 
            // INS2
            // 
            this.INS2.Location = new System.Drawing.Point(685, 187);
            this.INS2.Name = "INS2";
            this.INS2.ReadOnly = true;
            this.INS2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.INS2.Size = new System.Drawing.Size(100, 20);
            this.INS2.TabIndex = 6;
            this.INS2.Text = "הכנס מחלקה";
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(685, 213);
            this.Class.Name = "Class";
            this.Class.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Class.Size = new System.Drawing.Size(100, 20);
            this.Class.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(646, 239);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(139, 59);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "בשביל פלט מומלץ להשתמש ב:\r\nמערכת.חלונות.טפסים.קופסתהודעה.הראה";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Items.AddRange(new object[] {
            "abstract מופשט",
            "add הוסף",
            "as כמו",
            "ascending עולה",
            "async תאם",
            "await מחכה",
            "base בסיס",
            "bool בולבול",
            "break שבור",
            "by על ידי",
            "byte בית",
            "case במקרה",
            "catch תפוס",
            "char אות",
            "checked בדוק",
            "class מחלקה",
            "Console קונסולה",
            "const קבוע",
            "continue המשך",
            "decimal עשרוני",
            "default ברירת מחדל",
            "delegate נציג",
            "descending יורק",
            "do עשה",
            "double פעמיים",
            "dynamic משתנה",
            "else אחרת",
            "enum קבועים",
            "equals שווה",
            "explicit בפירוש",
            "extern מבחוץ",
            "false שקר",
            "finally סוף סוף",
            "fixed מקובע",
            "float צף",
            "for עבור",
            "foreach עבור כל",
            "Forms טפסים",
            "from מתוך",
            "get קבל",
            "global בינלאומי",
            "goto לך לך",
            "group קבוצה",
            "if אם",
            "implicit משתמע",
            "in בתוך",
            "int שלם",
            "interface ממשק",
            "internal מבפנים",
            "into לתוך",
            "is הוא ",
            "join צרף",
            "let תן",
            "lock נעול",
            "long ארוך",
            "Main ראשי",
            "MessageBox קופסתהודעה",
            "namespace שם",
            "new חדש",
            "null נעל",
            "object עצם",
            "on על",
            "operator סימן",
            "orderby סדר על פי",
            "out החוצה",
            "override התעלם",
            "params גורמים",
            "partial חלק",
            "private פרטי",
            "protected מוגן",
            "public ציבורי",
            "ReadLine קראשורה",
            "readonly לקריאה בלבד",
            "ref הפניה",
            "remove הסר",
            "return החזר",
            "sbyte עבית",
            "sealed אטום",
            "select בחר",
            "set קבע",
            "short קצר",
            "Show הראה",
            "sizeof גודלו של",
            "stackalloc הקצה מחסנית",
            "static דומם",
            "string מחרוזת",
            "struct מבנה",
            "switch החלף",
            "System מערכת",
            "this זה",
            "throw זרוק",
            "true אמת",
            "try נסה",
            "typeof סוג של",
            "uint למשלם",
            "ulong למארוך",
            "unchecked לא מסומן",
            "unsafe לא בטוח",
            "ushort למקצר",
            "using השתמש",
            "value ערך",
            "var מש",
            "virtual לא אמיתי",
            "void ריק",
            "volatile נדיף",
            "where איפה",
            "while כול עוד",
            "Windows חלונות",
            "WriteLine כתובשורה",
            "yield תשואה"});
            this.listBox1.Location = new System.Drawing.Point(571, 305);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(208, 329);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 644);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.INS2);
            this.Controls.Add(this.INS1);
            this.Controls.Add(this.Namespace);
            this.Controls.Add(this.MainOnly);
            this.Controls.Add(this.AllCS);
            this.Controls.Add(this.Compile);
            this.Controls.Add(this.CodeTextBox);
            this.Name = "Form1";
            this.Text = "סטודיו חזותי";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Button Compile;
        private System.Windows.Forms.RadioButton AllCS;
        private System.Windows.Forms.RadioButton MainOnly;
        private System.Windows.Forms.TextBox Namespace;
        private System.Windows.Forms.TextBox INS1;
        private System.Windows.Forms.TextBox INS2;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

