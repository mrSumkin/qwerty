using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AA7 RID: 2727
[eiz("SLS")]
[Serializable]
public sealed class euh : cze, ISerializable
{
	// Token: 0x06003FCE RID: 16334 RVA: 0x00183640 File Offset: 0x00181840
	private euh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SLS:S");
		this.b = (Color)A_0.GetValue("SLS:C", typeof(Color));
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x00183688 File Offset: 0x00181888
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLS:S", this.a);
		info.AddValue("SLS:C", this.b);
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x001836BC File Offset: 0x001818BC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x001836C4 File Offset: 0x001818C4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x001836D0 File Offset: 0x001818D0
	public Color b()
	{
		return this.b;
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x001836D8 File Offset: 0x001818D8
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x001836E4 File Offset: 0x001818E4
	public euh()
	{
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x001836F0 File Offset: 0x001818F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
			{
				if (this.a)
				{
					c5x.p.b.a[1].c = new Color?(this.b);
					c5x.p.b.a[1].d = new float?(0.9f);
					return;
				}
				c5x.p.b.a[1].c = null;
				c5x.p.b.a[1].d = new float?(0.5f);
			}
		}
	}

	// Token: 0x04001BE2 RID: 7138
	private new bool a;

	// Token: 0x04001BE3 RID: 7139
	private Color b;
}
