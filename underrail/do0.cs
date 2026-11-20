using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F80 RID: 8064
[ayj("AdrenalineShotConsumation")]
public sealed class do0 : awn
{
	// Token: 0x0600BD01 RID: 48385 RVA: 0x004172E4 File Offset: 0x004154E4
	public override string y8()
	{
		return "Инъекция адреналина";
	}

	// Token: 0x0600BD02 RID: 48386 RVA: 0x004172EC File Offset: 0x004154EC
	public override string os()
	{
		return "AdrenalineShotConsumation";
	}

	// Token: 0x0600BD03 RID: 48387 RVA: 0x004172F4 File Offset: 0x004154F4
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BD04 RID: 48388 RVA: 0x004172F8 File Offset: 0x004154F8
	public do0()
	{
		this.b = new List<string>();
		this.b.Add(do0.a);
		this.b.Add(brp.a);
	}

	// Token: 0x0600BD05 RID: 48389 RVA: 0x0041732C File Offset: 0x0041552C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BD06 RID: 48390 RVA: 0x00417330 File Offset: 0x00415530
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BD07 RID: 48391 RVA: 0x00417338 File Offset: 0x00415538
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/AdrenalineShot", new object[]
		{
			do0.d(A_0),
			(int)(do0.b(A_0) * 100f),
			do0.a(A_0),
			l4.a((double)do0.a(), false)
		});
	}

	// Token: 0x0600BD08 RID: 48392 RVA: 0x00417398 File Offset: 0x00415598
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(do0.a, 60000, false, false)
		};
	}

	// Token: 0x0600BD09 RID: 48393 RVA: 0x004173B8 File Offset: 0x004155B8
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600BD0A RID: 48394 RVA: 0x004173C0 File Offset: 0x004155C0
	public static float e(cnm A_0)
	{
		return 0.5f;
	}

	// Token: 0x0600BD0B RID: 48395 RVA: 0x004173C8 File Offset: 0x004155C8
	public static int d(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600BD0C RID: 48396 RVA: 0x004173CC File Offset: 0x004155CC
	public static float c(cnm A_0)
	{
		return 0.5f;
	}

	// Token: 0x0600BD0D RID: 48397 RVA: 0x004173D4 File Offset: 0x004155D4
	public static float b(cnm A_0)
	{
		return 0.3f;
	}

	// Token: 0x0600BD0E RID: 48398 RVA: 0x004173DC File Offset: 0x004155DC
	public static int a()
	{
		return 15000;
	}

	// Token: 0x0600BD0F RID: 48399 RVA: 0x004173E4 File Offset: 0x004155E4
	public new static int a(cnm A_0)
	{
		return 2;
	}

	// Token: 0x0600BD10 RID: 48400 RVA: 0x004173E8 File Offset: 0x004155E8
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0400440B RID: 17419
	public new static readonly string a = "adrenalineShot";

	// Token: 0x0400440C RID: 17420
	private List<string> b;
}
