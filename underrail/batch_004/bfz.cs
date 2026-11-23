using System;
using System.Runtime.Serialization;

// Token: 0x02001B0E RID: 6926
[eiz("Y2")]
[Serializable]
public sealed class bfz : els, ISerializable
{
	// Token: 0x060095F0 RID: 38384 RVA: 0x003ABDF8 File Offset: 0x003A9FF8
	private bfz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095F1 RID: 38385 RVA: 0x003ABE04 File Offset: 0x003AA004
	public bfz(int A_0) : base("lastStand", "Последний рубеж", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "LastStand";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.ExpiredAction = "LastStandExpiresAction";
		base.RemovedAction = "LastStandExpiresAction";
	}

	// Token: 0x060095F2 RID: 38386 RVA: 0x003ABE58 File Offset: 0x003AA058
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/LastStand", new object[0]);
	}
}
