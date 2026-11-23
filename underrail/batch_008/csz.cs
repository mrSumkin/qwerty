using System;
using System.Runtime.Serialization;

// Token: 0x02001994 RID: 6548
[dn2("LeperPoison")]
[eiz("L58")]
[Serializable]
public sealed class csz : buu, ISerializable
{
	// Token: 0x06008BEB RID: 35819 RVA: 0x00390450 File Offset: 0x0038E650
	private csz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BEC RID: 35820 RVA: 0x00390460 File Offset: 0x0038E660
	public override string e1(edm A_0)
	{
		string format;
		if (A_0.Chance < 1.0)
		{
			format = "Шанс {0}% поразить цель ядом прокажённого змея, который наносит {1} урона за ход в течение {2} и увеличивает весь получаемый механический урон на {3}%. Складывается до {4} раз.";
		}
		else
		{
			format = "Поражает цель ядом прокажённого змея, который наносит {1} урона за ход в течение {2} и увеличивает весь получаемый механический урон на {3}%. Складывается до {4} раз.";
		}
		return string.Format(format, new object[]
		{
			(int)(A_0.Chance * 100.0),
			ezx.q,
			l4.a(ezx.y, false),
			(int)(ezx.r * 100.0),
			ezx.s
		});
	}

	// Token: 0x06008BED RID: 35821 RVA: 0x003904F8 File Offset: 0x0038E6F8
	public csz()
	{
	}
}
