using System;
using System.Runtime.Serialization;

// Token: 0x02001974 RID: 6516
[dn2("dazeNearbyOnAttack")]
[eiz("DZHEN")]
[Serializable]
public sealed class dpv : buu, ISerializable
{
	// Token: 0x06008B7B RID: 35707 RVA: 0x0038F684 File Offset: 0x0038D884
	private dpv(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B7C RID: 35708 RVA: 0x0038F694 File Offset: 0x0038D894
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс дезориентировать цели, находящиеся рядом с атакующим, на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Дезориентирует цели рядом с атакующим на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008B7D RID: 35709 RVA: 0x0038F6F8 File Offset: 0x0038D8F8
	public override bool yk(edm A_0)
	{
		return true;
	}

	// Token: 0x06008B7E RID: 35710 RVA: 0x0038F6FC File Offset: 0x0038D8FC
	public dpv()
	{
	}
}
