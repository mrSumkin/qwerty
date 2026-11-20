using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A58 RID: 2648
[eiz("UFBXJ")]
[Serializable]
public sealed class bre : cze, ISerializable
{
	// Token: 0x06003E9D RID: 16029 RVA: 0x0017A20C File Offset: 0x0017840C
	private bre(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E9E RID: 16030 RVA: 0x0017A218 File Offset: 0x00178418
	public bre()
	{
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x0017A224 File Offset: 0x00178424
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_0 as c5x;
		if (c5x != null && c5x.p.b != null && c5x.p.b.a.Count >= 3)
		{
			d2b aspect = c5x.GetAspect<d2b>();
			bool flag = aspect != null && aspect.n();
			c5x.p.b.a[2].c = new Color?(flag ? new Color(255, 0, 0, 255) : new Color(0, 255, 0, 255));
		}
	}
}
