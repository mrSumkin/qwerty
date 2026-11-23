using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001EA5 RID: 7845
[ayj("SoundGunDisruptiveWave")]
public sealed class bc9 : bon
{
	// Token: 0x0600B03F RID: 45119 RVA: 0x003FFA80 File Offset: 0x003FDC80
	public override string y8()
	{
		return "Разрядная волна";
	}

	// Token: 0x0600B040 RID: 45120 RVA: 0x003FFA88 File Offset: 0x003FDC88
	public override string os()
	{
		return "SoundGunDisruptiveWave";
	}

	// Token: 0x0600B041 RID: 45121 RVA: 0x003FFA90 File Offset: 0x003FDC90
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600B042 RID: 45122 RVA: 0x003FFA94 File Offset: 0x003FDC94
	public override bool cs()
	{
		return false;
	}

	// Token: 0x0600B043 RID: 45123 RVA: 0x003FFA98 File Offset: 0x003FDC98
	public override int ct()
	{
		return 1;
	}

	// Token: 0x0600B044 RID: 45124 RVA: 0x003FFA9C File Offset: 0x003FDC9C
	public override bool bk()
	{
		return true;
	}

	// Token: 0x0600B045 RID: 45125 RVA: 0x003FFAA0 File Offset: 0x003FDCA0
	public override bool xc()
	{
		return true;
	}

	// Token: 0x0600B047 RID: 45127 RVA: 0x003FFAAC File Offset: 0x003FDCAC
	public override string bm(cnm A_0)
	{
		return "SoundGun.DisruptiveWave";
	}

	// Token: 0x0600B048 RID: 45128 RVA: 0x003FFAB4 File Offset: 0x003FDCB4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600B049 RID: 45129 RVA: 0x003FFAB8 File Offset: 0x003FDCB8
	public override string bo(cnm A_0)
	{
		return qv.a("SpecialAttacks/SoundGunDisruptiveWave", new object[]
		{
			(int)(bc9.b * 100.0),
			l4.a(bc9.a, false)
		});
	}

	// Token: 0x0600B04A RID: 45130 RVA: 0x003FFAF0 File Offset: 0x003FDCF0
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B04B RID: 45131 RVA: 0x003FFAFC File Offset: 0x003FDCFC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		List<cfd> list = new List<cfd>();
		if (A_1 == v5.b)
		{
			list.Add(new cfd(d7f.a, d7f.g, true, false));
		}
		return list;
	}

	// Token: 0x0600B04C RID: 45132 RVA: 0x003FFB30 File Offset: 0x003FDD30
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.a
		};
	}

	// Token: 0x0600B04D RID: 45133 RVA: 0x003FFB44 File Offset: 0x003FDD44
	protected override int br(cnm A_0)
	{
		return 200;
	}

	// Token: 0x040040D5 RID: 16597
	public new static readonly int a = 1;

	// Token: 0x040040D6 RID: 16598
	public static readonly double b = 0.3;
}
