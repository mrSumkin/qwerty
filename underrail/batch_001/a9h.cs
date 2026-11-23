using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001756 RID: 5974
[eiz("TNTA2")]
[Serializable]
public sealed class a9h : a6k, ISerializable
{
	// Token: 0x0600809F RID: 32927 RVA: 0x0036576C File Offset: 0x0036396C
	private a9h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060080A0 RID: 32928 RVA: 0x00365778 File Offset: 0x00363978
	public a9h()
	{
	}

	// Token: 0x060080A1 RID: 32929 RVA: 0x00365784 File Offset: 0x00363984
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
		dvv item = es2.a(base.vg().q(), c5x, "ThrowingNet", 0.5f, null, out b0b, true, 0.5f);
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
			else if (a9h.a(base.vg().q().h.b.aa(), c5x.h.b.aa()))
			{
				qy.ad().Add(new b8p(c5x, new bgj()));
				qy.ad().Add(new anw(new vr(new ap9(c5x.h.b.aa()), null, "{0} уворачивается от сети.", new Color?(adi.o), null)));
				flag = true;
			}
			else
			{
				bzi bzi = a9h.a(c5x.h.b.aa());
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
				qy.ad().Add(new a4s(new ezd("Locale\\Object\\Items\\ThrowingNet", new bt4(c5x.Area.y8(), c5x.aj().a().a()), null, null, null, null, null), null, null, null));
			}
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x060080A2 RID: 32930 RVA: 0x00365B4C File Offset: 0x00363D4C
	private static bzi a(efk A_0)
	{
		int num = ada.a(A_0);
		if (num > 0)
		{
			return new bzi(num, false);
		}
		return null;
	}

	// Token: 0x060080A3 RID: 32931 RVA: 0x00365B70 File Offset: 0x00363D70
	private static bool a(efk A_0, efk A_1)
	{
		return euf.b(A_0.Skills.Get<dei>().g(), A_1) || euf.k(A_1);
	}
}
