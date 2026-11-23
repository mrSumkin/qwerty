using System;
using System.Runtime.Serialization;

// Token: 0x02001988 RID: 6536
[eiz("CUHE")]
[dn2("carveUp")]
[Serializable]
public sealed class dwg : buu, ISerializable
{
	// Token: 0x06008BC4 RID: 35780 RVA: 0x0038FF90 File Offset: 0x0038E190
	private dwg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BC5 RID: 35781 RVA: 0x0038FFA0 File Offset: 0x0038E1A0
	public override string e1(edm A_0)
	{
		string format;
		if (A_0.Chance < 1.0)
		{
			format = "шанс {0}% изрезать цель на {1}, уменьшая её очки действия на {2} и увеличивая её шанс получить критический урон на {3}%. Накладывается до {4} раз.";
		}
		else
		{
			format = "Ранит цель на {1}, уменьшая её очки действия на {2} и увеличивая её шанс получить критический урон на {3}%. Накладывается до {4} раз.";
		}
		return string.Format(format, new object[]
		{
			(int)(A_0.Chance * 100.0),
			l4.a((double)a36.d, false),
			a36.c,
			(int)(a36.b * 100.0),
			a36.a
		});
	}

	// Token: 0x06008BC6 RID: 35782 RVA: 0x00390038 File Offset: 0x0038E238
	public dwg()
	{
	}
}
