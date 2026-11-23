using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F86 RID: 8070
[ayj("AegisConsumation")]
public sealed class bt9 : awn
{
	// Token: 0x0600BD50 RID: 48464 RVA: 0x00417894 File Offset: 0x00415A94
	public override string y8()
	{
		return "Эгида";
	}

	// Token: 0x0600BD51 RID: 48465 RVA: 0x0041789C File Offset: 0x00415A9C
	public override string os()
	{
		return "AegisConsumation";
	}

	// Token: 0x0600BD52 RID: 48466 RVA: 0x004178A4 File Offset: 0x00415AA4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD54 RID: 48468 RVA: 0x004178B0 File Offset: 0x00415AB0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD55 RID: 48469 RVA: 0x004178B4 File Offset: 0x00415AB4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD56 RID: 48470 RVA: 0x004178B8 File Offset: 0x00415AB8
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Aegis", new object[]
		{
			(int)(awz.a * 100.0),
			l4.a(bt9.a, false)
		});
	}

	// Token: 0x0400441C RID: 17436
	public new static readonly int a = 8;
}
