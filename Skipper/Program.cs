using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.IO;

namespace Skipper
{
    public class Program
    {
        public class varName
        {
            public string name;
            public string type;
            public int byteSize;
            public int IsArray;
            public int location;
        };

        public static List<varName> varList = new List<varName>();
        public static int pcprueba = 0;

        private static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"C:\An\testFile.txt");

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
                                varList.Add(new varName { name = name, type = type, byteSize = size, IsArray = isArray, location = item + 1 });
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
                if (!IsVarInList(context.children[0].GetText()))
                {
                    Console.WriteLine("Context Error: < " + context.children[0].GetText() + " > se usa sin declararse" + Environment.NewLine);
                }
                varName variable = GetVar(context.children[0].GetText());
                int lugarVar = variable.location;
                double num1 = double.Parse(context.children[2].GetText());
                //double num2 = double.Parse(context.children[3].GetChild(1).GetText());  //Estos sucedera si hay un operador
                //string operador = context.children[3].GetChild(0).GetText();
                Console.WriteLine("OperacionVeN " + context.GetText() + Environment.NewLine);
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
