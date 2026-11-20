using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x020011ED RID: 4589
[eiz("BTT")]
[Serializable]
public class azv : cos, enp, ISerializable
{
	// Token: 0x06006298 RID: 25240 RVA: 0x002A9B88 File Offset: 0x002A7D88
	protected azv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x002A9B94 File Offset: 0x002A7D94
	public virtual bool tq()
	{
		return false;
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x002A9B98 File Offset: 0x002A7D98
	public virtual string tr()
	{
		return null;
	}

	// Token: 0x0600629B RID: 25243 RVA: 0x002A9B9C File Offset: 0x002A7D9C
	public azv(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x002A9BA8 File Offset: 0x002A7DA8
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_1.a8().Zone != null && !A_1.aa().Dead && A_3.a != null && A_3.a.Count > 0)
		{
			int num = Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(azv.a.a.a)), new Func<csk, int>(azv.a.a.b));
			string text;
			string a_;
			float num2;
			if (num > 0)
			{
				text = cf0.c(A_1.an(), esu.b);
				a_ = cf0.b(A_1.an(), esu.b);
				num2 = cf0.a(A_1.an(), esu.b);
				if (!A_1.aa().Passive && !A_1.aa().b(d8o.e) && !A_1.aa().d(CharacterImmunities.Bleeding))
				{
					int a_2 = (int)Math.Max(1.0, (double)num * blb.c / (double)blb.d);
					a5e a_3 = new a5e((A_0 != null) ? A_0.aa().FactionId : null, blb.d * d0u.b, a_2, "bleedingWound", null);
					A_1.aa().StatusEffects.a(a_3, false, false, false);
					awq.c(A_0, A_1);
				}
				this.ts(A_0, A_1, A_2, A_3.a);
			}
			else
			{
				text = cf0.c(A_1.an(), esu.t);
				a_ = cf0.b(A_1.an(), esu.t);
				num2 = cf0.a(A_1.an(), esu.t);
			}
			A_1.a8().c().a(Guid.NewGuid().ToString(), a_, 1f, c9z.a, false, false);
			if (num2 > 0f)
			{
				A_1.a8().Zone.ActionManager.g9(new cn9(new edx(A_1.a8().Area.a(A_1.a8().aj().a())), (double)num2), atp.a);
			}
			c5x a_4 = A_1.a8();
			string a_5 = text;
			int a_6 = 1;
			double maxValue = double.MaxValue;
			bool a_7 = true;
			bool a_8 = true;
			float? a_9 = dz6.b();
			a7j a_10 = new a7j(a_4, a_5, a_6, maxValue, a_7, a_8, null, null, null, a_9, false, null);
			A_1.a8().Zone.ActionManager.g9(a_10, atp.a);
			dz6.a(a_10);
		}
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x002A9E54 File Offset: 0x002A8054
	protected override bool kr(c5x A_0, c5x A_1, bool A_2)
	{
		if (base.Area != null && base.Area.Zone != null && A_1 != null && A_1.l.Count > 0)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			ed2 ed = A_1.GetAspect<b4h>() as ed2;
			if (A_2)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(azv.a.a.b))) as c5x;
				if (c5x != null)
				{
					c5x.c().a("activated", "BearTrapActivate", 1f, c9z.a, false, false);
				}
			}
			else if (!A_2 && A_0 != null && A_0.h.b != null && ed != null)
			{
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(azv.a.a.a))) as c5x;
				if (c5x2 != null)
				{
					c5x2.c().a("activated", "BearTrapActivate", 1f, c9z.a, false, false);
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
				else if (cuo.a.NextDouble() < (double)A_0.h.b.aa().GetSpecializationValue<d2w>(true) * d2w.a || euf.k(A_0.h.b.aa()))
				{
					if (ed.a() != null)
					{
						bxv a_2 = new bxv(new ap9(A_0.h.b.aa()), "капкан");
						bey.a(a_2, ed.a().aa(), A_0.h.b.aa(), A_0.h.b);
						anw item3 = new anw(a_2);
						qy.ad().Add(item3);
					}
					b8p item4 = new b8p(A_0, new ewu());
					qy.ad().Add(item4);
				}
				else
				{
					amd item5 = new amd(A_0.h.b, new els[]
					{
						new dt9((ed.a() != null) ? ed.a().aa() : null, blb.e * d0u.b, this.tq(), this.tr())
					});
					qy.ad().Add(item5);
					cwt cwt = new cwt();
					cwt.e = (!A_0.h.b.aa().ImmuneToCriticalHits && cuo.a.NextDouble() < 0.05);
					cwt.f.Add(euf.a(blb.a(), (double)(cwt.e ? 2 : 1)));
					cwt.l = true;
					cwt.v = "капкан";
					cwt.b = true;
					cwt.h = ImpactSpeed.Low;
					cwt.j = new ap9(A_0.h.b.aa());
					cwt.ad["IsTrap"] = true;
					cwt.ad["IsBearTrap"] = true;
					amc amc = base.f();
					if (amc != null)
					{
						cwt.i = new ap9(amc.aa());
					}
					akg item6 = new akg(ed.a(), A_0.h.b, cwt, this, false);
					qy.ad().Add(item6);
					qy.ad().Add(new aro(A_0.h.b));
					if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
					{
						qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
					}
					vr a_3 = new vr(new ap9(A_0.h.b.aa()), null, "{0} в капкане.", new Color?(adi.j), null);
					bey.a(a_3, (ed.a() != null) ? ed.a().aa() : null, A_0.h.b.aa(), A_0.h.b);
					anw item7 = new anw(a_3);
					qy.ad().Add(item7);
				}
			}
			qy.ad().Add(new c7(A_1, false, false, true, false));
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x0600629E RID: 25246 RVA: 0x002AA3E0 File Offset: 0x002A85E0
	protected virtual void ts(amc A_0, amc A_1, cwt A_2, List<csk> A_3)
	{
	}

	// Token: 0x020011EE RID: 4590
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060062A1 RID: 25249 RVA: 0x002AA3F8 File Offset: 0x002A85F8
		internal bool a(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x002AA404 File Offset: 0x002A8604
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x002AA410 File Offset: 0x002A8610
		internal bool b(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x002AA418 File Offset: 0x002A8618
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029B9 RID: 10681
		public static readonly azv.a a = new azv.a();

		// Token: 0x040029BA RID: 10682
		public static Func<csk, bool> b;

		// Token: 0x040029BB RID: 10683
		public static Func<csk, int> c;

		// Token: 0x040029BC RID: 10684
		public static Func<b0b, bool> d;

		// Token: 0x040029BD RID: 10685
		public static Func<b0b, bool> e;
	}
}
