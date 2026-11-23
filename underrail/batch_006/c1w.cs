using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x0200155E RID: 5470
[eiz("XSBA")]
[Serializable]
public sealed class c1w : d64, ISerializable
{
	// Token: 0x060079D9 RID: 31193 RVA: 0x0032FE50 File Offset: 0x0032E050
	private c1w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060079DA RID: 31194 RVA: 0x0032FE5C File Offset: 0x0032E05C
	public c1w()
	{
	}

	// Token: 0x060079DB RID: 31195 RVA: 0x0032FE64 File Offset: 0x0032E064
	protected override bool gq()
	{
		di di = Enumerable.FirstOrDefault<di>(base.c().aa().StatusEffects.Get<di>());
		if (di != null)
		{
			base.c().aa().StatusEffects.d(di);
		}
		return true;
	}
}
