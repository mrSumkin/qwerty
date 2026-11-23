using System;
using System.Runtime.Serialization;

// Token: 0x0200197E RID: 6526
[dn2("acidicEntanglement")]
[eiz("AEX0")]
[Serializable]
public sealed class ate : buu, ISerializable
{
	// Token: 0x06008B9F RID: 35743 RVA: 0x0038FA90 File Offset: 0x0038DC90
	private ate(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BA0 RID: 35744 RVA: 0x0038FAA0 File Offset: 0x0038DCA0
	public override string e1(edm A_0)
	{
		int a_ = ate.b(A_0) / d0u.b;
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% опутать цель кислотной жижей, нанося дополнительно {1}% урона на протяжении {2}.", (int)(A_0.Chance * 100.0), A_0.Power, l4.a(a_, false));
		}
		return string.Format("Опутывает цель кислотной жижей, нанося дополнительно {0}% урона на протяжении {1}.", A_0.Power, l4.a(a_, false));
	}

	// Token: 0x06008BA1 RID: 35745 RVA: 0x0038FB20 File Offset: 0x0038DD20
	public static int b(edm A_0)
	{
		return 2 * d0u.b;
	}

	// Token: 0x06008BA2 RID: 35746 RVA: 0x0038FB2C File Offset: 0x0038DD2C
	public new static double a(edm A_0)
	{
		return (double)A_0.Power / 100.0;
	}

	// Token: 0x06008BA3 RID: 35747 RVA: 0x0038FB40 File Offset: 0x0038DD40
	public ate()
	{
	}
}
