using System;
using System.Runtime.Serialization;

// Token: 0x02001995 RID: 6549
[eiz("SGHFX")]
[dn2("spearGuard")]
[Serializable]
public sealed class h8 : buu, ISerializable
{
	// Token: 0x06008BEE RID: 35822 RVA: 0x00390500 File Offset: 0x0038E700
	private h8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008BEF RID: 35823 RVA: 0x0039050C File Offset: 0x0038E70C
	public h8()
	{
	}

	// Token: 0x06008BF0 RID: 35824 RVA: 0x00390518 File Offset: 0x0038E718
	public override string e1(edm A_0)
	{
		string text;
		if (A_0.Chance < 1.0)
		{
			text = "{0}% шанс получить \"Защиту копьём\"";
		}
		else
		{
			text = "Предоставляет \"Защиту копьём\"";
		}
		text += ", которая даёт атакующему {1}% шанс блокировать до {2} механического урона до конца следующего хода. Количество блокированного урона не может превышать половины от навыка ближнего боя персонажа.";
		return string.Format(text, (int)(A_0.Chance * 100.0), (int)(h8.a * 100.0), A_0.Power);
	}

	// Token: 0x04003799 RID: 14233
	public new static readonly double a = 0.5;
}
