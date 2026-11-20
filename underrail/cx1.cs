using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020008C5 RID: 2245
public sealed class cx1 : b1s
{
	// Token: 0x060037EA RID: 14314 RVA: 0x0014D354 File Offset: 0x0014B554
	public cx1() : base(4)
	{
	}

	// Token: 0x060037EB RID: 14315 RVA: 0x0014D360 File Offset: 0x0014B560
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
						c5x.h.b.a("ag1");
						return;
					case 2:
						c5x.h.b.a("ag2");
						return;
					case 3:
						c5x.h.b.a("ag_f1");
						c5x.h.b.aa().Gender = Gender.Female;
						return;
					case 4:
						c5x.h.b.a("ag_f2");
						c5x.h.b.aa().Gender = Gender.Female;
						return;
					default:
						c5x.h.b.a("ag1");
						break;
					}
				}
			}
		}
	}
}
