using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F92 RID: 8082
[ayj("PsionicAccelerator")]
public sealed class nv : awn
{
	// Token: 0x0600BDC8 RID: 48584 RVA: 0x00418194 File Offset: 0x00416394
	public override string y8()
	{
		return "Пси-ускоритель";
	}

	// Token: 0x0600BDC9 RID: 48585 RVA: 0x0041819C File Offset: 0x0041639C
	public override string os()
	{
		return "PsionicAccelerator";
	}

	// Token: 0x0600BDCA RID: 48586 RVA: 0x004181A4 File Offset: 0x004163A4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDCC RID: 48588 RVA: 0x004181B0 File Offset: 0x004163B0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDCD RID: 48589 RVA: 0x004181B4 File Offset: 0x004163B4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDCE RID: 48590 RVA: 0x004181B8 File Offset: 0x004163B8
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/PsionicAccelerator", new object[]
		{
			(int)(nv.b * 100.0),
			l4.a(nv.a, false)
		});
	}

	// Token: 0x0400443D RID: 17469
	public new static readonly int a = 10;

	// Token: 0x0400443E RID: 17470
	public static readonly double b = 0.5;
}
