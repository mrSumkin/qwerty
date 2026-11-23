using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F87 RID: 8071
[ayj("BullheadConsumation")]
public sealed class c6l : awn
{
	// Token: 0x0600BD58 RID: 48472 RVA: 0x004178F8 File Offset: 0x00415AF8
	public override string y8()
	{
		return "Болван";
	}

	// Token: 0x0600BD59 RID: 48473 RVA: 0x00417900 File Offset: 0x00415B00
	public override string os()
	{
		return "BullheadConsumation";
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x00417908 File Offset: 0x00415B08
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x0041790C File Offset: 0x00415B0C
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x00417914 File Offset: 0x00415B14
	public c6l()
	{
		this.d = new List<string>();
		this.d.Add("bullhead");
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x00417938 File Offset: 0x00415B38
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("bullhead", 6 * d0u.b, false, false)
		};
	}

	// Token: 0x0600BD5E RID: 48478 RVA: 0x00417958 File Offset: 0x00415B58
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x0041795C File Offset: 0x00415B5C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x00417960 File Offset: 0x00415B60
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/Bullhead", new object[]
		{
			l4.a(c6l.a, false)
		});
	}

	// Token: 0x0400441D RID: 17437
	public new static readonly int a = 3;

	// Token: 0x0400441E RID: 17438
	private const string b = "bullhead";

	// Token: 0x0400441F RID: 17439
	private const int c = 6;

	// Token: 0x04004420 RID: 17440
	private List<string> d;
}
