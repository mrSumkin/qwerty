using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F81 RID: 8065
[ayj("AntidoteConsumation")]
public sealed class cdi : awn
{
	// Token: 0x0600BD12 RID: 48402 RVA: 0x004173F8 File Offset: 0x004155F8
	public override string y8()
	{
		return "Противоядие";
	}

	// Token: 0x0600BD13 RID: 48403 RVA: 0x00417400 File Offset: 0x00415600
	public override string os()
	{
		return "AntidoteConsumation";
	}

	// Token: 0x0600BD14 RID: 48404 RVA: 0x00417408 File Offset: 0x00415608
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD15 RID: 48405 RVA: 0x0041740C File Offset: 0x0041560C
	public cdi()
	{
		this.b = new List<string>();
	}

	// Token: 0x0600BD16 RID: 48406 RVA: 0x00417420 File Offset: 0x00415620
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD17 RID: 48407 RVA: 0x00417424 File Offset: 0x00415624
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD18 RID: 48408 RVA: 0x00417428 File Offset: 0x00415628
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Antidote", new object[]
		{
			cdi.a
		});
	}

	// Token: 0x0600BD19 RID: 48409 RVA: 0x00417448 File Offset: 0x00415648
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600BD1A RID: 48410 RVA: 0x00417450 File Offset: 0x00415650
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0400440D RID: 17421
	public new static readonly int a = 3;

	// Token: 0x0400440E RID: 17422
	private List<string> b;
}
