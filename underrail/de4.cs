using System;
using System.Linq;

// Token: 0x0200087A RID: 2170
public sealed class de4 : el4
{
	// Token: 0x06003572 RID: 13682 RVA: 0x00146D40 File Offset: 0x00144F40
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x06003573 RID: 13683 RVA: 0x00146D4C File Offset: 0x00144F4C
	public override string a4()
	{
		return "Xpbl_DJ";
	}

	// Token: 0x06003574 RID: 13684 RVA: 0x00146D54 File Offset: 0x00144F54
	public override string a5()
	{
		return "Dead Jetters";
	}

	// Token: 0x06003575 RID: 13685 RVA: 0x00146D5C File Offset: 0x00144F5C
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003576 RID: 13686 RVA: 0x00146D60 File Offset: 0x00144F60
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003577 RID: 13687 RVA: 0x00146D64 File Offset: 0x00144F64
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003578 RID: 13688 RVA: 0x00146D6C File Offset: 0x00144F6C
	protected override bool aj0()
	{
		return true;
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x00146D70 File Offset: 0x00144F70
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600357A RID: 13690 RVA: 0x00146D88 File Offset: 0x00144F88
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600357B RID: 13691 RVA: 0x00146D8C File Offset: 0x00144F8C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x0600357C RID: 13692 RVA: 0x00146D94 File Offset: 0x00144F94
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600357D RID: 13693 RVA: 0x00146D98 File Offset: 0x00144F98
	public de4() : base(new string[]
	{
		ega.bp
	})
	{
	}

	// Token: 0x0600357E RID: 13694 RVA: 0x00146DB4 File Offset: 0x00144FB4
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd.Name != null && csd.Name == "randomEvent_xpbl_dj_1")
			{
				c5x c5x = new gx().a(csd, new int?(cuo.a.Next(10, 21)), "Generic_Jetski", "Dead Jet Skier", asp.ar, "", null, true, null, false);
				if (c5x != null && c5x.h.b != null)
				{
					bcx bcx = c5x.h.b.aa().Vehicle;
					if (bcx != null)
					{
						bcx = d06.a(bcx);
						c5x = d06.a(c5x, bcx);
						c5x = bfe.a(c5x, false);
						c5x.h.b.at();
					}
					c5x.h.b.aa().a(null, null, false);
				}
			}
		}
	}
}
