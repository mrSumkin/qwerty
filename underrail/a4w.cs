using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000BAD RID: 2989
[euj]
public sealed class a4w
{
	// Token: 0x060043FF RID: 17407 RVA: 0x001AD35C File Offset: 0x001AB55C
	[ayh("XPHWBBJHB")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.h.b != null)
		{
			if (!A_0.h.b.aa().Dead && A_0.h.b.aa().IsInControl)
			{
				if (!A_0.h.b.aa().StatusEffects.a(bd9.a))
				{
					bd9 a_ = new bd9();
					A_0.h.b.aa().StatusEffects.a(a_, false, false, false);
					return;
				}
			}
			else if (A_0.h.b.aa().StatusEffects.a(bd9.a))
			{
				bd9 bd = Enumerable.FirstOrDefault<bd9>(A_0.h.b.aa().StatusEffects.Get<bd9>());
				if (bd != null)
				{
					A_0.h.b.aa().StatusEffects.d(bd);
				}
			}
		}
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x001AD464 File Offset: 0x001AB664
	[ayh("XPHWBBJHBSC")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_0 == null && A_0.h.b == null)
		{
			return;
		}
		bool flag = A_0.h.b.aa().Dead || !A_0.h.b.aa().IsInControl;
		if (!flag)
		{
			if (!A_0.h.b.aa().StatusEffects.a(asu.a))
			{
				asu a_ = new asu();
				A_0.h.b.aa().StatusEffects.a(a_, false, false, false);
			}
		}
		else if (A_0.h.b.aa().StatusEffects.a(asu.a))
		{
			asu asu = Enumerable.FirstOrDefault<asu>(A_0.h.b.aa().StatusEffects.Get<asu>());
			if (asu != null)
			{
				A_0.h.b.aa().StatusEffects.d(asu);
			}
		}
		if (A_0.t.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service == null)
			{
				return;
			}
			List<ak1> list = A_0.t.b.af();
			HashSet<ak1> hashSet;
			if (list != null && list.Count > 0)
			{
				hashSet = new HashSet<ak1>(list);
			}
			else
			{
				hashSet = null;
			}
			foreach (d4n d4n in service.ahl())
			{
				if (d4n.b != null && d4n.b.a8() != null && !d4n.b.aa().Passive && !d4n.b.aa().StatusEffects.a(dlo.a))
				{
					c5x c5x = d4n.b.a8();
					amc b = d4n.b;
					bool flag2 = false;
					if (!flag && hashSet != null && hashSet.Count > 0)
					{
						foreach (ak1 ak in c5x.l)
						{
							if (hashSet.Contains(ak))
							{
								flag2 = true;
								break;
							}
						}
					}
					apk apk = Enumerable.FirstOrDefault<apk>(b.aa().StatusEffects.Get<apk>());
					if (flag2 && A_0.h.b.a(c5x.h.b) == h.a)
					{
						if (apk != null)
						{
							apk.TimeLeft = (double)apk.Duration;
						}
						else
						{
							apk = new apk(new ar7(A_0));
							c5x.h.b.aa().StatusEffects.a(apk, false, false, false);
						}
					}
					else if (apk != null && apk.b != null && apk.b.afk() == A_0)
					{
						b.aa().StatusEffects.d(apk);
					}
				}
			}
		}
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x001AD7D8 File Offset: 0x001AB9D8
	[ayh("XPHWLDTSET")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_2 == null || A_1 == null || A_1.h.b == null || A_1.j != cgy.b || A_1.Area == null)
		{
			return;
		}
		object obj;
		if (A_2.TryGetValue("StatusEffect", out obj))
		{
			apk apk = obj as apk;
			if (apk != null)
			{
				if (apk.b != null)
				{
					c5x c5x = apk.b.afk() as c5x;
					if (c5x != null && c5x.Area == A_1.Area)
					{
						return;
					}
				}
				A_1.h.b.aa().StatusEffects.d(apk);
			}
		}
	}
}
