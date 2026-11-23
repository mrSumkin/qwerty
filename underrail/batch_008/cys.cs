using System;
using System.Runtime.Serialization;

// Token: 0x02001999 RID: 6553
[eiz("CRPX")]
[dn2("cripple")]
[Serializable]
public sealed class cys : buu, ISerializable
{
	// Token: 0x06008BFB RID: 35835 RVA: 0x0039070C File Offset: 0x0038E90C
	private cys(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BFC RID: 35836 RVA: 0x00390718 File Offset: 0x0038E918
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% ослабить живую цель на {1}, уменьшая её Силу на {2}. Накладывается до {3} раз.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				l4.a((double)fz.c, false),
				fz.e,
				fz.d
			});
		}
		return string.Format("Ослабляет живую цель на {0}, уменьшая её Силу на {1}. Накладывается до {2} раз.", l4.a((double)fz.c, false), fz.e, fz.d);
	}

	// Token: 0x06008BFD RID: 35837 RVA: 0x003907B8 File Offset: 0x0038E9B8
	public cys()
	{
	}
}
