using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EA7 RID: 7847
[ayj("ShootRustingAcidBolt")]
public sealed class n7 : eyv
{
	// Token: 0x0600B05F RID: 45151 RVA: 0x003FFC44 File Offset: 0x003FDE44
	public override string y8()
	{
		return "Выстрел болтом с ржа-кислотой";
	}

	// Token: 0x0600B060 RID: 45152 RVA: 0x003FFC4C File Offset: 0x003FDE4C
	public override string os()
	{
		return "ShootRustingAcidBolt";
	}

	// Token: 0x0600B061 RID: 45153 RVA: 0x003FFC54 File Offset: 0x003FDE54
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B062 RID: 45154 RVA: 0x003FFC58 File Offset: 0x003FDE58
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B063 RID: 45155 RVA: 0x003FFC5C File Offset: 0x003FDE5C
	public n7()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
	}

	// Token: 0x0600B064 RID: 45156 RVA: 0x003FFC80 File Offset: 0x003FDE80
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B065 RID: 45157 RVA: 0x003FFC84 File Offset: 0x003FDE84
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
		return qv.a("SpecialAttacks/ShootRustingAcidBolt", new object[]
		{
			n7.a((A_0 != null) ? A_0.b8() : null, a_, false).a(true),
			ce.c,
			l4.a(ce.b, false),
			ce.a,
			Convert.ToInt32(d9b.a * 100.0)
		});
	}

	// Token: 0x0600B066 RID: 45158 RVA: 0x003FFD38 File Offset: 0x003FDF38
	public static a1q a(efk A_0, int A_1, bool A_2)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		if (A_2)
		{
			num *= 1.0 + d9b.a;
		}
		return new a1q(DamageType.Acid, (int)(num * (double)(7 + 7 * A_1)), (int)(num * (double)(15 + 22 * A_1)));
	}

	// Token: 0x0600B067 RID: 45159 RVA: 0x003FFDB0 File Offset: 0x003FDFB0
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B068 RID: 45160 RVA: 0x003FFDE4 File Offset: 0x003FDFE4
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x040040D9 RID: 16601
	private new const int a = 7;

	// Token: 0x040040DA RID: 16602
	private const int b = 15;

	// Token: 0x040040DB RID: 16603
	private const int c = 7;

	// Token: 0x040040DC RID: 16604
	private const int d = 22;

	// Token: 0x040040DD RID: 16605
	private new List<string> e;
}
