using System;
using System.Runtime.Serialization;

// Token: 0x0200199E RID: 6558
[dn2("leaveToxicGas")]
[eiz("LTGX")]
[Serializable]
public sealed class ayp : buu, ISerializable
{
	// Token: 0x06008C0A RID: 35850 RVA: 0x00390830 File Offset: 0x0038EA30
	private ayp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C0B RID: 35851 RVA: 0x0039083C File Offset: 0x0038EA3C
	public ayp()
	{
	}

	// Token: 0x06008C0C RID: 35852 RVA: 0x00390844 File Offset: 0x0038EA44
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% оставить облако токсичного газа.", (int)(A_0.Chance * 100.0));
		}
		return "Создаёт облако токсичного газа.";
	}
}
