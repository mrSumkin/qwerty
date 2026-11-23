using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020016DE RID: 5854
[eiz("9SB")]
[Serializable]
public sealed class bh0 : a6k, ISerializable
{
	// Token: 0x06007F5A RID: 32602 RVA: 0x0035ECB0 File Offset: 0x0035CEB0
	private bh0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F5B RID: 32603 RVA: 0x0035ECBC File Offset: 0x0035CEBC
	public bh0()
	{
	}

	// Token: 0x06007F5C RID: 32604 RVA: 0x0035ECC8 File Offset: 0x0035CEC8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (base.vg().q() == null || (base.vg().q().h.b == null | c5x == null) || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		if (c5x.h.b.aa().Passive || c5x.h.b.aa().b(d8o.e))
		{
			etm a_ = new etm(new ap9(c5x.h.b.aa()), "вытягиванию крови");
			bey.a(a_, base.vg().e().b8(), c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			bmj.a(c5x, new ba0());
			return dc4.e;
		}
		c5x.c().a("BloodSiphon", "BloodSiphon", 1f, c9z.a, false, false);
		double num = 1.0;
		bfm bfm = Enumerable.FirstOrDefault<bfm>(c5x.h.b.aa().StatusEffects.Get<bfm>());
		if (bfm != null)
		{
			num = 1.0 + (double)bfm.Stacks * bfm.b;
		}
		int num2 = (int)((double)ctx.a(base.vg().e()) * num);
		cwt cwt = new cwt();
		cwt.i = new ap9(base.vg().q().h.b.aa());
		cwt.j = new ap9(c5x.h.b.aa());
		cwt.p = true;
		cwt.l = true;
		cwt.v = "отсос крови";
		cwt.b = true;
		cwt.h = ImpactSpeed.VeryLow;
		cwt.w = true;
		cwt.r = true;
		cwt.f.Add(new csk(DamageType.Mechanical, num2));
		c5x.h.b.aa().Defense.a(cwt);
		base.vg().q().h.b.aa().Defense.a(num2, base.vg().q().h.b.aa(), null, true, false, false, null);
		return dc4.c;
	}
}
