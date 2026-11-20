using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001978 RID: 6520
[dn2("shockwave")]
[eiz("SWHE")]
[Serializable]
public sealed class e7w : buu, ISerializable
{
	// Token: 0x06008B8A RID: 35722 RVA: 0x0038F934 File Offset: 0x0038DB34
	private e7w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008B8B RID: 35723 RVA: 0x0038F940 File Offset: 0x0038DB40
	public e7w()
	{
	}

	// Token: 0x06008B8C RID: 35724 RVA: 0x0038F94C File Offset: 0x0038DB4C
	public override string e1(edm A_0)
	{
		a1q a1q = e7w.a(A_0);
		int num = e7w.b(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("{0}% шанс вызвать ударную волну, которая нанесёт {1} всем ближайшим врагам, потенциально дезориентируя их на один ход. Этот урон игнорирует защиту от механического урона и половину сопротивления от механического урона. Затрачивает {2} энергии.", (int)(A_0.Chance * 100.0), a1q.a(true), num);
		}
		return string.Format("Вызывает ударную волну, которая наносит {0} всем ближайшим врагам, потенциально дезориентируя их на один ход. Этот урон игнорирует защиту от механического урона и половину сопротивления от механического урона. Затрачивает {1} энергии.", a1q.a(true), num);
	}

	// Token: 0x06008B8D RID: 35725 RVA: 0x0038F9C4 File Offset: 0x0038DBC4
	public static int b(edm A_0)
	{
		return 4 + A_0.Power / 5;
	}

	// Token: 0x06008B8E RID: 35726 RVA: 0x0038F9D0 File Offset: 0x0038DBD0
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Mechanical, 2, 3), (double)A_0.Power / 2.5);
	}
}
