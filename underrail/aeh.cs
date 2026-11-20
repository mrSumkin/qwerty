using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020015DB RID: 5595
[eiz("PBA2")]
[Serializable]
public sealed class aeh : a6k, ISerializable
{
	// Token: 0x06007B61 RID: 31585 RVA: 0x00338AD8 File Offset: 0x00336CD8
	private aeh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007B62 RID: 31586 RVA: 0x00338AE4 File Offset: 0x00336CE4
	public aeh()
	{
	}

	// Token: 0x06007B63 RID: 31587 RVA: 0x00338AF0 File Offset: 0x00336CF0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ak1 ak = base.vg().h() as ak1;
		if (ak == null || ak.Area == null || ak.Zone == null)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), ak, false);
		base.vg().q().c().a("PlasmaBeam");
		aeh.a(base.vg().q(), ak, base.vg().e(), false);
		base.vg().q().Zone.ActionManager.g9(new duh(base.vg().q().h.b, new string[]
		{
			b0c.a
		}), atp.a);
		return dc4.c;
	}

	// Token: 0x06007B64 RID: 31588 RVA: 0x00338BCC File Offset: 0x00336DCC
	public static List<KeyValuePair<c5x, double>> a(c5x A_0, ak1 A_1, cnm A_2, bool A_3 = false)
	{
		if (!A_3)
		{
			eym.a(A_0, (double)aju.am);
		}
		List<KeyValuePair<c5x, double>> list = new List<KeyValuePair<c5x, double>>();
		Vector3 vector = es2.a(A_0, 0.8f, true);
		Vector3 value = A_1.h();
		value.Z = vector.Z;
		Vector3 value2 = value - vector;
		float num = value2.Length();
		value2.Normalize();
		HorizontalDirection a_ = A_0.h.b.a8().VisualDirection;
		HashSet<c5x> hashSet = new HashSet<c5x>();
		for (float num2 = 0f; num2 <= num; num2 += 0.25f)
		{
			Vector3 a_2 = vector + value2 * num2 - new Vector3(0.5f, 0.5f, 0f);
			int num3 = Convert.ToInt32(dgk.Get<evz>().a(A_2, num2) * 6f);
			c5x c5x = vq.a("Effects\\Plasma_Stream_Static", A_1.Zone, new bt4(A_1.Area.y8(), a_2), false);
			if (c5x != null)
			{
				c5x.ae = new float?(0f);
				c5x.VisualDirection = a_;
				dtb dtb = null;
				if (!A_3)
				{
					dtb = new dtb();
					dtb.b(false);
					dtb.c(false);
					List<auv> list2 = dtb.ad();
					ad6 ad = new ad6(c5x);
					ad.b(0.0);
					ad.c(1.0);
					ad.a(0.01 * (double)dz6.c());
					list2.Add(ad);
				}
				Vector2 a_3 = c5x.aj().b();
				ak1 ak = A_1.Area.a(c5x.aj().a());
				if (ak != null)
				{
					foreach (b0b b0b in ak.c.Values)
					{
						c5x c5x2 = (c5x)b0b;
						if (!hashSet.Contains(c5x2) && c5x2 != A_0 && c5x2.h.b != null && !c5x2.h.b.aa().Dead)
						{
							bool flag = ak == A_1;
							if (!flag)
							{
								flag = aw1.a(c5x2, a_3);
							}
							if (!flag)
							{
								flag = (aw1.b(c5x, c5x2) <= (double)((c5x2.Size.X + c5x2.Size.Y) / 4f) + 0.25);
							}
							if (flag)
							{
								list.Add(new KeyValuePair<c5x, double>(c5x2, (double)num2));
								hashSet.Add(c5x2);
								if (!A_3)
								{
									cwt a_4 = aeh.a(A_2, c5x2.h.b.aa(), num2);
									dtb.ad().Add(new a7j(c5x2, "PlasmaHit", 1, double.MaxValue, true, true, null, null, null, null, false, null));
									dtb.ad().Add(new a4s(new bfq("PlasmaHit"), null, new ar7(c5x2), null));
									awq.a(dtb, A_0, c5x2, true, true);
									dtb.ad().Add(new akg(A_0.h.b, c5x2.h.b, a_4, null, false));
								}
							}
						}
					}
				}
				if (!A_3)
				{
					dtb.ad().Add(new bm3(dz6.b(100)));
					List<auv> list3 = dtb.ad();
					ad6 ad2 = new ad6(c5x);
					ad2.b(1.0);
					ad2.c(0.0);
					ad2.a(0.01 * (double)dz6.c());
					list3.Add(ad2);
					dtb.ad().Add(new c7(c5x, false, false, true, false));
					A_1.Zone.ActionManager.g9(dtb, atp.a);
					dz6.a(dtb);
					if (num3 > 0 && c5x.o.b != null)
					{
						dtb dtb2 = new dtb();
						dtb2.b(false);
						dtb2.c(false);
						List<auv> list4 = dtb2.ad();
						dqm dqm = new dqm(c5x.o.b);
						dqm.b(0);
						dqm.c(num3);
						dqm.a((double)dz6.b(25));
						list4.Add(dqm);
						A_1.Zone.ActionManager.g9(dtb2, atp.a);
						dz6.a(dtb2);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06007B65 RID: 31589 RVA: 0x00339098 File Offset: 0x00337298
	private static cwt a(cnm A_0, efk A_1, float A_2)
	{
		efk efk = A_0.b8();
		bas bas = efk.Offense.ag()[PsiSchool.Metathermics];
		List<a1q> list = dgk.Get<evz>().b(A_0, A_2);
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(euf.a(bas, A_1)));
		cwt.i = new ap9(efk);
		cwt.j = new ap9(A_1);
		cwt.f = new List<csk>();
		foreach (a1q a_ in list)
		{
			cwt.f.Add(euf.a(a_, (double)(1f + (cwt.e ? bas.g() : 0f))));
		}
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.k = "Плазменный луч";
		cwt.ad["PsionicSource"] = PsiSchool.Metathermics;
		return cwt;
	}
}
