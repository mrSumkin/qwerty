using System;
using System.Runtime.Serialization;

// Token: 0x0200199A RID: 6554
[dn2("sporeInfection")]
[eiz("SI7")]
[Serializable]
public sealed class lb : buu, ISerializable
{
	// Token: 0x06008BFE RID: 35838 RVA: 0x003907C0 File Offset: 0x0038E9C0
	private lb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BFF RID: 35839 RVA: 0x003907CC File Offset: 0x0038E9CC
	public override string e1(edm A_0)
	{
		return "Spore infections";
	}

	// Token: 0x06008C00 RID: 35840 RVA: 0x003907D4 File Offset: 0x0038E9D4
	public lb()
	{
	}
}
