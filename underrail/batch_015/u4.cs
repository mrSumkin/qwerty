using System;
using System.Runtime.Serialization;

// Token: 0x02001986 RID: 6534
[eiz("CMN5")]
[dn2("contaminate")]
[Serializable]
public sealed class u4 : buu, ISerializable
{
	// Token: 0x06008BBE RID: 35774 RVA: 0x0038FEA8 File Offset: 0x0038E0A8
	private u4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x0038FEB8 File Offset: 0x0038E0B8
	public override string e1(edm A_0)
	{
		if (A_0.Chance < 1.0)
		{
			return string.Format("Шанс {0}% вызвать заражение живой цели на {1}. Заражённые цели получают на {2}% больше урона от всех источников. Накладывается до {3} раз.", new object[]
			{
				(int)(A_0.Chance * 100.0),
				l4.a(a8l.d, false),
				(int)(a8l.b * 100.0),
				a8l.c
			});
		}
		return string.Format("Заражает живую цель на {0}. Заражённые цели получают на {1}% больше урона от всех источников. Накладывается до {2} раз", l4.a(a8l.d, false), (int)(a8l.b * 100.0), a8l.c);
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x0038FF6C File Offset: 0x0038E16C
	public u4()
	{
	}
}
