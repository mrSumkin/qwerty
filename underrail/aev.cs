using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001479 RID: 5241
[eiz("VRZ")]
[Serializable]
public sealed class aev : a6k
{
	// Token: 0x06007649 RID: 30281 RVA: 0x00320188 File Offset: 0x0031E388
	private aev(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600764A RID: 30282 RVA: 0x00320194 File Offset: 0x0031E394
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = this.fm() as c5x;
		if (c5x == null)
		{
			return dc4.e;
		}
		wv wv = c5x.GetAspect<bim>() as wv;
		if (wv == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh == null)
		{
			return dc4.e;
		}
		int num = a1o.a(coh);
		if (num > 0)
		{
			double a = wv.a(num);
			if (base.vg().q() != null)
			{
				bmj.a(c5x, new e5x("Починено +" + Math.Ceiling(a).ToString(), Color.White, null, false));
				vr a_ = new vr(new ap9(base.vg().q().h.b.aa()), null, "{0} починено " + c5x.y8() + ".", null, null);
				bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
				a7v.a(a_);
				base.vg().q().c().a("VehicleItemRepair", "VehicleItemRepair", 1f, c9z.a, false, false);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x0600764B RID: 30283 RVA: 0x003202E4 File Offset: 0x0031E4E4
	public aev()
	{
	}
}
