using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010F3 RID: 4339
[eiz("SCGLJ")]
[Serializable]
public sealed class az4 : cze, ISerializable
{
	// Token: 0x06005BDF RID: 23519 RVA: 0x002767E4 File Offset: 0x002749E4
	private az4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SCGLJ:I", typeof(Guid?));
		this.c = A_0.GetString("SCGLJ:A");
		this.a = (A_0.GetValue("SCGLJ:L", typeof(bt4)) as bt4);
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x00276858 File Offset: 0x00274A58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCGLJ:I", this.b);
		info.AddValue("SCGLJ:A", this.c);
		info.AddValue("SCGLJ:L", this.a);
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x002768A8 File Offset: 0x00274AA8
	public bt4 c()
	{
		return this.a;
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x002768B0 File Offset: 0x00274AB0
	public void a(bt4 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x002768BC File Offset: 0x00274ABC
	public string a()
	{
		return this.c;
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x002768C4 File Offset: 0x00274AC4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x002768D0 File Offset: 0x00274AD0
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x002768D8 File Offset: 0x00274AD8
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x002768E4 File Offset: 0x00274AE4
	public az4()
	{
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x002768F8 File Offset: 0x00274AF8
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = cze.a(this.c, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			bm6 bm = c5x.t.b;
			if (bm != null)
			{
				bm.y6()[ddq.ay] = this.a;
			}
		}
	}

	// Token: 0x040024B6 RID: 9398
	private new bt4 a = new bt4();

	// Token: 0x040024B7 RID: 9399
	private Guid? b;

	// Token: 0x040024B8 RID: 9400
	private string c;
}
