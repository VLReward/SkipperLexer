//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Rolis\Documents\GitHub\SkipperLexer\Skipper\Penguinese.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Skipper {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PenguineseParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPenguineseListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeqNum([NotNull] PenguineseParser.SeqNumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeqNum([NotNull] PenguineseParser.SeqNumContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeqVar([NotNull] PenguineseParser.SeqVarContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeqVar([NotNull] PenguineseParser.SeqVarContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>asignarValor</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignarValor([NotNull] PenguineseParser.AsignarValorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>asignarValor</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignarValor([NotNull] PenguineseParser.AsignarValorContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>asignarVariable</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignarVariable([NotNull] PenguineseParser.AsignarVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>asignarVariable</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignarVariable([NotNull] PenguineseParser.AsignarVariableContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCicloWhile([NotNull] PenguineseParser.CicloWhileContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCicloWhile([NotNull] PenguineseParser.CicloWhileContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCicloIf([NotNull] PenguineseParser.CicloIfContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCicloIf([NotNull] PenguineseParser.CicloIfContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCicloFor([NotNull] PenguineseParser.CicloForContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCicloFor([NotNull] PenguineseParser.CicloForContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart([NotNull] PenguineseParser.StartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart([NotNull] PenguineseParser.StartContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpresion([NotNull] PenguineseParser.ExpresionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpresion([NotNull] PenguineseParser.ExpresionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclararVar([NotNull] PenguineseParser.DeclararVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclararVar([NotNull] PenguineseParser.DeclararVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignVar([NotNull] PenguineseParser.AsignVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignVar([NotNull] PenguineseParser.AsignVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.asignSimple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignSimple([NotNull] PenguineseParser.AsignSimpleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.asignSimple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignSimple([NotNull] PenguineseParser.AsignSimpleContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecVar([NotNull] PenguineseParser.DecVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecVar([NotNull] PenguineseParser.DecVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoVar([NotNull] PenguineseParser.TipoVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoVar([NotNull] PenguineseParser.TipoVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTipoVarS([NotNull] PenguineseParser.TipoVarSContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTipoVarS([NotNull] PenguineseParser.TipoVarSContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNombreVar([NotNull] PenguineseParser.NombreVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNombreVar([NotNull] PenguineseParser.NombreVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] PenguineseParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] PenguineseParser.VariableContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorVar([NotNull] PenguineseParser.ValorVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorVar([NotNull] PenguineseParser.ValorVarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorEntero([NotNull] PenguineseParser.ValorEnteroContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorEntero([NotNull] PenguineseParser.ValorEnteroContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorDec([NotNull] PenguineseParser.ValorDecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorDec([NotNull] PenguineseParser.ValorDecContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorChar([NotNull] PenguineseParser.ValorCharContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorChar([NotNull] PenguineseParser.ValorCharContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorString([NotNull] PenguineseParser.ValorStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorString([NotNull] PenguineseParser.ValorStringContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorBool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorBool([NotNull] PenguineseParser.ValorBoolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorBool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorBool([NotNull] PenguineseParser.ValorBoolContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.mathSimple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathSimple([NotNull] PenguineseParser.MathSimpleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.mathSimple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathSimple([NotNull] PenguineseParser.MathSimpleContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMath([NotNull] PenguineseParser.MathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMath([NotNull] PenguineseParser.MathContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathSeqMD([NotNull] PenguineseParser.MathSeqMDContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.mathSeqMD"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathSeqMD([NotNull] PenguineseParser.MathSeqMDContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.mathSeqPM"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathSeqPM([NotNull] PenguineseParser.MathSeqPMContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.mathSeqPM"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathSeqPM([NotNull] PenguineseParser.MathSeqPMContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorNum([NotNull] PenguineseParser.ValorNumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorNum([NotNull] PenguineseParser.ValorNumContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCiclo([NotNull] PenguineseParser.CicloContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCiclo([NotNull] PenguineseParser.CicloContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondicional([NotNull] PenguineseParser.CondicionalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondicional([NotNull] PenguineseParser.CondicionalContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValorCond([NotNull] PenguineseParser.ValorCondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValorCond([NotNull] PenguineseParser.ValorCondContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondSeq([NotNull] PenguineseParser.CondSeqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondSeq([NotNull] PenguineseParser.CondSeqContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeccionFor([NotNull] PenguineseParser.SeccionForContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeccionFor([NotNull] PenguineseParser.SeccionForContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.asignFor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsignFor([NotNull] PenguineseParser.AsignForContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.asignFor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsignFor([NotNull] PenguineseParser.AsignForContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEscribirValor([NotNull] PenguineseParser.EscribirValorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEscribirValor([NotNull] PenguineseParser.EscribirValorContext context);
}
} // namespace Skipper
