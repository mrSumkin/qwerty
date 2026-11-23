using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001047 RID: 4167
[eiz("EISEE")]
[Serializable]
public sealed class etg : cze, ISerializable
{
	// Token: 0x06005654 RID: 22100 RVA: 0x0025EC5C File Offset: 0x0025CE5C
	private etg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x0025EC68 File Offset: 0x0025CE68
	public etg()
	{
	}

	// Token: 0x06005656 RID: 22102 RVA: 0x0025EC74 File Offset: 0x0025CE74
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead)
		{
			c5x.h.b.aa().Offense.d(-1000000, true);
		}
	}
}
