using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B70 RID: 2928
[eiz("FOTPPJ")]
[Serializable]
public sealed class ewa : cze, ISerializable
{
	// Token: 0x06004302 RID: 17154 RVA: 0x001A2BC8 File Offset: 0x001A0DC8
	private ewa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004303 RID: 17155 RVA: 0x001A2BD4 File Offset: 0x001A0DD4
	public ewa()
	{
	}

	// Token: 0x06004304 RID: 17156 RVA: 0x001A2BDC File Offset: 0x001A0DDC
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.s.b != null)
		{
			c5x.s.b.s().Clear();
			c5x.s.b.s().Add(new dz7());
			c5x.s.b.s().Add(new e68
			{
				Destination = new c2w("fo_prisonCave", "FromEast")
			});
			c5x.q("Лаз");
		}
	}
}
