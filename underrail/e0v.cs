using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200080C RID: 2060
public abstract class e0v : el4
{
	// Token: 0x060033FD RID: 13309 RVA: 0x00142780 File Offset: 0x00140980
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x0014278C File Offset: 0x0014098C
	public override string a4()
	{
		return "DB_MT" + this.a.ToString();
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x001427A4 File Offset: 0x001409A4
	public override string a5()
	{
		return "Dead Mutie " + this.a.ToString();
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x001427BC File Offset: 0x001409BC
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x001427C0 File Offset: 0x001409C0
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x001427C8 File Offset: 0x001409C8
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x001427E0 File Offset: 0x001409E0
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x001427E4 File Offset: 0x001409E4
	public e0v(int A_0) : base(new string[]
	{
		ega.m
	})
	{
		this.a = A_0;
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x00142804 File Offset: 0x00140A04
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"deadBody",
				base.c()
			})) as c5x;
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"blood",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				cd0 aspect = c5x.GetAspect<cd0>();
				if (aspect != null)
				{
					string[] array = new string[]
					{
						"mgh1",
						"mgh2",
						"mgh3",
						"mgh_f1"
					};
					string arg = array[cuo.a.Next(array.Length)];
					aspect.a = string.Format("Creatures\\{0}\\di", arg);
					aspect.b = new Point(aspect.b.X, cuo.a.Next(8));
					if (c5x2 != null)
					{
						int x = cuo.a.Next(0, 3);
						c5x2.o.b.b.X = x;
					}
				}
			}
		}
	}

	// Token: 0x04001B7F RID: 7039
	private new int a;
}
