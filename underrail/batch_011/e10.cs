using System;
using System.Runtime.Serialization;

// Token: 0x02001A72 RID: 6770
[eiz("SMAMPSE")]
[Serializable]
public sealed class e10 : els, ISerializable
{
	// Token: 0x06009309 RID: 37641 RVA: 0x003A0ECC File Offset: 0x0039F0CC
	private e10(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600930A RID: 37642 RVA: 0x003A0ED8 File Offset: 0x0039F0D8
	public e10() : base(e10.a, "Сенсоримоторный стимулятор", ci8.b)
	{
		base.Icon = "Status.133";
		base.Stacking = axm.b;
	}

	// Token: 0x0600930B RID: 37643 RVA: 0x003A0F00 File Offset: 0x0039F100
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/SensorimotorAmplifier");
	}

	// Token: 0x04003875 RID: 14453
	public new static readonly string a = "sensorimotorAmplifier";
}
