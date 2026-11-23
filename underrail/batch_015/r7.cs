using System;
using Microsoft.Xna.Framework;

// Token: 0x02001259 RID: 4697
public sealed class r7 : a7o
{
	// Token: 0x0600658D RID: 25997 RVA: 0x002B3AAC File Offset: 0x002B1CAC
	public r7()
	{
		this.a = new bjp();
		this.a.c(new byte[]
		{
			2,
			5,
			1
		});
	}

	// Token: 0x0600658E RID: 25998 RVA: 0x002B3AE0 File Offset: 0x002B1CE0
	public e0b kn(aud A_0, b0b A_1, b0b A_2, amu A_3)
	{
		c5x c5x = A_1 as c5x;
		c5x c5x2 = A_2 as c5x;
		if (c5x != null && c5x.h.b != null && c5x2 != null && c5x2.h.b != null)
		{
			bool flag = c5x.IsPlayer || c5x2.IsPlayer;
			if (!flag && c5x.h.b.aa().FactionId != c5x2.h.b.aa().FactionId && (c5x.h.b.a(c5x2.h.b) != h.e || c5x2.h.b.a(c5x.h.b) != h.e))
			{
				flag = true;
			}
			if ((c5x.h.b.aa().b(d8o.u) && c5x2.IsPlayer) || (c5x2.h.b.aa().b(d8o.u) && c5x.IsPlayer))
			{
				flag = false;
			}
			if (flag)
			{
				c5x c5x3 = null;
				if (c5x.h.b.aa().SpecialStates.g && c5x.h.b.@as())
				{
					c5x3 = c5x;
				}
				else if (c5x2.h.b.aa().SpecialStates.g && c5x2.h.b.@as())
				{
					c5x3 = c5x2;
				}
				c5x.h.b.u();
				c5x2.h.b.u();
				if (c5x3 != null)
				{
					vr a_ = new vr(null, null, "Вы столкнулись с другим персонажем и вышли из режим скрытности.", new Color?(adi.i), null);
					bey.a(a_, c5x3.h.b.aa(), c5x3.h.b);
					a7v.a(a_);
					bmj.a(c5x3, new d53("Столкновение!", adi.i, null, false));
				}
			}
		}
		return e0b.b;
	}

	// Token: 0x0600658F RID: 25999 RVA: 0x002B3D0C File Offset: 0x002B1F0C
	public e0b ko(aud A_0, b0b A_1, ak1 A_2, amu A_3)
	{
		c5x c5x = A_1 as c5x;
		bool flag;
		if (c5x != null && c5x.k.b != null && c5x.k.b.d)
		{
			flag = A_2.Formation.c(1L);
		}
		else if (c5x != null && c5x.h.b != null && c5x.h.b.aa().b(d8o.l))
		{
			flag = (!A_2.Formation.c(64L) || A_2.Formation.c(262308L));
		}
		else if (c5x != null && c5x.h.b != null && c5x.h.b.aa().b(d8o.n))
		{
			flag = (!A_2.Formation.c(524352L) || A_2.Formation.c(262308L));
		}
		else
		{
			flag = (A_2.Formation.c(4L) || A_2.Formation.c(32L) || (A_2.Formation.c(2L) && !A_2.Formation.c(128L)));
		}
		if (flag)
		{
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.u();
				foreach (b0b b0b in A_2.c.Values)
				{
					c5x c5x2 = (c5x)b0b;
					if (c5x2.h.b != null)
					{
						c5x2.h.b.u();
					}
				}
			}
			return e0b.b;
		}
		return e0b.c;
	}

	// Token: 0x06006590 RID: 26000 RVA: 0x002B3F20 File Offset: 0x002B2120
	public bjp kp(b0b A_0)
	{
		if (A_0.z != null)
		{
			return this.a;
		}
		return null;
	}

	// Token: 0x06006591 RID: 26001 RVA: 0x002B3F3C File Offset: 0x002B213C
	public bool? kq(b0b A_0)
	{
		return null;
	}

	// Token: 0x04002A43 RID: 10819
	private bjp a;
}
