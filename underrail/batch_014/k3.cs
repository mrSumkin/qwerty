using System;
using System.Runtime.Serialization;

// Token: 0x02001A38 RID: 6712
[eiz("DSHE")]
[dn2("DS")]
[Serializable]
public sealed class k3 : buu, ISerializable
{
	// Token: 0x06009189 RID: 37257 RVA: 0x0039D254 File Offset: 0x0039B454
	private k3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600918A RID: 37258 RVA: 0x0039D264 File Offset: 0x0039B464
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% рассеять {1} щит.", buu.a(A_0), k3.a(A_0));
		}
		return string.Format("Рассеивает {0} очков щита.", k3.a(A_0));
	}

	// Token: 0x0600918B RID: 37259 RVA: 0x0039D2BC File Offset: 0x0039B4BC
	public new static int a(edm A_0)
	{
		return A_0.Power;
	}

	// Token: 0x0600918C RID: 37260 RVA: 0x0039D2C4 File Offset: 0x0039B4C4
	public k3()
	{
	}
}
