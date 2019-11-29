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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPenguineseVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class PenguineseBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IPenguineseVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSeqNum([NotNull] PenguineseParser.SeqNumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSeqVar([NotNull] PenguineseParser.SeqVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>asignarValor</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsignarValor([NotNull] PenguineseParser.AsignarValorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>asignarVariable</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsignarVariable([NotNull] PenguineseParser.AsignarVariableContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCicloWhile([NotNull] PenguineseParser.CicloWhileContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCicloIf([NotNull] PenguineseParser.CicloIfContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCicloFor([NotNull] PenguineseParser.CicloForContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStart([NotNull] PenguineseParser.StartContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpresion([NotNull] PenguineseParser.ExpresionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclararVar([NotNull] PenguineseParser.DeclararVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsignVar([NotNull] PenguineseParser.AsignVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.asignSimple"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAsignSimple([NotNull] PenguineseParser.AsignSimpleContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecVar([NotNull] PenguineseParser.DecVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTipoVar([NotNull] PenguineseParser.TipoVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTipoVarS([NotNull] PenguineseParser.TipoVarSContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNombreVar([NotNull] PenguineseParser.NombreVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariable([NotNull] PenguineseParser.VariableContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorVar([NotNull] PenguineseParser.ValorVarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorEntero([NotNull] PenguineseParser.ValorEnteroContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorDec([NotNull] PenguineseParser.ValorDecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorChar([NotNull] PenguineseParser.ValorCharContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorString([NotNull] PenguineseParser.ValorStringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorBool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorBool([NotNull] PenguineseParser.ValorBoolContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMath([NotNull] PenguineseParser.MathContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.mathSeq"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMathSeq([NotNull] PenguineseParser.MathSeqContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorNum([NotNull] PenguineseParser.ValorNumContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCiclo([NotNull] PenguineseParser.CicloContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondicional([NotNull] PenguineseParser.CondicionalContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValorCond([NotNull] PenguineseParser.ValorCondContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCondSeq([NotNull] PenguineseParser.CondSeqContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSeccionFor([NotNull] PenguineseParser.SeccionForContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEscribirValor([NotNull] PenguineseParser.EscribirValorContext context) { return VisitChildren(context); }
}
} // namespace Skipper
