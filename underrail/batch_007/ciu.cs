using System;
using System.Runtime.Serialization;

// Token: 0x02001B2C RID: 6956
[eiz("APH")]
[Serializable]
public sealed class ciu : els, ISerializable
{
	// Token: 0x0600966E RID: 38510 RVA: 0x003AD9C4 File Offset: 0x003ABBC4
	private ciu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600966F RID: 38511 RVA: 0x003AD9D0 File Offset: 0x003ABBD0
	public ciu(int A_0) : base("aphobia", "Афобия", ci8.b)
	{
		base.Icon = "Status.7";
		base.Duration = A_0;
		base.StaticEffects.Add(new atq());
	}

	// Token: 0x06009670 RID: 38512 RVA: 0x003ADA10 File Offset: 0x003ABC10
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Aphobia");
	}
}
