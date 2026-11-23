using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200196E RID: 6510
[eiz("CDT")]
[dn2("contaminateDot")]
[Serializable]
public sealed class dmj : buu, ISerializable
{
	// Token: 0x06008B5E RID: 35678 RVA: 0x0038F240 File Offset: 0x0038D440
	private dmj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B5F RID: 35679 RVA: 0x0038F24C File Offset: 0x0038D44C
	public dmj()
	{
	}

	// Token: 0x06008B60 RID: 35680 RVA: 0x0038F254 File Offset: 0x0038D454
	public override string e1(edm A_0)
	{
		a1q a1q = dmj.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс нанести заражённую рану живому существу, которая причинит {1} урона цели в течение {2}.", (int)(A_0.Chance * 100.0), a1q.a(true), l4.a(dmj.a, false));
		}
		return string.Format("Наносит заражённую рану живому существу, которая причиняет {0} урона цели в течение {1}.", a1q.a(true), l4.a(dmj.a, false));
	}

	// Token: 0x06008B61 RID: 35681 RVA: 0x0038F2D0 File Offset: 0x0038D4D0
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Bio, 1, 2), (double)A_0.Power / 2.0);
	}

	// Token: 0x04003794 RID: 14228
	public new static readonly int a = 5;
}
