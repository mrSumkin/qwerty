using System;
using System.Runtime.Serialization;

// Token: 0x0200199C RID: 6556
[dn2("corrosiveAcidSplashAndSpill")]
[eiz("ACYX")]
[Serializable]
public sealed class e1q : buu, ISerializable
{
	// Token: 0x06008C04 RID: 35844 RVA: 0x003907F8 File Offset: 0x0038E9F8
	private e1q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C05 RID: 35845 RVA: 0x00390804 File Offset: 0x0038EA04
	public e1q()
	{
	}

	// Token: 0x06008C06 RID: 35846 RVA: 0x0039080C File Offset: 0x0038EA0C
	public override string e1(edm A_0)
	{
		return "corrosiveAcidSplashAndSpill";
	}
}
