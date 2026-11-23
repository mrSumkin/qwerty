using System;
using System.Collections.Generic;

// Token: 0x02001EBF RID: 7871
[ayj("ShootCaveEarPoisonBolt")]
public sealed class e2v : eyv
{
	// Token: 0x0600B1A9 RID: 45481 RVA: 0x00402C2C File Offset: 0x00400E2C
	public override string y8()
	{
		return "Запустить отравленный болт";
	}

	// Token: 0x0600B1AA RID: 45482 RVA: 0x00402C34 File Offset: 0x00400E34
	public override string os()
	{
		return "ShootCaveEarPoisonBolt";
	}

	// Token: 0x0600B1AB RID: 45483 RVA: 0x00402C3C File Offset: 0x00400E3C
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B1AC RID: 45484 RVA: 0x00402C40 File Offset: 0x00400E40
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B1AD RID: 45485 RVA: 0x00402C44 File Offset: 0x00400E44
	public e2v()
	{
		this.a = new List<string>();
		this.a.Add(d7f.a);
	}

	// Token: 0x0600B1AE RID: 45486 RVA: 0x00402C6C File Offset: 0x00400E6C
	public override string bo(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("SpecialAttacks/ShootCaveEarPoisonBolt", new object[]
		{
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(cl5.d(a_), false)
		});
	}

	// Token: 0x0600B1AF RID: 45487 RVA: 0x00402CD8 File Offset: 0x00400ED8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B1B0 RID: 45488 RVA: 0x00402CE4 File Offset: 0x00400EE4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B1B1 RID: 45489 RVA: 0x00402D18 File Offset: 0x00400F18
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0400412B RID: 16683
	private new List<string> a;
}
