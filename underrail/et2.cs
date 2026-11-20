using System;

// Token: 0x02000C56 RID: 3158
public sealed class et2 : jn
{
	// Token: 0x060046FF RID: 18175 RVA: 0x001D5174 File Offset: 0x001D3374
	public override string cc()
	{
		return "xpbl";
	}

	// Token: 0x06004700 RID: 18176 RVA: 0x001D517C File Offset: 0x001D337C
	public et2() : base("aegisMessenger", "creature\\characters\\support\\xpbl\\cc_xpblMessenger")
	{
	}

	// Token: 0x06004701 RID: 18177 RVA: 0x001D5190 File Offset: 0x001D3390
	public override string b1(cyt A_0)
	{
		int num = A_0.v().Level;
		if (!A_0.r().GetPrimitivePropertyValue<bool>("npc_xpblMessenger_met", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("playerEnteredBlackSea", new bool?(false)).Value && num >= 10 && (string.Equals(A_0.c().b(), "cc_cityEnter", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc10", StringComparison.OrdinalIgnoreCase) || string.Equals(A_0.c().b(), "cc_dock", StringComparison.OrdinalIgnoreCase)))
		{
			return A_0.c().b();
		}
		return null;
	}
}
