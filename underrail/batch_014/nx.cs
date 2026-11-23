using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020019A1 RID: 6561
[eiz("ESAHH")]
[dn2("electroshock")]
[Serializable]
public sealed class nx : buu, ISerializable
{
	// Token: 0x06008C18 RID: 35864 RVA: 0x00390A48 File Offset: 0x0038EC48
	private nx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C19 RID: 35865 RVA: 0x00390A54 File Offset: 0x0038EC54
	public nx()
	{
	}

	// Token: 0x06008C1A RID: 35866 RVA: 0x00390A5C File Offset: 0x0038EC5C
	public override string e1(edm A_0)
	{
		a1q a1q = nx.a(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс нанести {1} урона цели.", (int)(A_0.Chance * 100.0), a1q.a(true));
		}
		return string.Format("Наносит {0} урона цели.", a1q.a(true));
	}

	// Token: 0x06008C1B RID: 35867 RVA: 0x00390AC0 File Offset: 0x0038ECC0
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Electricity, 1, 2), (double)A_0.Power / 2.0);
	}
}
