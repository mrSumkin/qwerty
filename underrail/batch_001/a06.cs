using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200193E RID: 6462
[eiz("EII")]
[Serializable]
public abstract class a06 : coh, IItemInstance<diz>, ISerializable
{
	// Token: 0x06008923 RID: 35107 RVA: 0x0038927C File Offset: 0x0038747C
	protected a06(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008924 RID: 35108 RVA: 0x00389288 File Offset: 0x00387488
	public diz fu()
	{
		return base.Definition as diz;
	}

	// Token: 0x06008925 RID: 35109 RVA: 0x00389298 File Offset: 0x00387498
	protected a06(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008926 RID: 35110 RVA: 0x003892A4 File Offset: 0x003874A4
	public override bool anx(efk A_0)
	{
		if (base.Definition != null && base.Definition.v)
		{
			return A_0 != null && A_0.Gear.a(this);
		}
		return this.fu() == null || !this.fu().at() || A_0 == null || A_0.Gear.b(base.Id) == this;
	}
}
