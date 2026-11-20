using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E6F RID: 7791
[ayj("HotwireVehicle")]
public sealed class b8d : m0
{
	// Token: 0x0600AD46 RID: 44358 RVA: 0x003FB21C File Offset: 0x003F941C
	public override string y8()
	{
		return "Взлом зажигания";
	}

	// Token: 0x0600AD47 RID: 44359 RVA: 0x003FB224 File Offset: 0x003F9424
	public override string os()
	{
		return "HotwireVehicle";
	}

	// Token: 0x0600AD48 RID: 44360 RVA: 0x003FB22C File Offset: 0x003F942C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AD49 RID: 44361 RVA: 0x003FB230 File Offset: 0x003F9430
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Hotwire);
	}

	// Token: 0x0600AD4A RID: 44362 RVA: 0x003FB23C File Offset: 0x003F943C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600AD4B RID: 44363 RVA: 0x003FB240 File Offset: 0x003F9440
	public override string c1()
	{
		return "Заводит";
	}

	// Token: 0x0600AD4C RID: 44364 RVA: 0x003FB248 File Offset: 0x003F9448
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AD4D RID: 44365 RVA: 0x003FB24C File Offset: 0x003F944C
	public b8d()
	{
		this.a = new List<string>();
	}

	// Token: 0x0600AD4E RID: 44366 RVA: 0x003FB260 File Offset: 0x003F9460
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600AD4F RID: 44367 RVA: 0x003FB264 File Offset: 0x003F9464
	public override string bm(cnm A_0)
	{
		return "Abilities.87";
	}

	// Token: 0x0600AD50 RID: 44368 RVA: 0x003FB26C File Offset: 0x003F946C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.HotwireableVehicle;
	}

	// Token: 0x0600AD51 RID: 44369 RVA: 0x003FB274 File Offset: 0x003F9474
	public override string bo(cnm A_0)
	{
		return "Пытается замкнуть схему зажигания транспорта.";
	}

	// Token: 0x0600AD52 RID: 44370 RVA: 0x003FB27C File Offset: 0x003F947C
	public override string bp(cnm A_0)
	{
		string text = "Пытается замкнуть схему зажигания транспорта.";
		if (A_0 != null && A_0.b8() != null)
		{
			text += string.Format(" Благодаря хорошему навыку взлома замков вы можете включить зажигание со сложностью до {0} ед.", A_0.b8().Skills.Get<dca>().g());
		}
		return text;
	}

	// Token: 0x0600AD53 RID: 44371 RVA: 0x003FB2CC File Offset: 0x003F94CC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x0600AD54 RID: 44372 RVA: 0x003FB2D4 File Offset: 0x003F94D4
	public override IList<string> bi()
	{
		return this.a;
	}

	// Token: 0x0600AD55 RID: 44373 RVA: 0x003FB2DC File Offset: 0x003F94DC
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AD56 RID: 44374 RVA: 0x003FB2E0 File Offset: 0x003F94E0
	protected override int br(cnm A_0)
	{
		return 10000;
	}

	// Token: 0x0600AD57 RID: 44375 RVA: 0x003FB2E8 File Offset: 0x003F94E8
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0400406C RID: 16492
	private new List<string> a;
}
