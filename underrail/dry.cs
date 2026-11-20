using System;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E88 RID: 7816
[ayj("CorrosiveAcidVialThrow")]
public sealed class dry : brm
{
	// Token: 0x0600AED8 RID: 44760 RVA: 0x003FCC14 File Offset: 0x003FAE14
	public override string y8()
	{
		return "Бросок колбы с едкой кислотой";
	}

	// Token: 0x0600AED9 RID: 44761 RVA: 0x003FCC1C File Offset: 0x003FAE1C
	public override string os()
	{
		return "CorrosiveAcidVialThrow";
	}

	// Token: 0x0600AEDA RID: 44762 RVA: 0x003FCC24 File Offset: 0x003FAE24
	public override string bp(cnm A_0)
	{
		return qv.a("Items\\Utilities/ThrowCorrosiveAcidVial", new object[]
		{
			dry.a(A_0).a(true),
			dry.c,
			(int)(deu.a * 100.0),
			l4.a(deu.c, false),
			deu.b
		});
	}

	// Token: 0x0600AEDB RID: 44763 RVA: 0x003FCC94 File Offset: 0x003FAE94
	public new static a1q a(cnm A_0)
	{
		return new a1q(DamageType.Acid, dry.a, dry.b);
	}

	// Token: 0x04004087 RID: 16519
	private new static readonly int a = 60;

	// Token: 0x04004088 RID: 16520
	private static readonly int b = 120;

	// Token: 0x04004089 RID: 16521
	public static readonly int c = deu.b / 3;
}
