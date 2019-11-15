﻿// The variable 'variable' is assigned but its value is never used.
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


namespace RipsASTTask
{
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
    [System.CLSCompliant(false)]
    public partial class EntityLexer : Antlr.Runtime.Lexer
    {
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


        // delegators

        public EntityLexer()
        {
            OnCreated();
        }

        public EntityLexer(ICharStream input)
            : this(input, new RecognizerSharedState())
        {
        }

        public EntityLexer(ICharStream input, RecognizerSharedState state)
            : base(input, state)
        {

            OnCreated();
        }
        //public override string GrammarFileName { get { return "E:\\Software\\ANTLR3\\projects\\EntityMapping\\EntityMapping.g"; } }


        partial void OnCreated();
        partial void EnterRule(string ruleName, int ruleIndex);
        partial void LeaveRule(string ruleName, int ruleIndex);

        partial void EnterRule_T__40();
        partial void LeaveRule_T__40();

        [GrammarRule("T__40")]
        private void mT__40()
        {
            EnterRule_T__40();
            EnterRule("T__40", 1);
            TraceIn("T__40", 1);
            try
            {
                int _type = T__40;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(9, 9);
                    Match('(');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__40", 1);
                LeaveRule("T__40", 1);
                LeaveRule_T__40();
            }
        }


        partial void EnterRule_T__41();
        partial void LeaveRule_T__41();


        [GrammarRule("T__41")]
        private void mT__41()
        {
            EnterRule_T__41();
            EnterRule("T__41", 2);
            TraceIn("T__41", 2);
            try
            {
                int _type = T__41;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(10, 9);
                    Match(')');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__41", 2);
                LeaveRule("T__41", 2);
                LeaveRule_T__41();
            }
        }


        partial void EnterRule_T__42();
        partial void LeaveRule_T__42();


        [GrammarRule("T__42")]
        private void mT__42()
        {
            EnterRule_T__42();
            EnterRule("T__42", 3);
            TraceIn("T__42", 3);
            try
            {
                int _type = T__42;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(11, 9);
                    Match(',');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__42", 3);
                LeaveRule("T__42", 3);
                LeaveRule_T__42();
            }
        }


        partial void EnterRule_T__43();
        partial void LeaveRule_T__43();


        [GrammarRule("T__43")]
        private void mT__43()
        {
            EnterRule_T__43();
            EnterRule("T__43", 4);
            TraceIn("T__43", 4);
            try
            {
                int _type = T__43;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(12, 9);
                    Match('.');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__43", 4);
                LeaveRule("T__43", 4);
                LeaveRule_T__43();
            }
        }


        partial void EnterRule_T__44();
        partial void LeaveRule_T__44();


        [GrammarRule("T__44")]
        private void mT__44()
        {
            EnterRule_T__44();
            EnterRule("T__44", 5);
            TraceIn("T__44", 5);
            try
            {
                int _type = T__44;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(13, 9);
                    Match(';');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__44", 5);
                LeaveRule("T__44", 5);
                LeaveRule_T__44();
            }
        }


        partial void EnterRule_T__45();
        partial void LeaveRule_T__45();


        [GrammarRule("T__45")]
        private void mT__45()
        {
            EnterRule_T__45();
            EnterRule("T__45", 6);
            TraceIn("T__45", 6);
            try
            {
                int _type = T__45;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(14, 9);
                    Match("<-");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__45", 6);
                LeaveRule("T__45", 6);
                LeaveRule_T__45();
            }
        }


        partial void EnterRule_T__46();
        partial void LeaveRule_T__46();


        [GrammarRule("T__46")]
        private void mT__46()
        {
            EnterRule_T__46();
            EnterRule("T__46", 7);
            TraceIn("T__46", 7);
            try
            {
                int _type = T__46;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(15, 9);
                    Match('=');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__46", 7);
                LeaveRule("T__46", 7);
                LeaveRule_T__46();
            }
        }


        partial void EnterRule_T__47();
        partial void LeaveRule_T__47();


        [GrammarRule("T__47")]
        private void mT__47()
        {
            EnterRule_T__47();
            EnterRule("T__47", 8);
            TraceIn("T__47", 8);
            try
            {
                int _type = T__47;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(16, 9);
                    Match("IF");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("T__47", 8);
                LeaveRule("T__47", 8);
                LeaveRule_T__47();
            }
        }


        partial void EnterRule_ID();
        partial void LeaveRule_ID();


        [GrammarRule("ID")]
        private void mID()
        {
            EnterRule_ID();
            EnterRule("ID", 9);
            TraceIn("ID", 9);
            try
            {
                int _type = ID;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(66, 7);
                    if ((input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z'))
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }

                    DebugLocation(66, 31);

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

                                if (((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || LA1_0 == '_' || (LA1_0 >= 'a' && LA1_0 <= 'z')))
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
                                        DebugLocation(66, 31);
                                        input.Consume();


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


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("ID", 9);
                LeaveRule("ID", 9);
                LeaveRule_ID();
            }
        }


        partial void EnterRule_INT();
        partial void LeaveRule_INT();


        [GrammarRule("INT")]
        private void mINT()
        {
            EnterRule_INT();
            EnterRule("INT", 10);
            TraceIn("INT", 10);
            try
            {
                int _type = INT;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(69, 7);

                    int cnt2 = 0;
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

                                if (((LA2_0 >= '0' && LA2_0 <= '9')))
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
                                        DebugLocation(69, 7);
                                        input.Consume();


                                    }
                                    break;

                                default:
                                    if (cnt2 >= 1)
                                        goto loop2;

                                    EarlyExitException eee2 = new EarlyExitException(2, input);
                                    DebugRecognitionException(eee2);
                                    throw eee2;
                            }
                            cnt2++;
                        }
                    loop2:
                        ;

                    }
                    finally { DebugExitSubRule(2); }


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("INT", 10);
                LeaveRule("INT", 10);
                LeaveRule_INT();
            }
        }


        partial void EnterRule_FLOAT();
        partial void LeaveRule_FLOAT();


        [GrammarRule("FLOAT")]
        private void mFLOAT()
        {
            EnterRule_FLOAT();
            EnterRule("FLOAT", 11);
            TraceIn("FLOAT", 11);
            try
            {
                int _type = FLOAT;
                int _channel = DefaultTokenChannel;

                int alt9 = 3;
                try
                {
                    DebugEnterDecision(9, false);
                    try
                    {
                        alt9 = dfa9.Predict(input);
                    }
                    catch (NoViableAltException nvae)
                    {
                        DebugRecognitionException(nvae);
                        throw;
                    }
                }
                finally { DebugExitDecision(9); }
                switch (alt9)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(73, 9);

                            int cnt3 = 0;
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

                                        if (((LA3_0 >= '0' && LA3_0 <= '9')))
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
                                                DebugLocation(73, 9);
                                                input.Consume();


                                            }
                                            break;

                                        default:
                                            if (cnt3 >= 1)
                                                goto loop3;

                                            EarlyExitException eee3 = new EarlyExitException(3, input);
                                            DebugRecognitionException(eee3);
                                            throw eee3;
                                    }
                                    cnt3++;
                                }
                            loop3:
                                ;

                            }
                            finally { DebugExitSubRule(3); }

                            DebugLocation(73, 21);
                            Match('.');
                            DebugLocation(73, 25);

                            try
                            {
                                DebugEnterSubRule(4);
                                while (true)
                                {
                                    int alt4 = 2;
                                    try
                                    {
                                        DebugEnterDecision(4, false);
                                        int LA4_0 = input.LA(1);

                                        if (((LA4_0 >= '0' && LA4_0 <= '9')))
                                        {
                                            alt4 = 1;
                                        }


                                    }
                                    finally { DebugExitDecision(4); }
                                    switch (alt4)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            {
                                                DebugLocation(73, 25);
                                                input.Consume();


                                            }
                                            break;

                                        default:
                                            goto loop4;
                                    }
                                }

                            loop4:
                                ;

                            }
                            finally { DebugExitSubRule(4); }

                            DebugLocation(73, 37);

                            int alt5 = 2;
                            try
                            {
                                DebugEnterSubRule(5);
                                try
                                {
                                    DebugEnterDecision(5, false);
                                    int LA5_0 = input.LA(1);

                                    if ((LA5_0 == 'E' || LA5_0 == 'e'))
                                    {
                                        alt5 = 1;
                                    }
                                }
                                finally { DebugExitDecision(5); }
                                switch (alt5)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(73, 37);
                                            mEXPONENT();

                                        }
                                        break;

                                }
                            }
                            finally { DebugExitSubRule(5); }


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(74, 9);
                            Match('.');
                            DebugLocation(74, 13);

                            int cnt6 = 0;
                            try
                            {
                                DebugEnterSubRule(6);
                                while (true)
                                {
                                    int alt6 = 2;
                                    try
                                    {
                                        DebugEnterDecision(6, false);
                                        int LA6_0 = input.LA(1);

                                        if (((LA6_0 >= '0' && LA6_0 <= '9')))
                                        {
                                            alt6 = 1;
                                        }


                                    }
                                    finally { DebugExitDecision(6); }
                                    switch (alt6)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            {
                                                DebugLocation(74, 13);
                                                input.Consume();


                                            }
                                            break;

                                        default:
                                            if (cnt6 >= 1)
                                                goto loop6;

                                            EarlyExitException eee6 = new EarlyExitException(6, input);
                                            DebugRecognitionException(eee6);
                                            throw eee6;
                                    }
                                    cnt6++;
                                }
                            loop6:
                                ;

                            }
                            finally { DebugExitSubRule(6); }

                            DebugLocation(74, 25);

                            int alt7 = 2;
                            try
                            {
                                DebugEnterSubRule(7);
                                try
                                {
                                    DebugEnterDecision(7, false);
                                    int LA7_0 = input.LA(1);

                                    if ((LA7_0 == 'E' || LA7_0 == 'e'))
                                    {
                                        alt7 = 1;
                                    }
                                }
                                finally { DebugExitDecision(7); }
                                switch (alt7)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(74, 25);
                                            mEXPONENT();

                                        }
                                        break;

                                }
                            }
                            finally { DebugExitSubRule(7); }


                        }
                        break;
                    case 3:
                        DebugEnterAlt(3);
                        {
                            DebugLocation(75, 9);

                            int cnt8 = 0;
                            try
                            {
                                DebugEnterSubRule(8);
                                while (true)
                                {
                                    int alt8 = 2;
                                    try
                                    {
                                        DebugEnterDecision(8, false);
                                        int LA8_0 = input.LA(1);

                                        if (((LA8_0 >= '0' && LA8_0 <= '9')))
                                        {
                                            alt8 = 1;
                                        }


                                    }
                                    finally { DebugExitDecision(8); }
                                    switch (alt8)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            {
                                                DebugLocation(75, 9);
                                                input.Consume();


                                            }
                                            break;

                                        default:
                                            if (cnt8 >= 1)
                                                goto loop8;

                                            EarlyExitException eee8 = new EarlyExitException(8, input);
                                            DebugRecognitionException(eee8);
                                            throw eee8;
                                    }
                                    cnt8++;
                                }
                            loop8:
                                ;

                            }
                            finally { DebugExitSubRule(8); }

                            DebugLocation(75, 21);
                            mEXPONENT();

                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("FLOAT", 11);
                LeaveRule("FLOAT", 11);
                LeaveRule_FLOAT();
            }
        }


        partial void EnterRule_COMMENT();
        partial void LeaveRule_COMMENT();


        [GrammarRule("COMMENT")]
        private void mCOMMENT()
        {
            EnterRule_COMMENT();
            EnterRule("COMMENT", 12);
            TraceIn("COMMENT", 12);
            try
            {
                int _type = COMMENT;
                int _channel = DefaultTokenChannel;

                int alt13 = 2;
                try
                {
                    DebugEnterDecision(13, false);
                    int LA13_0 = input.LA(1);

                    if ((LA13_0 == '/'))
                    {
                        int LA13_1 = input.LA(2);

                        if ((LA13_1 == '/'))
                        {
                            alt13 = 1;
                        }
                        else if ((LA13_1 == '*'))
                        {
                            alt13 = 2;
                        }
                        else
                        {
                            NoViableAltException nvae = new NoViableAltException("", 13, 1, input);
                            DebugRecognitionException(nvae);
                            throw nvae;
                        }
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 13, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(13); }
                switch (alt13)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(79, 9);
                            Match("//");

                            DebugLocation(79, 14);

                            try
                            {
                                DebugEnterSubRule(10);
                                while (true)
                                {
                                    int alt10 = 2;
                                    try
                                    {
                                        DebugEnterDecision(10, false);
                                        int LA10_0 = input.LA(1);

                                        if (((LA10_0 >= '\u0000' && LA10_0 <= '\t') || (LA10_0 >= '\u000B' && LA10_0 <= '\f') || (LA10_0 >= '\u000E' && LA10_0 <= '\uFFFF')))
                                        {
                                            alt10 = 1;
                                        }


                                    }
                                    finally { DebugExitDecision(10); }
                                    switch (alt10)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            {
                                                DebugLocation(79, 14);
                                                input.Consume();


                                            }
                                            break;

                                        default:
                                            goto loop10;
                                    }
                                }

                            loop10:
                                ;

                            }
                            finally { DebugExitSubRule(10); }

                            DebugLocation(79, 28);

                            int alt11 = 2;
                            try
                            {
                                DebugEnterSubRule(11);
                                try
                                {
                                    DebugEnterDecision(11, false);
                                    int LA11_0 = input.LA(1);

                                    if ((LA11_0 == '\r'))
                                    {
                                        alt11 = 1;
                                    }
                                }
                                finally { DebugExitDecision(11); }
                                switch (alt11)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        {
                                            DebugLocation(79, 28);
                                            Match('\r');

                                        }
                                        break;

                                }
                            }
                            finally { DebugExitSubRule(11); }

                            DebugLocation(79, 34);
                            Match('\n');
                            DebugLocation(79, 39);
                            Skip();

                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(80, 9);
                            Match("/*");

                            DebugLocation(80, 14);

                            try
                            {
                                DebugEnterSubRule(12);
                                while (true)
                                {
                                    int alt12 = 2;
                                    try
                                    {
                                        DebugEnterDecision(12, false);
                                        int LA12_0 = input.LA(1);

                                        if ((LA12_0 == '*'))
                                        {
                                            int LA12_1 = input.LA(2);

                                            if ((LA12_1 == '/'))
                                            {
                                                alt12 = 2;
                                            }
                                            else if (((LA12_1 >= '\u0000' && LA12_1 <= '.') || (LA12_1 >= '0' && LA12_1 <= '\uFFFF')))
                                            {
                                                alt12 = 1;
                                            }


                                        }
                                        else if (((LA12_0 >= '\u0000' && LA12_0 <= ')') || (LA12_0 >= '+' && LA12_0 <= '\uFFFF')))
                                        {
                                            alt12 = 1;
                                        }


                                    }
                                    finally { DebugExitDecision(12); }
                                    switch (alt12)
                                    {
                                        case 1:
                                            DebugEnterAlt(1);
                                            {
                                                DebugLocation(80, 42);
                                                MatchAny();

                                            }
                                            break;

                                        default:
                                            goto loop12;
                                    }
                                }

                            loop12:
                                ;

                            }
                            finally { DebugExitSubRule(12); }

                            DebugLocation(80, 47);
                            Match("*/");

                            DebugLocation(80, 52);
                            Skip();

                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("COMMENT", 12);
                LeaveRule("COMMENT", 12);
                LeaveRule_COMMENT();
            }
        }


        partial void EnterRule_WS();
        partial void LeaveRule_WS();


        [GrammarRule("WS")]
        private void mWS()
        {
            EnterRule_WS();
            EnterRule("WS", 13);
            TraceIn("WS", 13);
            try
            {
                int _type = WS;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(83, 9);
                    if ((input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ')
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }

                    DebugLocation(87, 11);
                    Skip();

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("WS", 13);
                LeaveRule("WS", 13);
                LeaveRule_WS();
            }
        }


        partial void EnterRule_STRING();
        partial void LeaveRule_STRING();


        [GrammarRule("STRING")]
        private void mSTRING()
        {
            EnterRule_STRING();
            EnterRule("STRING", 14);
            TraceIn("STRING", 14);
            try
            {
                int _type = STRING;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(92, 8);
                    Match('\"');
                    DebugLocation(92, 12);

                    try
                    {
                        DebugEnterSubRule(14);
                        while (true)
                        {
                            int alt14 = 3;
                            try
                            {
                                DebugEnterDecision(14, false);
                                int LA14_0 = input.LA(1);

                                if ((LA14_0 == '\\'))
                                {
                                    alt14 = 1;
                                }
                                else if (((LA14_0 >= '\u0000' && LA14_0 <= '!') || (LA14_0 >= '#' && LA14_0 <= '[') || (LA14_0 >= ']' && LA14_0 <= '\uFFFF')))
                                {
                                    alt14 = 2;
                                }


                            }
                            finally { DebugExitDecision(14); }
                            switch (alt14)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    {
                                        DebugLocation(92, 14);
                                        mESC_SEQ();

                                    }
                                    break;
                                case 2:
                                    DebugEnterAlt(2);
                                    {
                                        DebugLocation(92, 24);
                                        input.Consume();


                                    }
                                    break;

                                default:
                                    goto loop14;
                            }
                        }

                    loop14:
                        ;

                    }
                    finally { DebugExitSubRule(14); }

                    DebugLocation(92, 39);
                    Match('\"');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("STRING", 14);
                LeaveRule("STRING", 14);
                LeaveRule_STRING();
            }
        }


        partial void EnterRule_CHAR();
        partial void LeaveRule_CHAR();


        [GrammarRule("CHAR")]
        private void mCHAR()
        {
            EnterRule_CHAR();
            EnterRule("CHAR", 15);
            TraceIn("CHAR", 15);
            try
            {
                int _type = CHAR;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(95, 8);
                    Match('\'');
                    DebugLocation(95, 13);

                    int alt15 = 2;
                    try
                    {
                        DebugEnterSubRule(15);
                        try
                        {
                            DebugEnterDecision(15, false);
                            int LA15_0 = input.LA(1);

                            if ((LA15_0 == '\\'))
                            {
                                alt15 = 1;
                            }
                            else if (((LA15_0 >= '\u0000' && LA15_0 <= '&') || (LA15_0 >= '(' && LA15_0 <= '[') || (LA15_0 >= ']' && LA15_0 <= '\uFFFF')))
                            {
                                alt15 = 2;
                            }
                            else
                            {
                                NoViableAltException nvae = new NoViableAltException("", 15, 0, input);
                                DebugRecognitionException(nvae);
                                throw nvae;
                            }
                        }
                        finally { DebugExitDecision(15); }
                        switch (alt15)
                        {
                            case 1:
                                DebugEnterAlt(1);
                                {
                                    DebugLocation(95, 15);
                                    mESC_SEQ();

                                }
                                break;
                            case 2:
                                DebugEnterAlt(2);
                                {
                                    DebugLocation(95, 25);
                                    input.Consume();


                                }
                                break;

                        }
                    }
                    finally { DebugExitSubRule(15); }

                    DebugLocation(95, 40);
                    Match('\'');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("CHAR", 15);
                LeaveRule("CHAR", 15);
                LeaveRule_CHAR();
            }
        }


        partial void EnterRule_EXPONENT();
        partial void LeaveRule_EXPONENT();


        [GrammarRule("EXPONENT")]
        private void mEXPONENT()
        {
            EnterRule_EXPONENT();
            EnterRule("EXPONENT", 16);
            TraceIn("EXPONENT", 16);
            try
            {

                DebugEnterAlt(1);

                {
                    DebugLocation(100, 12);
                    if (input.LA(1) == 'E' || input.LA(1) == 'e')
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }

                    DebugLocation(100, 22);

                    int alt16 = 2;
                    try
                    {
                        DebugEnterSubRule(16);
                        try
                        {
                            DebugEnterDecision(16, false);
                            int LA16_0 = input.LA(1);

                            if ((LA16_0 == '+' || LA16_0 == '-'))
                            {
                                alt16 = 1;
                            }
                        }
                        finally { DebugExitDecision(16); }
                        switch (alt16)
                        {
                            case 1:
                                DebugEnterAlt(1);
                                {
                                    DebugLocation(100, 22);
                                    input.Consume();


                                }
                                break;

                        }
                    }
                    finally { DebugExitSubRule(16); }

                    DebugLocation(100, 33);

                    int cnt17 = 0;
                    try
                    {
                        DebugEnterSubRule(17);
                        while (true)
                        {
                            int alt17 = 2;
                            try
                            {
                                DebugEnterDecision(17, false);
                                int LA17_0 = input.LA(1);

                                if (((LA17_0 >= '0' && LA17_0 <= '9')))
                                {
                                    alt17 = 1;
                                }


                            }
                            finally { DebugExitDecision(17); }
                            switch (alt17)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    {
                                        DebugLocation(100, 33);
                                        input.Consume();


                                    }
                                    break;

                                default:
                                    if (cnt17 >= 1)
                                        goto loop17;

                                    EarlyExitException eee17 = new EarlyExitException(17, input);
                                    DebugRecognitionException(eee17);
                                    throw eee17;
                            }
                            cnt17++;
                        }
                    loop17:
                        ;

                    }
                    finally { DebugExitSubRule(17); }


                }

            }
            finally
            {
                TraceOut("EXPONENT", 16);
                LeaveRule("EXPONENT", 16);
                LeaveRule_EXPONENT();
            }
        }


        partial void EnterRule_HEX_DIGIT();
        partial void LeaveRule_HEX_DIGIT();


        [GrammarRule("HEX_DIGIT")]
        private void mHEX_DIGIT()
        {
            EnterRule_HEX_DIGIT();
            EnterRule("HEX_DIGIT", 17);
            TraceIn("HEX_DIGIT", 17);
            try
            {

                DebugEnterAlt(1);

                {
                    DebugLocation(103, 11);
                    if ((input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f'))
                    {
                        input.Consume();
                    }
                    else
                    {
                        MismatchedSetException mse = new MismatchedSetException(null, input);
                        DebugRecognitionException(mse);
                        Recover(mse);
                        throw mse;
                    }


                }

            }
            finally
            {
                TraceOut("HEX_DIGIT", 17);
                LeaveRule("HEX_DIGIT", 17);
                LeaveRule_HEX_DIGIT();
            }
        }


        partial void EnterRule_ESC_SEQ();
        partial void LeaveRule_ESC_SEQ();


        [GrammarRule("ESC_SEQ")]
        private void mESC_SEQ()
        {
            EnterRule_ESC_SEQ();
            EnterRule("ESC_SEQ", 18);
            TraceIn("ESC_SEQ", 18);
            try
            {

                int alt18 = 3;
                try
                {
                    DebugEnterDecision(18, false);
                    int LA18_0 = input.LA(1);

                    if ((LA18_0 == '\\'))
                    {
                        switch (input.LA(2))
                        {
                            case '\"':
                            case '\'':
                            case '\\':
                            case 'b':
                            case 'f':
                            case 'n':
                            case 'r':
                            case 't':
                                {
                                    alt18 = 1;
                                }
                                break;
                            case 'u':
                                {
                                    alt18 = 2;
                                }
                                break;
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                                {
                                    alt18 = 3;
                                }
                                break;
                            default:
                                {
                                    NoViableAltException nvae = new NoViableAltException("", 18, 1, input);
                                    DebugRecognitionException(nvae);
                                    throw nvae;
                                }
                        }

                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 18, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(18); }
                switch (alt18)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(107, 9);
                            Match('\\');
                            DebugLocation(107, 14);
                            input.Consume();


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(108, 9);
                            mUNICODE_ESC();

                        }
                        break;
                    case 3:
                        DebugEnterAlt(3);
                        {
                            DebugLocation(109, 9);
                            mOCTAL_ESC();

                        }
                        break;

                }
            }
            finally
            {
                TraceOut("ESC_SEQ", 18);
                LeaveRule("ESC_SEQ", 18);
                LeaveRule_ESC_SEQ();
            }
        }


        partial void EnterRule_OCTAL_ESC();
        partial void LeaveRule_OCTAL_ESC();


        [GrammarRule("OCTAL_ESC")]
        private void mOCTAL_ESC()
        {
            EnterRule_OCTAL_ESC();
            EnterRule("OCTAL_ESC", 19);
            TraceIn("OCTAL_ESC", 19);
            try
            {

                int alt19 = 3;
                try
                {
                    DebugEnterDecision(19, false);
                    int LA19_0 = input.LA(1);

                    if ((LA19_0 == '\\'))
                    {
                        int LA19_1 = input.LA(2);

                        if (((LA19_1 >= '0' && LA19_1 <= '3')))
                        {
                            int LA19_2 = input.LA(3);

                            if (((LA19_2 >= '0' && LA19_2 <= '7')))
                            {
                                int LA19_4 = input.LA(4);

                                if (((LA19_4 >= '0' && LA19_4 <= '7')))
                                {
                                    alt19 = 1;
                                }
                                else
                                {
                                    alt19 = 2;
                                }
                            }
                            else
                            {
                                alt19 = 3;
                            }
                        }
                        else if (((LA19_1 >= '4' && LA19_1 <= '7')))
                        {
                            int LA19_3 = input.LA(3);

                            if (((LA19_3 >= '0' && LA19_3 <= '7')))
                            {
                                alt19 = 2;
                            }
                            else
                            {
                                alt19 = 3;
                            }
                        }
                        else
                        {
                            NoViableAltException nvae = new NoViableAltException("", 19, 1, input);
                            DebugRecognitionException(nvae);
                            throw nvae;
                        }
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 19, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(19); }
                switch (alt19)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(114, 9);
                            Match('\\');
                            DebugLocation(114, 14);
                            input.Consume();

                            DebugLocation(114, 25);
                            input.Consume();

                            DebugLocation(114, 36);
                            input.Consume();


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(115, 9);
                            Match('\\');
                            DebugLocation(115, 14);
                            input.Consume();

                            DebugLocation(115, 25);
                            input.Consume();


                        }
                        break;
                    case 3:
                        DebugEnterAlt(3);
                        {
                            DebugLocation(116, 9);
                            Match('\\');
                            DebugLocation(116, 14);
                            input.Consume();


                        }
                        break;

                }
            }
            finally
            {
                TraceOut("OCTAL_ESC", 19);
                LeaveRule("OCTAL_ESC", 19);
                LeaveRule_OCTAL_ESC();
            }
        }


        partial void EnterRule_UNICODE_ESC();
        partial void LeaveRule_UNICODE_ESC();


        [GrammarRule("UNICODE_ESC")]
        private void mUNICODE_ESC()
        {
            EnterRule_UNICODE_ESC();
            EnterRule("UNICODE_ESC", 20);
            TraceIn("UNICODE_ESC", 20);
            try
            {

                DebugEnterAlt(1);

                {
                    DebugLocation(121, 9);
                    Match('\\');
                    DebugLocation(121, 14);
                    Match('u');
                    DebugLocation(121, 18);
                    mHEX_DIGIT();
                    DebugLocation(121, 28);
                    mHEX_DIGIT();
                    DebugLocation(121, 38);
                    mHEX_DIGIT();
                    DebugLocation(121, 48);
                    mHEX_DIGIT();

                }

            }
            finally
            {
                TraceOut("UNICODE_ESC", 20);
                LeaveRule("UNICODE_ESC", 20);
                LeaveRule_UNICODE_ESC();
            }
        }


        partial void EnterRule_OR();
        partial void LeaveRule_OR();


        [GrammarRule("OR")]
        private void mOR()
        {
            EnterRule_OR();
            EnterRule("OR", 21);
            TraceIn("OR", 21);
            try
            {
                int _type = OR;
                int _channel = DefaultTokenChannel;

                int alt20 = 2;
                try
                {
                    DebugEnterDecision(20, false);
                    int LA20_0 = input.LA(1);

                    if ((LA20_0 == '|'))
                    {
                        alt20 = 1;
                    }
                    else if ((LA20_0 == 'o'))
                    {
                        alt20 = 2;
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 20, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(20); }
                switch (alt20)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(125, 13);
                            Match("||");


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(125, 20);
                            Match("or");


                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("OR", 21);
                LeaveRule("OR", 21);
                LeaveRule_OR();
            }
        }


        partial void EnterRule_AND();
        partial void LeaveRule_AND();


        [GrammarRule("AND")]
        private void mAND()
        {
            EnterRule_AND();
            EnterRule("AND", 22);
            TraceIn("AND", 22);
            try
            {
                int _type = AND;
                int _channel = DefaultTokenChannel;

                int alt21 = 2;
                try
                {
                    DebugEnterDecision(21, false);
                    int LA21_0 = input.LA(1);

                    if ((LA21_0 == '&'))
                    {
                        alt21 = 1;
                    }
                    else if ((LA21_0 == 'a'))
                    {
                        alt21 = 2;
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 21, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(21); }
                switch (alt21)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(126, 13);
                            Match("&&");


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(126, 20);
                            Match("and");


                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("AND", 22);
                LeaveRule("AND", 22);
                LeaveRule_AND();
            }
        }


        partial void EnterRule_EQUALS();
        partial void LeaveRule_EQUALS();


        [GrammarRule("EQUALS")]
        private void mEQUALS()
        {
            EnterRule_EQUALS();
            EnterRule("EQUALS", 23);
            TraceIn("EQUALS", 23);
            try
            {
                int _type = EQUALS;
                int _channel = DefaultTokenChannel;

                int alt22 = 3;
                try
                {
                    DebugEnterDecision(22, false);
                    int LA22_0 = input.LA(1);

                    if ((LA22_0 == '='))
                    {
                        int LA22_1 = input.LA(2);

                        if ((LA22_1 == '='))
                        {
                            alt22 = 1;
                        }
                        else
                        {
                            alt22 = 2;
                        }
                    }
                    else if ((LA22_0 == 'e'))
                    {
                        alt22 = 3;
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 22, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(22); }
                switch (alt22)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(128, 13);
                            Match("==");


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(128, 20);
                            Match('=');

                        }
                        break;
                    case 3:
                        DebugEnterAlt(3);
                        {
                            DebugLocation(128, 26);
                            Match("eq");


                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("EQUALS", 23);
                LeaveRule("EQUALS", 23);
                LeaveRule_EQUALS();
            }
        }


        partial void EnterRule_NOTEQUALS();
        partial void LeaveRule_NOTEQUALS();


        [GrammarRule("NOTEQUALS")]
        private void mNOTEQUALS()
        {
            EnterRule_NOTEQUALS();
            EnterRule("NOTEQUALS", 24);
            TraceIn("NOTEQUALS", 24);
            try
            {
                int _type = NOTEQUALS;
                int _channel = DefaultTokenChannel;

                int alt23 = 3;
                try
                {
                    DebugEnterDecision(23, false);
                    switch (input.LA(1))
                    {
                        case '!':
                            {
                                alt23 = 1;
                            }
                            break;
                        case '<':
                            {
                                alt23 = 2;
                            }
                            break;
                        case 'n':
                            {
                                alt23 = 3;
                            }
                            break;
                        default:
                            {
                                NoViableAltException nvae = new NoViableAltException("", 23, 0, input);
                                DebugRecognitionException(nvae);
                                throw nvae;
                            }
                    }

                }
                finally { DebugExitDecision(23); }
                switch (alt23)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(130, 12);
                            Match("!=");


                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(130, 19);
                            Match("<>");


                        }
                        break;
                    case 3:
                        DebugEnterAlt(3);
                        {
                            DebugLocation(130, 26);
                            Match("ne");


                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("NOTEQUALS", 24);
                LeaveRule("NOTEQUALS", 24);
                LeaveRule_NOTEQUALS();
            }
        }


        partial void EnterRule_LT();
        partial void LeaveRule_LT();


        [GrammarRule("LT")]
        private void mLT()
        {
            EnterRule_LT();
            EnterRule("LT", 25);
            TraceIn("LT", 25);
            try
            {
                int _type = LT;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(131, 12);
                    Match('<');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("LT", 25);
                LeaveRule("LT", 25);
                LeaveRule_LT();
            }
        }


        partial void EnterRule_LTEQ();
        partial void LeaveRule_LTEQ();


        [GrammarRule("LTEQ")]
        private void mLTEQ()
        {
            EnterRule_LTEQ();
            EnterRule("LTEQ", 26);
            TraceIn("LTEQ", 26);
            try
            {
                int _type = LTEQ;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(132, 12);
                    Match("<=");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("LTEQ", 26);
                LeaveRule("LTEQ", 26);
                LeaveRule_LTEQ();
            }
        }


        partial void EnterRule_GT();
        partial void LeaveRule_GT();


        [GrammarRule("GT")]
        private void mGT()
        {
            EnterRule_GT();
            EnterRule("GT", 27);
            TraceIn("GT", 27);
            try
            {
                int _type = GT;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(133, 12);
                    Match('>');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("GT", 27);
                LeaveRule("GT", 27);
                LeaveRule_GT();
            }
        }


        partial void EnterRule_GTEQ();
        partial void LeaveRule_GTEQ();


        [GrammarRule("GTEQ")]
        private void mGTEQ()
        {
            EnterRule_GTEQ();
            EnterRule("GTEQ", 28);
            TraceIn("GTEQ", 28);
            try
            {
                int _type = GTEQ;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(134, 12);
                    Match(">=");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("GTEQ", 28);
                LeaveRule("GTEQ", 28);
                LeaveRule_GTEQ();
            }
        }


        partial void EnterRule_PLUS();
        partial void LeaveRule_PLUS();


        [GrammarRule("PLUS")]
        private void mPLUS()
        {
            EnterRule_PLUS();
            EnterRule("PLUS", 29);
            TraceIn("PLUS", 29);
            try
            {
                int _type = PLUS;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(135, 12);
                    Match('+');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("PLUS", 29);
                LeaveRule("PLUS", 29);
                LeaveRule_PLUS();
            }
        }


        partial void EnterRule_MINUS();
        partial void LeaveRule_MINUS();


        [GrammarRule("MINUS")]
        private void mMINUS()
        {
            EnterRule_MINUS();
            EnterRule("MINUS", 30);
            TraceIn("MINUS", 30);
            try
            {
                int _type = MINUS;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(136, 12);
                    Match('-');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("MINUS", 30);
                LeaveRule("MINUS", 30);
                LeaveRule_MINUS();
            }
        }


        partial void EnterRule_MULT();
        partial void LeaveRule_MULT();


        [GrammarRule("MULT")]
        private void mMULT()
        {
            EnterRule_MULT();
            EnterRule("MULT", 31);
            TraceIn("MULT", 31);
            try
            {
                int _type = MULT;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(137, 12);
                    Match('*');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("MULT", 31);
                LeaveRule("MULT", 31);
                LeaveRule_MULT();
            }
        }


        partial void EnterRule_DIV();
        partial void LeaveRule_DIV();


        [GrammarRule("DIV")]
        private void mDIV()
        {
            EnterRule_DIV();
            EnterRule("DIV", 32);
            TraceIn("DIV", 32);
            try
            {
                int _type = DIV;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(138, 12);
                    Match('/');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("DIV", 32);
                LeaveRule("DIV", 32);
                LeaveRule_DIV();
            }
        }


        partial void EnterRule_MOD();
        partial void LeaveRule_MOD();


        [GrammarRule("MOD")]
        private void mMOD()
        {
            EnterRule_MOD();
            EnterRule("MOD", 33);
            TraceIn("MOD", 33);
            try
            {
                int _type = MOD;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(139, 12);
                    Match('%');

                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("MOD", 33);
                LeaveRule("MOD", 33);
                LeaveRule_MOD();
            }
        }


        partial void EnterRule_NOT();
        partial void LeaveRule_NOT();


        [GrammarRule("NOT")]
        private void mNOT()
        {
            EnterRule_NOT();
            EnterRule("NOT", 34);
            TraceIn("NOT", 34);
            try
            {
                int _type = NOT;
                int _channel = DefaultTokenChannel;

                int alt24 = 2;
                try
                {
                    DebugEnterDecision(24, false);
                    int LA24_0 = input.LA(1);

                    if ((LA24_0 == '!'))
                    {
                        alt24 = 1;
                    }
                    else if ((LA24_0 == 'n'))
                    {
                        alt24 = 2;
                    }
                    else
                    {
                        NoViableAltException nvae = new NoViableAltException("", 24, 0, input);
                        DebugRecognitionException(nvae);
                        throw nvae;
                    }
                }
                finally { DebugExitDecision(24); }
                switch (alt24)
                {
                    case 1:
                        DebugEnterAlt(1);
                        {
                            DebugLocation(140, 12);
                            Match('!');

                        }
                        break;
                    case 2:
                        DebugEnterAlt(2);
                        {
                            DebugLocation(140, 18);
                            Match("not");


                        }
                        break;

                }
                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("NOT", 34);
                LeaveRule("NOT", 34);
                LeaveRule_NOT();
            }
        }


        partial void EnterRule_INC();
        partial void LeaveRule_INC();


        [GrammarRule("INC")]
        private void mINC()
        {
            EnterRule_INC();
            EnterRule("INC", 35);
            TraceIn("INC", 35);
            try
            {
                int _type = INC;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(141, 12);
                    Match("++");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("INC", 35);
                LeaveRule("INC", 35);
                LeaveRule_INC();
            }
        }


        partial void EnterRule_DEC();
        partial void LeaveRule_DEC();


        [GrammarRule("DEC")]
        private void mDEC()
        {
            EnterRule_DEC();
            EnterRule("DEC", 36);
            TraceIn("DEC", 36);
            try
            {
                int _type = DEC;
                int _channel = DefaultTokenChannel;

                DebugEnterAlt(1);

                {
                    DebugLocation(142, 12);
                    Match("--");


                }

                state.type = _type;
                state.channel = _channel;
            }
            finally
            {
                TraceOut("DEC", 36);
                LeaveRule("DEC", 36);
                LeaveRule_DEC();
            }
        }


        public override void mTokens()
        {

            int alt25 = 31;
            try
            {
                DebugEnterDecision(25, false);
                try
                {
                    alt25 = dfa25.Predict(input);
                }
                catch (NoViableAltException nvae)
                {
                    DebugRecognitionException(nvae);
                    throw;
                }
            }
            finally { DebugExitDecision(25); }
            switch (alt25)
            {
                case 1:
                    DebugEnterAlt(1);
                    {
                        DebugLocation(1, 10);
                        mT__40();

                    }
                    break;
                case 2:
                    DebugEnterAlt(2);
                    {
                        DebugLocation(1, 16);
                        mT__41();

                    }
                    break;
                case 3:
                    DebugEnterAlt(3);
                    {
                        DebugLocation(1, 22);
                        mT__42();

                    }
                    break;
                case 4:
                    DebugEnterAlt(4);
                    {
                        DebugLocation(1, 28);
                        mT__43();

                    }
                    break;
                case 5:
                    DebugEnterAlt(5);
                    {
                        DebugLocation(1, 34);
                        mT__44();

                    }
                    break;
                case 6:
                    DebugEnterAlt(6);
                    {
                        DebugLocation(1, 40);
                        mT__45();

                    }
                    break;
                case 7:
                    DebugEnterAlt(7);
                    {
                        DebugLocation(1, 46);
                        mT__46();

                    }
                    break;
                case 8:
                    DebugEnterAlt(8);
                    {
                        DebugLocation(1, 52);
                        mT__47();

                    }
                    break;
                case 9:
                    DebugEnterAlt(9);
                    {
                        DebugLocation(1, 58);
                        mID();

                    }
                    break;
                case 10:
                    DebugEnterAlt(10);
                    {
                        DebugLocation(1, 61);
                        mINT();

                    }
                    break;
                case 11:
                    DebugEnterAlt(11);
                    {
                        DebugLocation(1, 65);
                        mFLOAT();

                    }
                    break;
                case 12:
                    DebugEnterAlt(12);
                    {
                        DebugLocation(1, 71);
                        mCOMMENT();

                    }
                    break;
                case 13:
                    DebugEnterAlt(13);
                    {
                        DebugLocation(1, 79);
                        mWS();

                    }
                    break;
                case 14:
                    DebugEnterAlt(14);
                    {
                        DebugLocation(1, 82);
                        mSTRING();

                    }
                    break;
                case 15:
                    DebugEnterAlt(15);
                    {
                        DebugLocation(1, 89);
                        mCHAR();

                    }
                    break;
                case 16:
                    DebugEnterAlt(16);
                    {
                        DebugLocation(1, 94);
                        mOR();

                    }
                    break;
                case 17:
                    DebugEnterAlt(17);
                    {
                        DebugLocation(1, 97);
                        mAND();

                    }
                    break;
                case 18:
                    DebugEnterAlt(18);
                    {
                        DebugLocation(1, 101);
                        mEQUALS();

                    }
                    break;
                case 19:
                    DebugEnterAlt(19);
                    {
                        DebugLocation(1, 108);
                        mNOTEQUALS();

                    }
                    break;
                case 20:
                    DebugEnterAlt(20);
                    {
                        DebugLocation(1, 118);
                        mLT();

                    }
                    break;
                case 21:
                    DebugEnterAlt(21);
                    {
                        DebugLocation(1, 121);
                        mLTEQ();

                    }
                    break;
                case 22:
                    DebugEnterAlt(22);
                    {
                        DebugLocation(1, 126);
                        mGT();

                    }
                    break;
                case 23:
                    DebugEnterAlt(23);
                    {
                        DebugLocation(1, 129);
                        mGTEQ();

                    }
                    break;
                case 24:
                    DebugEnterAlt(24);
                    {
                        DebugLocation(1, 134);
                        mPLUS();

                    }
                    break;
                case 25:
                    DebugEnterAlt(25);
                    {
                        DebugLocation(1, 139);
                        mMINUS();

                    }
                    break;
                case 26:
                    DebugEnterAlt(26);
                    {
                        DebugLocation(1, 145);
                        mMULT();

                    }
                    break;
                case 27:
                    DebugEnterAlt(27);
                    {
                        DebugLocation(1, 150);
                        mDIV();

                    }
                    break;
                case 28:
                    DebugEnterAlt(28);
                    {
                        DebugLocation(1, 154);
                        mMOD();

                    }
                    break;
                case 29:
                    DebugEnterAlt(29);
                    {
                        DebugLocation(1, 158);
                        mNOT();

                    }
                    break;
                case 30:
                    DebugEnterAlt(30);
                    {
                        DebugLocation(1, 162);
                        mINC();

                    }
                    break;
                case 31:
                    DebugEnterAlt(31);
                    {
                        DebugLocation(1, 166);
                        mDEC();

                    }
                    break;

            }

        }


        #region DFA
        DFA9 dfa9;
        DFA25 dfa25;

        protected override void InitDFAs()
        {
            base.InitDFAs();
            dfa9 = new DFA9(this);
            dfa25 = new DFA25(this);
        }

        private class DFA9 : DFA
        {
            private const string DFA9_eotS =
                "\x5\xFFFF";
            private const string DFA9_eofS =
                "\x5\xFFFF";
            private const string DFA9_minS =
                "\x2\x2E\x3\xFFFF";
            private const string DFA9_maxS =
                "\x1\x39\x1\x65\x3\xFFFF";
            private const string DFA9_acceptS =
                "\x2\xFFFF\x1\x2\x1\x1\x1\x3";
            private const string DFA9_specialS =
                "\x5\xFFFF}>";
            private static readonly string[] DFA9_transitionS =
			{
				"\x1\x2\x1\xFFFF\xA\x1",
				"\x1\x3\x1\xFFFF\xA\x1\xB\xFFFF\x1\x4\x1F\xFFFF\x1\x4",
				"",
				"",
				""
			};

            private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
            private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
            private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
            private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
            private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
            private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
            private static readonly short[][] DFA9_transition;

            static DFA9()
            {
                int numStates = DFA9_transitionS.Length;
                DFA9_transition = new short[numStates][];
                for (int i = 0; i < numStates; i++)
                {
                    DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
                }
            }

            public DFA9(BaseRecognizer recognizer)
            {
                this.recognizer = recognizer;
                this.decisionNumber = 9;
                this.eot = DFA9_eot;
                this.eof = DFA9_eof;
                this.min = DFA9_min;
                this.max = DFA9_max;
                this.accept = DFA9_accept;
                this.special = DFA9_special;
                this.transition = DFA9_transition;
            }

            public override string Description { get { return "72:1: FLOAT : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* ( EXPONENT )? | '.' ( '0' .. '9' )+ ( EXPONENT )? | ( '0' .. '9' )+ EXPONENT );"; } }

            public override void Error(NoViableAltException nvae)
            {
                DebugRecognitionException(nvae);
            }
        }

        private class DFA25 : DFA
        {
            private const string DFA25_eotS =
                "\x4\xFFFF\x1\x1B\x1\xFFFF\x1\x20\x1\x22\x2\x15\x1\x25\x1\x27\x4\xFFFF" +
                "\x1\x15\x1\xFFFF\x2\x15\x1\x2C\x1\xFFFF\x1\x2E\x1\x30\x1\x32\xA\xFFFF" +
                "\x1\x33\x4\xFFFF\x1\x15\x2\xFFFF\x1\x15\xA\xFFFF";
            private const string DFA25_eofS =
                "\x36\xFFFF";
            private const string DFA25_minS =
                "\x1\x9\x3\xFFFF\x1\x30\x1\xFFFF\x1\x2D\x1\x3D\x1\x46\x1\x72\x1\x2E\x1" +
                "\x2A\x4\xFFFF\x1\x6E\x1\xFFFF\x1\x71\x1\x65\x1\x3D\x1\xFFFF\x1\x3D\x1" +
                "\x2B\x1\x2D\xA\xFFFF\x1\x30\x4\xFFFF\x1\x64\x2\xFFFF\x1\x74\xA\xFFFF";
            private const string DFA25_maxS =
                "\x1\x7C\x3\xFFFF\x1\x39\x1\xFFFF\x1\x3E\x1\x3D\x1\x46\x1\x72\x1\x65\x1" +
                "\x2F\x4\xFFFF\x1\x6E\x1\xFFFF\x1\x71\x1\x6F\x1\x3D\x1\xFFFF\x1\x3D\x1" +
                "\x2B\x1\x2D\xA\xFFFF\x1\x7A\x4\xFFFF\x1\x64\x2\xFFFF\x1\x74\xA\xFFFF";
            private const string DFA25_acceptS =
                "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\xFFFF\x1\x5\x6\xFFFF\x1\xD\x1\xE\x1\xF" +
                "\x1\x10\x1\xFFFF\x1\x11\x3\xFFFF\x1\x9\x3\xFFFF\x1\x1A\x1\x1C\x1\x4\x1" +
                "\xB\x1\x6\x1\x13\x1\x15\x1\x14\x1\x12\x1\x7\x1\xFFFF\x1\x9\x1\xA\x1\xC" +
                "\x1\x1B\x1\xFFFF\x2\x9\x1\xFFFF\x1\x1D\x1\x17\x1\x16\x1\x1E\x1\x18\x1" +
                "\x1F\x1\x19\x1\x8\x2\x9";
            private const string DFA25_specialS =
                "\x36\xFFFF}>";
            private static readonly string[] DFA25_transitionS =
			{
				"\x2\xC\x2\xFFFF\x1\xC\x12\xFFFF\x1\xC\x1\x14\x1\xD\x2\xFFFF\x1\x1A\x1"+
				"\x11\x1\xE\x1\x1\x1\x2\x1\x19\x1\x17\x1\x3\x1\x18\x1\x4\x1\xB\xA\xA"+
				"\x1\xFFFF\x1\x5\x1\x6\x1\x7\x1\x16\x2\xFFFF\x8\x15\x1\x8\x11\x15\x4"+
				"\xFFFF\x1\x15\x1\xFFFF\x1\x10\x3\x15\x1\x12\x8\x15\x1\x13\x1\x9\xB\x15"+
				"\x1\xFFFF\x1\xF",
				"",
				"",
				"",
				"\xA\x1C",
				"",
				"\x1\x1D\xF\xFFFF\x1\x1F\x1\x1E",
				"\x1\x21",
				"\x1\x23",
				"\x1\x24",
				"\x1\x1C\x1\xFFFF\xA\xA\xB\xFFFF\x1\x1C\x1F\xFFFF\x1\x1C",
				"\x1\x26\x4\xFFFF\x1\x26",
				"",
				"",
				"",
				"",
				"\x1\x28",
				"",
				"\x1\x29",
				"\x1\x2A\x9\xFFFF\x1\x2B",
				"\x1\x1E",
				"",
				"\x1\x2D",
				"\x1\x2F",
				"\x1\x31",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\xA\x15\x7\xFFFF\x1A\x15\x4\xFFFF\x1\x15\x1\xFFFF\x1A\x15",
				"",
				"",
				"",
				"",
				"\x1\x34",
				"",
				"",
				"\x1\x35",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

            private static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
            private static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
            private static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
            private static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
            private static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
            private static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
            private static readonly short[][] DFA25_transition;

            static DFA25()
            {
                int numStates = DFA25_transitionS.Length;
                DFA25_transition = new short[numStates][];
                for (int i = 0; i < numStates; i++)
                {
                    DFA25_transition[i] = DFA.UnpackEncodedString(DFA25_transitionS[i]);
                }
            }

            public DFA25(BaseRecognizer recognizer)
            {
                this.recognizer = recognizer;
                this.decisionNumber = 25;
                this.eot = DFA25_eot;
                this.eof = DFA25_eof;
                this.min = DFA25_min;
                this.max = DFA25_max;
                this.accept = DFA25_accept;
                this.special = DFA25_special;
                this.transition = DFA25_transition;
            }

            public override string Description { get { return "1:1: Tokens : ( T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | ID | INT | FLOAT | COMMENT | WS | STRING | CHAR | OR | AND | EQUALS | NOTEQUALS | LT | LTEQ | GT | GTEQ | PLUS | MINUS | MULT | DIV | MOD | NOT | INC | DEC );"; } }

            public override void Error(NoViableAltException nvae)
            {
                DebugRecognitionException(nvae);
            }
        }


        #endregion

    }
}

