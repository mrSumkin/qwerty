using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F89 RID: 8073
[ayj("BioluminousSwampHoneyConsumption")]
public sealed class cu7 : awn
{
	// Token: 0x0600BD6C RID: 48492 RVA: 0x00417A2C File Offset: 0x00415C2C
	public override string y8()
	{
		return "Биолюминесцентный болотный мёд";
	}

	// Token: 0x0600BD6D RID: 48493 RVA: 0x00417A34 File Offset: 0x00415C34
	public override string os()
	{
		return "BioluminousSwampHoneyConsumption";
	}

	// Token: 0x0600BD6E RID: 48494 RVA: 0x00417A3C File Offset: 0x00415C3C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD70 RID: 48496 RVA: 0x00417A48 File Offset: 0x00415C48
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD71 RID: 48497 RVA: 0x00417A4C File Offset: 0x00415C4C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD72 RID: 48498 RVA: 0x00417A50 File Offset: 0x00415C50
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/BioluminousSwampHoney", new object[]
		{
			cw0.c,
			cw0.b,
			l4.a(cu7.a, false)
		});
	}

	// Token: 0x04004425 RID: 17445
	public new static readonly int a = 10;

	// Token: 0x04004426 RID: 17446
	public static readonly int b = 2;
}
