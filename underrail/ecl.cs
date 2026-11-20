using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AA6 RID: 2726
[eiz("S20")]
[Serializable]
public sealed class ecl : cze
{
	// Token: 0x06003FC6 RID: 16326 RVA: 0x00183414 File Offset: 0x00181614
	private ecl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S20:S");
		this.b = (Color)A_0.GetValue("S20:C", typeof(Color));
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x0018345C File Offset: 0x0018165C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S20:S", this.a);
		info.AddValue("S20:C", this.b);
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x00183490 File Offset: 0x00181690
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x00183498 File Offset: 0x00181698
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x001834A4 File Offset: 0x001816A4
	public Color b()
	{
		return this.b;
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x001834AC File Offset: 0x001816AC
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x001834B8 File Offset: 0x001816B8
	public ecl()
	{
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x001834C4 File Offset: 0x001816C4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count > 2)
			{
				if (this.a)
				{
					c5x.p.b.a[1].c = new Color?(this.b);
					c5x.p.b.a[1].d = new float?(0.9f);
					c5x.p.b.a[2].c = new Color?(this.b);
					c5x.p.b.a[2].d = new float?(0.75f);
					return;
				}
				c5x.p.b.a[1].c = null;
				c5x.p.b.a[1].d = new float?(0f);
				c5x.p.b.a[2].c = null;
				c5x.p.b.a[2].d = new float?(0.65f);
			}
		}
	}

	// Token: 0x04001BE0 RID: 7136
	private new bool a;

	// Token: 0x04001BE1 RID: 7137
	private Color b;
}
