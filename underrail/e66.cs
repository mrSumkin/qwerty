using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001982 RID: 6530
[dn2("bioHit")]
[eiz("BHX")]
[Serializable]
public sealed class e66 : buu, ISerializable
{
	// Token: 0x06008BB0 RID: 35760 RVA: 0x0038FCDC File Offset: 0x0038DEDC
	private e66(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BB1 RID: 35761 RVA: 0x0038FCE8 File Offset: 0x0038DEE8
	public e66()
	{
	}

	// Token: 0x06008BB2 RID: 35762 RVA: 0x0038FCF4 File Offset: 0x0038DEF4
	public override string e1(edm A_0)
	{
		a1q a1q = e66.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс нанести {1} урона цели.", (int)(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит цели {0} урона.", a1q.a(true));
	}

	// Token: 0x06008BB3 RID: 35763 RVA: 0x0038FD58 File Offset: 0x0038DF58
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Bio, 1, 3), (double)A_0.Power / 3.0);
	}
}
