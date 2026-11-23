using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001744 RID: 5956
[eiz("TBBN")]
[Serializable]
public sealed class are : a6k, ISerializable
{
	// Token: 0x0600805C RID: 32860 RVA: 0x003636F8 File Offset: 0x003618F8
	private are(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600805D RID: 32861 RVA: 0x00363704 File Offset: 0x00361904
	public are()
	{
	}

	// Token: 0x0600805E RID: 32862 RVA: 0x0036370C File Offset: 0x0036190C
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
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "BarbedThrowingNet", 0.5f, null, out b0b, true, 0.5f);
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
			efk efk = base.vg().q().h.b.aa();
			efk efk2 = c5x.h.b.aa();
			if (efk2.d(CharacterImmunities.Root))
			{
				etm a_ = new etm(new ap9(efk2), "обездвиживанию");
				bey.a(a_, base.vg().q().h.b.aa(), efk2, c5x.h.b);
				anw item2 = new anw(a_);
				qy.ad().Add(item2);
				b8p item3 = new b8p(c5x, new ba0());
				qy.ad().Add(item3);
			}
			else if (are.a(efk, efk2))
			{
				qy.ad().Add(new b8p(c5x, new bgj()));
				qy.ad().Add(new anw(new vr(new ap9(efk2), null, "{0} уворачивается от сети.", new Color?(adi.o), null)));
				flag = true;
			}
			else
			{
				double num = 0.05;
				euf.a(ref num, efk, efk2);
				cwt cwt = new cwt();
				cwt.i = new ap9(efk);
				cwt.j = new ap9(efk2);
				cwt.x = AmmoType.Knife;
				cwt.l = true;
				cwt.e = (!efk2.d(CharacterImmunities.CriticalHits) && cuo.a.NextDouble() < num);
				cwt.f.Add(euf.a(cs.d, 1.0));
				cwt.b = true;
				cwt.c = new bool?(false);
				cwt.h = ImpactSpeed.VeryLow;
				cwt.k = "Колючая метательная сеть";
				cwt.g.Add(new edm(mi.a, 1.0, Convert.ToInt32(cs.e * 100.0), true));
				string a_2;
				string a_3;
				string a_4;
				string a_5;
				float a_6;
				float a_7;
				awq.a(c5x.h.b, new esu?(esu.b), out a_2, out a_3, out a_4, out a_5, out a_6, out a_7, null, false);
				qy.ad().Add(new akg(base.vg().q().h.b, c5x.h.b, cwt, new kg(new b7x(null), a_2, a_3, a_4, a_5, a_6, a_7), false));
				bzi bzi = are.a(c5x.h.b.aa());
				if (bzi != null)
				{
					qy.ad().Add(new amd(c5x.h.b, new els[]
					{
						bzi
					}));
				}
				else
				{
					qy.ad().Add(new b8p(c5x, new ba0()));
					qy.ad().Add(new anw(new vr(new ap9(c5x.h.b.aa()), null, "{0} имеет много силы. Невозможно захватить сетью.", new Color?(adi.n), null)));
					flag = true;
				}
			}
			if (flag)
			{
				qy.ad().Add(new a4s(new ezd("Locale\\Object\\Items\\BarbedThrowingNet", new bt4(c5x.Area.y8(), c5x.aj().a().a()), null, null, null, null, null), null, null, null));
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0600805F RID: 32863 RVA: 0x00363C08 File Offset: 0x00361E08
	private static bzi a(efk A_0)
	{
		int num = cs.a(A_0);
		if (num > 0)
		{
			return new bzi(num, true);
		}
		return null;
	}

	// Token: 0x06008060 RID: 32864 RVA: 0x00363C2C File Offset: 0x00361E2C
	private static bool a(efk A_0, efk A_1)
	{
		return euf.b(A_0.Skills.Get<dei>().g(), A_1) || euf.k(A_1);
	}
}
