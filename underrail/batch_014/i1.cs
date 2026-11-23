using System;
using System.Runtime.Serialization;

// Token: 0x02001996 RID: 6550
[eiz("PSIH")]
[dn2("psiInhib")]
[Serializable]
public sealed class i1 : buu, ISerializable
{
	// Token: 0x06008BF2 RID: 35826 RVA: 0x003905A4 File Offset: 0x0038E7A4
	private i1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BF3 RID: 35827 RVA: 0x003905B0 File Offset: 0x0038E7B0
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% подвергнуть цель псионическому угнетению на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Подвергает цель псионическому угнетению на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008BF4 RID: 35828 RVA: 0x00390614 File Offset: 0x0038E814
	public i1()
	{
	}
}
