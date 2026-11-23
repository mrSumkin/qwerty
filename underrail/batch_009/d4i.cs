using System;
using System.Runtime.Serialization;

// Token: 0x02001980 RID: 6528
[eiz("AEX2")]
[dn2("chill")]
[Serializable]
public sealed class d4i : buu, ISerializable
{
	// Token: 0x06008BA8 RID: 35752 RVA: 0x0038FB78 File Offset: 0x0038DD78
	private d4i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BA9 RID: 35753 RVA: 0x0038FB84 File Offset: 0x0038DD84
	public override string e1(edm A_0)
	{
		int a_ = d4i.a(A_0) / d0u.b;
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% переохладить цель на {1}, снижая её очки передвижения на {2}. Накладывается до {3} раз.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				l4.a(a_, false),
				b34.a,
				h7.i
			});
		}
		return string.Format("Переохлаждает цель на {0}, снижая её очки передвижения на {1}. Накладывается до {2} раз.", l4.a(a_, false), b34.a, h7.i);
	}

	// Token: 0x06008BAA RID: 35754 RVA: 0x0038FC28 File Offset: 0x0038DE28
	public new static int a(edm A_0)
	{
		return A_0.Power * d0u.b;
	}

	// Token: 0x06008BAB RID: 35755 RVA: 0x0038FC38 File Offset: 0x0038DE38
	public d4i()
	{
	}
}
