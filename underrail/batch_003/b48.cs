using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020021AE RID: 8622
[bmq("1.0.1.11_AgronomyShroomLabAgain", "1.0.1.11", "StationAlpha-Level8", false)]
public sealed class b48 : fg
{
	// Token: 0x0600C9B1 RID: 51633 RVA: 0x00475A30 File Offset: 0x00473C30
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("3f9e64dc-3b89-48e4-a63a-a521bf06aa72"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("2de12727-1d51-4dac-bc30-d3de2edb70a0"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			if (c5x != null)
			{
				c3g c3g = c5x.GetAspect<c3g>();
				if (c3g == null)
				{
					c3g = new c3g(c5x);
					c5x.SetAspect<c3g>(c3g);
				}
				c3g.d().Clear();
				c3g.d().Add(asp.f);
				d2b aspect = c5x.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(d1c.c);
					aspect.b(true);
					aspect.a(true);
					aspect.a(60);
					aspect.b("key.quintonsKey");
				}
			}
			if (c5x2 != null)
			{
				amc aspect2 = c5x2.GetAspect<amc>();
				if (aspect2 != null)
				{
					if (Enumerable.Sum<d5o>(aspect2.aa().b("key.quintonsKey", 1, false), new Func<d5o, int>(b48.a.a.a)) < 1)
					{
						coh coh = new d48(ez2.CreateDefinitonProvider<a0z>("plot\\quintonsKey"));
						if (coh != null)
						{
							aspect2.aa().Bag.z3(coh, true);
						}
					}
				}
			}
			c5x c5x3 = new ar7(new Guid("d20fadd6-2a82-4161-9dce-58fb97b2a342"), A_1.n("StationAlpha-Level8")).ao() as c5x;
			if (c5x3 != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedHopperTraps", new bool?(false)).Value)
			{
				c7j c7j = c5x3.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh2 = new d48(ez2.CreateDefinitonProvider<c4j>("traps\\hopperTrap"))
					{
						Stacks = 2
					};
					coh coh3 = new acz(ez2.CreateDefinitonProvider<cdk>("Ammo\\TranquilizingBolt"))
					{
						Stacks = 2
					};
					if (coh2 != null)
					{
						c7j.ItemContainer.z3(coh2, true);
					}
					if (coh3 != null)
					{
						c7j.ItemContainer.z3(coh3, true);
					}
					A_0.r()["patch_placedHopperTraps"] = true;
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x020021AF RID: 8623
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C9B5 RID: 51637 RVA: 0x00475CA4 File Offset: 0x00473EA4
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x04004A0F RID: 18959
		public static readonly b48.a a = new b48.a();

		// Token: 0x04004A10 RID: 18960
		public static Func<d5o, int> b;
	}
}
