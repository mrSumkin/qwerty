using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001972 RID: 6514
[dn2("firecrackerCapExplosiveHit")]
[eiz("FCCEHE")]
[Serializable]
public sealed class aaj : buu, ISerializable
{
	// Token: 0x06008B70 RID: 35696 RVA: 0x0038F4BC File Offset: 0x0038D6BC
	private aaj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B71 RID: 35697 RVA: 0x0038F4C8 File Offset: 0x0038D6C8
	public aaj()
	{
	}

	// Token: 0x06008B72 RID: 35698 RVA: 0x0038F4D4 File Offset: 0x0038D6D4
	public override string e1(edm A_0)
	{
		a1q a1q = aaj.b(A_0);
		a1q a1q2 = aaj.c(A_0);
		string str;
		if (A_0.Chance < 1.0)
		{
			str = string.Format("{0}% шанс вызвать ", Convert.ToInt32(A_0.Chance * 100.0));
		}
		else
		{
			str = string.Format("Вызывает ", Convert.ToInt32(A_0.Chance * 100.0));
		}
		return str + string.Format("взрыв, наносящий {0} и {1} урон всем целям в радиусе {2}. Кроме того, сопротивление и защита от механического и теплового урона основной цели снижаются на {3}% в течение {4}. Наносит большой урон по прочности оружия и брони основной цели.", new object[]
		{
			a1q.a(true),
			a1q2.a(true),
			aaj.a(A_0),
			Convert.ToInt32(bca.a * 100.0),
			l4.a(aaj.d(A_0), false)
		});
	}

	// Token: 0x06008B73 RID: 35699 RVA: 0x0038F5BC File Offset: 0x0038D7BC
	public static int d(edm A_0)
	{
		return 3;
	}

	// Token: 0x06008B74 RID: 35700 RVA: 0x0038F5C0 File Offset: 0x0038D7C0
	public static a1q c(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Mechanical, 1, 2), (double)A_0.Power / 4.0);
	}

	// Token: 0x06008B75 RID: 35701 RVA: 0x0038F5E0 File Offset: 0x0038D7E0
	public static a1q b(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Heat, 1, 2), (double)A_0.Power / 4.0);
	}

	// Token: 0x06008B76 RID: 35702 RVA: 0x0038F600 File Offset: 0x0038D800
	public new static int a(edm A_0)
	{
		return 3;
	}
}
