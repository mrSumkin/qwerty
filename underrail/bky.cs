using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020011F0 RID: 4592
[eiz("QWX")]
[Serializable]
public sealed class bky : cos, ISerializable, enp
{
	// Token: 0x060062AA RID: 25258 RVA: 0x002AA544 File Offset: 0x002A8744
	private bky(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x002AA550 File Offset: 0x002A8750
	public bky(c5x A_0) : base(A_0, null)
	{
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x002AA55C File Offset: 0x002A875C
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null)
		{
			dtb dtb = new dtb();
			dtb.b(false);
			dtb.c(false);
			if (A_3.a != null)
			{
				if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(bky.a.a.a)), new Func<csk, int>(bky.a.a.b)) > 0)
				{
					if (A_1.aa().Passive || (A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.ShortCircuiting)) || (!A_1.aa().c(d8o.e) && A_1.aa().d(CharacterImmunities.Stun)))
					{
						etm a_;
						if (A_1.aa().c(d8o.e))
						{
							a_ = new etm(new ap9(A_1.aa()), "короткому замыканию");
						}
						else
						{
							a_ = new etm(new ap9(A_1.aa()), "оглушению");
						}
						bey.a(a_, null, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
					}
					else
					{
						els els;
						if (A_1.aa().c(d8o.e))
						{
							els = new clt(2 * d0u.b);
						}
						else
						{
							els = awq.a(A_1.aa(), 2 * d0u.b);
						}
						dtb.ad().Add(new amd(A_1, new els[]
						{
							els
						}));
					}
				}
			}
			if (A_1.aa().Passive || A_1.aa().d(CharacterImmunities.Root))
			{
				etm a_2 = new etm(new ap9(A_1.aa()), "обездвиживанию");
				bey.a(a_2, null, A_1.aa(), A_1);
				a7v.a(a_2);
				bmj.a(A_1.a8(), new ba0());
			}
			else if (euf.k(A_1.aa()))
			{
				bjq a_3 = new bjq(new ap9(A_1.aa()), null, "запутыванию в сети");
				bey.a(a_3, null, A_1.aa(), A_1);
				anw item = new anw(a_3);
				dtb.ad().Add(item);
			}
			else
			{
				els els2 = new ata(4 * d0u.b, false);
				dtb.ad().Add(new amd(A_1, new els[]
				{
					els2
				}));
			}
			A_1.a8().Zone.ActionManager.g9(dtb, atp.a);
			dz6.a(dtb);
		}
	}

	// Token: 0x060062AD RID: 25261 RVA: 0x002AA7FC File Offset: 0x002A89FC
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0)
		{
			b2x aspect = A_1.GetAspect<b2x>();
			if (A_1.o.b != null)
			{
				A_1.o.b.b = new Point(A_1.o.b.b.X, 1);
			}
			if (A_1.r.b != null)
			{
				A_1.r.b.a(true);
			}
			A_1.TileFormationModifiers.s4(10);
			A_1.z();
			if (A_0 != null && A_0.h.b != null)
			{
				qy qy = new qy();
				qy.b(false);
				qy.c(false);
				cwt cwt = new cwt();
				cwt.i = null;
				cwt.j = new ap9(A_0.h.b.aa());
				cwt.l = true;
				cwt.f.Add(euf.a(new a1q(DamageType.Electricity, 30, 60), 1.0));
				cwt.v = "электрическая сеть";
				cwt.b = true;
				cwt.h = ImpactSpeed.VeryHigh;
				qy.ad().Add(new aro(A_0.h.b));
				qy.ad().Add(new a4s(new bfq("WebEntangle"), null, new ar7(A_0), null));
				List<auv> list = qy.ad();
				string a_ = "Electricity";
				int maxValue = int.MaxValue;
				double a_2 = (double)dz6.b(300);
				bool a_3 = true;
				bool a_4 = true;
				float? a_5 = dz6.b();
				list.Add(new a7j(A_0, a_, maxValue, a_2, a_3, a_4, null, null, null, a_5, false, null));
				qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "Electroshock"), null, new ar7(A_0), null));
				qy.ad().Add(new akg(null, A_0.h.b, cwt, this, false));
				base.Area.Zone.ActionManager.g9(qy, atp.a);
				dz6.a(qy);
			}
			d60 addon = base.Area.Zone.GetAddon<d60>();
			if (addon != null)
			{
				string text;
				if (aspect != null && !string.IsNullOrWhiteSpace(aspect.a))
				{
					text = aspect.a;
				}
				else
				{
					text = "coilSpidersDispatcher";
				}
				foreach (b0b b0b in addon.ab4(new string[]
				{
					text
				}))
				{
					bja aspect2 = b0b.GetAspect<bja>();
					if (aspect2 != null)
					{
						bt4 a_6 = new bt4(base.TrapEntity.Area.y8(), base.TrapEntity.aj());
						asf a_7 = new asf(base.TrapEntity.qe(), a_6);
						aspect2.d(a_7);
					}
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x002AAB34 File Offset: 0x002A8D34
	protected override bool yl(c5x A_0)
	{
		return (A_0 == null || A_0.h.b == null || !(A_0.h.b.aa().FactionId == asp.a0)) && base.yl(A_0);
	}

	// Token: 0x020011F1 RID: 4593
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060062B1 RID: 25265 RVA: 0x002AAB98 File Offset: 0x002A8D98
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x002AABA4 File Offset: 0x002A8DA4
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029BE RID: 10686
		public static readonly bky.a a = new bky.a();

		// Token: 0x040029BF RID: 10687
		public static Func<csk, bool> b;

		// Token: 0x040029C0 RID: 10688
		public static Func<csk, int> c;
	}
}
