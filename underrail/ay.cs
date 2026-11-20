using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001067 RID: 4199
[eiz("PIJ1")]
[Serializable]
public sealed class ay : cze, ISerializable
{
	// Token: 0x06005744 RID: 22340 RVA: 0x0026231C File Offset: 0x0026051C
	private ay(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x00262328 File Offset: 0x00260528
	public ay()
	{
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x00262334 File Offset: 0x00260534
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			aru aru = c5x.c();
			aru.a("polarization", false);
			aru.a("polarization", "Xpbl_Polarization", 1f, c9z.a, true, false);
		}
	}
}
