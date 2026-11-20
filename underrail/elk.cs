using System;
using System.Runtime.Serialization;

// Token: 0x02001B21 RID: 6945
[eiz("OB")]
[Serializable]
public sealed class elk : els, ISerializable
{
	// Token: 0x06009642 RID: 38466 RVA: 0x003AD1C0 File Offset: 0x003AB3C0
	private elk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009643 RID: 38467 RVA: 0x003AD1CC File Offset: 0x003AB3CC
	public elk(int A_0) : base("offBalance", "Неустойчивость", ci8.c)
	{
		base.Icon = "Status.OffBalance";
		base.Duration = A_0;
		base.StaticEffects.Add(new d19(-1f)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new e15(-1f)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009644 RID: 38468 RVA: 0x003AD23C File Offset: 0x003AB43C
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/OffBalance");
	}
}
