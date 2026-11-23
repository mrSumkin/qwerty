using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000B6B RID: 2923
[eiz("TCHPTRE")]
[Serializable]
public sealed class bhy : cze, ISerializable
{
	// Token: 0x060042F0 RID: 17136 RVA: 0x001A2620 File Offset: 0x001A0820
	private bhy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060042F1 RID: 17137 RVA: 0x001A262C File Offset: 0x001A082C
	public bhy()
	{
	}

	// Token: 0x060042F2 RID: 17138 RVA: 0x001A2638 File Offset: 0x001A0838
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = A_0.Area;
		if (aud != null)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "tch_mut_l" + 2.ToString()) + ".uzl");
			aud.Zone.a(a_, 1, null);
		}
	}
}
