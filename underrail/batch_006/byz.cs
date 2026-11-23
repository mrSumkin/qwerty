using System;
using System.Linq;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020008C6 RID: 2246
public sealed class byz : b1s
{
	// Token: 0x060037EC RID: 14316 RVA: 0x0014D484 File Offset: 0x0014B684
	public byz() : base(5)
	{
	}

	// Token: 0x060037ED RID: 14317 RVA: 0x0014D490 File Offset: 0x0014B690
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
				int num = new Random().Next(1, 4);
				if (c5x.h.b != null)
				{
					switch (num)
					{
					case 1:
						c5x.h.b.a("drifter");
						return;
					case 2:
						c5x.h.b.a("og1");
						return;
					case 3:
						c5x.h.b.a("og2");
						c5x.h.b.aa().Gender = Gender.Female;
						return;
					default:
						c5x.h.b.a("drifter");
						break;
					}
				}
			}
		}
	}
}
