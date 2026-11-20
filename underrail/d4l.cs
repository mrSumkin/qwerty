using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Comm;

// Token: 0x0200162E RID: 5678
[eiz("CA4")]
[Serializable]
public sealed class d4l : a6k, ISerializable
{
	// Token: 0x06007CB9 RID: 31929 RVA: 0x0034A2D0 File Offset: 0x003484D0
	private d4l(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007CBA RID: 31930 RVA: 0x0034A2DC File Offset: 0x003484DC
	public d4l()
	{
	}

	// Token: 0x06007CBB RID: 31931 RVA: 0x0034A2E8 File Offset: 0x003484E8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if ((c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null) && !(base.vg().h() is ak1))
		{
			return dc4.e;
		}
		if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null)
		{
			u6.a(base.vg().q().h.b);
			u6.a(base.vg().q().h.b, true);
		}
		awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
		d4l.a(c5x);
		c5x.c().a("cryostasis", "Cryostasis", 1f, c9z.a, false, false);
		if (c5x.h.b.aa().d(CharacterImmunities.Freeze))
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "заморозке");
			bey.a(a_, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
		}
		else
		{
			b34 b = Enumerable.FirstOrDefault<b34>(Enumerable.OfType<b34>(c5x.h.b.aa().StatusEffects.d()));
			int a_2 = 0;
			if (b != null)
			{
				a_2 = b.Stacks;
			}
			int num;
			if (base.vg().q() != null && base.vg().q().h.b != null)
			{
				num = euf.j(base.vg().q().h.b.aa());
			}
			else
			{
				num = 0;
			}
			int num2 = (int)((double)cmp.a(base.vg().e(), a_2) * (1.0 - c5x.h.b.aa().Defense.af()[DamageType.Cold].c()));
			if (num2 > 0)
			{
				if (!c5x.h.b.aa().SpecialStates.a && !c5x.h.b.aa().SpecialStates.h)
				{
					a20.a(c5x, new ap9(base.vg().e().b8()), new CombatSpeakEvent[]
					{
						CombatSpeakEvent.Hit_Frozen
					});
				}
				dtb dtb = new dtb();
				double? a_3 = null;
				if (base.vg().q().h.b.aa().Feats.Contains<co4>())
				{
					a_3 = new double?(co4.b - (double)base.vg().q().h.b.aa().GetSpecializationValue<il>(true) * il.a);
				}
				dtb.ad().Add(new aro(c5x.h.b));
				amd item = new amd(c5x.h.b, new els[]
				{
					new a2(num2, a_3)
				});
				dtb.ad().Add(item);
				dtb.ad().Add(new eae("CAH_HandleFreezing", null, new ar7(c5x), null));
				awq.b(dtb, c5x.h.b);
				if (base.vg().q().IsPlayer && !c5x.IsPlayer)
				{
					cxc.a(eyy.bx);
				}
				vr a_4 = new vr(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "{0}: заморозка.", new Color?(adi.j), null);
				bey.a(a_4, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				anw item2 = new anw(a_4);
				dtb.ad().Add(item2);
				double num3 = 1.0 - c5x.h.b.aa().Defense.af()[DamageType.Cold].c();
				if (base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().h.b.aa().Feats.Contains<qz>())
				{
					if (num3 > 0.0 && !c5x.h.b.aa().c(d8o.e))
					{
						e6y e6y = new e6y(Convert.ToInt32((double)(qz.c + num) * num3), qz.b + base.vg().e().b8().GetSpecializationValue<ekf>(true) * ekf.a);
						dtb.ad().Add(new amd(c5x.h.b, new els[]
						{
							e6y
						}));
					}
					else
					{
						etm a_5 = new etm(new ap9(c5x.h.b.aa()), "гипотермии");
						bey.a(a_5, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
						a7v.a(a_5);
						bmj.a(c5x, new ba0());
					}
				}
				c5x.Zone.ActionManager.g9(dtb, atp.a);
				if (c5x.t.b != null)
				{
					be9 item3 = new be9(c5x.t.b);
					dtb.ad().Add(item3);
				}
				dz6.a(dtb);
			}
			else
			{
				c6f a_6 = new c6f(new ap9(c5x.h.b.aa()), new ap9(base.vg().e().b8()), "криокинетической заморозке");
				bey.a(a_6, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
				a7v.a(a_6);
				bmj.a(c5x, new dym());
			}
		}
		return dc4.c;
	}

	// Token: 0x06007CBC RID: 31932 RVA: 0x0034A9A4 File Offset: 0x00348BA4
	public static void a(c5x A_0)
	{
		Vector3 vector = A_0.aj();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					Vector3 vector2 = new Vector3(vector.X + (float)i, vector.Y + (float)j, 0f);
					Point point = vector2.a();
					if (point.X >= 0 && point.Y >= 0 && point.X < A_0.Area.Size.c && point.Y < A_0.Area.Size.d)
					{
						for (float num = 0f; num <= 2f; num += 0.66f)
						{
							vector2.Z = num;
							d4l.a(A_0.Area, vector2, new Vector3(vector.X, vector.Y, 2f * (float)d4l.a.NextDouble()));
						}
					}
				}
			}
		}
	}

	// Token: 0x06007CBD RID: 31933 RVA: 0x0034AAB8 File Offset: 0x00348CB8
	private static void a(aud A_0, Vector3 A_1, Vector3 A_2)
	{
		double num = (double)Vector3.Distance(A_1, A_2);
		b0b b0b;
		auv a_ = es2.a(A_1, A_2, A_0, "IceFlake", null, out b0b);
		e4o e4o = new e4o(b0b as c5x);
		e4o.a(200);
		e4o.b(0);
		e4o.a(dz6.a(0.1 + 0.3 / num));
		qy qy = new qy();
		qy.ad().Add(e4o);
		qy.ad().Add(new c7(b0b, false, false, true, false));
		A_0.Zone.ActionManager.g9(a_, atp.a);
		A_0.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(a_);
		dz6.a(qy);
	}

	// Token: 0x0400318E RID: 12686
	private new static readonly Random a = new Random();
}
