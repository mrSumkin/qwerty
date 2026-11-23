using System;
using System.Runtime.Serialization;

// Token: 0x02001A4F RID: 6735
[eiz("SHE")]
[dn2("ST")]
[Serializable]
public sealed class b89 : buu, ISerializable
{
	// Token: 0x0600922A RID: 37418 RVA: 0x0039EB78 File Offset: 0x0039CD78
	private b89(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600922B RID: 37419 RVA: 0x0039EB88 File Offset: 0x0039CD88
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% оглушить живую цель на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Оглушает живую цель на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x0600922C RID: 37420 RVA: 0x0039EBEC File Offset: 0x0039CDEC
	public b89()
	{
	}
}
