using System;
using System.Runtime.Serialization;

// Token: 0x02001948 RID: 6472
[elw(typeof(k7))]
[eiz("HI")]
[Serializable]
public sealed class bqu : eya, ISerializable
{
	// Token: 0x060089BB RID: 35259 RVA: 0x0038AEA8 File Offset: 0x003890A8
	private bqu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060089BC RID: 35260 RVA: 0x0038AEB4 File Offset: 0x003890B4
	public override string tv()
	{
		return "Очки/шлем";
	}

	// Token: 0x060089BD RID: 35261 RVA: 0x0038AEBC File Offset: 0x003890BC
	public bqu()
	{
	}

	// Token: 0x060089BE RID: 35262 RVA: 0x0038AEC8 File Offset: 0x003890C8
	public override bk3 tw()
	{
		bqu bqu = new bqu();
		this.ai7(bqu);
		return bqu;
	}
}
