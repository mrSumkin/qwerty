using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EB1 RID: 7857
[ayj("ShootCorrosiveAcidBolt")]
public sealed class aao : eyv
{
	// Token: 0x0600B0D3 RID: 45267 RVA: 0x004008A4 File Offset: 0x003FEAA4
	public override string y8()
	{
		return "Выстрел болтом с едкой кислотой";
	}

	// Token: 0x0600B0D4 RID: 45268 RVA: 0x004008AC File Offset: 0x003FEAAC
	public override string os()
	{
		return "ShootCorrosiveAcidBolt";
	}

	// Token: 0x0600B0D5 RID: 45269 RVA: 0x004008B4 File Offset: 0x003FEAB4
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B0D6 RID: 45270 RVA: 0x004008B8 File Offset: 0x003FEAB8
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B0D7 RID: 45271 RVA: 0x004008BC File Offset: 0x003FEABC
	public aao()
	{
		this.e = new List<string>();
		this.e.Add(d7f.a);
	}

	// Token: 0x0600B0D8 RID: 45272 RVA: 0x004008E0 File Offset: 0x003FEAE0
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B0D9 RID: 45273 RVA: 0x004008E4 File Offset: 0x003FEAE4
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
		return qv.a("SpecialAttacks/ShootCorrosiveAcidBolt", new object[]
		{
			aao.a((A_0 != null) ? A_0.b8() : null, a_).a(true),
			(int)(deu.a * 100.0),
			l4.a(deu.c, false),
			deu.b
		});
	}

	// Token: 0x0600B0DA RID: 45274 RVA: 0x00400984 File Offset: 0x003FEB84
	public static a1q a(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Acid, (int)(num * (double)(10 + 10 * A_1)), (int)(num * (double)(20 + 30 * A_1)));
	}

	// Token: 0x0600B0DB RID: 45275 RVA: 0x004009E4 File Offset: 0x003FEBE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B0DC RID: 45276 RVA: 0x00400A18 File Offset: 0x003FEC18
	public override IList<string> bi()
	{
		return this.e;
	}

	// Token: 0x040040EE RID: 16622
	private new const int a = 10;

	// Token: 0x040040EF RID: 16623
	private const int b = 20;

	// Token: 0x040040F0 RID: 16624
	private const int c = 10;

	// Token: 0x040040F1 RID: 16625
	private const int d = 30;

	// Token: 0x040040F2 RID: 16626
	private new List<string> e;
}
