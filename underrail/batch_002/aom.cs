using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000B23 RID: 2851
[eiz("XPBLLABTJ")]
[Serializable]
public sealed class aom : cze, ISerializable
{
	// Token: 0x060041D1 RID: 16849 RVA: 0x00197134 File Offset: 0x00195334
	private aom(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x00197140 File Offset: 0x00195340
	public aom()
	{
	}

	// Token: 0x060041D3 RID: 16851 RVA: 0x00197148 File Offset: 0x00195348
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		object obj;
		if (c5x != null && A_2 != null && A_2.TryGetValue("tickCount", out obj) && obj is int)
		{
			int num = (int)obj;
			ak1 ak = c5x.Area.a(c5x.aj().a());
			if (ak != null)
			{
				new dku(new edx(ak), null, true, true, false).ym(A_0, A_1, null);
			}
			if (num >= 8)
			{
				c5x.RemoveAspect<dm>();
				if (c5x.p.b != null && c5x.p.b.a.Count >= 2)
				{
					c5x.p.b.a[0].b = new Point(2, 0);
					c5x.p.b.a.RemoveAt(1);
				}
				if (c5x.v.b != null)
				{
					c5x.v.b.a("leak", false);
				}
			}
		}
	}
}
