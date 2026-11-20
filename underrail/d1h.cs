using System;
using System.Linq;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8A RID: 8074
[ayj("CigarConsumation")]
public sealed class d1h : awn
{
	// Token: 0x0600BD74 RID: 48500 RVA: 0x00417A9C File Offset: 0x00415C9C
	public override string y8()
	{
		return "Сигара";
	}

	// Token: 0x0600BD75 RID: 48501 RVA: 0x00417AA4 File Offset: 0x00415CA4
	public override string os()
	{
		return "CigarConsumation";
	}

	// Token: 0x0600BD76 RID: 48502 RVA: 0x00417AAC File Offset: 0x00415CAC
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD78 RID: 48504 RVA: 0x00417AB8 File Offset: 0x00415CB8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD79 RID: 48505 RVA: 0x00417ABC File Offset: 0x00415CBC
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD7A RID: 48506 RVA: 0x00417AC0 File Offset: 0x00415CC0
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Cigar", new object[]
		{
			eys.d,
			eys.e,
			eys.b
		});
	}

	// Token: 0x0600BD7B RID: 48507 RVA: 0x00417AFC File Offset: 0x00415CFC
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && (A_0 != null && A_0.b8() != null) && Enumerable.Any<coh>(A_0.b8().Bag.b("lighter"));
	}
}
