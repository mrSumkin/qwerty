using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020019CA RID: 6602
[eiz("PFOLIE")]
[Serializable]
public sealed class cu2 : dbj
{
	// Token: 0x06008D77 RID: 36215 RVA: 0x00393640 File Offset: 0x00391840
	private cu2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D78 RID: 36216 RVA: 0x0039364C File Offset: 0x0039184C
	public override string f9()
	{
		return "protectorateFirearmOmnilube";
	}

	// Token: 0x06008D79 RID: 36217 RVA: 0x00393654 File Offset: 0x00391854
	public override string ga()
	{
		return "Протекторатская оружейная смазка Омнилубий";
	}

	// Token: 0x06008D7A RID: 36218 RVA: 0x0039365C File Offset: 0x0039185C
	public override string qj()
	{
		return "GunOil";
	}

	// Token: 0x06008D7B RID: 36219 RVA: 0x00393664 File Offset: 0x00391864
	public override SpellTargetType qk()
	{
		return SpellTargetType.FirearmWeaponNotLauncher;
	}

	// Token: 0x06008D7C RID: 36220 RVA: 0x00393668 File Offset: 0x00391868
	public override string ql()
	{
		return "Oil";
	}

	// Token: 0x06008D7D RID: 36221 RVA: 0x00393670 File Offset: 0x00391870
	public cu2()
	{
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x00393678 File Offset: 0x00391878
	public override void aie(efk A_0, efk A_1, cd1 A_2, bool A_3, cmn A_4)
	{
		if (A_3)
		{
			A_4.b += cu2.a;
		}
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x00393694 File Offset: 0x00391894
	public override bool aif(bool A_0)
	{
		return A_0;
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x00393698 File Offset: 0x00391898
	public override string qn(coh A_0)
	{
		return "ApplyGunOil";
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x003936A0 File Offset: 0x003918A0
	public override string gc(efk A_0)
	{
		string text = string.Format("Применяется к огнестрельному оружию, предоставляя {0}% дополнительного урона на следующие {1} выстрела.", Convert.ToInt32(cu2.a * 100.0), base.RemainingTicks);
		if (dk2.e())
		{
			text += " Не предназначено для гранатомётов и ракетниц.";
		}
		return text;
	}

	// Token: 0x06008D82 RID: 36226 RVA: 0x003936F4 File Offset: 0x003918F4
	public override string gd(efk A_0)
	{
		return string.Format("Предоставляет {0}% дополнительного урона.", Convert.ToInt32(cu2.a * 100.0));
	}

	// Token: 0x040037B5 RID: 14261
	public new static readonly double a = 0.1;
}
