using System;
using System.Collections.Generic;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020005B3 RID: 1459
public sealed class c4b : aje
{
	// Token: 0x060026F5 RID: 9973 RVA: 0x000E2F98 File Offset: 0x000E1198
	public c4b(dka A_0)
	{
		czh.a(A_0, "localeController");
		this.a = A_0;
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x000E2FC0 File Offset: 0x000E11C0
	public void a(e6d A_0)
	{
		if (this.b.Count > 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			TimeSpan a_ = TimeSpan.FromMilliseconds((double)serviceOrThrow.aq1().b().w().a());
			TimeSpan a_2 = TimeSpan.FromMilliseconds((double)serviceOrThrow.aq1().b().w().b());
			List<b0b> list = new List<b0b>();
			foreach (KeyValuePair<b0b, cmh> keyValuePair in this.b)
			{
				if (keyValuePair.Value.a(A_0.a().TotalGameTime, a_, a_2))
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (b0b key in list)
			{
				this.b.Remove(key);
			}
		}
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000E30E0 File Offset: 0x000E12E0
	public void aiz(b0b A_0, c3r A_1)
	{
		if (A_1 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			c5x c5x = A_0 as c5x;
			if (c5x == null)
			{
				return;
			}
			ScrollingCombatTextOptions scrollingCombatTextOptions;
			if (c5x.c(e2b.d))
			{
				scrollingCombatTextOptions = serviceOrThrow.aq1().b().w().d();
			}
			else if (this.a.ak1() == c5x)
			{
				scrollingCombatTextOptions = serviceOrThrow.aq1().b().w().g();
			}
			else
			{
				scrollingCombatTextOptions = serviceOrThrow.aq1().b().w().e();
			}
			if ((scrollingCombatTextOptions & A_1.sj()) == A_1.sj())
			{
				cmh cmh = this.ai0(A_0);
				if (cmh == null)
				{
					cmh = this.a(A_0);
				}
				cmh.a(A_1);
			}
		}
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000E31A0 File Offset: 0x000E13A0
	public cmh ai0(b0b A_0)
	{
		if (A_0 != null)
		{
			cmh result;
			this.b.TryGetValue(A_0, out result);
			return result;
		}
		return null;
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000E31C8 File Offset: 0x000E13C8
	public void ai1(b0b A_0)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.Area != null && c5x.Area.Zone != null)
		{
			cmh cmh;
			this.b.TryGetValue(A_0, out cmh);
			if (cmh != null)
			{
				c5x c5x2 = new c5x();
				c5x2.q("SCT placeholder");
				c5x2.Layer = aju.x;
				c5x2.Size = c5x.Size;
				c5x2.Location = c5x.Location;
				c5x2.ae = new float?(0f);
				dwt dwt = new dwt(c5x2);
				c5x2.SetAspect<dwt>(dwt);
				if (c5x.h.b != null && !c5x.h.b.a7())
				{
					c5x2.SetAspect<cd0>(new cd0(c5x2)
					{
						a = "Creatures\\" + c5x.h.b.g.a[CharacterState.Idle].b
					});
					if (c5x.h.b.g.f != 0)
					{
						dwt.a = new int?(c5x.h.b.g.f);
					}
				}
				else if (c5x.p.b != null)
				{
					alv alv = new alv(c5x2);
					foreach (cd0 cd in c5x.p.b.a)
					{
						alv.a(new cd0(c5x2)
						{
							a = cd.a
						});
					}
					c5x2.SetAspect<alv>(alv);
				}
				else if (c5x.o.b != null)
				{
					c5x2.SetAspect<cd0>(new cd0(c5x2)
					{
						a = c5x.o.b.a
					});
				}
				A_0.Area.a(c5x2);
				cmh.a(c5x2);
				this.b.Remove(c5x);
				this.b.Add(c5x2, cmh);
				A_0.Area.Zone.ActionManager.g9(new c7(c5x2, true, false, true, false), atp.a);
			}
		}
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x000E3420 File Offset: 0x000E1620
	private cmh a(b0b A_0)
	{
		cmh cmh = new cmh(A_0);
		this.b[A_0] = cmh;
		return cmh;
	}

	// Token: 0x04001639 RID: 5689
	private dka a;

	// Token: 0x0400163A RID: 5690
	private Dictionary<b0b, cmh> b = new Dictionary<b0b, cmh>();
}
