using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E76 RID: 7798
[ayj("MineRock")]
public sealed class eib : m0
{
	// Token: 0x0600ADBF RID: 44479 RVA: 0x003FB880 File Offset: 0x003F9A80
	public override string y8()
	{
		return "Дробить камень";
	}

	// Token: 0x0600ADC0 RID: 44480 RVA: 0x003FB888 File Offset: 0x003F9A88
	public override string os()
	{
		return "MineRock";
	}

	// Token: 0x0600ADC1 RID: 44481 RVA: 0x003FB890 File Offset: 0x003F9A90
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600ADC2 RID: 44482 RVA: 0x003FB894 File Offset: 0x003F9A94
	public override string c1()
	{
		return "Дробление";
	}

	// Token: 0x0600ADC3 RID: 44483 RVA: 0x003FB89C File Offset: 0x003F9A9C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600ADC4 RID: 44484 RVA: 0x003FB8A0 File Offset: 0x003F9AA0
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600ADC6 RID: 44486 RVA: 0x003FB8AC File Offset: 0x003F9AAC
	public override a3b bl(cnm A_0, efk A_1)
	{
		return new a3b
		{
			e = c0e.d
		};
	}

	// Token: 0x0600ADC7 RID: 44487 RVA: 0x003FB8C0 File Offset: 0x003F9AC0
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600ADC8 RID: 44488 RVA: 0x003FB8C4 File Offset: 0x003F9AC4
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600ADC9 RID: 44489 RVA: 0x003FB8C8 File Offset: 0x003F9AC8
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.MinableRockOrDestrucableRockOrDebris;
	}

	// Token: 0x0600ADCA RID: 44490 RVA: 0x003FB8D0 File Offset: 0x003F9AD0
	public override string bo(cnm A_0)
	{
		return string.Format("Добыть руду из камня или расчистить камни/обломки. Потребляет {0} очков энергии.", eib.a);
	}

	// Token: 0x0600ADCB RID: 44491 RVA: 0x003FB8E8 File Offset: 0x003F9AE8
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600ADCC RID: 44492 RVA: 0x003FB8F4 File Offset: 0x003F9AF4
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600ADCD RID: 44493 RVA: 0x003FB8FC File Offset: 0x003F9AFC
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600ADCE RID: 44494 RVA: 0x003FB904 File Offset: 0x003F9B04
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600ADCF RID: 44495 RVA: 0x003FB908 File Offset: 0x003F9B08
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600ADD0 RID: 44496 RVA: 0x003FB910 File Offset: 0x003F9B10
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600ADD1 RID: 44497 RVA: 0x003FB918 File Offset: 0x003F9B18
	protected override double q3(cnm A_0)
	{
		return (double)eib.a;
	}

	// Token: 0x04004072 RID: 16498
	public new static readonly int a = 20;
}
