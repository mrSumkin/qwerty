using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001990 RID: 6544
[eiz("EC11")]
[dn2("energyCut")]
[Serializable]
public sealed class brd : buu, ISerializable
{
	// Token: 0x06008BDD RID: 35805 RVA: 0x003902BC File Offset: 0x0038E4BC
	private brd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BDE RID: 35806 RVA: 0x003902C8 File Offset: 0x0038E4C8
	public brd()
	{
	}

	// Token: 0x06008BDF RID: 35807 RVA: 0x003902D4 File Offset: 0x0038E4D4
	public override string e1(edm A_0)
	{
		a1q a1q = brd.a(A_0);
		int num = brd.b(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс нанести {1} урон цели. Затрачивает {2} энергии.", (int)(A_0.Chance * 100.0), a1q.a(true), num);
		}
		return string.Format("Наносит {0} урона цели. Стоимость {1} энергии.", a1q.a(true), num);
	}

	// Token: 0x06008BE0 RID: 35808 RVA: 0x0039034C File Offset: 0x0038E54C
	public static int b(edm A_0)
	{
		return A_0.Power / 5;
	}

	// Token: 0x06008BE1 RID: 35809 RVA: 0x00390358 File Offset: 0x0038E558
	public new static a1q a(edm A_0)
	{
		return new a1q(DamageType.Energy, (int)(0.75 * (double)A_0.Power), A_0.Power);
	}
}
