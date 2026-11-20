using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020011F4 RID: 4596
[eiz("RABT2")]
[Serializable]
public sealed class biy : cos, ISerializable
{
	// Token: 0x060062BD RID: 25277 RVA: 0x002AADB4 File Offset: 0x002A8FB4
	private biy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x002AADC0 File Offset: 0x002A8FC0
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			ed2 ed = A_1.GetAspect<b4h>() as ed2;
			if (!A_2 && A_0 != null && A_0.h.b != null && ed != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(biy.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.c().a("activated", "ChemicalTrapActivate", 1f, c9z.a, false, false);
					qy.ad().Add(new cw(A_1));
					qy.ad().Add(new bm3(dz6.b(500)));
				}
				bfq a_ = new bfq("AcidBlobBigHit");
				qy.ad().Add(new a4s(a_, null, new ar7(A_0), null));
				string a_2 = "rustingAcidSplash";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
				qy.ad().Add(item);
				if (A_0.h.b.aa().d(CharacterImmunities.Root))
				{
					if (ed.a() != null)
					{
						etm a_7 = new etm(new ap9(A_0.h.b.aa()), "обездвиживанию");
						bey.a(a_7, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item2 = new anw(a_7);
						qy.ad().Add(item2);
					}
					b8p item3 = new b8p(A_0, new ba0());
					qy.ad().Add(item3);
				}
				else if (euf.k(A_0.h.b.aa()))
				{
					bjq a_8 = new bjq(new ap9(A_0.h.b.aa()), null, "кислотного опутывания");
					bey.a(a_8, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_8);
					bmj.a(A_0, new bgj());
				}
				else
				{
					int a_9 = c18.a(base.TrapItem);
					double num = 1.0;
					if (A_0.h.b.aa().c(d8o.e))
					{
						num += d9b.a;
					}
					csk csk = euf.a(c18.j(a_9), num);
					amd item4 = new amd(A_0.h.b, new els[]
					{
						new bgv((ed.a() != null) ? ed.a().aa() : null, c18.bp * d0u.b, (int)Math.Max(1.0, (double)csk.Amount / (double)c18.bp))
					});
					qy.ad().Add(item4);
					if (ed.a() != null)
					{
						vr a_10 = new vr(new ap9(A_0.h.b.aa()), null, "{0}: опутывание.", new Color?(adi.j), null);
						bey.a(a_10, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item5 = new anw(a_10);
						qy.ad().Add(item5);
					}
				}
				amc amc = base.f();
				if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
				{
					qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
				}
			}
			qy.ad().Add(new c7(A_1, false, false, true, false));
			qy.ad().Add(new a4s(new amg(new edx(A_1.l[0]), new EntityAspectReference<amc, amc>(base.f())), null, null, null));
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x002AB280 File Offset: 0x002A9480
	public biy(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x020011F5 RID: 4597
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060062C2 RID: 25282 RVA: 0x002AB2A0 File Offset: 0x002A94A0
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029C1 RID: 10689
		public static readonly biy.a a = new biy.a();

		// Token: 0x040029C2 RID: 10690
		public static Func<b0b, bool> b;
	}
}
