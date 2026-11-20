using System;
using System.Runtime.Serialization;

// Token: 0x02001A7D RID: 6781
[eiz("NVAF")]
[Serializable]
public sealed class ax5 : els, ISerializable
{
	// Token: 0x06009344 RID: 37700 RVA: 0x003A1C7C File Offset: 0x0039FE7C
	private ax5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009345 RID: 37701 RVA: 0x003A1C8C File Offset: 0x0039FE8C
	public ax5() : base(ax5.a, "Негативный аффект пустоты", ci8.c)
	{
		base.Duration = 0;
		base.Icon = "Status.NegativeVoidAffliction";
		base.Stacking = axm.b;
	}

	// Token: 0x06009346 RID: 37702 RVA: 0x003A1CC4 File Offset: 0x0039FEC4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/NegativeVoidAffliction", new object[0]);
	}

	// Token: 0x04003884 RID: 14468
	public new static string a = "negativeVoidAffliction";
}
