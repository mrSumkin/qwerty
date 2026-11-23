using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020015FA RID: 5626
[eiz("L72")]
[Serializable]
public sealed class ege : a6k, ISerializable
{
	// Token: 0x06007BCD RID: 31693 RVA: 0x0033E4C8 File Offset: 0x0033C6C8
	private ege(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007BCE RID: 31694 RVA: 0x0033E4D4 File Offset: 0x0033C6D4
	public ege()
	{
	}

	// Token: 0x06007BCF RID: 31695 RVA: 0x0033E4E0 File Offset: 0x0033C6E0
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
		bfq bfq = new bfq();
		bfq.b("xpbl_LimitedTemporalIncrement" + Guid.NewGuid().ToString());
		bfq.c("xpbl_LimitedTemporalIncrement");
		qy.ad().Add(new a4s(bfq, null, new ar7(c5x), null));
		c5x a_ = c5x;
		string a_2 = "Xpbl_LimitedTemporalIncrement";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = false;
		bool a_5 = true;
		Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, c5x.Size.Z));
		float? a_7 = dz6.b();
		a7j item = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
		qy.ad().Add(item);
		List<auv> list = qy.ad();
		e7m e7m = new e7m();
		e7m.a(-e6g.d);
		list.Add(new a4s(e7m, null, new ar7(c5x), null));
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
