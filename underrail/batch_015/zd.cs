using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020011F8 RID: 4600
[eiz("HTT")]
[Serializable]
public sealed class zd : cos, ISerializable
{
	// Token: 0x060062CD RID: 25293 RVA: 0x002AB504 File Offset: 0x002A9704
	private zd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062CE RID: 25294 RVA: 0x002AB510 File Offset: 0x002A9710
	public zd(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x002AB51C File Offset: 0x002A971C
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
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(zd.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.c().a("activated", "BearTrapActivate", 1f, c9z.a, false, false);
				}
				if (A_0.h.b.aa().d(CharacterImmunities.Root))
				{
					if (ed.a() != null)
					{
						etm a_ = new etm(new ap9(A_0.h.b.aa()), "обездвиживанию");
						bey.a(a_, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item = new anw(a_);
						qy.ad().Add(item);
					}
					b8p item2 = new b8p(A_0, new ba0());
					qy.ad().Add(item2);
				}
				else if (A_0.h.b.aa().BaseAbilities.Strength > by4.b)
				{
					c6f a_2 = new c6f(new ap9(A_0.h.b.aa()), null, "обездвиживанию");
					bey.a(a_2, (ed.a() != null) ? ed.a().aa() : null, A_0.h.b.aa(), A_0.h.b);
					anw item3 = new anw(a_2);
					qy.ad().Add(item3);
				}
				else if (euf.k(A_0.h.b.aa()))
				{
					bjq a_3 = new bjq(new ap9(A_0.h.b.aa()), null, "обездвиживанию");
					bey.a(a_3, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
					a7v.a(a_3);
					bmj.a(A_0, new bgj());
				}
				else
				{
					amd item4 = new amd(A_0.h.b, new els[]
					{
						new dio(by4.a * d0u.b)
					});
					qy.ad().Add(item4);
					amc amc = base.f();
					qy.ad().Add(new aro(A_0.h.b));
					if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
					{
						qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
					}
					vr a_4 = new vr(new ap9(A_0.h.b.aa()), null, "{0} в капкане.", new Color?(adi.j), null);
					bey.a(a_4, (ed.a() != null) ? ed.a().aa() : null, A_0.h.b.aa(), A_0.h.b);
					anw item5 = new anw(a_4);
					qy.ad().Add(item5);
				}
			}
			qy.ad().Add(new c7(A_1, false, false, true, false));
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x020011F9 RID: 4601
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060062D2 RID: 25298 RVA: 0x002AB948 File Offset: 0x002A9B48
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029C3 RID: 10691
		public static readonly zd.a a = new zd.a();

		// Token: 0x040029C4 RID: 10692
		public static Func<b0b, bool> b;
	}
}
