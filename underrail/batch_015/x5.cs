using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AA3 RID: 2723
[eiz("S22")]
[Serializable]
public sealed class x5 : cze
{
	// Token: 0x06003FBA RID: 16314 RVA: 0x001830B0 File Offset: 0x001812B0
	private x5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("S22:S");
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x001830CC File Offset: 0x001812CC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("S22:S", this.a);
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x001830E8 File Offset: 0x001812E8
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x001830F0 File Offset: 0x001812F0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x001830FC File Offset: 0x001812FC
	public x5()
	{
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x00183104 File Offset: 0x00181304
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 2)
			{
				if (this.a)
				{
					c5x.p.b.a[1].d = new float?(0.75f);
					return;
				}
				c5x.p.b.a[1].d = new float?(0f);
			}
		}
	}

	// Token: 0x04001BDF RID: 7135
	private new bool a;
}
