using System;
using System.Runtime.Serialization;

// Token: 0x02001991 RID: 6545
[dn2("PoisonBurstVisual")]
[eiz("PBVHE")]
[Serializable]
public sealed class cjc : buu, ISerializable
{
	// Token: 0x06008BE2 RID: 35810 RVA: 0x00390378 File Offset: 0x0038E578
	private cjc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BE3 RID: 35811 RVA: 0x00390384 File Offset: 0x0038E584
	public cjc()
	{
	}

	// Token: 0x06008BE4 RID: 35812 RVA: 0x0039038C File Offset: 0x0038E58C
	public override string e1(edm A_0)
	{
		return "PoisonBurstVisual";
	}
}
