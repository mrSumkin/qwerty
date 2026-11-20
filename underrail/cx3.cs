using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020008C7 RID: 2247
public sealed class cx3 : b1s
{
	// Token: 0x060037EE RID: 14318 RVA: 0x0014D584 File Offset: 0x0014B784
	public cx3() : base(2)
	{
	}

	// Token: 0x060037EF RID: 14319 RVA: 0x0014D590 File Offset: 0x0014B790
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
