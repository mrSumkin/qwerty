using System;
using System.Runtime.Serialization;

// Token: 0x0200197F RID: 6527
[dn2("Anticoagulation")]
[eiz("1AC")]
[Serializable]
public sealed class r6 : buu, ISerializable
{
	// Token: 0x06008BA4 RID: 35748 RVA: 0x0038FB48 File Offset: 0x0038DD48
	private r6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BA5 RID: 35749 RVA: 0x0038FB54 File Offset: 0x0038DD54
	public override string e1(edm A_0)
	{
		return string.Empty;
	}

	// Token: 0x06008BA6 RID: 35750 RVA: 0x0038FB5C File Offset: 0x0038DD5C
	public r6()
	{
	}

	// Token: 0x06008BA7 RID: 35751 RVA: 0x0038FB64 File Offset: 0x0038DD64
	public new static int a(edm A_0)
	{
		return Math.Max(1, A_0.Power) * d0u.b;
	}
}
