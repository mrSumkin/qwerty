using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200196F RID: 6511
[dn2("energyHit")]
[eiz("CSHEFE")]
[Serializable]
public sealed class ly : buu, ISerializable
{
	// Token: 0x06008B63 RID: 35683 RVA: 0x0038F2F8 File Offset: 0x0038D4F8
	private ly(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B64 RID: 35684 RVA: 0x0038F304 File Offset: 0x0038D504
	public ly()
	{
	}

	// Token: 0x06008B65 RID: 35685 RVA: 0x0038F310 File Offset: 0x0038D510
	public override string e1(edm A_0)
	{
		a1q a1q = ly.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести цели {1} урона.", Convert.ToInt32(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит цели {0} энергетического урона.", a1q.a(true));
	}

	// Token: 0x06008B66 RID: 35686 RVA: 0x0038F378 File Offset: 0x0038D578
	public new static a1q a(edm A_0)
	{
		return ly.a(A_0.Power);
	}

	// Token: 0x06008B67 RID: 35687 RVA: 0x0038F388 File Offset: 0x0038D588
	public static a1q a(int A_0)
	{
		return a1q.a(new a1q(DamageType.Energy, 1, 2), (double)A_0 / 2.0);
	}
}
