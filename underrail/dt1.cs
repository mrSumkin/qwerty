using System;
using System.Linq;

// Token: 0x02000872 RID: 2162
public sealed class dt1 : el4
{
	// Token: 0x06003517 RID: 13591 RVA: 0x00146134 File Offset: 0x00144334
	protected override esj a3()
	{
		return new esj(7, 12);
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x00146140 File Offset: 0x00144340
	public override string a4()
	{
		return "Xpbl_DEB";
	}

	// Token: 0x06003519 RID: 13593 RVA: 0x00146148 File Offset: 0x00144348
	public override string a5()
	{
		return "Damaged Explosive Boat";
	}

	// Token: 0x0600351A RID: 13594 RVA: 0x00146150 File Offset: 0x00144350
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x0600351B RID: 13595 RVA: 0x00146154 File Offset: 0x00144354
	public override double ke()
	{
		return e3a.b;
	}

	// Token: 0x0600351C RID: 13596 RVA: 0x0014615C File Offset: 0x0014435C
	protected override bool a7()
	{
		return false;
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x00146160 File Offset: 0x00144360
	protected override bool kf()
	{
		return true;
	}

	// Token: 0x0600351E RID: 13598 RVA: 0x00146164 File Offset: 0x00144364
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(5.0));
	}

	// Token: 0x0600351F RID: 13599 RVA: 0x0014617C File Offset: 0x0014437C
	public override bool a9()
	{
		return true;
	}

	// Token: 0x06003520 RID: 13600 RVA: 0x00146180 File Offset: 0x00144380
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003521 RID: 13601 RVA: 0x00146184 File Offset: 0x00144384
	protected override bool ap5()
	{
		return true;
	}

	// Token: 0x06003522 RID: 13602 RVA: 0x00146188 File Offset: 0x00144388
	public dt1() : base(new string[]
	{
		ega.bh,
		ega.bk,
		ega.bn,
		ega.bz
	})
	{
	}

	// Token: 0x06003523 RID: 13603 RVA: 0x001461B8 File Offset: 0x001443B8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		new apb().b();
	}

	// Token: 0x06003524 RID: 13604 RVA: 0x001461D0 File Offset: 0x001443D0
	protected override void ap6(cyt A_0, c1a A_1)
	{
		if (!this.a6())
		{
			return;
		}
		try
		{
			if (A_1 != null)
			{
				d60 d = A_1.a();
				if (d != null)
				{
					c5x c5x = d.ab5("xpbl_deb_dataSource") as c5x;
					if (c5x != null && c5x.Area != null)
					{
						int num = (int)c5x.Location.X - 4;
						while ((float)num <= c5x.Location.X + 2f)
						{
							int num2 = (int)c5x.Location.Y - 4;
							while ((float)num2 <= c5x.Location.Y + 4f)
							{
								ak1 ak = c5x.Area.b(num, num2);
								if (ak != null)
								{
									foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
									{
										c5x c5x2 = (c5x)b0b;
										if (c5x2.Layer == 1 && c5x2.GetAspect<e1d>() != null)
										{
											c5x2.w();
											c5x2.an();
										}
									}
									foreach (bqt bqt in Enumerable.ToList<bqt>(ak.TriggerProxies))
									{
										avy avy = bqt.Trigger as avy;
										if (avy != null && avy.Area != null)
										{
											avy.o();
										}
									}
								}
								num2++;
							}
							num++;
						}
					}
				}
			}
		}
		catch
		{
		}
	}
}
