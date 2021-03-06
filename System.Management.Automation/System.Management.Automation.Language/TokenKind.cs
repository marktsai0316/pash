namespace System.Management.Automation.Language
{
    using System;

    public enum TokenKind
    {
        Ampersand = 0x1c,
        And = 0x35,
        AndAnd = 0x1a,
        As = 0x5e,
        AtCurly = 0x17,
        AtParen = 0x16,
        Band = 0x38,
        Begin = 0x77,
        Bnot = 0x34,
        Bor = 0x39,
        Break = 120,
        Bxor = 0x3a,
        Catch = 0x79,
        Ccontains = 0x57,
        Ceq = 0x4c,
        Cge = 0x4e,
        Cgt = 0x4f,
        Cin = 0x59,
        Class = 0x7a,
        Cle = 0x51,
        Clike = 0x52,
        Clt = 80,
        Cmatch = 0x54,
        Cne = 0x4d,
        Cnotcontains = 0x58,
        Cnotin = 90,
        Cnotlike = 0x53,
        Cnotmatch = 0x55,
        ColonColon = 0x22,
        Comma = 30,
        Comment = 10,
        Continue = 0x7b,
        Creplace = 0x56,
        Csplit = 0x5b,
        Data = 0x7c,
        Define = 0x7d,
        Divide = 0x26,
        DivideEquals = 0x2e,
        Do = 0x7e,
        DollarParen = 0x18,
        Dot = 0x23,
        DotDot = 0x21,
        Dynamicparam = 0x7f,
        Else = 0x80,
        ElseIf = 0x81,
        End = 130,
        EndOfInput = 11,
        Equals = 0x2a,
        Exclaim = 0x24,
        Exit = 0x83,
        Filter = 0x84,
        Finally = 0x85,
        For = 0x86,
        Foreach = 0x87,
        Format = 50,
        From = 0x88,
        Function = 0x89,
        Generic = 7,
        HereStringExpandable = 15,
        HereStringLiteral = 14,
        Icontains = 0x47,
        Identifier = 6,
        Ieq = 60,
        If = 0x8a,
        Ige = 0x3e,
        Igt = 0x3f,
        Iin = 0x49,
        Ile = 0x41,
        Ilike = 0x42,
        Ilt = 0x40,
        Imatch = 0x44,
        In = 0x8b,
        Ine = 0x3d,
        InlineScript = 0x9a,
        Inotcontains = 0x48,
        Inotin = 0x4a,
        Inotlike = 0x43,
        Inotmatch = 0x45,
        Ireplace = 70,
        Is = 0x5c,
        IsNot = 0x5d,
        Isplit = 0x4b,
        Join = 0x3b,
        Label = 5,
        LBracket = 20,
        LCurly = 0x12,
        LineContinuation = 9,
        LParen = 0x10,
        Minus = 0x29,
        MinusEquals = 0x2c,
        MinusMinus = 0x1f,
        Multiply = 0x25,
        MultiplyEquals = 0x2d,
        NewLine = 8,
        Not = 0x33,
        Number = 4,
        Or = 0x36,
        OrOr = 0x1b,
        Parallel = 0x98,
        Param = 140,
        Parameter = 3,
        Pipe = 0x1d,
        Plus = 40,
        PlusEquals = 0x2b,
        PlusPlus = 0x20,
        PostfixMinusMinus = 0x60,
        PostfixPlusPlus = 0x5f,
        Process = 0x8d,
        RBracket = 0x15,
        RCurly = 0x13,
        RedirectInStd = 0x31,
        Redirection = 0x30,
        Rem = 0x27,
        RemainderEquals = 0x2f,
        Return = 0x8e,
        RParen = 0x11,
        Semi = 0x19,
        Sequence = 0x99,
        Shl = 0x61,
        Shr = 0x62,
        SplattedVariable = 2,
        StringExpandable = 13,
        StringLiteral = 12,
        Switch = 0x8f,
        Throw = 0x90,
        Trap = 0x91,
        Try = 0x92,
        Unknown = 0,
        Until = 0x93,
        Using = 0x94,
        Var = 0x95,
        Variable = 1,
        While = 150,
        Workflow = 0x97,
        Xor = 0x37
    }
}

