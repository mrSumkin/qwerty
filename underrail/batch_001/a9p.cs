using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F40 RID: 8000
[ayj("releaseAbramsCyberneticSpawn")]
public sealed class a9p : m0
{
	// Token: 0x0600BA3D RID: 47677 RVA: 0x00412B04 File Offset: 0x00410D04
	public override string y8()
	{
		return "releaseAbramsCyberneticSpawn";
	}

	// Token: 0x0600BA3E RID: 47678 RVA: 0x00412B0C File Offset: 0x00410D0C
	public override string os()
	{
		return "releaseAbramsCyberneticSpawn";
	}

	// Token: 0x0600BA3F RID: 47679 RVA: 0x00412B14 File Offset: 0x00410D14
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600BA40 RID: 47680 RVA: 0x00412B18 File Offset: 0x00410D18
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BA41 RID: 47681 RVA: 0x00412B1C File Offset: 0x00410D1C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BA42 RID: 47682 RVA: 0x00412B30 File Offset: 0x00410D30
	public override string c1()
	{
		return "Выпускает";
	}

	// Token: 0x0600BA43 RID: 47683 RVA: 0x00412B38 File Offset: 0x00410D38
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BA44 RID: 47684 RVA: 0x00412B3C File Offset: 0x00410D3C
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BA45 RID: 47685 RVA: 0x00412B44 File Offset: 0x00410D44
	public a9p()
	{
		this.c = new List<string>();
		this.c.Add("ReleaseAbramsCyberneticSpawn");
	}

	// Token: 0x0600BA46 RID: 47686 RVA: 0x00412B68 File Offset: 0x00410D68
	public override bool c3(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600BA47 RID: 47687 RVA: 0x00412B6C File Offset: 0x00410D6C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BA48 RID: 47688 RVA: 0x00412B70 File Offset: 0x00410D70
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.Self;
	}

	// Token: 0x0600BA49 RID: 47689 RVA: 0x00412B74 File Offset: 0x00410D74
	public override string bo(cnm A_0)
	{
		return "";
	}

	// Token: 0x0600BA4A RID: 47690 RVA: 0x00412B7C File Offset: 0x00410D7C
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Custom/ReleaseAbramsCyberneticSpawn");
	}

	// Token: 0x0600BA4B RID: 47691 RVA: 0x00412B88 File Offset: 0x00410D88
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("ReleaseAbramsCyberneticSpawn", a9p.b, false, false)
		};
	}

	// Token: 0x0600BA4C RID: 47692 RVA: 0x00412BA8 File Offset: 0x00410DA8
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BA4D RID: 47693 RVA: 0x00412BAC File Offset: 0x00410DAC
	protected override int hi(cnm A_0)
	{
		return 0;
	}

	// Token: 0x0600BA4E RID: 47694 RVA: 0x00412BB0 File Offset: 0x00410DB0
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x040043A3 RID: 17315
	private new const string a = "ReleaseAbramsCyberneticSpawn";

	// Token: 0x040043A4 RID: 17316
	public static readonly int b = 1000;

	// Token: 0x040043A5 RID: 17317
	private List<string> c;
}
