using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001063 RID: 4195
[eiz("SCHBMJ")]
[Serializable]
public sealed class cwx : cze, ISerializable
{
	// Token: 0x06005725 RID: 22309 RVA: 0x00261D8C File Offset: 0x0025FF8C
	private cwx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (c2n)A_0.GetValue("SCHBMJ:H", typeof(c2n));
		this.b = (Guid?)A_0.GetValue("SCHBMJ:I", typeof(Guid?));
		this.c = A_0.GetString("SCHBMJ:A");
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x00261DF4 File Offset: 0x0025FFF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCHBMJ:H", this.a);
		info.AddValue("SCHBMJ:I", this.b);
		info.AddValue("SCHBMJ:A", this.c);
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x00261E48 File Offset: 0x00260048
	public c2n b()
	{
		return this.a;
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x00261E50 File Offset: 0x00260050
	public void a(c2n A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x00261E5C File Offset: 0x0026005C
	public Guid? a()
	{
		return this.b;
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x00261E64 File Offset: 0x00260064
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x00261E70 File Offset: 0x00260070
	public string c()
	{
		return this.c;
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x00261E78 File Offset: 0x00260078
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x00261E84 File Offset: 0x00260084
	public cwx()
	{
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x00261E90 File Offset: 0x00260090
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
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
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().HostilityBroadcastMode = this.a;
		}
	}

	// Token: 0x0400234B RID: 9035
	private new c2n a;

	// Token: 0x0400234C RID: 9036
	private Guid? b;

	// Token: 0x0400234D RID: 9037
	private string c;
}
