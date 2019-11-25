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

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PenguineseParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPenguineseVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>seqNum</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSeqNum([NotNull] PenguineseParser.SeqNumContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>seqVar</c>
	/// labeled alternative in <see cref="PenguineseParser.mathSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSeqVar([NotNull] PenguineseParser.SeqVarContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>asignarValor</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignarValor([NotNull] PenguineseParser.AsignarValorContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>asignarVariable</c>
	/// labeled alternative in <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignarVariable([NotNull] PenguineseParser.AsignarVariableContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloWhile</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCicloWhile([NotNull] PenguineseParser.CicloWhileContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloIf</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCicloIf([NotNull] PenguineseParser.CicloIfContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>cicloFor</c>
	/// labeled alternative in <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCicloFor([NotNull] PenguineseParser.CicloForContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>nombreSimple</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNombreSimple([NotNull] PenguineseParser.NombreSimpleContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>nombreArreglo</c>
	/// labeled alternative in <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNombreArreglo([NotNull] PenguineseParser.NombreArregloContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>operacionVeV</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperacionVeV([NotNull] PenguineseParser.OperacionVeVContext context);

	/// <summary>
	/// Visit a parse tree produced by the <c>operacionVeN</c>
	/// labeled alternative in <see cref="PenguineseParser.math"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOperacionVeN([NotNull] PenguineseParser.OperacionVeNContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] PenguineseParser.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.bloqueCodigo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBloqueCodigo([NotNull] PenguineseParser.BloqueCodigoContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpresion([NotNull] PenguineseParser.ExpresionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.declararVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeclararVar([NotNull] PenguineseParser.DeclararVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.asignVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAsignVar([NotNull] PenguineseParser.AsignVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.decVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecVar([NotNull] PenguineseParser.DecVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.tipoVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoVar([NotNull] PenguineseParser.TipoVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.tipoVarS"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTipoVarS([NotNull] PenguineseParser.TipoVarSContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.nombreVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNombreVar([NotNull] PenguineseParser.NombreVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] PenguineseParser.VariableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorVar([NotNull] PenguineseParser.ValorVarContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorEntero"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorEntero([NotNull] PenguineseParser.ValorEnteroContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorDec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorDec([NotNull] PenguineseParser.ValorDecContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorChar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorChar([NotNull] PenguineseParser.ValorCharContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorString([NotNull] PenguineseParser.ValorStringContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorBool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorBool([NotNull] PenguineseParser.ValorBoolContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.math"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMath([NotNull] PenguineseParser.MathContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.mathSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathSeq([NotNull] PenguineseParser.MathSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorNum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorNum([NotNull] PenguineseParser.ValorNumContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.ciclo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCiclo([NotNull] PenguineseParser.CicloContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.condicional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondicional([NotNull] PenguineseParser.CondicionalContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.valorCond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitValorCond([NotNull] PenguineseParser.ValorCondContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.condSeq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCondSeq([NotNull] PenguineseParser.CondSeqContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.seccionFor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSeccionFor([NotNull] PenguineseParser.SeccionForContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.imprimirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImprimirValor([NotNull] PenguineseParser.ImprimirValorContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PenguineseParser.escribirValor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEscribirValor([NotNull] PenguineseParser.EscribirValorContext context);
}
} // namespace Skipper
