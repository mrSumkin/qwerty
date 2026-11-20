using System;
using System.Runtime.Serialization;

// Token: 0x02001A99 RID: 6809
[eiz("CSE8")]
[Serializable]
public sealed class ah8 : els, ISerializable
{
	// Token: 0x060093C8 RID: 37832 RVA: 0x003A3D68 File Offset: 0x003A1F68
	private ah8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093C9 RID: 37833 RVA: 0x003A3D78 File Offset: 0x003A1F78
	public ah8(int A_0, int A_1) : base(ah8.a, "Под напряжением", ci8.b)
	{
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "DamageType.Electricity";
		base.MaxStacks = 100;
		base.Stacks = A_1;
		base.Stacking = axm.b;
	}

	// Token: 0x060093CA RID: 37834 RVA: 0x003A3DC8 File Offset: 0x003A1FC8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Charged", new object[]
		{
			base.Stacks
		});
	}

	// Token: 0x040038C9 RID: 14537
	public new static readonly string a = "charged";
}
