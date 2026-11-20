using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200195A RID: 6490
[eiz("VPII")]
[Serializable]
public sealed class agt : coh, IItemInstance<b81>, ISerializable
{
	// Token: 0x06008AA4 RID: 35492 RVA: 0x0038D6C4 File Offset: 0x0038B8C4
	private agt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008AA5 RID: 35493 RVA: 0x0038D6D0 File Offset: 0x0038B8D0
	public b81 fu()
	{
		return base.Definition as b81;
	}

	// Token: 0x06008AA6 RID: 35494 RVA: 0x0038D6E0 File Offset: 0x0038B8E0
	public agt(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008AA7 RID: 35495 RVA: 0x0038D6EC File Offset: 0x0038B8EC
	public override coh fy()
	{
		agt agt = new agt(base.DefinitionProvider.wm());
		this.fz(agt);
		return agt;
	}

	// Token: 0x06008AA8 RID: 35496 RVA: 0x0038D714 File Offset: 0x0038B914
	public override bool anx(efk A_0)
	{
		return A_0 != null && A_0.Bag.h(this) && ((this.fu() != null && this.fu().m()) || !A_0.IsInCombat);
	}

	// Token: 0x06008AA9 RID: 35497 RVA: 0x0038D764 File Offset: 0x0038B964
	public void a(bcx A_0)
	{
		if (this.fu() != null)
		{
			this.fu().qq(A_0, this);
		}
	}
}
