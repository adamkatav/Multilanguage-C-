using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace רואה_חד
{
    class CS_Executer
    {
        #region Languages
        string[] keywords =
            {
                "abstract","add" ,"as" ,"ascending", "async",
                "await", "base", "bool", "break", "by", "byte", "case",
                "catch", "char", "checked", "class",  "const", "continue",
                "decimal", "default", "delegate", "descending", "do", "double",
                "dynamic", "else" , "enum", "equals", "explicit",
                "extern", "false", "finally", "fixed", "float", "for",
                "foreach", "from", "get", "global", "goto", "group", "if", "implicit",
                "in", "int", "interface", "internal", "into", "is", "join", "let",
                "lock", "long", "namespace", "new", "null", "object", "on", "operator",
                "orderby", "out", "override", "params", "partial", "private", "protected",
                "public", "readonly", "ref", "remove", "return", "sbyte", "sealed", "select",
                "set", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
                "unsafe", "ushort", "using", "value", "var", "virtual", "void", "volatile",
                "where", "while", "yield", "Console", "WriteLine", "Main", "System", "ReadLine",
                "Windows", "Forms", "MessageBox", "Show"

            };
        string[] HE_keywords =
        {
            "מופשט", "הוסף", "כמו", "עולה", "תאם", "מחכה", "בסיס", "בולבול", "שבור",
            "על ידי", "בית", "במקרה", "תפוס", "אות", "בדוק", "מחלקה", "קבוע",
            "המשך", "עשרוני", "ברירת מחדל", "נציג", "יורק", "עשה", "פעמיים",
                "משתנה", "אחרת", "קבועים", "שווה", "בפירוש",
                "מבחוץ", "שקר", "סוף סוף", "מקובע", "צף", "עבור",
                "עבור כל", "מתוך", "קבל", "בינלאומי", "לך לך", "קבוצה", "אם", "משתמע",
                "בתוך", "שלם", "ממשק", "מבפנים", "לתוך", "הוא ", "צרף", "תן",
                "נעול", "ארוך", "שם", "חדש", "נעל", "עצם", "על", "סימן",
                "סדר על פי", "החוצה", "התעלם", "גורמים", "חלק", "פרטי", "מוגן",
                "ציבורי", "לקריאה בלבד", "הפניה", "הסר", "החזר", "עבית", "אטום", "בחר",
                "קבע", "קצר", "גודלו של", "הקצה מחסנית", "דומם", "מחרוזת", "מבנה", "החלף",
                "זה", "זרוק", "אמת", "נסה", "סוג של", "למשלם", "למארוך", "לא מסומן",
                "לא בטוח", "למקצר", "השתמש", "ערך", "מש", "לא אמיתי", "ריק", "נדיף",
                "איפה", "כול עוד", "תשואה", "קונסולה", "כתובשורה", "ראשי", "מערכת", "קראשורה",
                "חלונות", "טפסים", "קופסתהודעה", "הראה"
        };
        #endregion

        public CS_Executer()
        {
 
        }

        public void RunFunc(string code)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = false;

            string basic = @"
    using System;
    using System.Windows.Forms;
    namespace First
    {
        public class Program
        {
            public static void Main()
            {
                "+Parse(code)+@"
Console.ReadLine();
            }
        }
    }
";
            //string ready = basic.Replace("INSERT", Parse(code));
            parameters.ReferencedAssemblies.Add(@"C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, basic);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                throw new InvalidOperationException(sb.ToString());
            }

            Assembly assembly = results.CompiledAssembly;
            Type program = assembly.GetType("First.Program");
            MethodInfo main = program.GetMethod("Main");

            main.Invoke(null, null);
        }


        public void Run(string code, string Namespace, string programN)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;
            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = false;

            string basic = Parse(code);

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, basic);

            if (results.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in results.Errors)
                {
                    sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                throw new InvalidOperationException(sb.ToString());
            }

            Assembly assembly = results.CompiledAssembly;
            Type program = assembly.GetType(Namespace+"."+programN);
            MethodInfo main = program.GetMethod("Main");

            main.Invoke(null, null);
        }

        private string Parse(string code)
        {
            for (int i = 0; i < keywords.Length; i++)
            {
              code = code.Replace(HE_keywords[i],keywords[i]);
            }
            return code;
        }

        public string Dic()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < keywords.Length; i++)
            {
                sb.Append(keywords[i] + " " + HE_keywords[i] + "\n");
            }
            return sb.ToString();
        }
    }
}
