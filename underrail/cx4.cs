using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020008C3 RID: 2243
public sealed class cx4 : b1s
{
	// Token: 0x060037E6 RID: 14310 RVA: 0x0014D0B4 File Offset: 0x0014B2B4
	public cx4() : base(1)
	{
	}

	// Token: 0x060037E7 RID: 14311 RVA: 0x0014D0C0 File Offset: 0x0014B2C0
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
				int num = new Random().Next(1, 5);
				if (c5x.h.b != null)
				{
					switch (num)
					{
					case 1:
						c5x.h.b.a("rg1");
						return;
					case 2:
						c5x.h.b.a("rg2");
						return;
					case 3:
						c5x.h.b.a("rg_f1");
						c5x.h.b.aa().Gender = Gender.Female;
						return;
					case 4:
						c5x.h.b.a("rg_f2");
						c5x.h.b.aa().Gender = Gender.Female;
						return;
					default:
						c5x.h.b.a("rg1");
						break;
					}
				}
			}
		}
	}
}
