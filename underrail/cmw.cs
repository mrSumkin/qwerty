using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001970 RID: 6512
[dn2("burn")]
[eiz("BRNH")]
[Serializable]
public sealed class cmw : buu, ISerializable
{
	// Token: 0x06008B68 RID: 35688 RVA: 0x0038F3A4 File Offset: 0x0038D5A4
	private cmw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B69 RID: 35689 RVA: 0x0038F3B0 File Offset: 0x0038D5B0
	public cmw()
	{
	}

	// Token: 0x06008B6A RID: 35690 RVA: 0x0038F3BC File Offset: 0x0038D5BC
	public override string e1(edm A_0)
	{
		a1q a1q = cmw.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести цели {1} урона.", (int)(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит цели {0} урона.", a1q.a(true));
	}

	// Token: 0x06008B6B RID: 35691 RVA: 0x0038F420 File Offset: 0x0038D620
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Heat, 1, 2), (double)A_0.Power / 2.0);
	}
}
