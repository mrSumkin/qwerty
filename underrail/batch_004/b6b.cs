using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F9E RID: 8094
[ayj("PsiBoosterConsumation")]
public sealed class b6b : awn
{
	// Token: 0x0600BE2F RID: 48687 RVA: 0x00418888 File Offset: 0x00416A88
	public override string y8()
	{
		return "Пси-усилитель";
	}

	// Token: 0x0600BE30 RID: 48688 RVA: 0x00418890 File Offset: 0x00416A90
	public override string os()
	{
		return "PsiBoosterConsumation";
	}

	// Token: 0x0600BE31 RID: 48689 RVA: 0x00418898 File Offset: 0x00416A98
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BE32 RID: 48690 RVA: 0x0041889C File Offset: 0x00416A9C
	public b6b()
	{
		this.c = new List<string>();
		this.c.Add(d7f.i);
	}

	// Token: 0x0600BE33 RID: 48691 RVA: 0x004188C0 File Offset: 0x00416AC0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BE34 RID: 48692 RVA: 0x004188C4 File Offset: 0x00416AC4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BE35 RID: 48693 RVA: 0x004188CC File Offset: 0x00416ACC
	public override string bo(cnm A_0)
	{
		if (dm9.f)
		{
			return qv.a("Items\\Consumables/PsiBooster2", new object[]
			{
				b6b.a(A_0),
				Convert.ToInt32(b6b.b * 100.0)
			});
		}
		return qv.a("Items\\Consumables/PsiBooster", new object[]
		{
			b6b.a(A_0)
		});
	}

	// Token: 0x0600BE36 RID: 48694 RVA: 0x0041893C File Offset: 0x00416B3C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			d7f.k
		};
	}

	// Token: 0x0600BE37 RID: 48695 RVA: 0x00418950 File Offset: 0x00416B50
	public override IList<cfd> p5(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(alm.a, d7f.k.b, false, false)
		};
	}

	// Token: 0x0600BE38 RID: 48696 RVA: 0x00418974 File Offset: 0x00416B74
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BE39 RID: 48697 RVA: 0x00418980 File Offset: 0x00416B80
	public new static int a(cnm A_0)
	{
		int num = 75;
		if (A_0 != null && A_0.b8() != null && A_0.b8().Feats.Contains<b8s>())
		{
			num += b8s.b + A_0.b8().GetSpecializationValue<adw>(true) * adw.a;
		}
		return num;
	}

	// Token: 0x04004458 RID: 17496
	private new const int a = 75;

	// Token: 0x04004459 RID: 17497
	public static readonly double b = 0.5;

	// Token: 0x0400445A RID: 17498
	private List<string> c;
}
