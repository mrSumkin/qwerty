using System;
using System.Runtime.Serialization;

// Token: 0x0200199B RID: 6555
[eiz("ACX8")]
[dn2("pneumaticHammerVisualHit")]
[Serializable]
public sealed class cjw : buu, ISerializable
{
	// Token: 0x06008C01 RID: 35841 RVA: 0x003907DC File Offset: 0x0038E9DC
	private cjw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C02 RID: 35842 RVA: 0x003907E8 File Offset: 0x0038E9E8
	public override string e1(edm A_0)
	{
		return "Визуальный эффект удара пневматическим молотом.";
	}

	// Token: 0x06008C03 RID: 35843 RVA: 0x003907F0 File Offset: 0x0038E9F0
	public cjw()
	{
	}
}
