using System;
using System.Runtime.Serialization;

// Token: 0x02001983 RID: 6531
[eiz("BPSHE")]
[dn2("burnPsi")]
[Serializable]
public sealed class dfp : buu, ISerializable
{
	// Token: 0x06008BB4 RID: 35764 RVA: 0x0038FD78 File Offset: 0x0038DF78
	private dfp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BB5 RID: 35765 RVA: 0x0038FD84 File Offset: 0x0038DF84
	public dfp()
	{
	}

	// Token: 0x06008BB6 RID: 35766 RVA: 0x0038FD90 File Offset: 0x0038DF90
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% сжечь {1} пси-очков цели.", (int)(A_0.Chance * 100.0), A_0.Power);
		}
		return string.Format("Сжигает {0} пси-очков цели.", A_0.Power);
	}
}
