using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001745 RID: 5957
[eiz("TSTBA")]
[Serializable]
public sealed class t4 : a6k, enp, ISerializable
{
	// Token: 0x06008061 RID: 32865 RVA: 0x00363C5C File Offset: 0x00361E5C
	private t4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008062 RID: 32866 RVA: 0x00363C68 File Offset: 0x00361E68
	public t4()
	{
	}

	// Token: 0x06008063 RID: 32867 RVA: 0x00363C74 File Offset: 0x00361E74
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.Area == null || c5x.h.b == null || base.vg().q() == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		base.vg().i();
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b;
		dvv item = es2.a(base.vg().q(), c5x, "xpbl_StoneBolas", 0.5f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			awq.a(base.vg().q(), c5x, true, true, true, true, false, false);
			qy.ad().Add(new a4s(new bfq("net", "NetThrow"), null, new ar7(b0b), null));
			qy.ad().Add(item);
			c7 c = new c7(b0b, false, false, true, false);
			c.a(true);
			qy.ad().Add(c);
			qy.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "NetFall"), null, new ar7(c5x), null));
			bool flag = false;
			if (c5x.h.b.aa().d(CharacterImmunities.Root))
			{
				etm a_ = new etm(new ap9(c5x.h.b.aa()), "обездвиживанию");
				bey.a(a_, base.vg().q().h.b.aa(), c5x.h.b.aa(), c5x.h.b);
				anw item2 = new anw(a_);
				qy.ad().Add(item2);
				b8p item3 = new b8p(c5x, new ba0());
				qy.ad().Add(item3);
			}
			else if (t4.a(base.vg().q().h.b.aa(), c5x.h.b.aa()))
			{
				qy.ad().Add(new b8p(c5x, new bgj()));
				qy.ad().Add(new anw(new vr(new ap9(c5x.h.b.aa()), null, "{0} уворачивается от болы.", new Color?(adi.o), null)));
				flag = true;
			}
			else
			{
				efk efk = base.vg().q().h.b.aa();
				efk efk2 = c5x.h.b.aa();
				double num = 0.05;
				euf.a(ref num, efk, efk2);
				cwt cwt = new cwt();
				cwt.i = new ap9(efk);
				cwt.j = new ap9(efk2);
				cwt.x = AmmoType.None;
				cwt.l = true;
				cwt.e = (!efk2.d(CharacterImmunities.CriticalHits) && cuo.a.NextDouble() < num);
				cwt.f.Add(euf.a(bkz.d, 1.0));
				cwt.b = true;
				cwt.c = new bool?(false);
				cwt.h = ImpactSpeed.VeryLow;
				cwt.k = "Бола";
				string a_2;
				string a_3;
				string a_4;
				string a_5;
				float a_6;
				float a_7;
				awq.a(c5x.h.b, new esu?(esu.d), out a_2, out a_3, out a_4, out a_5, out a_6, out a_7, null, false);
				qy.ad().Add(new akg(base.vg().q().h.b, c5x.h.b, cwt, new kg(new b7x(this), a_2, a_3, a_4, a_5, a_6, a_7), false));
				bbe bbe = t4.a(c5x.h.b.aa());
				if (bbe != null)
				{
					qy.ad().Add(new amd(c5x.h.b, new els[]
					{
						bbe
					}));
				}
				else
				{
					qy.ad().Add(new b8p(c5x, new ba0()));
					qy.ad().Add(new anw(new vr(new ap9(c5x.h.b.aa()), null, "{0} имеет много силы. Невозможно опутать болой.", new Color?(adi.n), null)));
					flag = true;
				}
			}
			if (flag)
			{
				qy.ad().Add(new a4s(new ezd("Locale\\Object\\Items\\Xpbl_StoneBolas", new bt4(c5x.Area.y8(), c5x.aj().a().a()), null, null, null, null, null), null, null, null));
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06008064 RID: 32868 RVA: 0x00364194 File Offset: 0x00362394
	private static bbe a(efk A_0)
	{
		int num = bkz.a(A_0);
		if (num > 0)
		{
			return new bbe(num);
		}
		return null;
	}

	// Token: 0x06008065 RID: 32869 RVA: 0x003641B8 File Offset: 0x003623B8
	private static bool a(efk A_0, efk A_1)
	{
		return euf.b(A_0.Skills.Get<dei>().g(), A_1) || euf.k(A_1);
	}

	// Token: 0x06008066 RID: 32870 RVA: 0x003641E8 File Offset: 0x003623E8
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 == null || A_1.aa().Dead || A_1.aa().b(d8o.e | d8o.i | d8o.k) || A_1.aa().d(CharacterImmunities.CriticalHits))
		{
			return;
		}
		if (A_3 == null || A_3.a == null || A_3.a.Count == 0)
		{
			return;
		}
		if (Enumerable.Sum<csk>(Enumerable.Where<csk>(A_3.a, new Func<csk, bool>(t4.a.a.b)), new Func<csk, int>(t4.a.a.a)) > 0)
		{
			e8b a_ = new e8b(0.0);
			A_1.aa().StatusEffects.a(a_, false, false, false);
		}
	}

	// Token: 0x02001746 RID: 5958
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06008069 RID: 32873 RVA: 0x003642F0 File Offset: 0x003624F0
		internal bool b(csk A_0)
		{
			return A_0.DamageType == DamageType.Mechanical;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x003642FC File Offset: 0x003624FC
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x0400323F RID: 12863
		public static readonly t4.a a = new t4.a();

		// Token: 0x04003240 RID: 12864
		public static Func<csk, bool> b;

		// Token: 0x04003241 RID: 12865
		public static Func<csk, int> c;
	}
}
