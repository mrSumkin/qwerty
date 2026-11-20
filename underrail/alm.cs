using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9D RID: 8093
[ayj("MindDartConsumation")]
public sealed class alm : awn
{
	// Token: 0x0600BE24 RID: 48676 RVA: 0x00418784 File Offset: 0x00416984
	public override string y8()
	{
		return "Пси-рывок";
	}

	// Token: 0x0600BE25 RID: 48677 RVA: 0x0041878C File Offset: 0x0041698C
	public override string os()
	{
		return "MindDartConsumation";
	}

	// Token: 0x0600BE26 RID: 48678 RVA: 0x00418794 File Offset: 0x00416994
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE27 RID: 48679 RVA: 0x00418798 File Offset: 0x00416998
	public alm()
	{
		this.g = new List<string>();
		this.g.Add(alm.a);
	}

	// Token: 0x0600BE28 RID: 48680 RVA: 0x004187BC File Offset: 0x004169BC
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE29 RID: 48681 RVA: 0x004187C0 File Offset: 0x004169C0
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE2A RID: 48682 RVA: 0x004187C4 File Offset: 0x004169C4
	public override string bo(cnm A_0)
	{
		return qv.a("Items\\Consumables/MindDart", new object[]
		{
			alm.c,
			alm.d,
			l4.a((double)alm.b, false),
			alm.e
		});
	}

	// Token: 0x0600BE2B RID: 48683 RVA: 0x00418818 File Offset: 0x00416A18
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(alm.a, alm.f, false, false)
		};
	}

	// Token: 0x0600BE2C RID: 48684 RVA: 0x00418838 File Offset: 0x00416A38
	public override IList<cfd> p5(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			d7f.k
		};
	}

	// Token: 0x0600BE2D RID: 48685 RVA: 0x0041884C File Offset: 0x00416A4C
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x04004451 RID: 17489
	public new static readonly string a = "mindDart";

	// Token: 0x04004452 RID: 17490
	public static readonly int b = 15000;

	// Token: 0x04004453 RID: 17491
	public static readonly int c = 15;

	// Token: 0x04004454 RID: 17492
	public static readonly int d = 15;

	// Token: 0x04004455 RID: 17493
	public new static readonly int e = 3;

	// Token: 0x04004456 RID: 17494
	private static readonly int f = d0u.b;

	// Token: 0x04004457 RID: 17495
	private new List<string> g;
}
