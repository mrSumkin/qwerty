using System;
using System.Collections.Generic;

// Token: 0x02001EC9 RID: 7881
[ayj("ShootTranquilizingBolt")]
public sealed class b43 : eyv
{
	// Token: 0x0600B235 RID: 45621 RVA: 0x00404264 File Offset: 0x00402464
	public override string y8()
	{
		return "Выстрел усыпляющим болтом";
	}

	// Token: 0x0600B236 RID: 45622 RVA: 0x0040426C File Offset: 0x0040246C
	public override string os()
	{
		return "ShootTranquilizingBolt";
	}

	// Token: 0x0600B237 RID: 45623 RVA: 0x00404274 File Offset: 0x00402474
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B238 RID: 45624 RVA: 0x00404278 File Offset: 0x00402478
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B239 RID: 45625 RVA: 0x0040427C File Offset: 0x0040247C
	public b43()
	{
		this.c = new List<string>();
		this.c.Add(d7f.a);
		this.c.Add("SAt.ShootTranquilizingBolt");
	}

	// Token: 0x0600B23A RID: 45626 RVA: 0x004042B0 File Offset: 0x004024B0
	public override string bo(cnm A_0)
	{
		coh a_ = (A_0 != null) ? (A_0.b9() as coh) : null;
		return qv.a("SpecialAttacks/ShootTranquilizingBolt", new object[]
		{
			(int)(b43.a() * 100.0),
			b43.b(a_)
		});
	}

	// Token: 0x0600B23B RID: 45627 RVA: 0x0040430C File Offset: 0x0040250C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B23C RID: 45628 RVA: 0x00404318 File Offset: 0x00402518
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		list.Add(new cfd("SAt.ShootTranquilizingBolt", b43.b, false, false));
		return list;
	}

	// Token: 0x0600B23D RID: 45629 RVA: 0x00404364 File Offset: 0x00402564
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600B23E RID: 45630 RVA: 0x00404370 File Offset: 0x00402570
	public static int b(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("MaxDuration", new int?(1)).Value;
		}
		return 1;
	}

	// Token: 0x0600B23F RID: 45631 RVA: 0x004043A8 File Offset: 0x004025A8
	public new static int a(coh A_0)
	{
		if (A_0 != null)
		{
			return A_0.Definition.a7().GetPrimitivePropertyValue<int>("TranquilizerPower", new int?(0)).Value;
		}
		return 0;
	}

	// Token: 0x0600B240 RID: 45632 RVA: 0x004043E0 File Offset: 0x004025E0
	public static double a()
	{
		return 0.25;
	}

	// Token: 0x0400414A RID: 16714
	private new const string a = "SAt.ShootTranquilizingBolt";

	// Token: 0x0400414B RID: 16715
	public static readonly int b = 60000;

	// Token: 0x0400414C RID: 16716
	private List<string> c;
}
