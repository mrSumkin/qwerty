using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AA2 RID: 2722
[eiz("S23")]
[Serializable]
public sealed class gf : cze
{
	// Token: 0x06003FB4 RID: 16308 RVA: 0x00182EFC File Offset: 0x001810FC
	private gf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S23:S");
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x00182F18 File Offset: 0x00181118
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S23:S", this.a);
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x00182F34 File Offset: 0x00181134
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x00182F3C File Offset: 0x0018113C
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x00182F48 File Offset: 0x00181148
	public gf()
	{
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x00182F54 File Offset: 0x00181154
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count > 2)
			{
				if (c5x.p.b.a[0].a == "Objects\\Devices\\BACamera")
				{
					if (this.a)
					{
						c5x.p.b.a[1].d = new float?(0.85f);
					}
					else
					{
						c5x.p.b.a[1].d = new float?(0f);
					}
				}
				else if (this.a)
				{
					c5x.p.b.a[2].d = new float?(1f);
				}
				else
				{
					c5x.p.b.a[2].d = new float?(0f);
				}
				if (c5x.t.b != null)
				{
					c5x.t.b.y6()[ddq.b] = null;
				}
			}
		}
	}

	// Token: 0x04001BDE RID: 7134
	private new bool a;
}
