using System;
using System.Runtime.Serialization;

// Token: 0x02001A73 RID: 6771
[eiz("SMTDSE")]
[Serializable]
public sealed class dm3 : els, ISerializable
{
	// Token: 0x0600930D RID: 37645 RVA: 0x003A0F18 File Offset: 0x0039F118
	private dm3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600930E RID: 37646 RVA: 0x003A0F24 File Offset: 0x0039F124
	public dm3(int A_0) : base("sensorimotorTransferenceDisruption", "Нарушение указаний сенсомоторики", ci8.c)
	{
		base.Icon = "Status.134";
		base.Stacking = axm.b;
		base.MaxStacks = 5;
		base.Duration = A_0;
	}

	// Token: 0x0600930F RID: 37647 RVA: 0x003A0F64 File Offset: 0x0039F164
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SensorimotorTransferenceDisruption", new object[]
		{
			base.Stacks
		});
	}
}
