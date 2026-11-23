using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016D7 RID: 5847
[eiz("RLE")]
[Serializable]
public sealed class sa : a6k, ISerializable
{
	// Token: 0x06007F3E RID: 32574 RVA: 0x0035DDCC File Offset: 0x0035BFCC
	private sa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F3F RID: 32575 RVA: 0x0035DDD8 File Offset: 0x0035BFD8
	public sa()
	{
	}

	// Token: 0x06007F40 RID: 32576 RVA: 0x0035DDE4 File Offset: 0x0035BFE4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		aw1.b(base.vg().q().h.b.a8(), c5x, false);
		qy qy = new qy();
		qy.b(false);
		qy.c(false);
		b0b b0b = null;
		dvv item = es2.a(base.vg().q(), c5x, "RedLaser", 0.7f, null, out b0b, true, 0.5f);
		if (b0b != null && b0b.Zone != null)
		{
			qy.ad().Add(item);
			c7 item2 = new c7(b0b, false, false, true, false);
			qy.ad().Add(item2);
			awq.a(qy, base.vg().q(), c5x, true, true);
			cwt a_ = this.a(base.vg().q().h.b.aa(), c5x.h.b.aa());
			akg item3 = new akg(base.vg().q().h.b, c5x.h.b, a_, null, false);
			qy.ad().Add(item3);
			bfq bfq = new bfq();
			bfq.b("LaserHit" + Guid.NewGuid().ToString());
			bfq.c("LaserHit");
			qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
			c5x a_2 = c5x;
			string a_3 = "LaserHit";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			bool a_5 = true;
			bool a_6 = true;
			float? a_7 = dz6.b();
			a7j item4 = new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null);
			qy.ad().Add(item4);
			base.vg().q().c().a("LaserShoot" + Guid.NewGuid().ToString(), "LaserShoot", 1f, c9z.a, false, false);
			b0b.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06007F41 RID: 32577 RVA: 0x0035E04C File Offset: 0x0035C24C
	private cwt a(efk A_0, efk A_1)
	{
		cwt cwt = new cwt();
		cwt.b = true;
		cwt.e = (!A_1.ImmuneToCriticalHits && euf.a(A_0.Offense.a0()));
		cwt.i = new ap9(A_0);
		cwt.j = new ap9(A_1);
		cwt.f = new List<csk>();
		cwt.f.Add(euf.a(zv.c, 1.0 + (cwt.e ? A_0.Offense.am() : 0.0)));
		cwt.h = ImpactSpeed.VeryHigh;
		cwt.k = "Третий глаз";
		return cwt;
	}
}
