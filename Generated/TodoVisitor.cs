//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/Users/inter/Documents/Tugas/7th/Compilation Technique/UTS/src/TodoAppCli/Todo.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="TodoParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ITodoVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompileUnit([NotNull] TodoParser.CompileUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] TodoParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.show"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShow([NotNull] TodoParser.ShowContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.create"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreate([NotNull] TodoParser.CreateContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.finish"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFinish([NotNull] TodoParser.FinishContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.delete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDelete([NotNull] TodoParser.DeleteContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilter([NotNull] TodoParser.FilterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.filterTime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilterTime([NotNull] TodoParser.FilterTimeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.filterCompletion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFilterCompletion([NotNull] TodoParser.FilterCompletionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDescription([NotNull] TodoParser.DescriptionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTime([NotNull] TodoParser.TimeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="TodoParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitId([NotNull] TodoParser.IdContext context);
}