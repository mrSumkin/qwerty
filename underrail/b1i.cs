using System;
using System.Linq;

// Token: 0x020008C4 RID: 2244
public sealed class b1i : b1s
{
	// Token: 0x060037E8 RID: 14312 RVA: 0x0014D1E4 File Offset: 0x0014B3E4
	public b1i() : base(3)
	{
	}

	// Token: 0x060037E9 RID: 14313 RVA: 0x0014D1F0 File Offset: 0x0014B3F0
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		d60 addon = A_1.GetAddon<d60>();
		if (addon != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab6(new string[]
			{
				"mugger",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				int num = new Random().Next(1, 9);
				if (c5x.h.b != null)
				{
					switch (num)
					{
					case 1:
						c5x.h.b.a("brw1");
						return;
					case 2:
						c5x.h.b.a("brw2");
						return;
					case 3:
						c5x.h.b.a("wrk1");
						return;
					case 4:
						c5x.h.b.a("wrk2");
						return;
					case 5:
						c5x.h.b.a("punk1");
						return;
					case 6:
						c5x.h.b.a("punk2");
						return;
					case 7:
						c5x.h.b.a("ft1");
						return;
					case 8:
						c5x.h.b.a("ft2");
						return;
					default:
						c5x.h.b.a("brw2");
						break;
					}
				}
			}
		}
	}
}
