using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000ABE RID: 2750
[eiz("XPBLFEQ")]
[Serializable]
public sealed class ain : cze, ISerializable
{
	// Token: 0x06004027 RID: 16423 RVA: 0x00185D20 File Offset: 0x00183F20
	private ain(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x00185D2C File Offset: 0x00183F2C
	public ain()
	{
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x00185D38 File Offset: 0x00183F38
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			foreach (eza eza in Enumerable.ToList<eza>(serviceOrThrow.aqu().t().c()))
			{
				if (eza.Value.Group == ca3.s)
				{
					serviceOrThrow.aqz().atd(eza.Value.Name, true);
				}
			}
		}
	}
}
