using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;

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

        private static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText(@"C:\AMD\testfile.txt ");

                AntlrInputStream inputStream = new AntlrInputStream(text.ToString());// copia datos de string a un arry de chars
                PenguineseLexer lexer = new PenguineseLexer(inputStream);    // crea un lexer nuevo
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);    // lista de tokens 


                PenguineseParser parser = new PenguineseParser(commonTokenStream);   // crea un parser nuevo
                parser.RemoveErrorListeners(); // no viene con error listeners, borra esto despues
                parser.AddErrorListener(new XParser());
                //PenguineseParser.start();
                IParseTree tree = parser.start();
                CompPrinter printer = new CompPrinter();
                ParseTreeWalker.Default.Walk(printer, tree);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:  " + ex);
            }
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
                Console.WriteLine("Expresion " + context.GetText() + Environment.NewLine);
            }
            public override void EnterDeclararVar(PenguineseParser.DeclararVarContext context)
            {
                Console.WriteLine("DeclararVar " + context.GetText() + Environment.NewLine);
            }
            public override void EnterAsignVar(PenguineseParser.AsignVarContext context)
            {
                Console.WriteLine("AsignVar " + context.GetText() + Environment.NewLine);
            }
            /*
             * EnterDecVar detecta el tipo de variable basado en los tokens dentro de la misma linea,
             * determinando asi la cantidad de bytes que deben asignarse a la variable de tamano.
             * 
             * 
             */
            public override void EnterDecVar(PenguineseParser.DecVarContext context)
            {
                var type = "";
                var name = "";
                var size = 0;
                var isArray = 0;
                int nameCount = context.GetText().Split(',').Length * 2 - 1;
                if (context.GetText().Substring(0, 1) == "a")
                {
                    type = context.children[0].GetChild(1).GetText();
                    isArray = int.Parse(context.children[0].GetChild(3).GetText());
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
                            foreach (var variable in varList)
                            {
                                if (variable.name == token)
                                    name = "";
                            }
                            if (name != "")
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
            {
                Console.WriteLine("OperacionVeV " + context.GetText() + Environment.NewLine);
            }
            public override void EnterOperacionVeN(PenguineseParser.OperacionVeNContext context)
            {
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
            {
                Console.WriteLine("CicloWhile " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCicloIf(PenguineseParser.CicloIfContext context)
            {
                Console.WriteLine("CicloIf " + context.GetText() + Environment.NewLine);
            }
            public override void EnterCicloFor(PenguineseParser.CicloForContext context)
            {
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
            {
                Console.WriteLine("SeccionFor " + context.GetText() + Environment.NewLine);
            }
            public override void EnterImprimirValor(PenguineseParser.ImprimirValorContext context)
            {
                Console.WriteLine("ImprimirValor " + context.GetText() + Environment.NewLine);
            }
            public override void EnterNombreValores(PenguineseParser.NombreValoresContext context)
            {
                Console.WriteLine("NombreValores " + context.GetText() + Environment.NewLine);
            }
            public override void EnterImprimirSeq(PenguineseParser.ImprimirSeqContext context)
            {
                Console.WriteLine("ImprimirSeq " + context.GetText() + Environment.NewLine);
            }
            public override void EnterEscribirValor(PenguineseParser.EscribirValorContext context)
            {
                Console.WriteLine("EscribirValor " + context.GetText() + Environment.NewLine);
            }
        }
    }
}
