using System;
using System.Runtime.Serialization;

// Token: 0x02001B04 RID: 6916
[eiz("ZME")]
[Serializable]
public sealed class dal : els, ISerializable
{
	// Token: 0x060095C0 RID: 38336 RVA: 0x003AB21C File Offset: 0x003A941C
	private dal(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095C1 RID: 38337 RVA: 0x003AB228 File Offset: 0x003A9428
	public dal() : base(dal.a, "Мутация", ci8.c)
	{
		base.Duration = 3 * d0u.b;
		base.Icon = "Status.ZombieMutating";
		base.Stacking = axm.b;
		base.ExpiredAction = "ZombieMutationAction";
	}

	// Token: 0x060095C2 RID: 38338 RVA: 0x003AB270 File Offset: 0x003A9470
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ZombieMutating", new object[0]);
	}

	// Token: 0x040039A5 RID: 14757
	public new static string a = "zombieMutating";
}
