using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EC1 RID: 7873
[ayj("ShootAcidBolt")]
public sealed class a0e : eyv
{
	// Token: 0x0600B1BC RID: 45500 RVA: 0x00402E1C File Offset: 0x0040101C
	public override string y8()
	{
		return "Выстрел болтом с кислотой";
	}

	// Token: 0x0600B1BD RID: 45501 RVA: 0x00402E24 File Offset: 0x00401024
	public override string os()
	{
		return "ShootAcidBolt";
	}

	// Token: 0x0600B1BE RID: 45502 RVA: 0x00402E2C File Offset: 0x0040102C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1BF RID: 45503 RVA: 0x00402E30 File Offset: 0x00401030
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1C0 RID: 45504 RVA: 0x00402E34 File Offset: 0x00401034
	public a0e()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
	}

	// Token: 0x0600B1C1 RID: 45505 RVA: 0x00402E58 File Offset: 0x00401058
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B1C2 RID: 45506 RVA: 0x00402E5C File Offset: 0x0040105C
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
		return qv.a("SpecialAttacks/ShootAcidBolt", new object[]
		{
			a0e.a((A_0 != null) ? A_0.b8() : null, a_).a(true)
		});
	}

	// Token: 0x0600B1C3 RID: 45507 RVA: 0x00402ECC File Offset: 0x004010CC
	public static a1q a(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Acid, (int)(num * (double)(5 + 5 * A_1)), (int)(num * (double)(10 + 15 * A_1)));
	}

	// Token: 0x0600B1C4 RID: 45508 RVA: 0x00402F2C File Offset: 0x0040112C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1C5 RID: 45509 RVA: 0x00402F60 File Offset: 0x00401160
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x04004130 RID: 16688
	private new const int a = 5;

	// Token: 0x04004131 RID: 16689
	private const int b = 10;

	// Token: 0x04004132 RID: 16690
	private const int c = 5;

	// Token: 0x04004133 RID: 16691
	private const int d = 15;

	// Token: 0x04004134 RID: 16692
	private new List<string> e;
}
