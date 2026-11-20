using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FCD RID: 4045
[eiz("ISMC")]
[Serializable]
public sealed class erj : dnh, ISerializable
{
	// Token: 0x0600532F RID: 21295 RVA: 0x0024FDCC File Offset: 0x0024DFCC
	private erj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005330 RID: 21296 RVA: 0x0024FDD8 File Offset: 0x0024DFD8
	public erj()
	{
	}

	// Token: 0x06005331 RID: 21297 RVA: 0x0024FDE4 File Offset: 0x0024DFE4
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		List<int> classPropertyValue = A_0.GetClassPropertyValue<List<int>>("SpecialMercandiseLevels");
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Skills.Get<e70>().g() >= classPropertyValue[0])
			{
				return true;
			}
		}
		return false;
	}
}
