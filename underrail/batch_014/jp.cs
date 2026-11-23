using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ABB RID: 2747
[eiz("XPBLSMGJ")]
[Serializable]
public sealed class jp : cze, ISerializable
{
	// Token: 0x0600401D RID: 16413 RVA: 0x001856B4 File Offset: 0x001838B4
	private jp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x001856C0 File Offset: 0x001838C0
	public jp()
	{
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x001856CC File Offset: 0x001838CC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			d60 d = serviceOrThrow.aqw().a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"spawnGore"
				}))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.o.b != null)
					{
						c5x.o.b.d = new float?((float)1);
					}
				}
			}
		}
	}
}
