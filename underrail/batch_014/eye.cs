using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200162F RID: 5679
[eiz("LCA")]
[Serializable]
public sealed class eye : a6k, ISerializable
{
	// Token: 0x06007CBF RID: 31935 RVA: 0x0034AB88 File Offset: 0x00348D88
	private eye(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007CC0 RID: 31936 RVA: 0x0034AB94 File Offset: 0x00348D94
	public eye()
	{
	}

	// Token: 0x06007CC1 RID: 31937 RVA: 0x0034AB9C File Offset: 0x00348D9C
	protected override dc4 dt()
	{
		return base.dt();
	}

	// Token: 0x06007CC2 RID: 31938 RVA: 0x0034ABA8 File Offset: 0x00348DA8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "IceBolt", 0.5f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
			{
				u6.a(base.vg().q().h.b);
				u6.a(base.vg().q().h.b, true);
			}
			eye.a(b0b);
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			awq.a(qy, base.vg().q(), c5x, true, true);
			cwt a_ = this.a(base.vg().q().h.b.aa(), c5x.h.b.aa());
			akg akg = new akg(base.vg().q().h.b, c5x.h.b, a_, null, false);
			qy.ad().Add(akg);
			akg.q(new EventHandler<EventArgs>(this.a));
			bfq bfq = new bfq();
			bfq.b("cyrokinesisHit" + Guid.NewGuid().ToString());
			bfq.c("CyrokinesisHit");
			qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
			eym.a(qy, c5x, (double)aju.bj);
			c5x a_2 = c5x;
			string a_3 = "ColdHit";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			bool a_5 = true;
			bool a_6 = true;
			float? a_7 = dz6.b();
			a7j item3 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
			qy.ad().Add(item3);
			qy.ad().Add(new duh(base.vg().q().h.b, new string[]
			{
				b0c.a
			}));
			base.vg().q().c().a("cryokinesisLaunch" + Guid.NewGuid().ToString(), "CyrokinesisLaunch", 1f, c9z.a, false, false);
			eym.a(base.vg().q(), (double)aju.bi);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007CC3 RID: 31939 RVA: 0x0034AEF4 File Offset: 0x003490F4
	private static void a(b0b A_0)
	{
		b4u aspect = A_0.GetAspect<b4u>();
		if (aspect != null)
		{
			aspect.b().Add(new ee1());
		}
	}

	// Token: 0x06007CC4 RID: 31940 RVA: 0x0034AF20 File Offset: 0x00349120
	private cwt a(efk A_0, efk A_1)
	{
		bas bas = A_0.Offense.ag()[PsiSchool.Metathermics];
		List<a1q> list = h7.a(base.vg().e());
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.f = new List<csk>();
		foreach (a1q a_ in list)
		{
			cwt.f.Add(euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f))));
		}
		cwt.h = ImpactSpeed.Low;
		cwt.k = "Криокинез";
		cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
		return cwt;
	}

	// Token: 0x06007CC5 RID: 31941 RVA: 0x0034B040 File Offset: 0x00349240
	[dcc("LCA:mARA_F")]
	private void a(object A_0, EventArgs A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return;
		}
		akg akg = A_0 as akg;
		if (akg == null || akg.b() == null || akg.b().a == null || akg.b().a.Count == 0)
		{
			return;
		}
		if (Enumerable.FirstOrDefault<csk>(Enumerable.Where<csk>(akg.b().a, new Func<csk, bool>(eye.a.a.a))).Amount > 0)
		{
			awq.e(c5x.h.b);
			double num = 1.0 - c5x.h.b.aa().Defense.af()[DamageType.Cold].c();
			if (c5x.h.b.aa().a(CharacterImmunities.Chill) || num <= 0.0)
			{
				etm a_ = new etm(new ap9(c5x.h.b.aa()), "эффекту переохлаждения");
				bey.a(a_, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_);
				bmj.a(c5x, new ba0());
				return;
			}
			int num2;
			if (base.vg().q() != null && base.vg().q().h.b != null)
			{
				num2 = euf.j(base.vg().q().h.b.aa());
			}
			else
			{
				num2 = 0;
			}
			c5x.h.b.aa().StatusEffects.a(new b34(h7.h + num2, h7.i), false, false, false);
			awq.c(c5x.h.b);
			if (!c5x.h.b.aa().SpecialStates.a && !c5x.h.b.aa().SpecialStates.h)
			{
				a20.a(c5x, new ap9(base.vg().e().b8()), new CombatSpeakEvent[]
				{
					CombatSpeakEvent.Hit_Frost
				});
			}
			if (base.vg().q().IsPlayer && !c5x.IsPlayer)
			{
				cxc.a(eyy.bw);
			}
			if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().h.b.aa().Feats.Contains<qz>())
			{
				if (num > 0.0 && !c5x.h.b.aa().c(d8o.e))
				{
					e6y a_2 = new e6y(Convert.ToInt32((double)(qz.c + num2) * num), qz.b + base.vg().e().b8().GetSpecializationValue<ekf>(true) * ekf.a);
					c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
					return;
				}
				etm a_3 = new etm(new ap9(c5x.h.b.aa()), "гипотермии");
				bey.a(a_3, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_3);
				bmj.a(c5x, new ba0());
			}
		}
	}

	// Token: 0x02001630 RID: 5680
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06007CC8 RID: 31944 RVA: 0x0034B464 File Offset: 0x00349664
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x0400318F RID: 12687
		public static readonly eye.a a = new eye.a();

		// Token: 0x04003190 RID: 12688
		public static Func<csk, bool> b;
	}
}
