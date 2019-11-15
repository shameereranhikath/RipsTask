﻿
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace RipsASTTask
{
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
    [System.CLSCompliant(false)]
    public partial class EntityParser : Antlr.Runtime.Parser
    {
        internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "AND", "ASSIGN", "CALL", "CHAR", "COMMENT", "COND", "DEC", "DIV", "ENTMAP", "EQUALS", "ESC_SEQ", "EXPONENT", "FLOAT", "GETMEMBER", "GT", "GTEQ", "HEX_DIGIT", "ID", "INC", "INT", "LT", "LTEQ", "MAPBODY", "MAPDCL", "MINUS", "MOD", "MULT", "NOT", "NOTEQUALS", "OCTAL_ESC", "OR", "PLUS", "STRING", "TFEXPR", "UNICODE_ESC", "WS", "'('", "')'", "','", "'.'", "';'", "'<-'", "'='", "'IF'"
	};
        public const int EOF = -1;
        public const int T__40 = 40;
        public const int T__41 = 41;
        public const int T__42 = 42;
        public const int T__43 = 43;
        public const int T__44 = 44;
        public const int T__45 = 45;
        public const int T__46 = 46;
        public const int T__47 = 47;
        public const int AND = 4;
        public const int ASSIGN = 5;
        public const int CALL = 6;
        public const int CHAR = 7;
        public const int COMMENT = 8;
        public const int COND = 9;
        public const int DEC = 10;
        public const int DIV = 11;
        public const int ENTMAP = 12;
        public const int EQUALS = 13;
        public const int ESC_SEQ = 14;
        public const int EXPONENT = 15;
        public const int FLOAT = 16;
        public const int GETMEMBER = 17;
        public const int GT = 18;
        public const int GTEQ = 19;
        public const int HEX_DIGIT = 20;
        public const int ID = 21;
        public const int INC = 22;
        public const int INT = 23;
        public const int LT = 24;
        public const int LTEQ = 25;
        public const int MAPBODY = 26;
        public const int MAPDCL = 27;
        public const int MINUS = 28;
        public const int MOD = 29;
        public const int MULT = 30;
        public const int NOT = 31;
        public const int NOTEQUALS = 32;
        public const int OCTAL_ESC = 33;
        public const int OR = 34;
        public const int PLUS = 35;
        public const int STRING = 36;
        public const int TFEXPR = 37;
        public const int UNICODE_ESC = 38;
        public const int WS = 39;

        public EntityParser(ITokenStream input)
            : this(input, new RecognizerSharedState())
        {
        }
        public EntityParser(ITokenStream input, RecognizerSharedState state)
            : base(input, state)
        {
            ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
            CreateTreeAdaptor(ref treeAdaptor);
            TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
            OnCreated();
        }
        // Implement this function in your helper file to use a custom tree adaptor
        partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

        private ITreeAdaptor adaptor;

        public ITreeAdaptor TreeAdaptor
        {
            get
            {
                return adaptor;
            }

            set
            {
                this.adaptor = value;
            }
        }

        public override string[] TokenNames { get { return EntityParser.tokenNames; } }
        public override string GrammarFileName { get { return "E:\\Software\\ANTLR3\\projects\\EntityMapping\\EntityMapping.g"; } }


        partial void OnCreated();
        partial void EnterRule(string ruleName, int ruleIndex);
        partial void LeaveRule(string ruleName, int ruleIndex);

        #region Rules
        partial void EnterRule_prog();
        partial void LeaveRule_prog();


        [GrammarRule("prog")]
        public AstParserRuleReturnScope<CommonTree, IToken> prog()
        {
            EnterRule_prog();
            EnterRule("prog", 1);
            TraceIn("prog", 1);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            AstParserRuleReturnScope<CommonTree, IToken> mapDeclaration1 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> stat2 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            RewriteRuleSubtreeStream stream_mapDeclaration = new RewriteRuleSubtreeStream(adaptor, "rule mapDeclaration");
            RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor, "rule stat");
            try
            {
                DebugEnterRule(GrammarFileName, "prog");
                DebugLocation(28, 82);
                try
                {

                    DebugEnterAlt(1);

                    {
                        DebugLocation(28, 15);
                        PushFollow(Follow._mapDeclaration_in_prog108);
                        mapDeclaration1 = mapDeclaration();
                        PopFollow();

                        stream_mapDeclaration.Add(mapDeclaration1.Tree);
                        DebugLocation(28, 30);

                        try
                        {
                            DebugEnterSubRule(1);
                            while (true)
                            {
                                int alt1 = 2;
                                try
                                {
                                    DebugEnterDecision(1, false);
                                    int LA1_0 = input.LA(1);

                                    if ((LA1_0 == ID))
                                    {
                                        alt1 = 1;
                                    }


                                }
                                finally { DebugExitDecision(1); }
                                switch (alt1)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(28, 30);
                                            PushFollow(Follow._stat_in_prog110);
                                            stat2 = stat();
                                            PopFollow();

                                            stream_stat.Add(stat2.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop1;
                                }
                            }

                        loop1:
                            ;

                        }
                        finally { DebugExitSubRule(1); }



                        {
                            // AST REWRITE
                            // elements: mapDeclaration, stat
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 28:36: -> ^( ENTMAP mapDeclaration ^( MAPBODY ( stat )* ) )
                            {
                                DebugLocation(28, 39);

                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(28, 41);
                                    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ENTMAP, "ENTMAP"), root_1);

                                    DebugLocation(28, 48);
                                    adaptor.AddChild(root_1, stream_mapDeclaration.NextTree());
                                    DebugLocation(28, 63);

                                    {
                                        CommonTree root_2 = (CommonTree)adaptor.Nil();
                                        DebugLocation(28, 65);
                                        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MAPBODY, "MAPBODY"), root_2);

                                        DebugLocation(28, 73);

                                        while (stream_stat.HasNext)
                                        {
                                            DebugLocation(28, 73);
                                            adaptor.AddChild(root_2, stream_stat.NextTree());

                                        }
                                        stream_stat.Reset();

                                        adaptor.AddChild(root_1, root_2);
                                    }

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("prog", 1);
                    LeaveRule("prog", 1);
                    LeaveRule_prog();
                }
                DebugLocation(28, 82);
            }
            finally { DebugExitRule(GrammarFileName, "prog"); }
            return retval;

        }


        partial void EnterRule_mapDeclaration();
        partial void LeaveRule_mapDeclaration();


        [GrammarRule("mapDeclaration")]
        private AstParserRuleReturnScope<CommonTree, IToken> mapDeclaration()
        {
            EnterRule_mapDeclaration();
            EnterRule("mapDeclaration", 2);
            TraceIn("mapDeclaration", 2);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken ID3 = default(IToken);
            IToken string_literal4 = default(IToken);
            IToken ID5 = default(IToken);
            IToken char_literal6 = default(IToken);

            CommonTree ID3_tree = default(CommonTree);
            CommonTree string_literal4_tree = default(CommonTree);
            CommonTree ID5_tree = default(CommonTree);
            CommonTree char_literal6_tree = default(CommonTree);
            RewriteRuleITokenStream stream_45 = new RewriteRuleITokenStream(adaptor, "token 45");
            RewriteRuleITokenStream stream_44 = new RewriteRuleITokenStream(adaptor, "token 44");
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            try
            {
                DebugEnterRule(GrammarFileName, "mapDeclaration");
                DebugLocation(30, 51);
                try
                {

                    DebugEnterAlt(1);

                    {
                        DebugLocation(30, 18);
                        ID3 = (IToken)Match(input, ID, Follow._ID_in_mapDeclaration137);
                        stream_ID.Add(ID3);

                        DebugLocation(30, 21);
                        string_literal4 = (IToken)Match(input, 45, Follow._45_in_mapDeclaration139);
                        stream_45.Add(string_literal4);

                        DebugLocation(30, 26);
                        ID5 = (IToken)Match(input, ID, Follow._ID_in_mapDeclaration141);
                        stream_ID.Add(ID5);

                        DebugLocation(30, 29);
                        char_literal6 = (IToken)Match(input, 44, Follow._44_in_mapDeclaration143);
                        stream_44.Add(char_literal6);



                        {
                            // AST REWRITE
                            // elements: ID, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 30:33: -> ^( MAPDCL ID ID )
                            {
                                DebugLocation(30, 36);

                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(30, 38);
                                    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(MAPDCL, "MAPDCL"), root_1);

                                    DebugLocation(30, 45);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(30, 48);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("mapDeclaration", 2);
                    LeaveRule("mapDeclaration", 2);
                    LeaveRule_mapDeclaration();
                }
                DebugLocation(30, 51);
            }
            finally { DebugExitRule(GrammarFileName, "mapDeclaration"); }
            return retval;

        }


        partial void EnterRule_stat();
        partial void LeaveRule_stat();


        [GrammarRule("stat")]
        private AstParserRuleReturnScope<CommonTree, IToken> stat()
        {
            EnterRule_stat();
            EnterRule("stat", 3);
            TraceIn("stat", 3);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken ID7 = default(IToken);
            IToken char_literal8 = default(IToken);
            IToken char_literal10 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> expr9 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree ID7_tree = default(CommonTree);
            CommonTree char_literal8_tree = default(CommonTree);
            CommonTree char_literal10_tree = default(CommonTree);
            RewriteRuleITokenStream stream_44 = new RewriteRuleITokenStream(adaptor, "token 44");
            RewriteRuleITokenStream stream_46 = new RewriteRuleITokenStream(adaptor, "token 46");
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor, "rule expr");
            try
            {
                DebugEnterRule(GrammarFileName, "stat");
                DebugLocation(32, 43);
                try
                {

                    DebugEnterAlt(1);

                    {
                        DebugLocation(32, 8);
                        ID7 = (IToken)Match(input, ID, Follow._ID_in_stat162);
                        stream_ID.Add(ID7);

                        DebugLocation(32, 11);
                        char_literal8 = (IToken)Match(input, 46, Follow._46_in_stat164);
                        stream_46.Add(char_literal8);

                        DebugLocation(32, 15);
                        PushFollow(Follow._expr_in_stat166);
                        expr9 = expr();
                        PopFollow();

                        stream_expr.Add(expr9.Tree);
                        DebugLocation(32, 20);
                        char_literal10 = (IToken)Match(input, 44, Follow._44_in_stat168);
                        stream_44.Add(char_literal10);



                        {
                            // AST REWRITE
                            // elements: expr, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 32:24: -> ^( ASSIGN ID expr )
                            {
                                DebugLocation(32, 27);

                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(32, 29);
                                    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

                                    DebugLocation(32, 36);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(32, 39);
                                    adaptor.AddChild(root_1, stream_expr.NextTree());

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("stat", 3);
                    LeaveRule("stat", 3);
                    LeaveRule_stat();
                }
                DebugLocation(32, 43);
            }
            finally { DebugExitRule(GrammarFileName, "stat"); }
            return retval;

        }


        partial void EnterRule_expr();
        partial void LeaveRule_expr();


        [GrammarRule("expr")]
        private AstParserRuleReturnScope<CommonTree, IToken> expr()
        {
            EnterRule_expr();
            EnterRule("expr", 4);
            TraceIn("expr", 4);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken OR12 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> boolAndExpr11 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> boolAndExpr13 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree OR12_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "expr");
                DebugLocation(34, 37);
                try
                {

                    DebugEnterAlt(1);

                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(34, 8);
                        PushFollow(Follow._boolAndExpr_in_expr186);
                        boolAndExpr11 = boolAndExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, boolAndExpr11.Tree);
                        DebugLocation(34, 20);

                        try
                        {
                            DebugEnterSubRule(2);
                            while (true)
                            {
                                int alt2 = 2;
                                try
                                {
                                    DebugEnterDecision(2, false);
                                    int LA2_0 = input.LA(1);

                                    if ((LA2_0 == OR))
                                    {
                                        alt2 = 1;
                                    }


                                }
                                finally { DebugExitDecision(2); }
                                switch (alt2)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(34, 23);
                                            OR12 = (IToken)Match(input, OR, Follow._OR_in_expr189);
                                            OR12_tree = (CommonTree)adaptor.Create(OR12);
                                            root_0 = (CommonTree)adaptor.BecomeRoot(OR12_tree, root_0);
                                            DebugLocation(34, 25);
                                            PushFollow(Follow._boolAndExpr_in_expr192);
                                            boolAndExpr13 = boolAndExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, boolAndExpr13.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop2;
                                }
                            }

                        loop2:
                            ;

                        }
                        finally { DebugExitSubRule(2); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("expr", 4);
                    LeaveRule("expr", 4);
                    LeaveRule_expr();
                }
                DebugLocation(34, 37);
            }
            finally { DebugExitRule(GrammarFileName, "expr"); }
            return retval;

        }


        partial void EnterRule_boolAndExpr();
        partial void LeaveRule_boolAndExpr();


        [GrammarRule("boolAndExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> boolAndExpr()
        {
            EnterRule_boolAndExpr();
            EnterRule("boolAndExpr", 5);
            TraceIn("boolAndExpr", 5);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken AND15 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> equalityExpr14 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> equalityExpr16 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree AND15_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "boolAndExpr");
                DebugLocation(36, 47);
                try
                {

                    DebugEnterAlt(1);

                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(36, 15);
                        PushFollow(Follow._equalityExpr_in_boolAndExpr202);
                        equalityExpr14 = equalityExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, equalityExpr14.Tree);
                        DebugLocation(36, 28);

                        try
                        {
                            DebugEnterSubRule(3);
                            while (true)
                            {
                                int alt3 = 2;
                                try
                                {
                                    DebugEnterDecision(3, false);
                                    int LA3_0 = input.LA(1);

                                    if ((LA3_0 == AND))
                                    {
                                        alt3 = 1;
                                    }


                                }
                                finally { DebugExitDecision(3); }
                                switch (alt3)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(36, 32);
                                            AND15 = (IToken)Match(input, AND, Follow._AND_in_boolAndExpr205);
                                            AND15_tree = (CommonTree)adaptor.Create(AND15);
                                            root_0 = (CommonTree)adaptor.BecomeRoot(AND15_tree, root_0);
                                            DebugLocation(36, 34);
                                            PushFollow(Follow._equalityExpr_in_boolAndExpr208);
                                            equalityExpr16 = equalityExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, equalityExpr16.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop3;
                                }
                            }

                        loop3:
                            ;

                        }
                        finally { DebugExitSubRule(3); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("boolAndExpr", 5);
                    LeaveRule("boolAndExpr", 5);
                    LeaveRule_boolAndExpr();
                }
                DebugLocation(36, 47);
            }
            finally { DebugExitRule(GrammarFileName, "boolAndExpr"); }
            return retval;

        }


        partial void EnterRule_equalityExpr();
        partial void LeaveRule_equalityExpr();


        [GrammarRule("equalityExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> equalityExpr()
        {
            EnterRule_equalityExpr();
            EnterRule("equalityExpr", 6);
            TraceIn("equalityExpr", 6);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken EQUALS18 = default(IToken);
            IToken NOTEQUALS19 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> relationalExpr17 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> relationalExpr20 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree EQUALS18_tree = default(CommonTree);
            CommonTree NOTEQUALS19_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "equalityExpr");
                DebugLocation(38, 67);
                try
                {

                    DebugEnterAlt(1);

                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(38, 16);
                        PushFollow(Follow._relationalExpr_in_equalityExpr218);
                        relationalExpr17 = relationalExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, relationalExpr17.Tree);
                        DebugLocation(38, 31);
                        //  ( ( EQUALS ^| NOTEQUALS ^) relationalExpr )*
                        try
                        {
                            DebugEnterSubRule(5);
                            while (true)
                            {
                                int alt5 = 2;
                                try
                                {
                                    DebugEnterDecision(5, false);
                                    int LA5_0 = input.LA(1);

                                    if ((LA5_0 == EQUALS || LA5_0 == NOTEQUALS))
                                    {
                                        alt5 = 1;
                                    }


                                }
                                finally { DebugExitDecision(5); }
                                switch (alt5)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // ( EQUALS ^| NOTEQUALS ^) relationalExpr
                                        {
                                            DebugLocation(38, 32);
                                            // ( EQUALS ^| NOTEQUALS ^)
                                            int alt4 = 2;
                                            try
                                            {
                                                DebugEnterSubRule(4);
                                                try
                                                {
                                                    DebugEnterDecision(4, false);
                                                    int LA4_0 = input.LA(1);

                                                    if ((LA4_0 == EQUALS))
                                                    {
                                                        alt4 = 1;
                                                    }
                                                    else if ((LA4_0 == NOTEQUALS))
                                                    {
                                                        alt4 = 2;
                                                    }
                                                    else
                                                    {
                                                        NoViableAltException nvae = new NoViableAltException("", 4, 0, input);
                                                        DebugRecognitionException(nvae);
                                                        throw nvae;
                                                    }
                                                }
                                                finally { DebugExitDecision(4); }
                                                switch (alt4)
                                                {
                                                    case 1:
                                                        DebugEnterAlt(1);
                                                        // EQUALS ^
                                                        {
                                                            DebugLocation(38, 39);
                                                            EQUALS18 = (IToken)Match(input, EQUALS, Follow._EQUALS_in_equalityExpr222);
                                                            EQUALS18_tree = (CommonTree)adaptor.Create(EQUALS18);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(EQUALS18_tree, root_0);

                                                        }
                                                        break;
                                                    case 2:
                                                        DebugEnterAlt(2);
                                                        // NOTEQUALS ^
                                                        {
                                                            DebugLocation(38, 50);
                                                            NOTEQUALS19 = (IToken)Match(input, NOTEQUALS, Follow._NOTEQUALS_in_equalityExpr225);
                                                            NOTEQUALS19_tree = (CommonTree)adaptor.Create(NOTEQUALS19);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(NOTEQUALS19_tree, root_0);

                                                        }
                                                        break;

                                                }
                                            }
                                            finally { DebugExitSubRule(4); }

                                            DebugLocation(38, 52);
                                            PushFollow(Follow._relationalExpr_in_equalityExpr228);
                                            relationalExpr20 = relationalExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, relationalExpr20.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop5;
                                }
                            }

                        loop5:
                            ;

                        }
                        finally { DebugExitSubRule(5); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("equalityExpr", 6);
                    LeaveRule("equalityExpr", 6);
                    LeaveRule_equalityExpr();
                }
                DebugLocation(38, 67);
            }
            finally { DebugExitRule(GrammarFileName, "equalityExpr"); }
            return retval;

        }


        partial void EnterRule_relationalExpr();
        partial void LeaveRule_relationalExpr();


        // additiveExpr ( ( LT ^| LTEQ ^| GT ^| GTEQ ^) additiveExpr )* ;
        [GrammarRule("relationalExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> relationalExpr()
        {
            EnterRule_relationalExpr();
            EnterRule("relationalExpr", 7);
            TraceIn("relationalExpr", 7);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken LT22 = default(IToken);
            IToken LTEQ23 = default(IToken);
            IToken GT24 = default(IToken);
            IToken GTEQ25 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> additiveExpr21 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> additiveExpr26 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree LT22_tree = default(CommonTree);
            CommonTree LTEQ23_tree = default(CommonTree);
            CommonTree GT24_tree = default(CommonTree);
            CommonTree GTEQ25_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "relationalExpr");
                DebugLocation(40, 67);
                try
                {
                    // additiveExpr ( ( LT ^| LTEQ ^| GT ^| GTEQ ^) additiveExpr )* )
                    DebugEnterAlt(1);
                    // additiveExpr ( ( LT ^| LTEQ ^| GT ^| GTEQ ^) additiveExpr )*
                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(40, 18);
                        PushFollow(Follow._additiveExpr_in_relationalExpr238);
                        additiveExpr21 = additiveExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, additiveExpr21.Tree);
                        DebugLocation(40, 31);
                        // ( ( LT ^| LTEQ ^| GT ^| GTEQ ^) additiveExpr )*
                        try
                        {
                            DebugEnterSubRule(7);
                            while (true)
                            {
                                int alt7 = 2;
                                try
                                {
                                    DebugEnterDecision(7, false);
                                    int LA7_0 = input.LA(1);

                                    if (((LA7_0 >= GT && LA7_0 <= GTEQ) || (LA7_0 >= LT && LA7_0 <= LTEQ)))
                                    {
                                        alt7 = 1;
                                    }


                                }
                                finally { DebugExitDecision(7); }
                                switch (alt7)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // ( LT ^| LTEQ ^| GT ^| GTEQ ^) additiveExpr
                                        {
                                            DebugLocation(40, 32);
                                            //( LT ^| LTEQ ^| GT ^| GTEQ ^)
                                            int alt6 = 4;
                                            try
                                            {
                                                DebugEnterSubRule(6);
                                                try
                                                {
                                                    DebugEnterDecision(6, false);
                                                    switch (input.LA(1))
                                                    {
                                                        case LT:
                                                            {
                                                                alt6 = 1;
                                                            }
                                                            break;
                                                        case LTEQ:
                                                            {
                                                                alt6 = 2;
                                                            }
                                                            break;
                                                        case GT:
                                                            {
                                                                alt6 = 3;
                                                            }
                                                            break;
                                                        case GTEQ:
                                                            {
                                                                alt6 = 4;
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                NoViableAltException nvae = new NoViableAltException("", 6, 0, input);
                                                                DebugRecognitionException(nvae);
                                                                throw nvae;
                                                            }
                                                    }

                                                }
                                                finally { DebugExitDecision(6); }
                                                switch (alt6)
                                                {
                                                    case 1:
                                                        DebugEnterAlt(1);
                                                        //  LT ^
                                                        {
                                                            DebugLocation(40, 35);
                                                            LT22 = (IToken)Match(input, LT, Follow._LT_in_relationalExpr242);
                                                            LT22_tree = (CommonTree)adaptor.Create(LT22);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(LT22_tree, root_0);

                                                        }
                                                        break;
                                                    case 2:
                                                        DebugEnterAlt(2);
                                                        // LTEQ ^
                                                        {
                                                            DebugLocation(40, 41);
                                                            LTEQ23 = (IToken)Match(input, LTEQ, Follow._LTEQ_in_relationalExpr245);
                                                            LTEQ23_tree = (CommonTree)adaptor.Create(LTEQ23);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(LTEQ23_tree, root_0);

                                                        }
                                                        break;
                                                    case 3:
                                                        DebugEnterAlt(3);
                                                        //  GT ^
                                                        {
                                                            DebugLocation(40, 45);
                                                            GT24 = (IToken)Match(input, GT, Follow._GT_in_relationalExpr248);
                                                            GT24_tree = (CommonTree)adaptor.Create(GT24);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(GT24_tree, root_0);

                                                        }
                                                        break;
                                                    case 4:
                                                        DebugEnterAlt(4);
                                                        //  GTEQ ^
                                                        {
                                                            DebugLocation(40, 51);
                                                            GTEQ25 = (IToken)Match(input, GTEQ, Follow._GTEQ_in_relationalExpr251);
                                                            GTEQ25_tree = (CommonTree)adaptor.Create(GTEQ25);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(GTEQ25_tree, root_0);

                                                        }
                                                        break;

                                                }
                                            }
                                            finally { DebugExitSubRule(6); }

                                            DebugLocation(40, 53);
                                            PushFollow(Follow._additiveExpr_in_relationalExpr254);
                                            additiveExpr26 = additiveExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, additiveExpr26.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop7;
                                }
                            }

                        loop7:
                            ;

                        }
                        finally { DebugExitSubRule(7); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("relationalExpr", 7);
                    LeaveRule("relationalExpr", 7);
                    LeaveRule_relationalExpr();
                }
                DebugLocation(40, 67);
            }
            finally { DebugExitRule(GrammarFileName, "relationalExpr"); }
            return retval;

        }


        partial void EnterRule_additiveExpr();
        partial void LeaveRule_additiveExpr();


        // multiExpr ( ( PLUS ^| MINUS ^) multiExpr )* ;
        [GrammarRule("additiveExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> additiveExpr()
        {
            EnterRule_additiveExpr();
            EnterRule("additiveExpr", 8);
            TraceIn("additiveExpr", 8);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken PLUS28 = default(IToken);
            IToken MINUS29 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> multiExpr27 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> multiExpr30 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree PLUS28_tree = default(CommonTree);
            CommonTree MINUS29_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "additiveExpr");
                DebugLocation(42, 54);
                try
                {
                    // ( multiExpr ( ( PLUS ^| MINUS ^) multiExpr )* )
                    DebugEnterAlt(1);
                    // multiExpr ( ( PLUS ^| MINUS ^) multiExpr )*
                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(42, 16);
                        PushFollow(Follow._multiExpr_in_additiveExpr265);
                        multiExpr27 = multiExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, multiExpr27.Tree);
                        DebugLocation(42, 26);
                        //  ( ( PLUS ^| MINUS ^) multiExpr )*
                        try
                        {
                            DebugEnterSubRule(9);
                            while (true)
                            {
                                int alt9 = 2;
                                try
                                {
                                    DebugEnterDecision(9, false);
                                    int LA9_0 = input.LA(1);

                                    if ((LA9_0 == MINUS || LA9_0 == PLUS))
                                    {
                                        alt9 = 1;
                                    }


                                }
                                finally { DebugExitDecision(9); }
                                switch (alt9)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // ( PLUS ^| MINUS ^) multiExpr
                                        {
                                            DebugLocation(42, 28);
                                            // ( PLUS ^| MINUS ^)
                                            int alt8 = 2;
                                            try
                                            {
                                                DebugEnterSubRule(8);
                                                try
                                                {
                                                    DebugEnterDecision(8, false);
                                                    int LA8_0 = input.LA(1);

                                                    if ((LA8_0 == PLUS))
                                                    {
                                                        alt8 = 1;
                                                    }
                                                    else if ((LA8_0 == MINUS))
                                                    {
                                                        alt8 = 2;
                                                    }
                                                    else
                                                    {
                                                        NoViableAltException nvae = new NoViableAltException("", 8, 0, input);
                                                        DebugRecognitionException(nvae);
                                                        throw nvae;
                                                    }
                                                }
                                                finally { DebugExitDecision(8); }
                                                switch (alt8)
                                                {
                                                    case 1:
                                                        DebugEnterAlt(1);
                                                        //  PLUS ^
                                                        {
                                                            DebugLocation(42, 33);
                                                            PLUS28 = (IToken)Match(input, PLUS, Follow._PLUS_in_additiveExpr270);
                                                            PLUS28_tree = (CommonTree)adaptor.Create(PLUS28);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(PLUS28_tree, root_0);

                                                        }
                                                        break;
                                                    case 2:
                                                        DebugEnterAlt(2);
                                                        //  MINUS ^
                                                        {
                                                            DebugLocation(42, 40);
                                                            MINUS29 = (IToken)Match(input, MINUS, Follow._MINUS_in_additiveExpr273);
                                                            MINUS29_tree = (CommonTree)adaptor.Create(MINUS29);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(MINUS29_tree, root_0);

                                                        }
                                                        break;

                                                }
                                            }
                                            finally { DebugExitSubRule(8); }

                                            DebugLocation(42, 43);
                                            PushFollow(Follow._multiExpr_in_additiveExpr277);
                                            multiExpr30 = multiExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, multiExpr30.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop9;
                                }
                            }

                        loop9:
                            ;

                        }
                        finally { DebugExitSubRule(9); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("additiveExpr", 8);
                    LeaveRule("additiveExpr", 8);
                    LeaveRule_additiveExpr();
                }
                DebugLocation(42, 54);
            }
            finally { DebugExitRule(GrammarFileName, "additiveExpr"); }
            return retval;

        }


        partial void EnterRule_multiExpr();
        partial void LeaveRule_multiExpr();


        //  multiExpr : unaryExpr ( ( MULT ^| DIV ^| MOD ^) unaryExpr )* ;
        [GrammarRule("multiExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> multiExpr()
        {
            EnterRule_multiExpr();
            EnterRule("multiExpr", 9);
            TraceIn("multiExpr", 9);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken MULT32 = default(IToken);
            IToken DIV33 = default(IToken);
            IToken MOD34 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> unaryExpr31 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> unaryExpr35 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree MULT32_tree = default(CommonTree);
            CommonTree DIV33_tree = default(CommonTree);
            CommonTree MOD34_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "multiExpr");
                DebugLocation(44, 53);
                try
                {
                    //  unaryExpr ( ( MULT ^| DIV ^| MOD ^) unaryExpr )* )
                    DebugEnterAlt(1);
                    //  unaryExpr ( ( MULT ^| DIV ^| MOD ^) unaryExpr )*
                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(44, 13);
                        PushFollow(Follow._unaryExpr_in_multiExpr288);
                        unaryExpr31 = unaryExpr();
                        PopFollow();

                        adaptor.AddChild(root_0, unaryExpr31.Tree);
                        DebugLocation(44, 23);
                        //  ( ( MULT ^| DIV ^| MOD ^) unaryExpr )*
                        try
                        {
                            DebugEnterSubRule(11);
                            while (true)
                            {
                                int alt11 = 2;
                                try
                                {
                                    DebugEnterDecision(11, false);
                                    int LA11_0 = input.LA(1);

                                    if ((LA11_0 == DIV || (LA11_0 >= MOD && LA11_0 <= MULT)))
                                    {
                                        alt11 = 1;
                                    }


                                }
                                finally { DebugExitDecision(11); }
                                switch (alt11)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        //  ( MULT ^| DIV ^| MOD ^) unaryExpr
                                        {
                                            DebugLocation(44, 25);
                                            //( MULT ^| DIV ^| MOD ^)
                                            int alt10 = 3;
                                            try
                                            {
                                                DebugEnterSubRule(10);
                                                try
                                                {
                                                    DebugEnterDecision(10, false);
                                                    switch (input.LA(1))
                                                    {
                                                        case MULT:
                                                            {
                                                                alt10 = 1;
                                                            }
                                                            break;
                                                        case DIV:
                                                            {
                                                                alt10 = 2;
                                                            }
                                                            break;
                                                        case MOD:
                                                            {
                                                                alt10 = 3;
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                NoViableAltException nvae = new NoViableAltException("", 10, 0, input);
                                                                DebugRecognitionException(nvae);
                                                                throw nvae;
                                                            }
                                                    }

                                                }
                                                finally { DebugExitDecision(10); }
                                                switch (alt10)
                                                {
                                                    case 1:
                                                        DebugEnterAlt(1);
                                                        //  MULT ^
                                                        {
                                                            DebugLocation(44, 30);
                                                            MULT32 = (IToken)Match(input, MULT, Follow._MULT_in_multiExpr293);
                                                            MULT32_tree = (CommonTree)adaptor.Create(MULT32);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(MULT32_tree, root_0);

                                                        }
                                                        break;
                                                    case 2:
                                                        DebugEnterAlt(2);
                                                        //  DIV ^
                                                        {
                                                            DebugLocation(44, 35);
                                                            DIV33 = (IToken)Match(input, DIV, Follow._DIV_in_multiExpr296);
                                                            DIV33_tree = (CommonTree)adaptor.Create(DIV33);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(DIV33_tree, root_0);

                                                        }
                                                        break;
                                                    case 3:
                                                        DebugEnterAlt(3);
                                                        //  MOD ^
                                                        {
                                                            DebugLocation(44, 40);
                                                            MOD34 = (IToken)Match(input, MOD, Follow._MOD_in_multiExpr299);
                                                            MOD34_tree = (CommonTree)adaptor.Create(MOD34);
                                                            root_0 = (CommonTree)adaptor.BecomeRoot(MOD34_tree, root_0);

                                                        }
                                                        break;

                                                }
                                            }
                                            finally { DebugExitSubRule(10); }

                                            DebugLocation(44, 43);
                                            PushFollow(Follow._unaryExpr_in_multiExpr303);
                                            unaryExpr35 = unaryExpr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, unaryExpr35.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop11;
                                }
                            }

                        loop11:
                            ;

                        }
                        finally { DebugExitSubRule(11); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("multiExpr", 9);
                    LeaveRule("multiExpr", 9);
                    LeaveRule_multiExpr();
                }
                DebugLocation(44, 53);
            }
            finally { DebugExitRule(GrammarFileName, "multiExpr"); }
            return retval;

        }


        partial void EnterRule_unaryExpr();
        partial void LeaveRule_unaryExpr();


        //  unaryExpr : ( NOT ^| INC ^| DEC ^|) atom ;
        [GrammarRule("unaryExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> unaryExpr()
        {
            EnterRule_unaryExpr();
            EnterRule("unaryExpr", 10);
            TraceIn("unaryExpr", 10);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken NOT36 = default(IToken);
            IToken INC37 = default(IToken);
            IToken DEC38 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> atom39 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree NOT36_tree = default(CommonTree);
            CommonTree INC37_tree = default(CommonTree);
            CommonTree DEC38_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "unaryExpr");
                DebugLocation(46, 34);
                try
                {
                    //  ( ( NOT ^| INC ^| DEC ^|) atom )
                    DebugEnterAlt(1);
                    // ( NOT ^| INC ^| DEC ^|) atom
                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(46, 13);
                        //  ( NOT ^| INC ^| DEC ^|)
                        int alt12 = 4;
                        try
                        {
                            DebugEnterSubRule(12);
                            try
                            {
                                DebugEnterDecision(12, false);
                                switch (input.LA(1))
                                {
                                    case NOT:
                                        {
                                            alt12 = 1;
                                        }
                                        break;
                                    case INC:
                                        {
                                            alt12 = 2;
                                        }
                                        break;
                                    case DEC:
                                        {
                                            alt12 = 3;
                                        }
                                        break;
                                    case CHAR:
                                    case FLOAT:
                                    case ID:
                                    case INT:
                                    case STRING:
                                    case 40:
                                    case 47:
                                        {
                                            alt12 = 4;
                                        }
                                        break;
                                    default:
                                        {
                                            NoViableAltException nvae = new NoViableAltException("", 12, 0, input);
                                            DebugRecognitionException(nvae);
                                            throw nvae;
                                        }
                                }

                            }
                            finally { DebugExitDecision(12); }
                            switch (alt12)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    //  NOT ^
                                    {
                                        DebugLocation(46, 17);
                                        NOT36 = (IToken)Match(input, NOT, Follow._NOT_in_unaryExpr314);
                                        NOT36_tree = (CommonTree)adaptor.Create(NOT36);
                                        root_0 = (CommonTree)adaptor.BecomeRoot(NOT36_tree, root_0);

                                    }
                                    break;
                                case 2:
                                    DebugEnterAlt(2);
                                    //  INC ^
                                    {
                                        DebugLocation(46, 22);
                                        INC37 = (IToken)Match(input, INC, Follow._INC_in_unaryExpr317);
                                        INC37_tree = (CommonTree)adaptor.Create(INC37);
                                        root_0 = (CommonTree)adaptor.BecomeRoot(INC37_tree, root_0);

                                    }
                                    break;
                                case 3:
                                    DebugEnterAlt(3);
                                    //  DEC ^
                                    {
                                        DebugLocation(46, 27);
                                        DEC38 = (IToken)Match(input, DEC, Follow._DEC_in_unaryExpr320);
                                        DEC38_tree = (CommonTree)adaptor.Create(DEC38);
                                        root_0 = (CommonTree)adaptor.BecomeRoot(DEC38_tree, root_0);

                                    }
                                    break;
                                case 4:
                                    DebugEnterAlt(4);
                                    {
                                    }
                                    break;

                            }
                        }
                        finally { DebugExitSubRule(12); }

                        DebugLocation(46, 31);
                        PushFollow(Follow._atom_in_unaryExpr325);
                        atom39 = atom();
                        PopFollow();

                        adaptor.AddChild(root_0, atom39.Tree);

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("unaryExpr", 10);
                    LeaveRule("unaryExpr", 10);
                    LeaveRule_unaryExpr();
                }
                DebugLocation(46, 34);
            }
            finally { DebugExitRule(GrammarFileName, "unaryExpr"); }
            return retval;

        }


        partial void EnterRule_atom();
        partial void LeaveRule_atom();
        // atom : ( value | ID | functionCall | ifExpr | memberAccess | '(' expr ')' );
        [GrammarRule("atom")]
        private AstParserRuleReturnScope<CommonTree, IToken> atom()
        {
            EnterRule_atom();
            EnterRule("atom", 11);
            TraceIn("atom", 11);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken ID41 = default(IToken);
            IToken char_literal45 = default(IToken);
            IToken char_literal47 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> value40 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> functionCall42 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> ifExpr43 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> memberAccess44 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> expr46 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree ID41_tree = default(CommonTree);
            CommonTree char_literal45_tree = default(CommonTree);
            CommonTree char_literal47_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "atom");
                DebugLocation(48, 16);
                try
                {
                    //  ( value | ID | functionCall | ifExpr | memberAccess | '(' expr ')' )
                    int alt13 = 6;
                    try
                    {
                        DebugEnterDecision(13, false);
                        switch (input.LA(1))
                        {
                            case CHAR:
                            case FLOAT:
                            case INT:
                            case STRING:
                                {
                                    alt13 = 1;
                                }
                                break;
                            case ID:
                                {
                                    switch (input.LA(2))
                                    {
                                        case 40:
                                            {
                                                alt13 = 3;
                                            }
                                            break;
                                        case 43:
                                            {
                                                alt13 = 5;
                                            }
                                            break;
                                        case AND:
                                        case DIV:
                                        case EQUALS:
                                        case GT:
                                        case GTEQ:
                                        case LT:
                                        case LTEQ:
                                        case MINUS:
                                        case MOD:
                                        case MULT:
                                        case NOTEQUALS:
                                        case OR:
                                        case PLUS:
                                        case 41:
                                        case 42:
                                        case 44:
                                            {
                                                alt13 = 2;
                                            }
                                            break;
                                        default:
                                            {
                                                NoViableAltException nvae = new NoViableAltException("", 13, 2, input);
                                                DebugRecognitionException(nvae);
                                                throw nvae;
                                            }
                                    }

                                }
                                break;
                            case 47:
                                {
                                    alt13 = 4;
                                }
                                break;
                            case 40:
                                {
                                    alt13 = 6;
                                }
                                break;
                            default:
                                {
                                    NoViableAltException nvae = new NoViableAltException("", 13, 0, input);
                                    DebugRecognitionException(nvae);
                                    throw nvae;
                                }
                        }

                    }
                    finally { DebugExitDecision(13); }
                    switch (alt13)
                    {
                        case 1:
                            DebugEnterAlt(1);
                            //  value
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(48, 9);
                                PushFollow(Follow._value_in_atom334);
                                value40 = value();
                                PopFollow();

                                adaptor.AddChild(root_0, value40.Tree);

                            }
                            break;
                        case 2:
                            DebugEnterAlt(2);
                            //  ID
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(49, 4);
                                ID41 = (IToken)Match(input, ID, Follow._ID_in_atom339);
                                ID41_tree = (CommonTree)adaptor.Create(ID41);
                                adaptor.AddChild(root_0, ID41_tree);

                            }
                            break;
                        case 3:
                            DebugEnterAlt(3);
                            //  functionCall
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(50, 4);
                                PushFollow(Follow._functionCall_in_atom344);
                                functionCall42 = functionCall();
                                PopFollow();

                                adaptor.AddChild(root_0, functionCall42.Tree);

                            }
                            break;
                        case 4:
                            DebugEnterAlt(4);
                            //  ifExpr
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(51, 4);
                                PushFollow(Follow._ifExpr_in_atom349);
                                ifExpr43 = ifExpr();
                                PopFollow();

                                adaptor.AddChild(root_0, ifExpr43.Tree);

                            }
                            break;
                        case 5:
                            DebugEnterAlt(5);
                            //  memberAccess
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(52, 4);
                                PushFollow(Follow._memberAccess_in_atom355);
                                memberAccess44 = memberAccess();
                                PopFollow();

                                adaptor.AddChild(root_0, memberAccess44.Tree);

                            }
                            break;
                        case 6:
                            DebugEnterAlt(6);
                            //  '(' expr ')'
                            {
                                root_0 = (CommonTree)adaptor.Nil();

                                DebugLocation(53, 4);
                                char_literal45 = (IToken)Match(input, 40, Follow._40_in_atom361);
                                char_literal45_tree = (CommonTree)adaptor.Create(char_literal45);
                                adaptor.AddChild(root_0, char_literal45_tree);
                                DebugLocation(53, 8);
                                PushFollow(Follow._expr_in_atom363);
                                expr46 = expr();
                                PopFollow();

                                adaptor.AddChild(root_0, expr46.Tree);
                                DebugLocation(53, 13);
                                char_literal47 = (IToken)Match(input, 41, Follow._41_in_atom365);
                                char_literal47_tree = (CommonTree)adaptor.Create(char_literal47);
                                adaptor.AddChild(root_0, char_literal47_tree);

                            }
                            break;

                    }
                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("atom", 11);
                    LeaveRule("atom", 11);
                    LeaveRule_atom();
                }
                DebugLocation(53, 16);
            }
            finally { DebugExitRule(GrammarFileName, "atom"); }
            return retval;

        }


        partial void EnterRule_value();
        partial void LeaveRule_value();

        // value : ( INT | FLOAT | STRING | CHAR );
        [GrammarRule("value")]
        private AstParserRuleReturnScope<CommonTree, IToken> value()
        {
            EnterRule_value();
            EnterRule("value", 12);
            TraceIn("value", 12);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken set48 = default(IToken);

            CommonTree set48_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "value");
                DebugLocation(55, 34);
                try
                {
                    //  ( INT | FLOAT | STRING | CHAR )
                    DebugEnterAlt(1);

                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(55, 7);

                        set48 = (IToken)input.LT(1);
                        if (input.LA(1) == CHAR || input.LA(1) == FLOAT || input.LA(1) == INT || input.LA(1) == STRING)
                        {
                            input.Consume();
                            adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set48));
                            state.errorRecovery = false;
                        }
                        else
                        {
                            MismatchedSetException mse = new MismatchedSetException(null, input);
                            DebugRecognitionException(mse);
                            throw mse;
                        }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("value", 12);
                    LeaveRule("value", 12);
                    LeaveRule_value();
                }
                DebugLocation(55, 34);
            }
            finally { DebugExitRule(GrammarFileName, "value"); }
            return retval;

        }


        partial void EnterRule_memberAccess();
        partial void LeaveRule_memberAccess();

        // memberAccess : ID '.' ID -> ^( GETMEMBER ID ID ) ;
        [GrammarRule("memberAccess")]
        private AstParserRuleReturnScope<CommonTree, IToken> memberAccess()
        {
            EnterRule_memberAccess();
            EnterRule("memberAccess", 13);
            TraceIn("memberAccess", 13);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken ID49 = default(IToken);
            IToken char_literal50 = default(IToken);
            IToken ID51 = default(IToken);

            CommonTree ID49_tree = default(CommonTree);
            CommonTree char_literal50_tree = default(CommonTree);
            CommonTree ID51_tree = default(CommonTree);
            RewriteRuleITokenStream stream_43 = new RewriteRuleITokenStream(adaptor, "token 43");
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            try
            {
                DebugEnterRule(GrammarFileName, "memberAccess");
                DebugLocation(57, 46);
                try
                {
                    //  ( ID '.' ID -> ^( GETMEMBER ID ID ) )
                    DebugEnterAlt(1);
                    // ID '.' ID
                    {
                        DebugLocation(57, 16);
                        ID49 = (IToken)Match(input, ID, Follow._ID_in_memberAccess393);
                        stream_ID.Add(ID49);

                        DebugLocation(57, 19);
                        char_literal50 = (IToken)Match(input, 43, Follow._43_in_memberAccess395);
                        stream_43.Add(char_literal50);

                        DebugLocation(57, 23);
                        ID51 = (IToken)Match(input, ID, Follow._ID_in_memberAccess397);
                        stream_ID.Add(ID51);



                        {
                            // AST REWRITE
                            // elements: ID, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 57:26: -> ^( GETMEMBER ID ID )
                            {
                                DebugLocation(57, 29);
                                //  ^( GETMEMBER ID ID )
                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(57, 31);
                                    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(GETMEMBER, "GETMEMBER"), root_1);

                                    DebugLocation(57, 41);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(57, 44);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("memberAccess", 13);
                    LeaveRule("memberAccess", 13);
                    LeaveRule_memberAccess();
                }
                DebugLocation(57, 46);
            }
            finally { DebugExitRule(GrammarFileName, "memberAccess"); }
            return retval;

        }


        partial void EnterRule_ifExpr();
        partial void LeaveRule_ifExpr();


        // ifExpr : 'IF' '(' ce= expr ',' e1= expr ',' e2= expr ')' -> ^( 'IF' ^( COND $ce) ^( TFEXPR $e1 $e2) ) ;
        [GrammarRule("ifExpr")]
        private AstParserRuleReturnScope<CommonTree, IToken> ifExpr()
        {
            EnterRule_ifExpr();
            EnterRule("ifExpr", 14);
            TraceIn("ifExpr", 14);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken string_literal52 = default(IToken);
            IToken char_literal53 = default(IToken);
            IToken char_literal54 = default(IToken);
            IToken char_literal55 = default(IToken);
            IToken char_literal56 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> ce = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> e1 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> e2 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree string_literal52_tree = default(CommonTree);
            CommonTree char_literal53_tree = default(CommonTree);
            CommonTree char_literal54_tree = default(CommonTree);
            CommonTree char_literal55_tree = default(CommonTree);
            CommonTree char_literal56_tree = default(CommonTree);
            RewriteRuleITokenStream stream_42 = new RewriteRuleITokenStream(adaptor, "token 42");
            RewriteRuleITokenStream stream_41 = new RewriteRuleITokenStream(adaptor, "token 41");
            RewriteRuleITokenStream stream_47 = new RewriteRuleITokenStream(adaptor, "token 47");
            RewriteRuleITokenStream stream_40 = new RewriteRuleITokenStream(adaptor, "token 40");
            RewriteRuleSubtreeStream stream_expr = new RewriteRuleSubtreeStream(adaptor, "rule expr");
            try
            {
                DebugEnterRule(GrammarFileName, "ifExpr");
                DebugLocation(59, 94);
                try
                {
                    //  ( 'IF' '(' ce= expr ',' e1= expr ',' e2= expr ')' -> ^( 'IF' ^( COND $ce) ^( TFEXPR $e1 $e2) ) )
                    DebugEnterAlt(1);
                    //  'IF' '(' ce= expr ',' e1= expr ',' e2= expr ')'
                    {
                        DebugLocation(59, 11);
                        string_literal52 = (IToken)Match(input, 47, Follow._47_in_ifExpr416);
                        stream_47.Add(string_literal52);

                        DebugLocation(59, 15);
                        char_literal53 = (IToken)Match(input, 40, Follow._40_in_ifExpr417);
                        stream_40.Add(char_literal53);

                        DebugLocation(59, 21);
                        PushFollow(Follow._expr_in_ifExpr421);
                        ce = expr();
                        PopFollow();

                        stream_expr.Add(ce.Tree);
                        DebugLocation(59, 27);
                        char_literal54 = (IToken)Match(input, 42, Follow._42_in_ifExpr423);
                        stream_42.Add(char_literal54);

                        DebugLocation(59, 33);
                        PushFollow(Follow._expr_in_ifExpr427);
                        e1 = expr();
                        PopFollow();

                        stream_expr.Add(e1.Tree);
                        DebugLocation(59, 39);
                        char_literal55 = (IToken)Match(input, 42, Follow._42_in_ifExpr429);
                        stream_42.Add(char_literal55);

                        DebugLocation(59, 45);
                        PushFollow(Follow._expr_in_ifExpr433);
                        e2 = expr();
                        PopFollow();

                        stream_expr.Add(e2.Tree);
                        DebugLocation(59, 51);
                        char_literal56 = (IToken)Match(input, 41, Follow._41_in_ifExpr435);
                        stream_41.Add(char_literal56);



                        {
                            // AST REWRITE
                            // elements: e1, ce, 47, e2
                            // token labels: 
                            // rule labels: retval, e1, e2, ce
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);
                            RewriteRuleSubtreeStream stream_e1 = new RewriteRuleSubtreeStream(adaptor, "rule e1", e1 != null ? e1.Tree : null);
                            RewriteRuleSubtreeStream stream_e2 = new RewriteRuleSubtreeStream(adaptor, "rule e2", e2 != null ? e2.Tree : null);
                            RewriteRuleSubtreeStream stream_ce = new RewriteRuleSubtreeStream(adaptor, "rule ce", ce != null ? ce.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 59:55: -> ^( 'IF' ^( COND $ce) ^( TFEXPR $e1 $e2) )
                            {
                                DebugLocation(59, 58);
                                // ^( 'IF' ^( COND $ce) ^( TFEXPR $e1 $e2) )
                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(59, 60);
                                    root_1 = (CommonTree)adaptor.BecomeRoot(stream_47.NextNode(), root_1);

                                    DebugLocation(59, 65);
                                    // \Ent ^( COND $ce)
                                    {
                                        CommonTree root_2 = (CommonTree)adaptor.Nil();
                                        DebugLocation(59, 67);
                                        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COND, "COND"), root_2);

                                        DebugLocation(59, 73);
                                        adaptor.AddChild(root_2, stream_ce.NextTree());

                                        adaptor.AddChild(root_1, root_2);
                                    }
                                    DebugLocation(59, 77);
                                    // ^( TFEXPR $e1 $e2)
                                    {
                                        CommonTree root_2 = (CommonTree)adaptor.Nil();
                                        DebugLocation(59, 79);
                                        root_2 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(TFEXPR, "TFEXPR"), root_2);

                                        DebugLocation(59, 87);
                                        adaptor.AddChild(root_2, stream_e1.NextTree());
                                        DebugLocation(59, 91);
                                        adaptor.AddChild(root_2, stream_e2.NextTree());

                                        adaptor.AddChild(root_1, root_2);
                                    }

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("ifExpr", 14);
                    LeaveRule("ifExpr", 14);
                    LeaveRule_ifExpr();
                }
                DebugLocation(59, 94);
            }
            finally { DebugExitRule(GrammarFileName, "ifExpr"); }
            return retval;

        }


        partial void EnterRule_functionCall();
        partial void LeaveRule_functionCall();


        // functionCall : ID '(' ( params )? ')' -> ^( CALL ID ( params )* ) ;
        [GrammarRule("functionCall")]
        private AstParserRuleReturnScope<CommonTree, IToken> functionCall()
        {
            EnterRule_functionCall();
            EnterRule("functionCall", 15);
            TraceIn("functionCall", 15);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken ID57 = default(IToken);
            IToken char_literal58 = default(IToken);
            IToken char_literal60 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> params59 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree ID57_tree = default(CommonTree);
            CommonTree char_literal58_tree = default(CommonTree);
            CommonTree char_literal60_tree = default(CommonTree);
            RewriteRuleITokenStream stream_41 = new RewriteRuleITokenStream(adaptor, "token 41");
            RewriteRuleITokenStream stream_40 = new RewriteRuleITokenStream(adaptor, "token 40");
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleSubtreeStream stream_params = new RewriteRuleSubtreeStream(adaptor, "rule params");
            try
            {
                DebugEnterRule(GrammarFileName, "functionCall");
                DebugLocation(61, 58);
                try
                {
                    //  ( ID '(' ( params )? ')' -> ^( CALL ID ( params )* ) )
                    DebugEnterAlt(1);
                    //  ID '(' ( params )? ')'
                    {
                        DebugLocation(61, 16);
                        ID57 = (IToken)Match(input, ID, Follow._ID_in_functionCall466);
                        stream_ID.Add(ID57);

                        DebugLocation(61, 19);
                        char_literal58 = (IToken)Match(input, 40, Follow._40_in_functionCall468);
                        stream_40.Add(char_literal58);

                        DebugLocation(61, 23);
                        //  ( params )?
                        int alt14 = 2;
                        try
                        {
                            DebugEnterSubRule(14);
                            try
                            {
                                DebugEnterDecision(14, false);
                                int LA14_0 = input.LA(1);

                                if ((LA14_0 == CHAR || LA14_0 == DEC || LA14_0 == FLOAT || (LA14_0 >= ID && LA14_0 <= INT) || LA14_0 == NOT || LA14_0 == STRING || LA14_0 == 40 || LA14_0 == 47))
                                {
                                    alt14 = 1;
                                }
                            }
                            finally { DebugExitDecision(14); }
                            switch (alt14)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    //  params
                                    {
                                        DebugLocation(61, 24);
                                        PushFollow(Follow._params_in_functionCall471);
                                        params59 = @params();
                                        PopFollow();

                                        stream_params.Add(params59.Tree);

                                    }
                                    break;

                            }
                        }
                        finally { DebugExitSubRule(14); }

                        DebugLocation(61, 33);
                        char_literal60 = (IToken)Match(input, 41, Follow._41_in_functionCall475);
                        stream_41.Add(char_literal60);



                        {
                            // AST REWRITE
                            // elements: params, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval != null ? retval.Tree : null);

                            root_0 = (CommonTree)adaptor.Nil();
                            // 61:37: -> ^( CALL ID ( params )* )
                            {
                                DebugLocation(61, 40);
                                //  ^( CALL ID ( params )* )
                                {
                                    CommonTree root_1 = (CommonTree)adaptor.Nil();
                                    DebugLocation(61, 42);
                                    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(CALL, "CALL"), root_1);

                                    DebugLocation(61, 47);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(61, 50);
                                    //  ( params )*
                                    while (stream_params.HasNext)
                                    {
                                        DebugLocation(61, 50);
                                        adaptor.AddChild(root_1, stream_params.NextTree());

                                    }
                                    stream_params.Reset();

                                    adaptor.AddChild(root_0, root_1);
                                }

                            }

                            retval.Tree = root_0;
                        }

                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("functionCall", 15);
                    LeaveRule("functionCall", 15);
                    LeaveRule_functionCall();
                }
                DebugLocation(61, 58);
            }
            finally { DebugExitRule(GrammarFileName, "functionCall"); }
            return retval;

        }


        partial void EnterRule_params();
        partial void LeaveRule_params();


        //  params : expr ( ',' expr )* ;
        [GrammarRule("params")]
        private AstParserRuleReturnScope<CommonTree, IToken> @params()
        {
            EnterRule_params();
            EnterRule("params", 16);
            TraceIn("params", 16);
            AstParserRuleReturnScope<CommonTree, IToken> retval = new AstParserRuleReturnScope<CommonTree, IToken>();
            retval.Start = (IToken)input.LT(1);

            CommonTree root_0 = default(CommonTree);

            IToken char_literal62 = default(IToken);
            AstParserRuleReturnScope<CommonTree, IToken> expr61 = default(AstParserRuleReturnScope<CommonTree, IToken>);
            AstParserRuleReturnScope<CommonTree, IToken> expr63 = default(AstParserRuleReturnScope<CommonTree, IToken>);

            CommonTree char_literal62_tree = default(CommonTree);
            try
            {
                DebugEnterRule(GrammarFileName, "params");
                DebugLocation(63, 27);
                try
                {
                    //  ( expr ( ',' expr )* )
                    DebugEnterAlt(1);
                    //  expr ( ',' expr )*
                    {
                        root_0 = (CommonTree)adaptor.Nil();

                        DebugLocation(63, 11);
                        PushFollow(Follow._expr_in_params496);
                        expr61 = expr();
                        PopFollow();

                        adaptor.AddChild(root_0, expr61.Tree);
                        DebugLocation(63, 16);
                        // ( ',' expr )*
                        try
                        {
                            DebugEnterSubRule(15);
                            while (true)
                            {
                                int alt15 = 2;
                                try
                                {
                                    DebugEnterDecision(15, false);
                                    int LA15_0 = input.LA(1);

                                    if ((LA15_0 == 42))
                                    {
                                        alt15 = 1;
                                    }


                                }
                                finally { DebugExitDecision(15); }
                                switch (alt15)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        //  ',' expr
                                        {
                                            DebugLocation(63, 17);
                                            char_literal62 = (IToken)Match(input, 42, Follow._42_in_params499);
                                            char_literal62_tree = (CommonTree)adaptor.Create(char_literal62);
                                            adaptor.AddChild(root_0, char_literal62_tree);
                                            DebugLocation(63, 21);
                                            PushFollow(Follow._expr_in_params501);
                                            expr63 = expr();
                                            PopFollow();

                                            adaptor.AddChild(root_0, expr63.Tree);

                                        }
                                        break;

                                    default:
                                        goto loop15;
                                }
                            }

                        loop15:
                            ;

                        }
                        finally { DebugExitSubRule(15); }


                    }

                    retval.Stop = (IToken)input.LT(-1);

                    retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = (CommonTree)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

                }
                finally
                {
                    TraceOut("params", 16);
                    LeaveRule("params", 16);
                    LeaveRule_params();
                }
                DebugLocation(63, 27);
            }
            finally { DebugExitRule(GrammarFileName, "params"); }
            return retval;

        }

        #endregion Rules


        #region Follow sets
        private static class Follow
        {
            public static readonly BitSet _mapDeclaration_in_prog108 = new BitSet(new ulong[] { 0x200002UL });
            public static readonly BitSet _stat_in_prog110 = new BitSet(new ulong[] { 0x200002UL });
            public static readonly BitSet _ID_in_mapDeclaration137 = new BitSet(new ulong[] { 0x200000000000UL });
            public static readonly BitSet _45_in_mapDeclaration139 = new BitSet(new ulong[] { 0x200000UL });
            public static readonly BitSet _ID_in_mapDeclaration141 = new BitSet(new ulong[] { 0x100000000000UL });
            public static readonly BitSet _44_in_mapDeclaration143 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _ID_in_stat162 = new BitSet(new ulong[] { 0x400000000000UL });
            public static readonly BitSet _46_in_stat164 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_stat166 = new BitSet(new ulong[] { 0x100000000000UL });
            public static readonly BitSet _44_in_stat168 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _boolAndExpr_in_expr186 = new BitSet(new ulong[] { 0x400000002UL });
            public static readonly BitSet _OR_in_expr189 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _boolAndExpr_in_expr192 = new BitSet(new ulong[] { 0x400000002UL });
            public static readonly BitSet _equalityExpr_in_boolAndExpr202 = new BitSet(new ulong[] { 0x12UL });
            public static readonly BitSet _AND_in_boolAndExpr205 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _equalityExpr_in_boolAndExpr208 = new BitSet(new ulong[] { 0x12UL });
            public static readonly BitSet _relationalExpr_in_equalityExpr218 = new BitSet(new ulong[] { 0x100002002UL });
            public static readonly BitSet _EQUALS_in_equalityExpr222 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _NOTEQUALS_in_equalityExpr225 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _relationalExpr_in_equalityExpr228 = new BitSet(new ulong[] { 0x100002002UL });
            public static readonly BitSet _additiveExpr_in_relationalExpr238 = new BitSet(new ulong[] { 0x30C0002UL });
            public static readonly BitSet _LT_in_relationalExpr242 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _LTEQ_in_relationalExpr245 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _GT_in_relationalExpr248 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _GTEQ_in_relationalExpr251 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _additiveExpr_in_relationalExpr254 = new BitSet(new ulong[] { 0x30C0002UL });
            public static readonly BitSet _multiExpr_in_additiveExpr265 = new BitSet(new ulong[] { 0x810000002UL });
            public static readonly BitSet _PLUS_in_additiveExpr270 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _MINUS_in_additiveExpr273 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _multiExpr_in_additiveExpr277 = new BitSet(new ulong[] { 0x810000002UL });
            public static readonly BitSet _unaryExpr_in_multiExpr288 = new BitSet(new ulong[] { 0x60000802UL });
            public static readonly BitSet _MULT_in_multiExpr293 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _DIV_in_multiExpr296 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _MOD_in_multiExpr299 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _unaryExpr_in_multiExpr303 = new BitSet(new ulong[] { 0x60000802UL });
            public static readonly BitSet _NOT_in_unaryExpr314 = new BitSet(new ulong[] { 0x811000A10080UL });
            public static readonly BitSet _INC_in_unaryExpr317 = new BitSet(new ulong[] { 0x811000A10080UL });
            public static readonly BitSet _DEC_in_unaryExpr320 = new BitSet(new ulong[] { 0x811000A10080UL });
            public static readonly BitSet _atom_in_unaryExpr325 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _value_in_atom334 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _ID_in_atom339 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _functionCall_in_atom344 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _ifExpr_in_atom349 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _memberAccess_in_atom355 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _40_in_atom361 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_atom363 = new BitSet(new ulong[] { 0x20000000000UL });
            public static readonly BitSet _41_in_atom365 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _ID_in_memberAccess393 = new BitSet(new ulong[] { 0x80000000000UL });
            public static readonly BitSet _43_in_memberAccess395 = new BitSet(new ulong[] { 0x200000UL });
            public static readonly BitSet _ID_in_memberAccess397 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _47_in_ifExpr416 = new BitSet(new ulong[] { 0x10000000000UL });
            public static readonly BitSet _40_in_ifExpr417 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_ifExpr421 = new BitSet(new ulong[] { 0x40000000000UL });
            public static readonly BitSet _42_in_ifExpr423 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_ifExpr427 = new BitSet(new ulong[] { 0x40000000000UL });
            public static readonly BitSet _42_in_ifExpr429 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_ifExpr433 = new BitSet(new ulong[] { 0x20000000000UL });
            public static readonly BitSet _41_in_ifExpr435 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _ID_in_functionCall466 = new BitSet(new ulong[] { 0x10000000000UL });
            public static readonly BitSet _40_in_functionCall468 = new BitSet(new ulong[] { 0x831080E10480UL });
            public static readonly BitSet _params_in_functionCall471 = new BitSet(new ulong[] { 0x20000000000UL });
            public static readonly BitSet _41_in_functionCall475 = new BitSet(new ulong[] { 0x2UL });
            public static readonly BitSet _expr_in_params496 = new BitSet(new ulong[] { 0x40000000002UL });
            public static readonly BitSet _42_in_params499 = new BitSet(new ulong[] { 0x811080E10480UL });
            public static readonly BitSet _expr_in_params501 = new BitSet(new ulong[] { 0x40000000002UL });
        }
        #endregion Follow sets
    }
}

