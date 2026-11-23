using System;
using System.Runtime.Serialization;

// Token: 0x02001998 RID: 6552
[dn2("fear")]
[eiz("FRX")]
[Serializable]
public sealed class dyd : buu, ISerializable
{
	// Token: 0x06008BF8 RID: 35832 RVA: 0x00390694 File Offset: 0x0038E894
	private dyd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BF9 RID: 35833 RVA: 0x003906A0 File Offset: 0x0038E8A0
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% заставить живую цель запаниковать на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Заставляет живую цель запаниковать на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008BFA RID: 35834 RVA: 0x00390704 File Offset: 0x0038E904
	public dyd()
	{
	}
}
