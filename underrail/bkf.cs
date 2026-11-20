using System;
using System.Runtime.Serialization;

// Token: 0x02001973 RID: 6515
[eiz("SMSOA")]
[dn2("stunMeleeSingleOnAttack")]
[Serializable]
public sealed class bkf : buu, ISerializable
{
	// Token: 0x06008B77 RID: 35703 RVA: 0x0038F604 File Offset: 0x0038D804
	private bkf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B78 RID: 35704 RVA: 0x0038F614 File Offset: 0x0038D814
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс оглушить цель, если она находится в области ближнего боя, на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Оглушает цель, если она находится в области ближнего боя, на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008B79 RID: 35705 RVA: 0x0038F678 File Offset: 0x0038D878
	public override bool yk(edm A_0)
	{
		return true;
	}

	// Token: 0x06008B7A RID: 35706 RVA: 0x0038F67C File Offset: 0x0038D87C
	public bkf()
	{
	}
}
