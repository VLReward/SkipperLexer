//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\AMD\Skipper\Skipper\Penguinese.g4 by ANTLR 4.6.6

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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPenguineseListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PenguineseBaseListener : IPenguineseListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeqNum([NotNull] PenguineseParser.SeqNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeqNum([NotNull] PenguineseParser.SeqNumContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeqVar([NotNull] PenguineseParser.SeqVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeqVar([NotNull] PenguineseParser.SeqVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCicloWhile([NotNull] PenguineseParser.CicloWhileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCicloWhile([NotNull] PenguineseParser.CicloWhileContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCicloIf([NotNull] PenguineseParser.CicloIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCicloIf([NotNull] PenguineseParser.CicloIfContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCicloFor([NotNull] PenguineseParser.CicloForContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCicloFor([NotNull] PenguineseParser.CicloForContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>operacionVeV</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperacionVeV([NotNull] PenguineseParser.OperacionVeVContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>operacionVeV</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperacionVeV([NotNull] PenguineseParser.OperacionVeVContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>operacionVeN</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperacionVeN([NotNull] PenguineseParser.OperacionVeNContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>operacionVeN</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperacionVeN([NotNull] PenguineseParser.OperacionVeNContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart([NotNull] PenguineseParser.StartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart([NotNull] PenguineseParser.StartContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpresion([NotNull] PenguineseParser.ExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpresion([NotNull] PenguineseParser.ExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclararVar([NotNull] PenguineseParser.DeclararVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclararVar([NotNull] PenguineseParser.DeclararVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsignVar([NotNull] PenguineseParser.AsignVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsignVar([NotNull] PenguineseParser.AsignVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecVar([NotNull] PenguineseParser.DecVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecVar([NotNull] PenguineseParser.DecVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTipoVar([NotNull] PenguineseParser.TipoVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTipoVar([NotNull] PenguineseParser.TipoVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTipoVarS([NotNull] PenguineseParser.TipoVarSContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTipoVarS([NotNull] PenguineseParser.TipoVarSContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNombreVar([NotNull] PenguineseParser.NombreVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNombreVar([NotNull] PenguineseParser.NombreVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] PenguineseParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] PenguineseParser.VariableContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorVar([NotNull] PenguineseParser.ValorVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorVar([NotNull] PenguineseParser.ValorVarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorEntero([NotNull] PenguineseParser.ValorEnteroContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorEntero([NotNull] PenguineseParser.ValorEnteroContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorDec([NotNull] PenguineseParser.ValorDecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorDec([NotNull] PenguineseParser.ValorDecContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorChar([NotNull] PenguineseParser.ValorCharContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorChar([NotNull] PenguineseParser.ValorCharContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorString([NotNull] PenguineseParser.ValorStringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorString([NotNull] PenguineseParser.ValorStringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMath([NotNull] PenguineseParser.MathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMath([NotNull] PenguineseParser.MathContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathSeq([NotNull] PenguineseParser.MathSeqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.mathSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathSeq([NotNull] PenguineseParser.MathSeqContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorNum([NotNull] PenguineseParser.ValorNumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorNum([NotNull] PenguineseParser.ValorNumContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCiclo([NotNull] PenguineseParser.CicloContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCiclo([NotNull] PenguineseParser.CicloContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondicional([NotNull] PenguineseParser.CondicionalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondicional([NotNull] PenguineseParser.CondicionalContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValorCond([NotNull] PenguineseParser.ValorCondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValorCond([NotNull] PenguineseParser.ValorCondContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondSeq([NotNull] PenguineseParser.CondSeqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondSeq([NotNull] PenguineseParser.CondSeqContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeccionFor([NotNull] PenguineseParser.SeccionForContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeccionFor([NotNull] PenguineseParser.SeccionForContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.nombreValores"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNombreValores([NotNull] PenguineseParser.NombreValoresContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.nombreValores"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNombreValores([NotNull] PenguineseParser.NombreValoresContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.imprimirSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImprimirSeq([NotNull] PenguineseParser.ImprimirSeqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.imprimirSeq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImprimirSeq([NotNull] PenguineseParser.ImprimirSeqContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEscribirValor([NotNull] PenguineseParser.EscribirValorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEscribirValor([NotNull] PenguineseParser.EscribirValorContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Skipper
