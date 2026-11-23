using System;
using System.Runtime.Serialization;

// Token: 0x0200198A RID: 6538
[eiz("ITDX")]
[dn2("intimidate")]
[Serializable]
public sealed class ano : buu, ISerializable
{
	// Token: 0x06008BCA RID: 35786 RVA: 0x0039005C File Offset: 0x0038E25C
	private ano(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BCB RID: 35787 RVA: 0x00390068 File Offset: 0x0038E268
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс уменьшить все боевые навыки живой цели на {1} в течение {2}.", Convert.ToInt32(A_0.Chance * 100.0), A_0.Power, l4.a(ano.a, false));
		}
		return string.Format("Снижает все боевые навыки живых целей на {0} в течение {1}.", A_0.Power, l4.a(ano.a, false));
	}

	// Token: 0x06008BCC RID: 35788 RVA: 0x003900E4 File Offset: 0x0038E2E4
	public ano()
	{
	}

	// Token: 0x04003798 RID: 14232
	public new static readonly int a = 3;
}
