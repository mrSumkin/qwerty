using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020014EE RID: 5358
[eiz("TK00")]
[Serializable]
public abstract class bp7 : a6k, ISerializable
{
	// Token: 0x06007842 RID: 30786 RVA: 0x00325F20 File Offset: 0x00324120
	protected bp7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007843 RID: 30787 RVA: 0x00325F2C File Offset: 0x0032412C
	public bp7()
	{
	}

	// Token: 0x06007844 RID: 30788 RVA: 0x00325F38 File Offset: 0x00324138
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.Zone == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		List<c5x> list = new List<c5x>();
		list.Add(c5x);
		if (base.vg().e().b8().Feats.Contains<d1d>() && (base.vg().e().b9() as coh).Stacks >= 2)
		{
			aq8 aq = Enumerable.FirstOrDefault<aq8>(Enumerable.Where<aq8>(Enumerable.OfType<aq8>(base.vg().ad()), new Func<aq8, bool>(bp7.a.a.a)));
			if (aq != null)
			{
				e71 e = aq.Validator as e71;
				if (e != null && e.LastImprintedNodes != null)
				{
					HashSet<amc> hashSet = bp7.a(base.vg().q().h.b, c5x.h.b, base.vg().e().c(null));
					if (hashSet.Count > 0)
					{
						Vector2 a_ = base.vg().q().aj().b();
						SortedList<double, amc> sortedList = new SortedList<double, amc>();
						foreach (amc amc in hashSet)
						{
							if (e.LastImprintedNodes.Contains(amc.a8().aj().a()))
							{
								double num = aw1.b(base.vg().q(), amc.a8());
								double num2 = bnx.a(a_, c5x.aj().b(), amc.a8().aj().b());
								double num3 = aw1.b(c5x, amc.a8());
								if (!sortedList.ContainsKey(num3) && num3 <= 2.0 && num <= (double)(base.vg().e().c(null) + 1f) && num2 <= 30.0)
								{
									sortedList.Add(num3, amc);
								}
							}
						}
						if (sortedList.Count > 0)
						{
							list.Add(sortedList.Values[0].a8());
							base.vg().e().a(true);
						}
					}
				}
			}
		}
		foreach (c5x c5x2 in list)
		{
			cwt cwt = new cwt();
			double num4 = 1.0;
			if (base.vg().e().b8().Feats.Contains<zf>() && !c5x2.h.b.aa().Passive && !c5x2.h.b.aa().b(d8o.e))
			{
				double num5 = zf.a(base.vg().e().b8(), c5x2.h.b.aa(), ref cwt.a);
				num4 += num5;
			}
			double val = aw1.b(base.vg().q(), c5x2);
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			b0b b0b = null;
			dvv item = es2.a(base.vg().q(), c5x2, "ThrowingKnife", 0.5f, null, out b0b, true, 0.5f);
			double a_2 = 0.0;
			ea3 microfeat = base.vg().e().b8().GetMicrofeat<ea3>();
			if (microfeat != null)
			{
				a_2 = microfeat.a();
			}
			bg3 bg = euf.a(base.vg().e().b8(), c5x2.h.b.aa(), Math.Min(val, (double)base.vg().e().c(null)), c5x2.l(), base.vg().e().b8().Darkvision, awq.f(base.vg().q().h.b), 1.0, c3u.a, a_2);
			cwt.b = (cuo.a.NextDouble() < bg.a);
			if (!c5x2.h.b.aa().d(CharacterImmunities.CriticalHits))
			{
				if ((double)euf.f(c5x2.h.b.aa()) < d2f.a + (double)base.vg().e().b8().GetSpecializationValue<c3o>(true) * c3o.a && base.vg().e().b8().Feats.Contains<d2f>())
				{
					cwt.e = true;
				}
				else
				{
					double num6 = as3.a0 + c5x2.h.b.aa().Defense.w();
					euf.a(ref num6, base.vg().e().b8(), c5x2.h.b.aa());
					kl.b(ref num6, base.vg().e().b8(), c5x2.h.b.aa());
					cwt.e = (cuo.a.NextDouble() < num6);
				}
			}
			else
			{
				cwt.e = false;
			}
			cwt.x = jh.a(base.vg().e().b8());
			cwt.i = new ap9(base.vg().e().b8());
			cwt.j = new ap9(c5x2.h.b.aa());
			cwt.h = ImpactSpeed.Low;
			cwt.k = "метательный нож";
			if (cwt.e && base.vg().e().b8().Feats.Contains<cln>())
			{
				double num7 = (double)d05.b(0f, 1f - euf.f(c5x2.h.b.aa()), 1f);
				double num8 = 1.0 + (double)((int)(num7 / cln.b)) * cln.a(base.vg().e().b8());
				num4 *= num8;
			}
			if (list.Count > 1)
			{
				num4 *= 1.0 + (double)base.vg().e().b8().GetSpecializationValue<rt>(true) * rt.a;
			}
			csk item2 = euf.a(a0y.a(base.vg().e()), num4 * (1.0 + (cwt.e ? as3.a1 : 0.0)));
			cwt.f.Add(item2);
			if (b0b != null && b0b.Zone != null)
			{
				qy.ad().Add(new a4s(new bfq("throw", "KnifeThrow"), null, new ar7(base.vg().q()), null));
				qy.ad().Add(item);
				c7 c = new c7(b0b, false, false, true, false);
				c.a(true);
				qy.ad().Add(c);
				awq.a(qy, base.vg().q(), c5x2, true, true);
				string a_3 = null;
				string a_4 = null;
				string a_5 = null;
				string a_6 = null;
				float a_7 = 0f;
				float a_8 = 0f;
				awq.a(c5x2.h.b, new esu?(esu.b), out a_3, out a_4, out a_5, out a_6, out a_7, out a_8, null, false);
				enp a_9 = null;
				if (cwt.b)
				{
					a_9 = new kg(this.r6(), a_3, a_4, a_5, a_6, a_7, a_8);
				}
				akg item3 = new akg(base.vg().q().h.b, c5x2.h.b, cwt, a_9, true);
				qy.ad().Add(item3);
				b0b.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
		}
		return dc4.c;
	}

	// Token: 0x06007845 RID: 30789
	protected abstract enp r6();

	// Token: 0x06007846 RID: 30790 RVA: 0x00326810 File Offset: 0x00324A10
	public static HashSet<amc> a(amc A_0, amc A_1, float A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		HashSet<amc> hashSet = new HashSet<amc>();
		if (serviceOrThrow.aqu() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				using (List<d4n>.Enumerator enumerator = service.ahl().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						d4n d4n = enumerator.Current;
						if (d4n.b != null && d4n.b.a8() != null && d4n.b.a8().Area == A_1.a8().Area && d4n.b.a8().j == cgy.b && !d4n.b.aa().Dead && d4n.b != A_1 && d4n.b != A_0 && d4n.b.aa().a(serviceOrThrow.aqu().ac(), A_0.aa().FactionId) == h.a && aw1.b(A_0.a8(), d4n.b.a8()) <= (double)(A_2 + 1f))
						{
							hashSet.Add(d4n.b);
						}
					}
					return hashSet;
				}
			}
			Point point = A_1.a8().aj().a();
			for (int i = point.X - 1; i <= point.X + 1; i++)
			{
				for (int j = point.Y - 1; j <= point.Y + 1; j++)
				{
					foreach (b0b b0b in A_1.a8().Area.b(i, j).Entities)
					{
						c5x c5x = (c5x)b0b;
						if (c5x.h.b != null && c5x.h.b != A_1)
						{
							hashSet.Add(c5x.h.b);
						}
					}
				}
			}
		}
		return hashSet;
	}

	// Token: 0x0200150D RID: 5389
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060078B8 RID: 30904 RVA: 0x00328A10 File Offset: 0x00326C10
		internal bool a(aq8 A_0)
		{
			return A_0.Validator is e71;
		}

		// Token: 0x0400306D RID: 12397
		public static readonly bp7.a a = new bp7.a();

		// Token: 0x0400306E RID: 12398
		public static Func<aq8, bool> b;
	}
}
