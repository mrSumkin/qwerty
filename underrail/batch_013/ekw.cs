using System;
using System.Runtime.Serialization;

// Token: 0x02001A87 RID: 6791
[eiz("PVAF")]
[Serializable]
public sealed class ekw : els, ISerializable
{
	// Token: 0x06009374 RID: 37748 RVA: 0x003A282C File Offset: 0x003A0A2C
	private ekw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009375 RID: 37749 RVA: 0x003A2838 File Offset: 0x003A0A38
	public ekw() : base(ekw.a, "Позитивный аффект пустоты", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.PositiveVoidAffliction";
		base.Stacking = axm.b;
	}

	// Token: 0x06009376 RID: 37750 RVA: 0x003A2870 File Offset: 0x003A0A70
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PositiveVoidAffliction", new object[0]);
	}

	// Token: 0x040038A3 RID: 14499
	public new static string a = "positiveVoidAffliction";
}
