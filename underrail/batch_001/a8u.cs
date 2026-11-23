using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200179F RID: 6047
[eiz("CMCA2")]
[Serializable]
public sealed class a8u : a6k, ISerializable
{
	// Token: 0x0600817B RID: 33147 RVA: 0x00368C3C File Offset: 0x00366E3C
	private a8u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600817C RID: 33148 RVA: 0x00368C48 File Offset: 0x00366E48
	public a8u()
	{
	}

	// Token: 0x0600817D RID: 33149 RVA: 0x00368C54 File Offset: 0x00366E54
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h.b == null || c5x.h.b.aa().Dead || c5x.Zone == null)
		{
			return dc4.e;
		}
		if (c5x.h.b.aa().b(d8o.e))
		{
			vr a_ = new vr(new ap9(c5x.h.b.aa()), null, "Машины не могут курить сигары.", new Color?(adi.m), null);
			bey.a(a_, c5x.h.b.aa(), c5x.h.b);
			a7v.a(a_);
			return dc4.e;
		}
		boj.a(c5x, "CigarSmoke", 2, double.MaxValue, true, false, new Vector3?(new Vector3(0.45f, 0f, 0.6f)), null, null, null, false);
		eys a_2 = new eys(eys.c);
		c5x.h.b.aa().StatusEffects.a(a_2, false, false, false);
		return dc4.c;
	}
}
