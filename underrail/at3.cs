using System;
using System.Runtime.Serialization;

// Token: 0x02001993 RID: 6547
[dn2("HeartbreakPoison")]
[eiz("HB5")]
[Serializable]
public sealed class at3 : buu, ISerializable
{
	// Token: 0x06008BE8 RID: 35816 RVA: 0x003903B0 File Offset: 0x0038E5B0
	private at3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BE9 RID: 35817 RVA: 0x003903BC File Offset: 0x0038E5BC
	public override string e1(edm A_0)
	{
		string text;
		if (A_0.Chance < 1.0)
		{
			text = "Шанс {0}% поразить цель ядом сердцеед, который наносит {1} урона за ход в течение {2}.";
		}
		else
		{
			text = "Поражает цель ядом сердцеед, который наносит {1} урона за ход в течение {2}.";
		}
		text += " Складывается до {3} раз. Если яд не был вылечен до истечения срока его действия, он будет иметь большой урон с каждой добавленной ед. его эффекта.";
		return string.Format(text, new object[]
		{
			(int)(A_0.Chance * 100.0),
			ezx.v,
			l4.a(ezx.y, false),
			ezx.x
		});
	}

	// Token: 0x06008BEA RID: 35818 RVA: 0x00390448 File Offset: 0x0038E648
	public at3()
	{
	}
}
