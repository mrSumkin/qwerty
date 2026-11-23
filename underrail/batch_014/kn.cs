using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200199F RID: 6559
[dn2("explosiveHit")]
[eiz("XPL")]
[Serializable]
public sealed class kn : buu, ISerializable
{
	// Token: 0x06008C0D RID: 35853 RVA: 0x00390880 File Offset: 0x0038EA80
	private kn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C0E RID: 35854 RVA: 0x0039088C File Offset: 0x0038EA8C
	public kn()
	{
	}

	// Token: 0x06008C0F RID: 35855 RVA: 0x00390898 File Offset: 0x0038EA98
	public override string e1(edm A_0)
	{
		a1q a1q = kn.b(A_0);
		a1q a1q2 = kn.c(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс вызвать взрыв, который нанесёт {1} и {2} урона цели и всем близлежащим целям.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				a1q.a(true),
				a1q2.a(true),
				kn.a(A_0)
			});
		}
		return string.Format("Вызывает взрыв, наносящий {0} и {1} урона цели и всем близлежащим целям.", a1q.a(true), a1q2.a(true), kn.a(A_0));
	}

	// Token: 0x06008C10 RID: 35856 RVA: 0x0039093C File Offset: 0x0038EB3C
	public static a1q c(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Mechanical, 1, 2), (double)A_0.Power / 2.0);
	}

	// Token: 0x06008C11 RID: 35857 RVA: 0x0039095C File Offset: 0x0038EB5C
	public static a1q b(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Heat, 1, 2), (double)A_0.Power / 2.0);
	}

	// Token: 0x06008C12 RID: 35858 RVA: 0x0039097C File Offset: 0x0038EB7C
	public new static int a(edm A_0)
	{
		return 1;
	}
}
