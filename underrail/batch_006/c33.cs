using System;
using System.Runtime.Serialization;

// Token: 0x02001976 RID: 6518
[eiz("EXWK")]
[dn2("exposeWeakness")]
[Serializable]
public sealed class c33 : buu, ISerializable
{
	// Token: 0x06008B84 RID: 35716 RVA: 0x0038F830 File Offset: 0x0038DA30
	private c33(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B85 RID: 35717 RVA: 0x0038F83C File Offset: 0x0038DA3C
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс снизить сопротивление и защиту от механического урона цели на {1}% в течение {2}. Для неживых целей эффект уменьшается вдвое.", (int)(A_0.Chance * 100.0), A_0.Power, l4.a(csr.d, false));
		}
		return string.Format("Снижает сопротивление и защиту от механического урона цели на {0}% в течение {1}. Для неживых целей эффект уменьшается вдвое.", A_0.Power, l4.a(csr.d, false));
	}

	// Token: 0x06008B86 RID: 35718 RVA: 0x0038F8B4 File Offset: 0x0038DAB4
	public c33()
	{
	}
}
