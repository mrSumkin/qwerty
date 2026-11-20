using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001EC3 RID: 7875
[ayj("ShootShockBolt")]
public sealed class ers : eyv
{
	// Token: 0x0600B1D2 RID: 45522 RVA: 0x00403188 File Offset: 0x00401388
	public override string y8()
	{
		return "Выстрел электрошоковым болтом";
	}

	// Token: 0x0600B1D3 RID: 45523 RVA: 0x00403190 File Offset: 0x00401390
	public override string os()
	{
		return "ShootShockBolt";
	}

	// Token: 0x0600B1D4 RID: 45524 RVA: 0x00403198 File Offset: 0x00401398
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1D5 RID: 45525 RVA: 0x0040319C File Offset: 0x0040139C
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1D6 RID: 45526 RVA: 0x004031A0 File Offset: 0x004013A0
	public ers()
	{
		this.f = new List<string>();
		this.f.Add(d7f.a);
	}

	// Token: 0x0600B1D7 RID: 45527 RVA: 0x004031C4 File Offset: 0x004013C4
	public override string bo(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B1D8 RID: 45528 RVA: 0x004031CC File Offset: 0x004013CC
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
		a1q a1q = ers.a((A_0 != null) ? A_0.b8() : null, a_);
		a1q a1q2 = ers.b((A_0 != null) ? A_0.b8() : null, a_);
		return qv.a("SpecialAttacks/ShootShockBolt", new object[]
		{
			a1q.a(true),
			l4.a(ers.a, false),
			a1q2.a(true)
		});
	}

	// Token: 0x0600B1D9 RID: 45529 RVA: 0x0040326C File Offset: 0x0040146C
	public static a1q b(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Electricity, (int)(num * (double)(3 * A_1) / 2.0), (int)(num * (double)(15 + 18 * A_1) / 2.0));
	}

	// Token: 0x0600B1DA RID: 45530 RVA: 0x004032DC File Offset: 0x004014DC
	public static a1q a(efk A_0, int A_1)
	{
		double num = 1.0;
		if (A_0 != null && A_0.Feats.Contains<ceu>())
		{
			num += ceu.a + (double)A_0.GetSpecializationValue<ar6>(true) * ar6.a;
		}
		return new a1q(DamageType.Electricity, (int)(num * (double)(3 * A_1)), (int)(num * (double)(15 + 18 * A_1)));
	}

	// Token: 0x0600B1DB RID: 45531 RVA: 0x00403338 File Offset: 0x00401538
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1DC RID: 45532 RVA: 0x0040336C File Offset: 0x0040156C
	public override IList<string> bi()
	{
		return this.f;
	}

	// Token: 0x0400413C RID: 16700
	public new static readonly int a = 1;

	// Token: 0x0400413D RID: 16701
	private const int b = 0;

	// Token: 0x0400413E RID: 16702
	private const int c = 15;

	// Token: 0x0400413F RID: 16703
	private const int d = 3;

	// Token: 0x04004140 RID: 16704
	private new const int e = 18;

	// Token: 0x04004141 RID: 16705
	private List<string> f;
}
