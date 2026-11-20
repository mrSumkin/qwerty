using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E86 RID: 7814
[ayj("RustingAcidVialThrow")]
public sealed class es1 : brm
{
	// Token: 0x0600AEC3 RID: 44739 RVA: 0x003FCA28 File Offset: 0x003FAC28
	public override string y8()
	{
		return "Бросок колбы с ржа-кислотой";
	}

	// Token: 0x0600AEC4 RID: 44740 RVA: 0x003FCA30 File Offset: 0x003FAC30
	public override string os()
	{
		return "RustingAcidVialThrow";
	}

	// Token: 0x0600AEC5 RID: 44741 RVA: 0x003FCA3C File Offset: 0x003FAC3C
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/ThrowRustingAcidVial", new object[]
		{
			es1.a(A_0).a(true),
			es1.c,
			ce.c,
			l4.a(ce.b, false),
			ce.a,
			Convert.ToInt32(d9b.a * 100.0)
		});
	}

	// Token: 0x0600AEC6 RID: 44742 RVA: 0x003FCABC File Offset: 0x003FACBC
	public new static a1q a(cnm A_0)
	{
		return new a1q(DamageType.Acid, es1.a, es1.b);
	}

	// Token: 0x04004084 RID: 16516
	private new static readonly int a = 50;

	// Token: 0x04004085 RID: 16517
	private static readonly int b = 100;

	// Token: 0x04004086 RID: 16518
	public static readonly int c = ce.a / 3;
}
