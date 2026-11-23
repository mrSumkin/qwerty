using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EC2 RID: 7874
[ayj("ShootIncendiaryBolt")]
public sealed class ezy : eyv
{
	// Token: 0x0600B1C6 RID: 45510 RVA: 0x00402F68 File Offset: 0x00401168
	public override string y8()
	{
		return "Выстрел зажигательным болтом";
	}

	// Token: 0x0600B1C7 RID: 45511 RVA: 0x00402F70 File Offset: 0x00401170
	public override string os()
	{
		return "ShootIncendiaryBolt";
	}

	// Token: 0x0600B1C8 RID: 45512 RVA: 0x00402F78 File Offset: 0x00401178
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1C9 RID: 45513 RVA: 0x00402F7C File Offset: 0x0040117C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1CA RID: 45514 RVA: 0x00402F80 File Offset: 0x00401180
	public ezy()
	{
		this.g = new List<string>();
		this.g.Add(d7f.a);
	}

	// Token: 0x0600B1CB RID: 45515 RVA: 0x00402FA4 File Offset: 0x004011A4
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B1CC RID: 45516 RVA: 0x00402FA8 File Offset: 0x004011A8
	public override string bp(cnm A_0)
	{
		coh coh = (A_0 != null) ? (A_0.b9() as coh) : null;
		int a_;
		if (coh != null)
		{
			a_ = eyv.a(coh);
		}
		else
		{
			a_ = 1;
		}
		a1q a1q = ezy.a((A_0 != null) ? A_0.b8() : null, a_);
		return qv.a("SpecialAttacks/ShootIncendiaryBolt", new object[]
		{
			ezy.b((A_0 != null) ? A_0.b8() : null, a_).a(true),
			a1q.a(true),
			(int)(ezy.b * 100.0),
			l4.a(ezy.a, false)
		});
	}

	// Token: 0x0600B1CD RID: 45517 RVA: 0x00403060 File Offset: 0x00401260
	public static a1q b(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Heat, (int)(num * (double)(10 + 8 * A_1) / 2.0), (int)(num * (double)(10 + 12 * A_1) / 2.0));
	}

	// Token: 0x0600B1CE RID: 45518 RVA: 0x004030D4 File Offset: 0x004012D4
	public static a1q a(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Heat, (int)(num * (double)(10 + 8 * A_1)), (int)(num * (double)(10 + 12 * A_1)));
	}

	// Token: 0x0600B1CF RID: 45519 RVA: 0x00403134 File Offset: 0x00401334
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1D0 RID: 45520 RVA: 0x00403168 File Offset: 0x00401368
	public override IList<string> bi()
	{
		return this.g;
	}

	// Token: 0x04004135 RID: 16693
	public new static readonly int a = 2;

	// Token: 0x04004136 RID: 16694
	public static readonly double b = 0.5;

	// Token: 0x04004137 RID: 16695
	private const int c = 10;

	// Token: 0x04004138 RID: 16696
	private const int d = 10;

	// Token: 0x04004139 RID: 16697
	private new const int e = 8;

	// Token: 0x0400413A RID: 16698
	private const int f = 12;

	// Token: 0x0400413B RID: 16699
	private new List<string> g;
}
