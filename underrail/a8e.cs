using System;
using System.Runtime.Serialization;

// Token: 0x02001977 RID: 6519
[dn2("immobilize")]
[eiz("IHE")]
[Serializable]
public sealed class a8e : buu, ISerializable
{
	// Token: 0x06008B87 RID: 35719 RVA: 0x0038F8BC File Offset: 0x0038DABC
	private a8e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B88 RID: 35720 RVA: 0x0038F8C8 File Offset: 0x0038DAC8
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс обездвижить цель на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Обездвиживает цель на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008B89 RID: 35721 RVA: 0x0038F92C File Offset: 0x0038DB2C
	public a8e()
	{
	}
}
