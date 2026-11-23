using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019C9 RID: 6601
[eiz("SHARP")]
[Serializable]
public sealed class c8m : dbj
{
	// Token: 0x06008D69 RID: 36201 RVA: 0x003934FC File Offset: 0x003916FC
	private c8m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D6A RID: 36202 RVA: 0x00393508 File Offset: 0x00391708
	public override string f9()
	{
		return "sharpened";
	}

	// Token: 0x06008D6B RID: 36203 RVA: 0x00393510 File Offset: 0x00391710
	public override string ga()
	{
		return "Заточенный";
	}

	// Token: 0x06008D6C RID: 36204 RVA: 0x00393518 File Offset: 0x00391718
	public override string qj()
	{
		return "Sharpening";
	}

	// Token: 0x06008D6D RID: 36205 RVA: 0x00393520 File Offset: 0x00391720
	public override SpellTargetType qk()
	{
		return SpellTargetType.SharpenableWeapon;
	}

	// Token: 0x06008D6E RID: 36206 RVA: 0x00393524 File Offset: 0x00391724
	public override string ql()
	{
		return "SharpeningStone";
	}

	// Token: 0x06008D6F RID: 36207 RVA: 0x0039352C File Offset: 0x0039172C
	public c8m()
	{
	}

	// Token: 0x06008D70 RID: 36208 RVA: 0x00393534 File Offset: 0x00391734
	public override void ajq(coh A_0)
	{
		A_0.MaxDurabilityReduction = Math.Min(0.95, A_0.MaxDurabilityReduction + c8m.b);
		A_0.Durability = Math.Min(A_0.Durability, (double)A_0.MaxDurability);
	}

	// Token: 0x06008D71 RID: 36209 RVA: 0x0039357C File Offset: 0x0039177C
	public override void ajr(efk A_0, efk A_1, cd1 A_2, bool A_3, cmn A_4)
	{
		if (A_3)
		{
			A_4.b += c8m.a;
		}
	}

	// Token: 0x06008D72 RID: 36210 RVA: 0x00393598 File Offset: 0x00391798
	public override bool qm(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008D73 RID: 36211 RVA: 0x0039359C File Offset: 0x0039179C
	public override string qn(coh A_0)
	{
		return "Sharpen";
	}

	// Token: 0x06008D74 RID: 36212 RVA: 0x003935A4 File Offset: 0x003917A4
	public override string gc(efk A_0)
	{
		return string.Format("Применяется на клинковом оружии ближнего боя для получения дополнительного {0}% урона на следующие {1} ударов. Заточка оружия навсегда снижает его максимальную прочность на {2}%.", Convert.ToInt32(c8m.a * 100.0), base.RemainingTicks, Convert.ToInt32(c8m.b * 100.0));
	}

	// Token: 0x06008D75 RID: 36213 RVA: 0x003935F8 File Offset: 0x003917F8
	public override string gd(efk A_0)
	{
		return string.Format("Предоставляет {0}% дополнительного урона.", Convert.ToInt32(c8m.a * 100.0));
	}

	// Token: 0x040037B3 RID: 14259
	public new static readonly double a = 0.1;

	// Token: 0x040037B4 RID: 14260
	public new static readonly double b = 0.05;
}
