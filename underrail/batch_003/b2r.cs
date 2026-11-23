using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010D4 RID: 4308
[eiz("RADJ")]
[Serializable]
public sealed class b2r : cze, ISerializable
{
	// Token: 0x06005ACB RID: 23243 RVA: 0x00271E6C File Offset: 0x0027006C
	private b2r(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x00271E78 File Offset: 0x00270078
	public b2r()
	{
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x00271E84 File Offset: 0x00270084
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			a3f aspect = c5x.GetAspect<a3f>();
			if (aspect != null)
			{
				aspect.a()["Timer"] = 0;
				crx crx = new crx();
				crx.a(c5x.Area.y8());
				crx.a(bbo.a);
				crx.c().Add(c5x.qe());
				crx.ym(null, c5x, null);
			}
		}
	}
}
