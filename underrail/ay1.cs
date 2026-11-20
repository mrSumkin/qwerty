using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A56 RID: 2646
[eiz("ULBXJ")]
[Serializable]
public sealed class ay1 : cze, ISerializable
{
	// Token: 0x06003E97 RID: 16023 RVA: 0x00179E90 File Offset: 0x00178090
	private ay1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E98 RID: 16024 RVA: 0x00179E9C File Offset: 0x0017809C
	public ay1()
	{
	}

	// Token: 0x06003E99 RID: 16025 RVA: 0x00179EA8 File Offset: 0x001780A8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		b0e b0e = null;
		axh axh = null;
		bool flag = false;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
		{
			b0e = (c5x.s.b as b0e);
			axh = c5x.GetAspect<axh>();
			flag = (b0e != null && axh != null);
		}
		if (!flag)
		{
			c5x = (A_1 as c5x);
			b0e = (c5x.s.b as b0e);
			axh = c5x.GetAspect<axh>();
			flag = (b0e != null && axh != null);
		}
		if (flag)
		{
			if (axh != null && axh.f() && b0e != null && !b0e.q())
			{
				c5x.p.b.a[1].d = null;
				return;
			}
			c5x.p.b.a[1].d = new float?(0f);
		}
	}
}
