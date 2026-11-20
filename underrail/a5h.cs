using System;
using System.Runtime.Serialization;

// Token: 0x0200198E RID: 6542
[eiz("PXHE")]
[dn2("polarize")]
[Serializable]
public sealed class a5h : buu, ISerializable
{
	// Token: 0x06008BD7 RID: 35799 RVA: 0x0039017C File Offset: 0x0038E37C
	private a5h(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BD8 RID: 35800 RVA: 0x00390188 File Offset: 0x0038E388
	public override string e1(edm A_0)
	{
		string text;
		if (A_0.Chance < 1.0)
		{
			text = "{0}% шанс применить ";
		}
		else
		{
			text = "Applies ";
		}
		text += "{1} эффект поляризации. Каждая ед. эффекта уменьшает сопротивление и защиту цели от энергетического урона на {3}% и электрического на {4}%, и увеличивает шанс критического удара оружием по этой цели на {5}%. ";
		text += "Складывается до {6} раз и длится {7}.";
		return string.Format(text, new object[]
		{
			Convert.ToInt32(A_0.Chance * 100.0),
			A_0.Power,
			(A_0.Power > 1) ? "а(ов)" : "",
			Convert.ToInt32(di1.d * 100.0),
			Convert.ToInt32(di1.e * 100.0),
			Convert.ToInt32(di1.f * 100.0),
			di1.c,
			l4.a(di1.a, false)
		});
	}

	// Token: 0x06008BD9 RID: 35801 RVA: 0x00390298 File Offset: 0x0038E498
	public a5h()
	{
	}
}
