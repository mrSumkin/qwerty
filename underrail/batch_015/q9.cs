using System;
using System.Runtime.Serialization;

// Token: 0x02001997 RID: 6551
[dn2("daze")]
[eiz("DZHE")]
[Serializable]
public sealed class q9 : buu, ISerializable
{
	// Token: 0x06008BF5 RID: 35829 RVA: 0x0039061C File Offset: 0x0038E81C
	private q9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BF6 RID: 35830 RVA: 0x00390628 File Offset: 0x0038E828
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% дезориентировать цель на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Дезориентирует цель на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008BF7 RID: 35831 RVA: 0x0039068C File Offset: 0x0038E88C
	public q9()
	{
	}
}
