using System;
using System.Collections.Generic;

// Token: 0x02001EC6 RID: 7878
[ayj("ShootPutrefyingBolt")]
public sealed class d8m : eyv
{
	// Token: 0x0600B207 RID: 45575 RVA: 0x00403C70 File Offset: 0x00401E70
	public override string y8()
	{
		return "Выстрел разлагающим болтом";
	}

	// Token: 0x0600B208 RID: 45576 RVA: 0x00403C78 File Offset: 0x00401E78
	public override string os()
	{
		return "ShootPutrefyingBolt";
	}

	// Token: 0x0600B209 RID: 45577 RVA: 0x00403C80 File Offset: 0x00401E80
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B20A RID: 45578 RVA: 0x00403C84 File Offset: 0x00401E84
	public override int ct()
	{
		return 2;
	}

	// Token: 0x0600B20B RID: 45579 RVA: 0x00403C88 File Offset: 0x00401E88
	public d8m()
	{
		this.b = new List<string>();
		this.b.Add(d7f.a);
		this.b.Add("SAt.ShootPutrefyingBolt");
	}

	// Token: 0x0600B20C RID: 45580 RVA: 0x00403CBC File Offset: 0x00401EBC
	public override string bo(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		return qv.a("SpecialAttacks/ShootPutrefyingBolt", new object[]
		{
			(int)(d8m.a() * 100.0)
		});
	}

	// Token: 0x0600B20D RID: 45581 RVA: 0x00403CF4 File Offset: 0x00401EF4
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B20E RID: 45582 RVA: 0x00403D00 File Offset: 0x00401F00
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B20F RID: 45583 RVA: 0x00403D34 File Offset: 0x00401F34
	public override IList<string> bi()
	{
		return this.b;
	}

	// Token: 0x0600B210 RID: 45584 RVA: 0x00403D3C File Offset: 0x00401F3C
	public static double a()
	{
		return 0.5;
	}

	// Token: 0x04004143 RID: 16707
	private new const string a = "SAt.ShootPutrefyingBolt";

	// Token: 0x04004144 RID: 16708
	private List<string> b;
}
