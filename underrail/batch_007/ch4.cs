using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001031 RID: 4145
[eiz("BLO4")]
[Serializable]
public sealed class ch4 : cze, ISerializable
{
	// Token: 0x0600559B RID: 21915 RVA: 0x0025C074 File Offset: 0x0025A274
	private ch4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600559C RID: 21916 RVA: 0x0025C080 File Offset: 0x0025A280
	public ch4()
	{
	}

	// Token: 0x0600559D RID: 21917 RVA: 0x0025C088 File Offset: 0x0025A288
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			e1d aspect = c5x.GetAspect<e1d>();
			if (aspect != null)
			{
				aspect.d();
			}
		}
	}
}
