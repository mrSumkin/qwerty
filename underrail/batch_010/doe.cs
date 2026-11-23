using System;
using System.Runtime.Serialization;

// Token: 0x02001ADD RID: 6877
[eiz("NBSE")]
[Serializable]
public sealed class doe : els, ISerializable
{
	// Token: 0x06009506 RID: 38150 RVA: 0x003A86B8 File Offset: 0x003A68B8
	private doe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009507 RID: 38151 RVA: 0x003A86C4 File Offset: 0x003A68C4
	public doe(int A_0, int A_1) : base(doe.a, "Усиление инициативы", ci8.b)
	{
		base.Duration = A_0;
		base.Power = A_1;
		base.Icon = "Status.InitiativeBoost";
		base.ExpiredAction = "YellowExpirationAction";
		base.RemovedAction = "YellowExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new b5x(A_1));
	}

	// Token: 0x06009508 RID: 38152 RVA: 0x003A872C File Offset: 0x003A692C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/InitiativeBoost", new object[]
		{
			base.Power
		});
	}

	// Token: 0x04003961 RID: 14689
	public new static readonly string a = "initiativeBoost";
}
