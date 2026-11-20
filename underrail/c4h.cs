using System;
using System.Runtime.Serialization;

// Token: 0x02001605 RID: 5637
[eiz("IY")]
[Serializable]
public sealed class c4h : a6k, ISerializable
{
	// Token: 0x06007C06 RID: 31750 RVA: 0x00340B6C File Offset: 0x0033ED6C
	private c4h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C07 RID: 31751 RVA: 0x00340B78 File Offset: 0x0033ED78
	public c4h()
	{
	}

	// Token: 0x06007C08 RID: 31752 RVA: 0x00340B80 File Offset: 0x0033ED80
	protected override dc4 dt()
	{
		if (!(base.vg().h() is c5x))
		{
			return dc4.e;
		}
		return dc4.b;
	}

	// Token: 0x06007C09 RID: 31753 RVA: 0x00340B9C File Offset: 0x0033ED9C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead)
		{
			return dc4.e;
		}
		qy qy = new qy();
		awq.a(qy, base.vg().q(), c5x, true, true);
		qy.ad().Add(new amd(c5x.h.b, new els[]
		{
			new cpy(ezt.a(base.vg().e()), ezt.e * d0u.b)
		}));
		c5x.Zone.ActionManager.g9(qy, atp.a);
		dz6.a(qy);
		return dc4.c;
	}
}
