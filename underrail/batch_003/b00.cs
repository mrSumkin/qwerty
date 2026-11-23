using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001030 RID: 4144
[eiz("AAAMPJ")]
[Serializable]
public sealed class b00 : cze, ISerializable
{
	// Token: 0x06005593 RID: 21907 RVA: 0x0025BF78 File Offset: 0x0025A178
	private b00(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("AAAMPJ:A");
		this.b = A_0.GetInt32("AAAMPJ:M");
	}

	// Token: 0x06005594 RID: 21908 RVA: 0x0025BFA4 File Offset: 0x0025A1A4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AAAMPJ:A", this.a);
		info.AddValue("AAAMPJ:M", this.b);
	}

	// Token: 0x06005595 RID: 21909 RVA: 0x0025BFD0 File Offset: 0x0025A1D0
	public int b()
	{
		return this.a;
	}

	// Token: 0x06005596 RID: 21910 RVA: 0x0025BFD8 File Offset: 0x0025A1D8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005597 RID: 21911 RVA: 0x0025BFE4 File Offset: 0x0025A1E4
	public int a()
	{
		return this.b;
	}

	// Token: 0x06005598 RID: 21912 RVA: 0x0025BFEC File Offset: 0x0025A1EC
	public void b(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005599 RID: 21913 RVA: 0x0025BFF8 File Offset: 0x0025A1F8
	public b00()
	{
	}

	// Token: 0x0600559A RID: 21914 RVA: 0x0025C004 File Offset: 0x0025A204
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null)
		{
			d4n d4n = dz6.b(c5x.h.b.aa());
			if (d4n != null)
			{
				d4n.c += (double)this.a;
				d4n.d += (double)this.b;
			}
		}
	}

	// Token: 0x040022D2 RID: 8914
	private new int a;

	// Token: 0x040022D3 RID: 8915
	private int b;
}
