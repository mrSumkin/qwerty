using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F8C RID: 8076
[ayj("VitalityPowderConsumption")]
public sealed class brp : awn
{
	// Token: 0x0600BD86 RID: 48518 RVA: 0x00417C14 File Offset: 0x00415E14
	public override string y8()
	{
		return "Порошок живучести";
	}

	// Token: 0x0600BD87 RID: 48519 RVA: 0x00417C1C File Offset: 0x00415E1C
	public override string os()
	{
		return "VitalityPowderConsumption";
	}

	// Token: 0x0600BD88 RID: 48520 RVA: 0x00417C24 File Offset: 0x00415E24
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD89 RID: 48521 RVA: 0x00417C28 File Offset: 0x00415E28
	public brp()
	{
		this.b = new List<string>();
		this.b.Add(brp.a);
		this.b.Add(do0.a);
	}

	// Token: 0x0600BD8A RID: 48522 RVA: 0x00417C5C File Offset: 0x00415E5C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD8B RID: 48523 RVA: 0x00417C60 File Offset: 0x00415E60
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD8C RID: 48524 RVA: 0x00417C64 File Offset: 0x00415E64
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/VitalityPowder", new object[]
		{
			brp.e(A_0),
			(int)(brp.c(A_0) * 100f),
			brp.a(A_0),
			l4.a((double)brp.b(A_0), false),
			cpb.b,
			l4.a(cpb.c, false)
		});
	}

	// Token: 0x0600BD8D RID: 48525 RVA: 0x00417CE0 File Offset: 0x00415EE0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(brp.a, 60000, false, false)
		};
	}

	// Token: 0x0600BD8E RID: 48526 RVA: 0x00417D00 File Offset: 0x00415F00
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600BD8F RID: 48527 RVA: 0x00417D08 File Offset: 0x00415F08
	public static float f(cnm A_0)
	{
		return 0.65f;
	}

	// Token: 0x0600BD90 RID: 48528 RVA: 0x00417D10 File Offset: 0x00415F10
	public static int e(cnm A_0)
	{
		return 25;
	}

	// Token: 0x0600BD91 RID: 48529 RVA: 0x00417D14 File Offset: 0x00415F14
	public static float d(cnm A_0)
	{
		return 0.65f;
	}

	// Token: 0x0600BD92 RID: 48530 RVA: 0x00417D1C File Offset: 0x00415F1C
	public static float c(cnm A_0)
	{
		return 0.4f;
	}

	// Token: 0x0600BD93 RID: 48531 RVA: 0x00417D24 File Offset: 0x00415F24
	public static int b(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && !(A_0.b8() is e3q))
		{
			return 15000;
		}
		return 10000;
	}

	// Token: 0x0600BD94 RID: 48532 RVA: 0x00417D54 File Offset: 0x00415F54
	public new static int a(cnm A_0)
	{
		return 4;
	}

	// Token: 0x0600BD95 RID: 48533 RVA: 0x00417D58 File Offset: 0x00415F58
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x04004429 RID: 17449
	public new static readonly string a = "vitalityPowder";

	// Token: 0x0400442A RID: 17450
	private List<string> b;
}
