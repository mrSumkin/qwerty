using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E98 RID: 7832
[ayj("ShootVoidBolt")]
public sealed class e7b : eyv
{
	// Token: 0x0600AF61 RID: 44897 RVA: 0x003FDBE4 File Offset: 0x003FBDE4
	public override string y8()
	{
		return "Выстрел болтом пустоты";
	}

	// Token: 0x0600AF62 RID: 44898 RVA: 0x003FDBEC File Offset: 0x003FBDEC
	public override string os()
	{
		return "ShootVoidBolt";
	}

	// Token: 0x0600AF63 RID: 44899 RVA: 0x003FDBF4 File Offset: 0x003FBDF4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600AF64 RID: 44900 RVA: 0x003FDBF8 File Offset: 0x003FBDF8
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600AF65 RID: 44901 RVA: 0x003FDBFC File Offset: 0x003FBDFC
	public e7b()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
	}

	// Token: 0x0600AF66 RID: 44902 RVA: 0x003FDC20 File Offset: 0x003FBE20
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600AF67 RID: 44903 RVA: 0x003FDC24 File Offset: 0x003FBE24
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
		return qv.a("SpecialAttacks/ShootVoidBolt", new object[]
		{
			e7b.a((A_0 != null) ? A_0.b8() : null, a_).a(true),
			bq4.b,
			bq4.c
		});
	}

	// Token: 0x0600AF68 RID: 44904 RVA: 0x003FDCAC File Offset: 0x003FBEAC
	public static a1q a(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Energy, (int)(num * (double)(10 + 10 * A_1)), (int)(num * (double)(15 + 20 * A_1)));
	}

	// Token: 0x0600AF69 RID: 44905 RVA: 0x003FDD0C File Offset: 0x003FBF0C
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600AF6A RID: 44906 RVA: 0x003FDD40 File Offset: 0x003FBF40
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x040040A5 RID: 16549
	private new const int a = 10;

	// Token: 0x040040A6 RID: 16550
	private const int b = 15;

	// Token: 0x040040A7 RID: 16551
	private const int c = 10;

	// Token: 0x040040A8 RID: 16552
	private const int d = 20;

	// Token: 0x040040A9 RID: 16553
	private new List<string> e;
}
