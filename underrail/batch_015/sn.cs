using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001205 RID: 4613
[eiz("CLB")]
[Serializable]
public sealed class sn : cos, ISerializable, enp
{
	// Token: 0x06006313 RID: 25363 RVA: 0x002ACF88 File Offset: 0x002AB188
	private sn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x002ACF94 File Offset: 0x002AB194
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
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(sn.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.c().a("activated", "ChemicalTrapActivate", 1f, c9z.a, false, false);
					qy.ad().Add(new cw(A_1));
					qy.ad().Add(new bm3(dz6.b(500)));
				}
				bfq a_ = new bfq("CyrokinesisHit");
				qy.ad().Add(new a4s(a_, null, new ar7(A_0), null));
				string a_2 = "ColdHit";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
				qy.ad().Add(item);
				int a_7 = c18.a(base.TrapItem);
				cwt cwt = new cwt();
				cwt.e = (!A_0.h.b.aa().ImmuneToCriticalHits && cuo.a.NextDouble() < 0.05);
				cwt.f.Add(euf.a(c18.i(a_7), (double)(cwt.e ? 2 : 1)));
				cwt.l = true;
				cwt.v = "замораживающая ловушка";
				cwt.b = true;
				cwt.h = ImpactSpeed.Low;
				cwt.j = new ap9(A_0.h.b.aa());
				cwt.ad["IsTrap"] = true;
				amc amc = base.f();
				if (amc != null)
				{
					cwt.i = new ap9(amc.aa());
				}
				akg item2 = new akg(ed.a(), A_0.h.b, cwt, this, false);
				qy.ad().Add(item2);
				if (amc != null && !A_0.h.b.aa().Passive && eir.a(A_0.Zone, A_0.h.b.aa().FactionId) != ZoneControlLevel.Uncontrolled)
				{
					qy.ad().Add(new a27(amc, A_0.h.b, false, false, false, false));
				}
				qy.ad().Add(new aro(A_0.h.b));
			}
			qy.ad().Add(new c7(A_1, false, false, true, false));
			base.Area.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return true;
		}
		return false;
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x002AD2F8 File Offset: 0x002AB4F8
	public sn(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x002AD304 File Offset: 0x002AB504
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_3.a != null && A_3.a.Count > 0)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(sn.a.a.b)), new Func<csk, int>(sn.a.a.a)) > 0)
			{
				awq.e(A_1);
				if (!A_1.aa().Passive)
				{
					double num = A_1.aa().Defense.af()[DamageType.Cold].c();
					if (A_1.aa().d(CharacterImmunities.Freeze) || num >= 1.0)
					{
						etm a_ = new etm(new ap9(A_1.aa()), "замерзанию");
						bey.a(a_, (A_0 != null) ? A_0.aa() : null, A_1.aa(), A_1);
						a7v.a(a_);
						bmj.a(A_1.a8(), new ba0());
						return;
					}
					int num2 = c18.h(c18.a(base.TrapItem));
					int num3 = Convert.ToInt32(Math.Max(1.0, (double)num2 * (1.0 - num)));
					d4l.a(A_1.a8());
					A_1.u();
					A_1.aa().StatusEffects.a(new a2(num3 * d0u.b, null), false, false, false);
					awq.b(A_1);
					if (A_1.a8() != null && A_1.a8().t.b != null)
					{
						A_1.a8().t.b.ah();
					}
					vr a_2 = new vr(new ap9(A_1.aa()), null, "{0}: заморозка.", new Color?(adi.j), null);
					bey.a(a_2, (A_0 != null) ? A_0.aa() : null, A_1.aa(), A_1);
					a7v.a(a_2);
				}
			}
		}
	}

	// Token: 0x02001206 RID: 4614
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006319 RID: 25369 RVA: 0x002AD544 File Offset: 0x002AB744
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x002AD54C File Offset: 0x002AB74C
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Cold;
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x002AD558 File Offset: 0x002AB758
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040029CE RID: 10702
		public static readonly sn.a a = new sn.a();

		// Token: 0x040029CF RID: 10703
		public static Func<b0b, bool> b;

		// Token: 0x040029D0 RID: 10704
		public static Func<csk, bool> c;

		// Token: 0x040029D1 RID: 10705
		public static Func<csk, int> d;
	}
}
