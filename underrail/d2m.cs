using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000ABF RID: 2751
[eiz("XPBLFPQ")]
[Serializable]
public sealed class d2m : cze, ISerializable
{
	// Token: 0x0600402A RID: 16426 RVA: 0x00185DDC File Offset: 0x00183FDC
	private d2m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x00185DE8 File Offset: 0x00183FE8
	public d2m()
	{
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x00185DF4 File Offset: 0x00183FF4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (eza eza in Enumerable.ToList<eza>(serviceOrThrow.aqu().t().c()))
			{
				if (eza.Value.Group == ca3.t)
				{
					serviceOrThrow.aqz().atd(eza.Value.Name, true);
				}
			}
		}
	}
}
