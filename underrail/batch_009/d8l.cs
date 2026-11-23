using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x0200035A RID: 858
public sealed class d8l : d24
{
	// Token: 0x0600182D RID: 6189 RVA: 0x0007A9B4 File Offset: 0x00078BB4
	public override abg f7()
	{
		amc amc = new bzv(base.b().c().y6()).g();
		if (amc != null)
		{
			Point point;
			Point point2;
			amc.a8().a(out point, out point2);
			int num = 0;
			HashSet<Guid> hashSet = new HashSet<Guid>();
			for (int i = point.Y - 1; i <= point.Y + 1; i++)
			{
				for (int j = point.X - 1; j <= point.X + 1; j++)
				{
					ak1 ak = amc.a8().Area.b(j, i);
					if (ak != null)
					{
						foreach (b0b b0b in ak.Entities)
						{
							c5x c5x = (c5x)b0b;
							if (!hashSet.Contains(c5x.qe()) && c5x.h.b != null)
							{
								if (c5x.h.b != base.b().g() && c5x.h.b != amc && c5x.h.b.aa().FactionId == base.b().g().aa().FactionId && (c5x.s() - amc.a8().s()).Length() < 1.25f)
								{
									num++;
								}
								hashSet.Add(c5x.qe());
							}
						}
					}
				}
			}
			cwa cwa = Enumerable.FirstOrDefault<cwa>(base.b().g().aa().StatusEffects.Get<cwa>());
			if (num == 0)
			{
				if (cwa != null)
				{
					base.b().g().aa().StatusEffects.d(cwa);
				}
			}
			else if (cwa != null)
			{
				cwa.Stacks = Math.Min(num, cwa.MaxStacks);
				cwa.TargetId = amc.a8().qe();
				cwa.ad();
			}
			else
			{
				cwa = new cwa(amc.a8().qe(), d0u.b * 2);
				cwa.Stacks = Math.Min(num, cwa.MaxStacks);
				base.b().g().aa().StatusEffects.a(cwa, false, false, false);
			}
		}
		base.b().g().aa().bl();
		return base.f7();
	}
}
