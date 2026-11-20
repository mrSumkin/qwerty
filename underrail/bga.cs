using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001028 RID: 4136
[eiz("B67")]
[Serializable]
public sealed class bga : cze, ISerializable
{
	// Token: 0x06005560 RID: 21856 RVA: 0x0025B424 File Offset: 0x00259624
	private bga(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("B67:D");
	}

	// Token: 0x06005561 RID: 21857 RVA: 0x0025B440 File Offset: 0x00259640
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("B67:D", this.a);
	}

	// Token: 0x06005562 RID: 21858 RVA: 0x0025B45C File Offset: 0x0025965C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x0025B464 File Offset: 0x00259664
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x0025B470 File Offset: 0x00259670
	public bga()
	{
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x0025B47C File Offset: 0x0025967C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int && (int)obj >= this.a)
			{
				dm0.a(c5x);
			}
		}
	}

	// Token: 0x040022C4 RID: 8900
	private new int a;
}
