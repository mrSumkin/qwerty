using System;
using System.Linq;

// Token: 0x02000842 RID: 2114
public abstract class dxp : el4
{
	// Token: 0x06003485 RID: 13445 RVA: 0x0014366C File Offset: 0x0014186C
	protected override esj a3()
	{
		return new esj(1, 1);
	}

	// Token: 0x06003486 RID: 13446 RVA: 0x00143678 File Offset: 0x00141878
	public override string a4()
	{
		return "LC_FLOAT_" + this.b + this.a.ToString();
	}

	// Token: 0x06003487 RID: 13447 RVA: 0x00143698 File Offset: 0x00141898
	public override string a5()
	{
		return "Floating Lost Container " + this.b + this.a.ToString();
	}

	// Token: 0x06003488 RID: 13448 RVA: 0x001436B8 File Offset: 0x001418B8
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x06003489 RID: 13449 RVA: 0x001436BC File Offset: 0x001418BC
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600348A RID: 13450 RVA: 0x001436C0 File Offset: 0x001418C0
	protected override TimeSpan? a8()
	{
		return null;
	}

	// Token: 0x0600348B RID: 13451 RVA: 0x001436D8 File Offset: 0x001418D8
	public override bool a9()
	{
		return true;
	}

	// Token: 0x0600348C RID: 13452 RVA: 0x001436DC File Offset: 0x001418DC
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600348D RID: 13453 RVA: 0x001436E0 File Offset: 0x001418E0
	protected dxp(int A_0, string A_1) : base(new string[]
	{
		ega.k
	})
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x00143704 File Offset: 0x00141904
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2);
	}

	// Token: 0x0600348F RID: 13455 RVA: 0x00143718 File Offset: 0x00141918
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 d = A_1.a();
		if (d != null && this.b == "EBOX")
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"Box",
				base.c()
			})) as c5x;
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"Погружение",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				bfc bfc = A_0.h();
				if (bfc != null)
				{
					c5x = d06.a(c5x, bfc);
				}
				ak1 ak = Enumerable.FirstOrDefault<ak1>(c5x.l);
				alv aspect = c5x.GetAspect<alv>();
				if (ak != null)
				{
					if (aspect != null && aspect.a[1] != null)
					{
						aspect.a[1].b.Y = ((boj.c(ak) == "Dirty") ? 1 : 2);
					}
					if (c5x2 != null)
					{
						etz etz = c5x2.GetAspect<cd0>() as etz;
						if (etz != null)
						{
							int value = cuo.a.Next(1, 4) * 200;
							etz.b.Y = (((boj.c(ak) == "Dirty") > false) ? 1 : 0);
							etz.c(new int?(value));
							if (aspect != null)
							{
								foreach (cd0 cd in aspect.a)
								{
									etz etz2 = (etz)cd;
									if (etz2 != null)
									{
										etz2.c(new int?(value));
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x04001B85 RID: 7045
	private new int a;

	// Token: 0x04001B86 RID: 7046
	private string b;
}
