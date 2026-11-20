using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A9D RID: 2717
[eiz("S21A")]
[Serializable]
public sealed class b4 : cze
{
	// Token: 0x06003FA0 RID: 16288 RVA: 0x00182844 File Offset: 0x00180A44
	private b4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S21A:S");
		this.b = (Color)A_0.GetValue("S21A:C", typeof(Color));
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x0018288C File Offset: 0x00180A8C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S21A:S", this.a);
		info.AddValue("S21A:C", this.b);
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x001828C0 File Offset: 0x00180AC0
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x001828C8 File Offset: 0x00180AC8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x001828D4 File Offset: 0x00180AD4
	public Color b()
	{
		return this.b;
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x001828DC File Offset: 0x00180ADC
	public void a(Color A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x001828E8 File Offset: 0x00180AE8
	public b4()
	{
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x001828F4 File Offset: 0x00180AF4
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
					c5x.p.b.a[1].d = new float?(0.2f);
					c5x.p.b.a[2].c = new Color?(this.b);
					c5x.p.b.a[2].d = new float?(0.15f);
					c5x.p.b.a[3].c = new Color?(this.b);
					c5x.p.b.a[3].d = new float?(0.1f);
					return;
				}
				c5x.p.b.a[1].c = null;
				c5x.p.b.a[1].d = new float?(0f);
				c5x.p.b.a[2].c = null;
				c5x.p.b.a[2].d = new float?(0f);
				c5x.p.b.a[3].c = null;
				c5x.p.b.a[3].d = new float?(0f);
			}
		}
	}

	// Token: 0x04001BDC RID: 7132
	private new bool a;

	// Token: 0x04001BDD RID: 7133
	private Color b;
}
