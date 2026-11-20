using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F91 RID: 8081
[ayj("HypercerebrixConsumation")]
public sealed class b36 : awn
{
	// Token: 0x0600BDC0 RID: 48576 RVA: 0x00418130 File Offset: 0x00416330
	public override string y8()
	{
		return "Гиперцеребриксовый боб";
	}

	// Token: 0x0600BDC1 RID: 48577 RVA: 0x00418138 File Offset: 0x00416338
	public override string os()
	{
		return "HypercerebrixConsumation";
	}

	// Token: 0x0600BDC2 RID: 48578 RVA: 0x00418140 File Offset: 0x00416340
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BDC4 RID: 48580 RVA: 0x0041814C File Offset: 0x0041634C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BDC5 RID: 48581 RVA: 0x00418150 File Offset: 0x00416350
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BDC6 RID: 48582 RVA: 0x00418154 File Offset: 0x00416354
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Hypercerebrix", new object[]
		{
			b36.b,
			l4.a(b36.a, false)
		});
	}

	// Token: 0x0400443B RID: 17467
	public new static readonly int a = 8;

	// Token: 0x0400443C RID: 17468
	public static readonly int b = 2;
}
