using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Rico;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Skipper
{
    public class Program
    {
        #region Defines
        public const byte EFE = 0;
        public const byte RDI = 1;
        public const byte RDD = 2;
        public const byte RDS = 3;
        public const byte RDB = 4;
        public const byte RDC = 5;
        public const byte RDIV = 6;
        public const byte RDDV = 7;
        public const byte RDSV = 8;
        public const byte RDBV = 9;
        public const byte RDCV = 10;
        public const byte PRTM = 11;
        public const byte PRTI = 12;
        public const byte PRTD = 13;
        public const byte PRTS = 14;
        public const byte PRTB = 15;
        public const byte PRTC = 16;
        public const byte PRTIV = 17;
        public const byte PRTDV = 18;
        public const byte PRTSV = 19;
        public const byte PRTBV = 20;
        public const byte PRTCV = 21;
        public const byte PUSHI = 22;
        public const byte PUSHD = 23;
        public const byte PUSHS = 24;
        public const byte PUSHB = 25;
        public const byte PUSHC = 26;
        public const byte PUSHKI = 27;
        public const byte PUSHKD = 28;
        public const byte PUSHKS = 29;
        public const byte PUSHKB = 30;
        public const byte PUSHKC = 31;
        public const byte POPI = 32;
        public const byte POPD = 33;
        public const byte POPS = 34;
        public const byte POPB = 35;
        public const byte POPC = 36;
        public const byte POPIV = 37;
        public const byte POPDV = 38;
        public const byte POPSV = 39;
        public const byte POPBV = 40;
        public const byte POPCV = 41;
        public const byte SUM = 42;
        public const byte SUB = 43;
        public const byte MULT = 44;
        public const byte DIV = 45;
        public const byte MOD = 46;
        public const byte AND = 47;
        public const byte OR = 48;
        public const byte XOR = 49;
        public const byte MAX = 50;
        public const byte MIN = 51;
        public const byte INCI = 52;
        public const byte INCD = 53;
        public const byte INCC = 54;
        public const byte DECI = 55;
        public const byte DECD = 56;
        public const byte DECC = 57;
        public const byte BRANCH = 58;
        public const byte CMPLE = 59;
        public const byte CMPL = 60;
        public const byte CMPGE = 61;
        public const byte CMPG = 62;
        public const byte CMPE = 63;
        public const byte CMPNE = 64;
        public const byte IDX = 65;
        public const byte BRNCHC = 66;
        #endregion

        public class varName
        {
            public string name;
            public string type;
            public int byteSize;
            public int IsArray;
            public int location;
        };

        public static List<varName> varList = new List<varName>();
        public static short tc = 0;

        private static void Main(string[] args)
        {
            try
            {
                YoungWriter youngWriter = new YoungWriter();
                using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Create, FileAccess.ReadWrite, FileShare.None))
                using (BinaryWriter file = new BinaryWriter(fileStream))
                {
                    //BinaryWriter file = new BinaryWriter(File.Open("zoinks.ye", FileMode.Create), Encoding.ASCII, true);
                    youngWriter.WriteByte(file, (byte)73);//I
                    youngWriter.WriteByte(file, (byte)67);//C
                    youngWriter.WriteByte(file, (byte)67);//C
                    youngWriter.WriteByte(file, (byte)50);//2
                    youngWriter.WriteByte(file, (byte)48);//0
                    youngWriter.WriteByte(file, (byte)50);//2
                    youngWriter.WriteByte(file, (byte)48);//0
                    youngWriter.WriteByte(file, (byte)0);
                    youngWriter.WriteByte(file, (byte)25);//TC
                    youngWriter.WriteByte(file, (byte)0);
                    youngWriter.WriteByte(file, (byte)4);//TD
                    file.Close();
                    file.Dispose();
                }

                string text = File.ReadAllText(@"C:\AN\DebugStep.txt");
                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());// copia datos de string a un arry de chars
                PenguineseLexer lexer = new PenguineseLexer(inputStream);    // crea un lexer nuevo
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);    // lista de tokens 
                PenguineseParser parser = new PenguineseParser(commonTokenStream);   // crea un parser nuevo
                parser.RemoveErrorListeners(); // no viene con error listeners, borra esto despues
                parser.AddErrorListener(new XParser());
                //parser.start();
                if (parser.NumberOfSyntaxErrors == 0)
                {
                    IParseTree tree = parser.start();
                    CompPrinter printer = new CompPrinter();
                    ParseTreeWalker.Default.Walk(printer, tree);
                }
                short td = (short)(varList[varList.Count - 1].location + varList[varList.Count - 1].byteSize);

                using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                using (BinaryWriter file = new BinaryWriter(fileStream))
                {
                    youngWriter.WriteByte(file, (byte)0);//HALT
                    tc++;
                    file.Close();
                    file.Dispose();
                }
                byte[] header = (new byte[] { (byte)73, (byte)67, (byte)67, (byte)50, (byte)48, (byte)50, (byte)48 }).Concat(BitConverter.GetBytes(tc)).ToArray();
                //header = header.Concat(BitConverter.GetBytes(td)).ToArray();
                YoungWriter.ReplaceData("zoinks.ye", 0, header.Concat(BitConverter.GetBytes(td)).ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:  " + ex);
            }
        }

        public static bool IsVarInList(string newName)
        {
            foreach (varName variable in varList)
            {
                if (variable.name == newName)
                    return true;
            }
            return false;
        }

        public static varName GetVar(string name)
        {
            foreach (varName variable in varList)
            {
                if (variable.name == name)
                    return variable;
            }
            return new varName();
        }

        public static string GetInputType(string suspect)
        {
            if (suspect[0] == '"')
                return "text";
            else if (suspect[0] == '\'')
                return "character";
            if (suspect.Contains("["))
                return "array";
            else if (int.TryParse(suspect, out int x))
                return "number";
            else if (double.TryParse(suspect, out double y))
                return "double";
            else if (suspect == "true" || suspect == "false")
                return "boolean";
            else
                return "variable";
        }

        partial class XParser : IAntlrErrorListener<IToken>
        {
            public void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
            {
                try
                {
                    Console.WriteLine("Parser Error at line  " + line + ", char  " + charPositionInLine + ":  " + msg);

                }
                catch (Exception ex)
                { }
            }
        }

        public class CompPrinter : PenguineseBaseListener
        {
            // override default listener behavior
            public override void EnterExpresion(PenguineseParser.ExpresionContext context)
            {
                //checar si es halt
                if (context.children[0].GetText() == "NOOT NOOT")
                {
                    //escribir 0;
                    YoungWriter youngWriter = new YoungWriter();
                    using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                    using (BinaryWriter file = new BinaryWriter(fileStream))
                    {
                        youngWriter.WriteByte(file, EFE);//HALT
                        tc++;
                        file.Close();
                        file.Dispose();
                    }
                }
            }
            public override void EnterAsignarValor(PenguineseParser.AsignarValorContext context)
            {   // en asignar tambien se deberia dar de alta la variable
                //context.children[0].GetText() tipo de variable 
                //context.children[1].GetText() nombre de variable 
                //context.children[3].GetText() valor a asignar
                if (!IsVarInList(context.children[3].GetText()))
                {
                    Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                }
                string name = context.children[1].GetText();
                int size = 0;
                int isArray = 0;
                int item = 0;
                string type = context.children[0].GetText();
                if (type == "number")
                    size = 4;
                else if (type == "character")
                    size = 1;
                else if (type == "double")
                    size = 8;
                else if (type == "boolean")
                    size = 1;
                else if (type == "text")
                    size = 256;
                if (varList.Count > 0)
                    item = varList[varList.Count - 1].location + varList[varList.Count - 1].byteSize;
                varList.Add(new varName { name = name, type = type, byteSize = size, IsArray = isArray, location = (item == 0 ? item : item + 1) }); //deberia ser +1, era antes location = item + 1 todo el tiempo
                varName variable = GetVar(name);

                string valType = GetInputType(context.children[3].GetText());
                string porAsignar = context.children[3].GetText();
                YoungWriter youngWriter = new YoungWriter();
                using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                using (BinaryWriter file = new BinaryWriter(fileStream))
                {
                    if (valType != variable.type)
                        Console.WriteLine("Error: El tipo de < " + context.children[3].GetText() + " > no concuerda con la variable < " + name + " >" + Environment.NewLine);
                    else if (valType == "number")
                    {
                        youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(porAsignar) });
                        youngWriter.WriteToFile(file, POPI, new ArrayList { (short)variable.location });
                    }
                    else if (valType == "character")
                    {
                        youngWriter.WriteToFile(file, PUSHKC, new ArrayList { porAsignar[1] });
                        youngWriter.WriteToFile(file, POPC, new ArrayList { (short)variable.location });
                    }
                    else if (valType == "double")
                    {
                        youngWriter.WriteToFile(file, PUSHKD, new ArrayList { double.Parse(porAsignar) });
                        youngWriter.WriteToFile(file, POPD, new ArrayList { (short)variable.location });
                    }
                    else if (valType == "boolean")
                    {
                        youngWriter.WriteToFile(file, PUSHKB, new ArrayList { porAsignar == "true" ? true : false });
                        youngWriter.WriteToFile(file, POPB, new ArrayList { (short)variable.location });
                    }
                    else if (valType == "text")
                    {
                        youngWriter.WriteToFile(file, PUSHKS, new ArrayList { porAsignar.Replace("\"", "") });
                        youngWriter.WriteToFile(file, POPS, new ArrayList { (short)variable.location });
                    }
                    file.Close();
                    file.Dispose();
                }
            }
            public override void EnterAsignarVariable(PenguineseParser.AsignarVariableContext context)
            {
                //context.children[0].GetText() tipo de variable 
                //context.children[1].GetText() nombre de variable 
                //context.children[3].GetText() variable a asignar
                string name = context.children[1].GetText();
                int size = 0;
                int isArray = 0;
                int item = 0;
                string type = context.children[0].GetText();
                if (type == "number")
                    size = 4;
                else if (type == "character")
                    size = 1;
                else if (type == "double")
                    size = 8;
                else if (type == "boolean")
                    size = 1;
                else if (type == "text")
                    size = 256;
                if (varList.Count > 0)
                    item = varList[varList.Count - 1].location + varList[varList.Count - 1].byteSize;
                varList.Add(new varName { name = name, type = type, byteSize = size, IsArray = isArray, location = (item == 0 ? item : item + 1) }); //deberia ser +1, era antes location = item + 1 todo el tiempo

                varName variable = GetVar(name);
                var asignType = GetInputType(context.children[3].GetText());
                if (asignType == "variable")
                {
                    if (!IsVarInList(context.children[3].GetText()))
                    {
                        Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                    }
                    varName porAsignar = GetVar(context.children[3].GetText());
                    YoungWriter youngWriter = new YoungWriter();
                    using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                    using (BinaryWriter file = new BinaryWriter(fileStream))
                    {
                        if (porAsignar.type != variable.type)
                            Console.WriteLine("Error: El tipo de < " + context.children[3].GetText() + " > no concuerda con la variable < " + name + " >" + Environment.NewLine);
                        else if (IsVarInList(porAsignar.name))
                        {
                            if (variable.type == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPI, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "double")
                            {
                                youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPD, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "character")
                            {
                                youngWriter.WriteToFile(file, PUSHC, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPC, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "text")
                            {
                                youngWriter.WriteToFile(file, PUSHS, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPS, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "boolean")
                            {
                                youngWriter.WriteToFile(file, PUSHB, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPB, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Context Error: < " + context.children[3].GetText() + " > se usa sin declararse" + Environment.NewLine);
                        }
                        file.Close();
                        file.Dispose();
                    }
                }
                else if (asignType == "array")
                {
                    string nombreArray = context.children[3].GetChild(0).GetText();
                    string indVal = context.children[3].GetChild(2).GetText();
                    varName porAsignar = GetVar(nombreArray);
                    YoungWriter youngWriter = new YoungWriter();
                    using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                    using (BinaryWriter file = new BinaryWriter(fileStream))
                    {
                        var tipoindex = GetInputType(context.children[3].GetChild(2).GetText());
                        if (tipoindex == "variable")
                        {
                            youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(indVal).location });
                            youngWriter.WriteByte(file, (byte)IDX);
                            tc += 4;
                        }
                        else
                        {
                            //numero
                            youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(indVal) });
                            youngWriter.WriteByte(file, (byte)IDX);
                            tc += 6;
                        }
                        if (porAsignar.type != variable.type)
                            Console.WriteLine("Error: El tipo de < " + nombreArray + " > no concuerda con la variable < " + name + " >" + Environment.NewLine);
                        else if (IsVarInList(porAsignar.name))
                        {
                            if (variable.type == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPI, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "double")
                            {
                                youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPD, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "character")
                            {
                                youngWriter.WriteToFile(file, PUSHC, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPC, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "text")
                            {
                                youngWriter.WriteToFile(file, PUSHS, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPS, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                            else if (variable.type == "boolean")
                            {
                                youngWriter.WriteToFile(file, PUSHB, new ArrayList { (short)porAsignar.location });
                                youngWriter.WriteToFile(file, POPB, new ArrayList { (short)variable.location });
                                tc += 6;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Context Error: < " + context.children[3].GetText() + " > se usa sin declararse" + Environment.NewLine);
                        }
                        file.Close();
                        file.Dispose();
                    }
                }
            }
            /*
             * EnterDecVar detecta el tipo de variable basado en los tokens dentro de la misma linea,
             * determinando asi la cantidad de bytes que deben asignarse a la variable de tamano.
             */
            public override void EnterDecVar(PenguineseParser.DecVarContext context)//no agregar mensajes de error en este metodo
            {
                string type = "";
                string name = "";
                int size = 0;
                int isArray = 0;
                int nameCount = context.GetText().Split(',').Length * 2 - 1;
                if (context.GetText().Substring(0, 1) == "a")
                {
                    type = context.children[0].GetChild(1).GetText();
                    if (int.TryParse(context.children[0].GetChild(3).GetText(), out int idx))
                        isArray = idx;
                    if (type == "number")// se rompera esto si se trata de inicializar algo con una variable
                        size = 4 * isArray;
                    else if (type == "character")
                        size = 1 * isArray;
                    else if (type == "double")
                        size = 8 * isArray;
                    else if (type == "boolean")
                        size = 1 * isArray;
                    else if (type == "text")
                        size = 256 * isArray;
                }
                else
                {
                    type = context.children[0].GetText();
                    if (type == "number")
                        size = 4;
                    else if (type == "character")
                        size = 1;
                    else if (type == "double")
                        size = 8;
                    else if (type == "boolean")
                        size = 1;
                    else if (type == "text")
                        size = 256;
                }
                for (int i = 0; i < nameCount; i++)
                {
                    if (context.children[i + 1].GetText() != ",")
                    {
                        foreach (string token in context.children[i + 1].GetText().Split(","))
                        {
                            name = token;
                            //foreach (var variable in varList)
                            //{
                            //    if (variable.name == token)
                            //        name = "";
                            //}
                            if (!IsVarInList(name))
                            {
                                int item = 0;
                                if (varList.Count > 0)
                                    item = varList[varList.Count - 1].location + varList[varList.Count - 1].byteSize;
                                varList.Add(new varName { name = name, type = type, byteSize = size, IsArray = isArray, location = (item == 0 ? item : item + 1) }); //deberia ser +1, era antes location = item + 1 todo el tiempo
                            }
                        }
                    }
                }
            }

            public override void EnterMath(PenguineseParser.MathContext context)
            {
                try
                {

                    YoungWriter youngWriter = new YoungWriter();
                    using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                    using (BinaryWriter file = new BinaryWriter(fileStream))
                    {
                        int opCount = context.children.Count - 3;//numero de operaciones  
                        if (GetInputType(context.children[2].GetText()) == "number")
                        {
                            youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(context.children[2].GetText()) });
                            tc += 5;
                        }
                        else if (GetInputType(context.children[2].GetText()) == "double")
                        {
                            youngWriter.WriteToFile(file, PUSHKD, new ArrayList { double.Parse(context.children[2].GetText()) });
                            tc += 9;
                        }
                        else if (GetInputType(context.children[2].GetText()) == "variable")
                        {
                            varName temp = GetVar(context.children[2].GetText());
                            if (temp.type == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)temp.location });
                                tc += 3;
                            }
                            else if (temp.type == "double")
                            {
                                youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)temp.location });
                                tc += 3;
                            }
                            else
                                Console.WriteLine("Error: < " + temp.name + " > no es una variable numerica" + Environment.NewLine);
                        }
                        else if (GetInputType(context.children[2].GetText()) == "array")
                        {
                            // primero checar si existe
                            varName temp = GetVar(context.children[2].GetChild(0).GetText());

                            var idxType = GetInputType(context.children[2].GetChild(2).GetText());
                            if (idxType == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(context.children[2].GetChild(2).GetText()) });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 6;
                            }
                            else if (idxType == "variable")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(context.children[2].GetChild(2).GetText()).location });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 4;
                            }
                            if (temp.type == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)temp.location });
                                tc += 3;
                            }
                            else if (temp.type == "double")
                            {
                                youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)temp.location });
                                tc += 3;
                            }
                            else
                                Console.WriteLine("Error: < " + temp.name + " > no es una variable numerica" + Environment.NewLine);
                        }
                        List<string> operators = new List<string>();
                        List<string> values = new List<string>();
                        for (int i = 0; i < opCount; i++)
                        {
                            operators.Add(context.children[i + 3].GetChild(0).GetText());
                            values.Add(context.children[i + 3].GetChild(1).GetText());
                        }
                        double num1 = double.Parse(context.children[2].GetText());// agregar posibilidad de variables
                        youngWriter.WriteToFile(file, PUSHKD, new ArrayList { num1 });
                        tc += 9;
                        int j = 0;
                        foreach (string op in operators)
                        {
                            if (int.TryParse(values[j], out int val))
                            {
                                youngWriter.WriteToFile(file, PUSHKI, new ArrayList { val });
                                tc += 5;
                            }
                            else if (double.TryParse(values[j], out double val2))
                            {
                                youngWriter.WriteToFile(file, PUSHKD, new ArrayList { val2 });
                                tc += 9;
                            }
                            else if (GetVar(values[j]).type == "double")
                            {
                                youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)GetVar(values[j]).location });
                                tc += 3;
                            }
                            else if (GetVar(values[j]).type == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(values[j]).location });
                                tc += 3;
                            }
                            else if (GetInputType(values[j]) == "array")
                            {
                                var nombreArray = context.children[j + 3].GetChild(1).GetChild(0).GetText();
                                var indVal = context.children[j + 3].GetChild(1).GetChild(2).GetText();
                                varName varArray = GetVar(nombreArray);
                                var tipoindex = GetInputType(context.children[3].GetChild(2).GetText());
                                if (tipoindex == "variable")
                                {
                                    youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(indVal).location });
                                    youngWriter.WriteByte(file, (byte)IDX);
                                    tc += 4;
                                }
                                else
                                {
                                    //numero
                                    youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(indVal) });
                                    youngWriter.WriteByte(file, (byte)IDX);
                                    tc += 6;
                                }
                                if (IsVarInList(varArray.name))
                                {
                                    if (varArray.type == "number")
                                    {
                                        youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)varArray.location });
                                        tc += 3;
                                    }
                                    else if (varArray.type == "double")
                                    {
                                        youngWriter.WriteToFile(file, PUSHD, new ArrayList { (short)varArray.location });
                                        tc += 3;
                                    }
                                    else if (varArray.type == "character")
                                    {
                                        youngWriter.WriteToFile(file, PUSHC, new ArrayList { (short)varArray.location });
                                        tc += 3;
                                    }
                                    else if (varArray.type == "text")
                                    {
                                        youngWriter.WriteToFile(file, PUSHS, new ArrayList { (short)varArray.location });
                                        tc += 3;
                                    }
                                    else if (varArray.type == "boolean")
                                    {
                                        youngWriter.WriteToFile(file, PUSHB, new ArrayList { (short)varArray.location });
                                        tc += 3;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Context Error: < " + context.children[3].GetText() + " > se usa sin declararse" + Environment.NewLine);
                                }
                            }
                            else
                                Console.WriteLine("Context Error: < " + values[j] + " > no es un numero valido" + Environment.NewLine);
                            tc++;
                            if (op == "+")
                            {
                                youngWriter.WriteByte(file, (byte)SUM);
                            }
                            else if (op == "-")
                            {
                                //youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)SUB);
                            }
                            else if (op == "*")
                            {
                                //youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)MULT);
                            }
                            else if (op == "/")
                            {
                                //youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)DIV);
                            }
                            j++;
                        }
                        if (GetInputType(context.children[0].GetText()) == "variable")//    si se metera a una variable
                        {
                            if (!IsVarInList(context.children[0].GetText()))
                            {
                                Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                            }
                            else
                            {
                                varName variable = GetVar(context.children[0].GetText());
                                tc += 3;
                                if (variable.type == "number")
                                    youngWriter.WriteToFile(file, POPI, new ArrayList { (short)variable.location });
                                else if (variable.type == "double")
                                    youngWriter.WriteToFile(file, POPD, new ArrayList { (short)variable.location });
                                else
                                    Console.WriteLine("Context Error: < " + variable.name + " > no es un numero" + Environment.NewLine);
                            }
                        }
                        else if (GetInputType(context.children[0].GetText()) == "array")//  si se metera a un array
                        {
                            varName variable = GetVar(context.children[0].GetChild(0).GetText());

                            var idxType = GetInputType(context.children[0].GetChild(2).GetText());
                            if (idxType == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(context.children[0].GetChild(2).GetText()) });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 6;
                            }
                            else if (idxType == "variable")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(context.children[0].GetChild(2).GetText()).location });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 4;
                            }
                            else
                                Console.WriteLine("Error: < " + context.children[0].GetChild(2).GetText() + " > no es un numero" + Environment.NewLine);

                            if (variable.type == "number")
                                youngWriter.WriteToFile(file, POPIV, new ArrayList { (short)variable.location });
                            else if (variable.type == "double")
                                youngWriter.WriteToFile(file, POPDV, new ArrayList { (short)variable.location });
                            else
                                Console.WriteLine("Context Error: < " + variable.name + " > no es un numero" + Environment.NewLine);
                        }
                        Console.WriteLine("OperacionVeN " + context.GetText() + Environment.NewLine);
                        file.Close();
                        file.Dispose();
                    }
                }
                catch (Exception ex)
                { }
                Console.WriteLine("Math " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorNum(PenguineseParser.ValorNumContext context)
            {
                Console.WriteLine("ValorNum " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCiclo(PenguineseParser.CicloContext context)
            {
                Console.WriteLine("Ciclo " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCicloWhile(PenguineseParser.CicloWhileContext context)
            {//cosas que se hacen antes del primer ciclo
                Console.WriteLine("CicloWhile " + context.GetText() + Environment.NewLine);
            }
            public override void ExitCicloWhile(PenguineseParser.CicloWhileContext context)
            {//cosas que se hacen al acabar ciclo
                Console.WriteLine("CicloWhile " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCicloIf(PenguineseParser.CicloIfContext context)
            {//chequeo de bool 
                Console.WriteLine("CicloIf " + context.GetText() + Environment.NewLine);
            }
            public override void ExitCicloIf(PenguineseParser.CicloIfContext context)
            {//notar que aqui termina el if anterior 
                Console.WriteLine("CicloIf " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCicloFor(PenguineseParser.CicloForContext context)
            {// alguien mas bigg brain que yo podra hacer esto
                Console.WriteLine("CicloFor " + context.GetText() + Environment.NewLine);
            }
            public override void ExitCicloFor(PenguineseParser.CicloForContext context)
            {// sale del ciclo aqui
                Console.WriteLine("CicloFor " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCondicional(PenguineseParser.CondicionalContext context)
            {
                Console.WriteLine("Condicional " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorCond(PenguineseParser.ValorCondContext context)
            {
                Console.WriteLine("ValorCond " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCondSeq(PenguineseParser.CondSeqContext context)
            {
                Console.WriteLine("CondSeq " + context.GetText() + Environment.NewLine);
            }
            public override void EnterSeccionFor(PenguineseParser.SeccionForContext context)
            {// tiene toda la carne de EnterCicloFor, preferirira usar esto para decidir las primeras acciones
                //primero se deberia declarar y asignar la variable
                Console.WriteLine("SeccionFor " + context.GetText() + Environment.NewLine);
            }
            public override void EnterImprimirValor(PenguineseParser.ImprimirValorContext context)
            {
                YoungWriter youngWriter = new YoungWriter();
                using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                using (BinaryWriter file = new BinaryWriter(fileStream))
                {
                    var x = GetInputType(context.children[3].GetText());
                    switch (x)
                    {
                        case "text":
                            youngWriter.WriteToFile(file, PRTM, new ArrayList { context.children[3].GetText().Replace("\"", "").Length });
                            tc += 3;
                            file.Write(context.children[3].GetText().Replace("\"", ""));
                            tc += (short)context.children[3].GetText().Replace("\"", "").Length;
                            break;
                        case "array":
                            //context.children[3].GetChild(2).GetText() = index
                            //context.children[3].GetChild(0).GetText() = nombre
                            var tipoindex = GetInputType(context.children[3].GetChild(2).GetText());
                            if (tipoindex == "variable")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(context.children[3].GetChild(2).GetText()).location });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 4;
                            }
                            else
                            {
                                //numero
                                youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(context.children[3].GetChild(2).GetText()) });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 6;
                            }
                            var nombrevar = context.children[3].GetChild(0).GetText();
                            var variable = GetVar(nombrevar);
                            switch (variable.type)
                            {
                                case "number":
                                    youngWriter.WriteToFile(file, PRTIV, new ArrayList { (short)variable.location });
                                    break;
                                case "double":
                                    youngWriter.WriteToFile(file, PRTDV, new ArrayList { (short)variable.location });
                                    break;
                                case "boolean":
                                    youngWriter.WriteToFile(file, PRTBV, new ArrayList { (short)variable.location });
                                    break;
                                case "char":
                                    youngWriter.WriteToFile(file, PRTCV, new ArrayList { (short)variable.location });
                                    break;
                                case "text":
                                    youngWriter.WriteToFile(file, PRTSV, new ArrayList { (short)variable.location });
                                    break;
                                default:
                                    Console.WriteLine("Error: unexpected input");
                                    break;
                            }
                            tc += 3;
                            break;
                        case "variable":
                            if ((!IsVarInList(context.children[3].GetText())) && context.children[3].GetText()[0] != '"')
                            {
                                Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                            }
                            else
                            {
                                var vari = GetVar(context.children[3].GetText());
                                switch (vari.type)
                                {
                                    case "number":
                                        youngWriter.WriteToFile(file, PRTI, new ArrayList { (short)vari.location });
                                        break;
                                    case "double":
                                        youngWriter.WriteToFile(file, PRTD, new ArrayList { (short)vari.location });
                                        break;
                                    case "boolean":
                                        youngWriter.WriteToFile(file, PRTB, new ArrayList { (short)vari.location });
                                        break;
                                    case "char":
                                        youngWriter.WriteToFile(file, PRTC, new ArrayList { (short)vari.location });
                                        break;
                                    case "text":
                                        youngWriter.WriteToFile(file, PRTS, new ArrayList { (short)vari.location });
                                        break;
                                    default:
                                        Console.WriteLine("Error: unexpected input");
                                        break;
                                }
                                tc += 3;
                            }
                            break;
                        default:
                            Console.WriteLine("Error: unexpected input");
                            break;
                    }
                    file.Close();
                    file.Dispose();
                }
            }
            public override void EnterEscribirValor(PenguineseParser.EscribirValorContext context)
            {
                string tipoStr = GetInputType(context.children[3].GetText());
                if (tipoStr == "variable")
                {
                    if (!IsVarInList(context.children[3].GetText()))
                        Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                    else
                    {
                        YoungWriter youngWriter = new YoungWriter();
                        varName variable = GetVar(context.children[3].GetText());
                        using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                        using (BinaryWriter file = new BinaryWriter(fileStream))
                        {
                            if (variable.type == "number")
                            {
                                youngWriter.WriteToFile(file, RDI, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "character")
                            {
                                youngWriter.WriteToFile(file, RDC, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "double")
                            {
                                youngWriter.WriteToFile(file, RDD, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "boolean")
                            {
                                youngWriter.WriteToFile(file, RDB, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "text")
                            {
                                youngWriter.WriteToFile(file, RDS, new ArrayList { (short)variable.location });
                            }
                            tc += 3;
                            file.Close();
                            file.Dispose();
                        }
                    }
                }
                else if (tipoStr == "array")
                {
                    if (!IsVarInList(context.children[3].GetChild(0).GetText()))
                    {
                        Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                    }
                    else
                    {
                        YoungWriter youngWriter = new YoungWriter();
                        using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                        using (BinaryWriter file = new BinaryWriter(fileStream))
                        {
                            varName variable = GetVar(context.children[3].GetChild(0).GetText());
                            var idxType = GetInputType(context.children[3].GetChild(2).GetText());
                            if (idxType == "number")
                            {
                                youngWriter.WriteToFile(file, PUSHKI, new ArrayList { int.Parse(context.children[3].GetChild(2).GetText()) });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 6;
                            }
                            else if (idxType == "variable")
                            {
                                youngWriter.WriteToFile(file, PUSHI, new ArrayList { (short)GetVar(context.children[3].GetChild(2).GetText()).location });
                                youngWriter.WriteByte(file, (byte)IDX);
                                tc += 4;
                            }
                            else
                                Console.WriteLine("Error: < " + context.children[3].GetChild(2).GetText() + " > no es numero ni variable tipo number" + Environment.NewLine);
                            if (variable.type == "text")
                            {
                                youngWriter.WriteToFile(file, RDSV, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "character")
                            {
                                youngWriter.WriteToFile(file, RDCV, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "number")
                            {
                                youngWriter.WriteToFile(file, RDIV, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "double")
                            {
                                youngWriter.WriteToFile(file, RDDV, new ArrayList { (short)variable.location });
                            }
                            else if (variable.type == "boolean")
                            {
                                youngWriter.WriteToFile(file, RDBV, new ArrayList { (short)variable.location });
                            }
                            tc += 3;
                            file.Close();
                            file.Dispose();
                        }
                    }
                }
                else
                { }
            }
        }
    }
}
