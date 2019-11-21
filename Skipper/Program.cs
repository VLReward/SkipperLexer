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

                string text = File.ReadAllText(@"C:\AMD\testfile.txt");
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
            foreach (var variable in varList)
            {
                if (variable.name == newName)
                    return true;
            }
            return false;
        }

        public static varName GetVar(string name)
        {
            foreach (var variable in varList)
            {
                if (variable.name == name)
                    return variable;
            }
            return new varName();
        }
        //public static void Convert8BitToByte(int n )
        //{
        //    //std::ofstream outfile(filename);
        //    var outfile = new FileStream("", FileMode.Open, FileAccess.ReadWrite);
        //    char bytes[1];
        //    //Get each byte value from short.
        //    bytes[0] = n & 0xFF;
        //    outfile.Write(bytes[0]);

        //    int Int8 = 0;

        //    Int8 = bytes[0];
        //}

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
            public override void EnterStart(PenguineseParser.StartContext context)
            {
                Console.WriteLine("Start " + context.GetText() + Environment.NewLine);
            }
            public override void EnterBloqueCodigo(PenguineseParser.BloqueCodigoContext context)
            {
                Console.WriteLine("BloqueCodigo " + context.GetText() + Environment.NewLine);
            }
            public override void EnterExpresion(PenguineseParser.ExpresionContext context)
            {
                //checar si es halt
                if (context.children[0].GetText() == "NOOT NOOT")
                {
                    //escribir 0;
                }
                Console.WriteLine("Expresion " + context.GetText() + Environment.NewLine);
            }
            public override void EnterDeclararVar(PenguineseParser.DeclararVarContext context)
            {
                Console.WriteLine("DeclararVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterAsignarValor(PenguineseParser.AsignarValorContext context)
            {// en asignar tambien se deberia dar de alta la variable
                //context.children[0].GetText() tipo de variable 
                //context.children[1].GetText() nombre de variable 
                //context.children[3].GetText() valor a asignar
                Console.WriteLine("AsignVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterAsignarVariable(PenguineseParser.AsignarVariableContext context)
            {
                //context.children[0].GetText() tipo de variable 
                //context.children[1].GetText() nombre de variable 
                //context.children[3].GetText() variable a asignar
                if (!IsVarInList(context.children[3].GetText()))
                {
                    Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                }
                Console.WriteLine("AsignVar " + context.GetText() + Environment.NewLine);
            }
            /*
             * EnterDecVar detecta el tipo de variable basado en los tokens dentro de la misma linea,
             * determinando asi la cantidad de bytes que deben asignarse a la variable de tamano.
             */
            public override void EnterDecVar(PenguineseParser.DecVarContext context)//no agregar mensajes de error en este metodo
            {
                var type = "";
                var name = "";
                var size = 0;
                var isArray = 0;
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
                                var item = 0;
                                if (varList.Count > 0)
                                    item = varList[varList.Count - 1].location + varList[varList.Count - 1].byteSize;
                                varList.Add(new varName { name = name, type = type, byteSize = size, IsArray = isArray, location = (item == 0 ? item : item + 1) }); //deberia ser +1, era antes location = item + 1 todo el tiempo
                            }
                        }
                    }
                }
                Console.WriteLine("DecVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterTipoVar(PenguineseParser.TipoVarContext context)
            {
                Console.WriteLine("TipoVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterTipoVarS(PenguineseParser.TipoVarSContext context)
            {
                Console.WriteLine("TipoVarS " + context.GetText() + Environment.NewLine);
            }
            public override void EnterNombreVar(PenguineseParser.NombreVarContext context)
            {
                Console.WriteLine("NombreVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterVariable(PenguineseParser.VariableContext context)
            {
                Console.WriteLine("Variable " + context.GetText() + Environment.NewLine);
            }
            public override void EnterNombreSimple(PenguineseParser.NombreSimpleContext context)
            {
                Console.WriteLine("NombreSimple " + context.GetText() + Environment.NewLine);
            }
            public override void EnterNombreArreglo(PenguineseParser.NombreArregloContext context)
            {
                Console.WriteLine("NombreArreglo " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorVar(PenguineseParser.ValorVarContext context)
            {
                Console.WriteLine("ValorVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorEntero(PenguineseParser.ValorEnteroContext context)
            {
                Console.WriteLine("ValorEntero " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorDec(PenguineseParser.ValorDecContext context)
            {
                Console.WriteLine("ValorDec " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorChar(PenguineseParser.ValorCharContext context)
            {
                Console.WriteLine("ValorChar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterValorString(PenguineseParser.ValorStringContext context)
            {
                Console.WriteLine("ValorString " + context.GetText() + Environment.NewLine);
            }
            public override void EnterMath(PenguineseParser.MathContext context)
            {
                Console.WriteLine("Math " + context.GetText() + Environment.NewLine);
            }
            public override void EnterOperacionVeV(PenguineseParser.OperacionVeVContext context)
            {// muy similar a VeN
                Console.WriteLine("OperacionVeV " + context.GetText() + Environment.NewLine);
            }
            public override void EnterOperacionVeN(PenguineseParser.OperacionVeNContext context)
            {
                // se puede evaluar todo de un jalon
                try
                {
                    if (!IsVarInList(context.children[0].GetText()))
                    {
                        Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                    }

                    YoungWriter youngWriter = new YoungWriter();
                    using (Stream fileStream = new FileStream("zoinks.ye", FileMode.Append, FileAccess.Write, FileShare.None))
                    using (BinaryWriter file = new BinaryWriter(fileStream))
                    {
                        int opCount = context.children.Count - 3;//numero de operaciones  
                        varName variable = GetVar(context.children[0].GetText());
                        int lugarVar = variable.location;
                        double num1 = double.Parse(context.children[2].GetText());
                        List<string> operators = new List<string>();
                        List<string> values = new List<string>();
                        for (int i = 0; i < opCount; i++)
                        {
                            operators.Add(context.children[i + 3].GetChild(0).GetText());
                            values.Add(context.children[i + 3].GetChild(1).GetText());
                        }
                        youngWriter.WriteToFile(file, PUSHKD, new ArrayList { num1 });
                        tc += 9;
                        int j = 0;
                        foreach (var op in operators)
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
                            else
                                Console.WriteLine("Context Error: < " + values[j] + " > no es un numero" + Environment.NewLine);
                            tc++;
                            if (op == "+")
                            {
                                youngWriter.WriteByte(file, (byte)SUM);
                            }
                            else if (op == "-")
                            {
                                youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)SUB);
                            }
                            else if (op == "*")
                            {
                                youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)MULT);
                            }
                            else if (op == "/")
                            {
                                youngWriter.WriteToFile(file, PUSHKD, new ArrayList { values[j] });
                                youngWriter.WriteByte(file, (byte)DIV);
                            }
                            j++;
                        }
                        //double num2 = double.Parse(context.children[3].GetChild(1).GetText());  //Estos sucedera si hay un operador
                        //string operador = context.children[3].GetChild(0).GetText();
                        Console.WriteLine("OperacionVeN " + context.GetText() + Environment.NewLine);
                        file.Close();
                        file.Dispose();
                    }
                }
                catch (Exception ex)
                { }
            }
            public override void EnterMathSeq(PenguineseParser.MathSeqContext context)
            {
                Console.WriteLine("MathSeq " + context.GetText() + Environment.NewLine);
            }
            public override void EnterSeqNum(PenguineseParser.SeqNumContext context)
            {
                Console.WriteLine("SeqNum " + context.GetText() + Environment.NewLine);
            }
            public override void EnterSeqVar(PenguineseParser.SeqVarContext context)
            {
                Console.WriteLine("SeqVar " + context.GetText() + Environment.NewLine);
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
                //context.children[3].GetText()  El contenido; Si comienza con '\"' es string, else es nombre de variable
                if ((!IsVarInList(context.children[3].GetText())) && context.children[3].GetText()[0] != '"')
                {
                    Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                }
                Console.WriteLine("ImprimirValor " + context.GetText() + Environment.NewLine);
            }
            //public override void EnterNombreValores(PenguineseParser.NombreValoresContext context)
            //{
            //    Console.WriteLine("NombreValores " + context.GetText() + Environment.NewLine);
            //}
            //public override void EnterImprimirSeq(PenguineseParser.ImprimirSeqContext context)
            //{
            //    Console.WriteLine("ImprimirSeq " + context.GetText() + Environment.NewLine);
            //}
            public override void EnterEscribirValor(PenguineseParser.EscribirValorContext context)
            {
                //context.children[3].GetText() nombre de variable
                if (!IsVarInList(context.children[3].GetText()))
                {
                    Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                }
                if (GetVar(context.children[3].GetText()).type != "text")
                {
                    Console.WriteLine("Context Error: La variable < " + context.children[0].GetText() + " > no es de tipo text" + Environment.NewLine);
                }
                Console.WriteLine("EscribirValor " + context.GetText() + Environment.NewLine);
            }
        }
    }
}
