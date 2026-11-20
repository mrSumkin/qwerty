using System;
using System.Linq;

// Token: 0x02000809 RID: 2057
public abstract class ev5 : el4
{
	// Token: 0x060033EE RID: 13294 RVA: 0x00142574 File Offset: 0x00140774
	protected override esj a3()
	{
		return this.b;
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x0014257C File Offset: 0x0014077C
	public override string a4()
	{
		return "Xpbl_GE_TRMCH_" + this.a;
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x00142590 File Offset: 0x00140790
	public override string a5()
	{
		return "Traveling Merchant " + this.a;
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x001425A4 File Offset: 0x001407A4
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && am9.d();
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x001425C4 File Offset: 0x001407C4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x001425C8 File Offset: 0x001407C8
	protected override int? au5()
	{
		return new int?(10);
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x001425D4 File Offset: 0x001407D4
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x060033F5 RID: 13301 RVA: 0x001425DC File Offset: 0x001407DC
	public override double ke()
	{
		return 0.05;
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x001425E8 File Offset: 0x001407E8
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(30.0));
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x00142600 File Offset: 0x00140800
	public ev5(string A_0, esj A_1, string[] A_2) : base(A_2)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x0014261C File Offset: 0x0014081C
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"merchant",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				c5x = d06.a(c5x, false);
				A_0.r()["npc_random_travelingMerchant_met"] = false;
				if (A_2.e() != null)
				{
					c5x.VisualDirection = A_2.e().Value;
				}
			}
		}
	}

	// Token: 0x04001B7B RID: 7035
	private new string a;

	// Token: 0x04001B7C RID: 7036
	private esj b;
}
