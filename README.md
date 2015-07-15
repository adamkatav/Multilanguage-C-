# Multilanguage-C-
Parse C# from any language you want!

Options:

1. You can write the entire .cs file or just Main().
2. CS_Executer.Run(string code) is a function that execute the text in CodeTextBox as is.
3. CS_Executer.RunFunc(string code) is a function that execute the text in CodeTextBox as if it was in Main(). Save you time.
4. CS_Executer.Dic() mapps the keywords.


Instructions:

1. Go to CS_Executer.cs
2. Declare a string array and add every string existing in keywords array (the one in English).
3. Change or add your keywords to the dictionary:
3.1. In "Dic" function change sb.Append(keywords[i] + " " + HE_keywords[i] + "\n"); and add your array. For example:
3.2. sb.Append(keywords[i] + " " + HE_keywords[i] + AB_keywords[i] + "\n");
4. Chage AllCS, MainOnly and Compile buttons text to your language.
5. textBox1 is a comment textbox. Do whatever you want.
6. Change INS1 to your equivalent of "insert namespace"
7. Change INS2 to your equivalent of "insert class"
//Both class is the class Program on a default Console Application
8. Edit MessageBox.Show("הכנס מחלקה"); (Form1) to your equivalent of "insert class"
9 Edit MessageBox.Show("הכנס שם"); to your equivalent of "insert namespace"


I wrote this tired so if I forgot something please tell me.
