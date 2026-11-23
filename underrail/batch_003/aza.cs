using System;

// Token: 0x020007F0 RID: 2032
public sealed class aza : el4
{
	// Token: 0x0600331D RID: 13085 RVA: 0x0013E860 File Offset: 0x0013CA60
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x0600331E RID: 13086 RVA: 0x0013E86C File Offset: 0x0013CA6C
	public override string a4()
	{
		return "LUX_LEP";
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x0013E874 File Offset: 0x0013CA74
	public override string a5()
	{
		return "Luperchaun";
	}

	// Token: 0x06003320 RID: 13088 RVA: 0x0013E87C File Offset: 0x0013CA7C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!base.e2(A_0, A_1, A_2))
		{
			return false;
		}
		DateTime t = new DateTime(DateTime.Now.Year, 3, 10);
		DateTime t2 = new DateTime(DateTime.Now.Year, 3, 24);
		return DateTime.Today >= t && DateTime.Today <= t2;
	}

	// Token: 0x06003321 RID: 13089 RVA: 0x0013E8E4 File Offset: 0x0013CAE4
	public override double ke()
	{
		return e3a.e;
	}

	// Token: 0x06003322 RID: 13090 RVA: 0x0013E8EC File Offset: 0x0013CAEC
	protected override int? g2()
	{
		return new int?(12);
	}

	// Token: 0x06003323 RID: 13091 RVA: 0x0013E8F8 File Offset: 0x0013CAF8
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003324 RID: 13092 RVA: 0x0013E8FC File Offset: 0x0013CAFC
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003325 RID: 13093 RVA: 0x0013E900 File Offset: 0x0013CB00
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x06003326 RID: 13094 RVA: 0x0013E918 File Offset: 0x0013CB18
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003327 RID: 13095 RVA: 0x0013E91C File Offset: 0x0013CB1C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003328 RID: 13096 RVA: 0x0013E920 File Offset: 0x0013CB20
	public aza() : base(new string[]
	{
		ega.d
	})
	{
	}

	// Token: 0x06003329 RID: 13097 RVA: 0x0013E938 File Offset: 0x0013CB38
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.a(new bw0("lux-lep", new evv(new c2w(A_1.y8(), "randomEvent_lux_lep_exit"), "ladder"), 1));
	}
}
