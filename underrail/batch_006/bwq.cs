using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200085F RID: 2143
public sealed class bwq : el4
{
	// Token: 0x060034DA RID: 13530 RVA: 0x0014499C File Offset: 0x00142B9C
	public override bool fk()
	{
		return true;
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x001449A0 File Offset: 0x00142BA0
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x060034DC RID: 13532 RVA: 0x001449AC File Offset: 0x00142BAC
	public override string a4()
	{
		return "HLW_LRK1";
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x001449B4 File Offset: 0x00142BB4
	public override string a5()
	{
		return "Halloween - Lurkers 1";
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x001449C0 File Offset: 0x00142BC0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		if (!base.e2(A_0, A_1, A_2))
		{
			return false;
		}
		DateTime t = new DateTime(DateTime.Now.Year, 10, 24);
		DateTime t2 = new DateTime(DateTime.Now.Year, 11, 14);
		return DateTime.Today >= t && DateTime.Today <= t2;
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00144A2C File Offset: 0x00142C2C
	public override double ke()
	{
		return e3a.e;
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x00144A34 File Offset: 0x00142C34
	protected override int? g2()
	{
		return new int?(12);
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x00144A40 File Offset: 0x00142C40
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x00144A44 File Offset: 0x00142C44
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(120.0));
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00144A5C File Offset: 0x00142C5C
	public bwq() : base(new string[]
	{
		ega.a,
		ega.g,
		ega.e
	})
	{
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x00144A84 File Offset: 0x00142C84
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_hlw_lrk1_guard", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
			if (csd != null && csd.Name.StartsWith("randomEvent_hlw_lrk1_dog", StringComparison.OrdinalIgnoreCase))
			{
				list2.Add(csd);
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x c5x = gx.a(list[i], new int?(17), "Lurkers", null, null, null, null, false, null, false);
				if (c5x != null)
				{
					if (c5x.t.b != null)
					{
						c5x.t.b.y6()[ddq.w] = CharacterState.Operating;
						c5x.t.b.b("rnd_feastingLurkers");
						c5x.t.b.y6()[ddq.x] = 100 + cuo.a.Next(-5, 6);
					}
					if (c5x.h.b != null)
					{
						c5x.h.b.aa().Bag.z3(new d48(ez2.CreateDefinitonProvider<a3e>("Consumables\\Food\\MysteryCandy")), true);
					}
					a6p aspect = c5x.GetAspect<a6p>();
					if (aspect != null)
					{
						aspect.d().Add("-ai");
						aspect.d().Add("-inventory");
						aspect.d().Add("-gear");
					}
					this.iy(c5x);
				}
			}
		}
		if (Enumerable.Any<csd>(list2))
		{
			Random random = new Random();
			for (int j = 0; j < list2.Count; j++)
			{
				if (list2[j] != null && random.Next(0, 101) > 40)
				{
					if (dk2.b("xpbl"))
					{
						c5x a_ = gx.a(list2[j], "lu_lurkers_dogs", "Pitbull", null, false, null);
						this.iy(a_);
					}
					else
					{
						c5x a_2 = gx.a(list2[j], "lu_lurkers_dogs", "Dog", null, false, null);
						this.iy(a_2);
					}
				}
			}
		}
	}
}
