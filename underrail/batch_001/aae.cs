using System;
using System.Runtime.Serialization;

// Token: 0x020019A3 RID: 6563
[eiz("AEX8")]
[dn2("freeze")]
[Serializable]
public sealed class aae : buu, ISerializable
{
	// Token: 0x06008C21 RID: 35873 RVA: 0x00390BB4 File Offset: 0x0038EDB4
	private aae(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C22 RID: 35874 RVA: 0x00390BC4 File Offset: 0x0038EDC4
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% заморозить цель на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Замораживает цель на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008C23 RID: 35875 RVA: 0x00390C28 File Offset: 0x0038EE28
	public aae()
	{
	}
}
