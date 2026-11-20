using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000AC0 RID: 2752
[eiz("XPBLFDQ")]
[Serializable]
public sealed class ahy : cze, ISerializable
{
	// Token: 0x0600402D RID: 16429 RVA: 0x00185E98 File Offset: 0x00184098
	private ahy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x00185EA4 File Offset: 0x001840A4
	public ahy()
	{
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x00185EB0 File Offset: 0x001840B0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (eza eza in Enumerable.ToList<eza>(serviceOrThrow.aqu().t().c()))
			{
				if (eza.Value.Group == ca3.p)
				{
					serviceOrThrow.aqz().atd(eza.Value.Name, true);
				}
			}
		}
	}
}
