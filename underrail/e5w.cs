using System;
using System.Runtime.Serialization;

// Token: 0x02001971 RID: 6513
[eiz("DSOAHE")]
[dn2("dazeSelfOnAttack")]
[Serializable]
public sealed class e5w : buu, ISerializable
{
	// Token: 0x06008B6C RID: 35692 RVA: 0x0038F440 File Offset: 0x0038D640
	private e5w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B6D RID: 35693 RVA: 0x0038F44C File Offset: 0x0038D64C
	public override bool yk(edm A_0)
	{
		return true;
	}

	// Token: 0x06008B6E RID: 35694 RVA: 0x0038F450 File Offset: 0x0038D650
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс дезориентировать носителя на {1}.", (int)(A_0.Chance * 100.0), l4.a(A_0.Power, false));
		}
		return string.Format("Дезориентирует носителя на {0}.", l4.a(A_0.Power, false));
	}

	// Token: 0x06008B6F RID: 35695 RVA: 0x0038F4B4 File Offset: 0x0038D6B4
	public e5w()
	{
	}
}
