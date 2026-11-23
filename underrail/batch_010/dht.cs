using System;
using System.Runtime.Serialization;

// Token: 0x020019A2 RID: 6562
[eiz("AYX0")]
[dn2("ignite")]
[Serializable]
public sealed class dht : buu, ISerializable
{
	// Token: 0x06008C1C RID: 35868 RVA: 0x00390AE0 File Offset: 0x0038ECE0
	private dht(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C1D RID: 35869 RVA: 0x00390AF0 File Offset: 0x0038ECF0
	public override string e1(edm A_0)
	{
		int a_ = dht.b(A_0) / d0u.b;
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% поджечь цель и нанести дополнительно {1}% урона на протяжении {2}.", (int)(A_0.Chance * 100.0), A_0.Power, l4.a(a_, false));
		}
		return string.Format("Поджигает цель и наносит дополнительно {0}% урона на протяжении {1}.", A_0.Power, l4.a(a_, false));
	}

	// Token: 0x06008C1E RID: 35870 RVA: 0x00390B70 File Offset: 0x0038ED70
	public static int b(edm A_0)
	{
		return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(A_0.Power) / 80.0)) * d0u.b;
	}

	// Token: 0x06008C1F RID: 35871 RVA: 0x00390B98 File Offset: 0x0038ED98
	public new static double a(edm A_0)
	{
		return (double)A_0.Power / 100.0;
	}

	// Token: 0x06008C20 RID: 35872 RVA: 0x00390BAC File Offset: 0x0038EDAC
	public dht()
	{
	}
}
