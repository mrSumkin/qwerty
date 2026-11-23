using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001202 RID: 4610
[eiz("ILB")]
[Serializable]
public sealed class e07 : cos, ISerializable
{
	// Token: 0x0600630A RID: 25354 RVA: 0x002ACA70 File Offset: 0x002AAC70
	private e07(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600630B RID: 25355 RVA: 0x002ACA7C File Offset: 0x002AAC7C
	public e07(c5x A_0, coh A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x002ACA88 File Offset: 0x002AAC88
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
				c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(A_1.l).Entities, new Func<b0b, bool>(e07.a.a.a))) as c5x;
				if (c5x != null)
				{
					c5x.c().a("activated", "ChemicalTrapActivate", 1f, c9z.a, false, false);
					qy.ad().Add(new cw(A_1));
					qy.ad().Add(new bm3(dz6.b(500)));
				}
				bfq a_ = new bfq("FireballSpread");
				qy.ad().Add(new a4s(a_, null, new ar7(A_0), null));
				string a_2 = "ExplosionSmall";
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				a7j item = new a7j(A_0, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null);
				qy.ad().Add(item);
				c18.a(base.TrapItem);
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				dictionary["TrapItem"] = base.TrapItem;
				a4s item2 = new a4s(new e07.b(), (ed.a() != null) ? new ar7(ed.a().a8()) : null, new ar7(A_0), dictionary);
				qy.ad().Add(item2);
				amc amc = base.f();
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

	// Token: 0x02001203 RID: 4611
	[eiz("ILBb")]
	[Serializable]
	private new sealed class b : cze, ISerializable
	{
		// Token: 0x0600630D RID: 25357 RVA: 0x002ACD40 File Offset: 0x002AAF40
		private b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x002ACD4C File Offset: 0x002AAF4C
		public b()
		{
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x002ACD58 File Offset: 0x002AAF58
		public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
		{
			amc amc = null;
			amc amc2 = null;
			c5x c5x = A_1 as c5x;
			c5x c5x2 = A_0 as c5x;
			if (c5x != null)
			{
				amc = c5x.h.b;
			}
			if (c5x2 != null)
			{
				amc2 = c5x2.h.b;
			}
			coh a_ = A_2["TrapItem"] as coh;
			if (amc != null && !amc.aa().Passive)
			{
				double num = amc.aa().Defense.af()[DamageType.Heat].c();
				if (amc.aa().d(CharacterImmunities.Burning) || num >= 1.0)
				{
					etm a_2 = new etm(new ap9(amc.aa()), "горению");
					bey.a(a_2, (amc2 != null) ? amc2.aa() : null, amc.aa(), amc);
					a7v.a(a_2);
					bmj.a(amc.a8(), new ba0());
					return;
				}
				int a_3 = c18.a(a_);
				int num2 = c18.f(a_3);
				int num3 = euf.a(c18.g(a_3), 1.0).Amount;
				int a_4 = Math.Max(1, num3 / num2);
				int num4 = Convert.ToInt32(Math.Max(1.0, (double)num2 * (1.0 - num)));
				amc.aa().StatusEffects.a(new bk9((amc2 != null) ? amc2.aa() : null, num4 * d0u.b, a_4, false), false, false, false);
				dd5.a(amc.aa());
				vr a_5 = new vr(new ap9(amc.aa()), null, "{0} горит.", new Color?(adi.j), null);
				bey.a(a_5, (amc2 != null) ? amc2.aa() : null, amc.aa(), amc);
				a7v.a(a_5);
				if (amc2 != null && amc2.aa() is e3q && !(amc.aa() is e3q))
				{
					cxc.a(eyy.b1);
				}
			}
		}
	}

	// Token: 0x02001204 RID: 4612
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06006312 RID: 25362 RVA: 0x002ACF80 File Offset: 0x002AB180
		internal bool a(b0b A_0)
		{
			return A_0.IsFloor;
		}

		// Token: 0x040029CC RID: 10700
		public static readonly e07.a a = new e07.a();

		// Token: 0x040029CD RID: 10701
		public static Func<b0b, bool> b;
	}
}
