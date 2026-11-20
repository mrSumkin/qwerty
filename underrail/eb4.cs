using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000371 RID: 881
public static class eb4
{
	// Token: 0x0600188C RID: 6284 RVA: 0x0007DD24 File Offset: 0x0007BF24
	public static bool a(amc A_0, amc A_1, float A_2, int A_3 = 18)
	{
		d02 service = bpo.GetService<d02>();
		if (service != null && service.ahg())
		{
			bm6 b = A_0.a8().t.b;
			if (b != null)
			{
				HashSet<r0> hashSet = b.b(service);
				if (hashSet != null)
				{
					HashSet<amc> hashSet2 = avt.a(A_0, A_1, A_2);
					if (hashSet2.Count > 0)
					{
						Vector2 a_ = A_0.a8().aj().b();
						List<amc> list = new List<amc>();
						foreach (amc amc in hashSet2)
						{
							if (!amc.aa().Passive && A_0.a(amc) != h.a)
							{
								r0 r = new r0(amc.a8().Area.c(), amc.a8().aj().a().b());
								if (hashSet.Contains(r) && bnx.a(a_, A_1.a8().aj().b(), amc.a8().aj().b()) <= (double)A_3)
								{
									list.Add(amc);
								}
							}
						}
						return list.Count > 0;
					}
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x0007DE80 File Offset: 0x0007C080
	public static bool IsSafeToThrow<TSkill>(amc thrower, amc target, int range, int radius, cmb acSet, bool checkForPartialObstruction, bool decideBasedOnChance, bool reckless = false, bool applyModifier = true) where TSkill : csn
	{
		if (target != null && target.a8() != null && target.a8().TileFormationModifiers.c(4L))
		{
			return false;
		}
		int num;
		acSet.a(range, out num);
		if (!reckless && num < radius + 1)
		{
			return false;
		}
		if (decideBasedOnChance)
		{
			double num2 = Math.Min(euf.a(thrower.aa(), thrower.aa().Skills.Get<TSkill>().g(), (double)num, applyModifier ? thrower.aa().Offense.aw() : 0.0)[0] * 2.0, 0.9);
			if (cuo.a.NextDouble() > num2)
			{
				return false;
			}
		}
		d02 service = bpo.GetService<d02>();
		if (service != null)
		{
			HashSet<r0> hashSet = null;
			if (target.a8().t.b != null)
			{
				hashSet = target.a8().t.b.b(service);
			}
			ak1 ak = target.a8().Area.a(target.a8().aj().a());
			if (ak != null)
			{
				if (!reckless)
				{
					foreach (d4n d4n in service.ahl())
					{
						if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().Area == thrower.a8().Area && !d4n.b.aa().Passive && d4n.b.aa().FactionId != asp.a3 && thrower.a(d4n.b) != h.a && (hashSet == null || hashSet.Contains(new r0(d4n.b.a8().Area.c(), d4n.b.a8().aj().a().b()))) && aw1.a(d4n.b.a8(), ak) <= (double)(radius + 1))
						{
							return false;
						}
					}
				}
				Point point = acSet.a(num);
				ak1 ak2 = target.a8().Area.b(point.X / 4, point.Y / 4);
				if (ak2 != null)
				{
					if (checkForPartialObstruction)
					{
						bbg bbg = new bbg();
						bbg.a(false);
						bbg.a().Add(new eb4.a(target.a8().Area));
						bbg.a(float.MaxValue);
						bbg.a(true);
						return new exm(bbg, ak.Location.b() + new Vector2(0.5f, 0.5f), ak2.Location.b() + new Vector2(0.5f, 0.5f)).a(null).b();
					}
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x02000372 RID: 882
	private class a : ok
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x0007E1D4 File Offset: 0x0007C3D4
		public a(aud A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0007E1E4 File Offset: 0x0007C3E4
		public bool g5(anl A_0)
		{
			ak1 ak = this.a.a(A_0.d());
			return ak != null && !ak.Formation.c(36L);
		}

		// Token: 0x04000E53 RID: 3667
		private aud a;
	}
}
