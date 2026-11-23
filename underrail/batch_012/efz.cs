using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001981 RID: 6529
[eiz("ACCX")]
[dn2("acid")]
[Serializable]
public sealed class efz : buu, ISerializable
{
	// Token: 0x06008BAC RID: 35756 RVA: 0x0038FC40 File Offset: 0x0038DE40
	private efz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BAD RID: 35757 RVA: 0x0038FC4C File Offset: 0x0038DE4C
	public efz()
	{
	}

	// Token: 0x06008BAE RID: 35758 RVA: 0x0038FC58 File Offset: 0x0038DE58
	public override string e1(edm A_0)
	{
		a1q a1q = efz.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести цели {1} урона.", (int)(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит цели {0} урона.", a1q.a(true));
	}

	// Token: 0x06008BAF RID: 35759 RVA: 0x0038FCBC File Offset: 0x0038DEBC
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Acid, 1, 2), (double)A_0.Power / 2.0);
	}
}
