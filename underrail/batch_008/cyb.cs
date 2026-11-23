using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A2E RID: 6702
[dn2("electroshockAoe")]
[eiz("ESAHE")]
[Serializable]
public sealed class cyb : buu, ISerializable
{
	// Token: 0x06009126 RID: 37158 RVA: 0x0039C494 File Offset: 0x0039A694
	private cyb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009127 RID: 37159 RVA: 0x0039C4A0 File Offset: 0x0039A6A0
	public cyb()
	{
	}

	// Token: 0x06009128 RID: 37160 RVA: 0x0039C4AC File Offset: 0x0039A6AC
	public override string e1(edm A_0)
	{
		a1q a1q = cyb.b(A_0);
		a1q a1q2 = cyb.a(A_0);
		int num = cyb.c(A_0);
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% нанести {1} основной цели и {2} всем окружающим врагам. Стоит {3} энергии.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				a1q.a(true),
				a1q2.a(true),
				num
			});
		}
		return string.Format("Наносит {0} основной цели и {1} всем окружающим врагам. Стоит {2} энергии.", a1q.a(true), a1q2.a(true), num);
	}

	// Token: 0x06009129 RID: 37161 RVA: 0x0039C54C File Offset: 0x0039A74C
	public static int c(edm A_0)
	{
		return 3 + A_0.Power / 8;
	}

	// Token: 0x0600912A RID: 37162 RVA: 0x0039C558 File Offset: 0x0039A758
	public static a1q b(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Electricity, 1, 2), (double)A_0.Power / 2.0);
	}

	// Token: 0x0600912B RID: 37163 RVA: 0x0039C578 File Offset: 0x0039A778
	public new static a1q a(edm A_0)
	{
		return a1q.a(new a1q(DamageType.Electricity, 1, 2), (double)A_0.Power / 4.0);
	}
}
