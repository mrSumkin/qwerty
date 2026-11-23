using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019A0 RID: 6560
[dn2("incendiaryIgnite")]
[eiz("AYZ0")]
[Serializable]
public sealed class bm9 : buu, ISerializable
{
	// Token: 0x06008C13 RID: 35859 RVA: 0x00390980 File Offset: 0x0038EB80
	private bm9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C14 RID: 35860 RVA: 0x0039098C File Offset: 0x0038EB8C
	public override string e1(edm A_0)
	{
		int a_ = bm9.b(A_0) / d0u.b;
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% поджечь цель, нанося дополнительно {1} урона на протяжение {2}.", (int)(A_0.Chance * 100.0), bm9.a(A_0).a(true), l4.a(a_, false));
		}
		return string.Format("Поджигает цель, нанося дополнительно {0} урона на протяжение {1}.", bm9.a(A_0).a(true), l4.a(a_, false));
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x00390A14 File Offset: 0x0038EC14
	public static int b(edm A_0)
	{
		return 2 * d0u.b;
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x00390A20 File Offset: 0x0038EC20
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Heat, 1, 2), (double)A_0.Power / 2.0);
	}

	// Token: 0x06008C17 RID: 35863 RVA: 0x00390A40 File Offset: 0x0038EC40
	public bm9()
	{
	}
}
