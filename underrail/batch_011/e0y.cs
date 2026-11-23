using System;
using System.Linq;

// Token: 0x0200087B RID: 2171
public sealed class e0y : el4
{
	// Token: 0x0600357F RID: 13695 RVA: 0x00146EE0 File Offset: 0x001450E0
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x06003580 RID: 13696 RVA: 0x00146EEC File Offset: 0x001450EC
	public override string a4()
	{
		return "Xpbl_AJ";
	}

	// Token: 0x06003581 RID: 13697 RVA: 0x00146EF4 File Offset: 0x001450F4
	public override string a5()
	{
		return "Abandoned Jets";
	}

	// Token: 0x06003582 RID: 13698 RVA: 0x00146EFC File Offset: 0x001450FC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003583 RID: 13699 RVA: 0x00146F00 File Offset: 0x00145100
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x06003584 RID: 13700 RVA: 0x00146F08 File Offset: 0x00145108
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003585 RID: 13701 RVA: 0x00146F0C File Offset: 0x0014510C
	protected override bool aj0()
	{
		return true;
	}

	// Token: 0x06003586 RID: 13702 RVA: 0x00146F10 File Offset: 0x00145110
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003587 RID: 13703 RVA: 0x00146F28 File Offset: 0x00145128
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003588 RID: 13704 RVA: 0x00146F2C File Offset: 0x0014512C
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x06003589 RID: 13705 RVA: 0x00146F34 File Offset: 0x00145134
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600358A RID: 13706 RVA: 0x00146F38 File Offset: 0x00145138
	public e0y() : base(new string[]
	{
		ega.bp
	})
	{
	}

	// Token: 0x0600358B RID: 13707 RVA: 0x00146F54 File Offset: 0x00145154
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"abandonedJet",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				wv wv = c5x.GetAspect<bim>() as wv;
				if (wv != null)
				{
					int num = cuo.a.Next(0, 101);
					bcx bcx;
					if (num <= 40)
					{
						bcx = new d1w().x4();
					}
					else if (num > 40 && num <= 80)
					{
						bcx = new bh6().x4();
					}
					else if (num > 80 && num <= 90)
					{
						bcx = new cjl().x4();
					}
					else
					{
						bcx = new b44().x4();
					}
					wv.a(d06.a(bcx));
					wv.d();
					c5x = d06.a(c5x, bcx);
				}
			}
		}
	}
}
