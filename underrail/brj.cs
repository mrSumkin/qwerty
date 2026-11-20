using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F64 RID: 8036
[ayj("udc")]
public sealed class brj : c0r
{
	// Token: 0x0600BBCC RID: 48076 RVA: 0x0041543C File Offset: 0x0041363C
	public override string y8()
	{
		return "Capture";
	}

	// Token: 0x0600BBCD RID: 48077 RVA: 0x00415444 File Offset: 0x00413644
	public override string os()
	{
		return "udc";
	}

	// Token: 0x0600BBCE RID: 48078 RVA: 0x0041544C File Offset: 0x0041364C
	public override string c1()
	{
		return "Захватывает";
	}

	// Token: 0x0600BBCF RID: 48079 RVA: 0x00415454 File Offset: 0x00413654
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.CreatureNotSelf;
	}

	// Token: 0x0600BBD0 RID: 48080 RVA: 0x00415458 File Offset: 0x00413658
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BBD1 RID: 48081 RVA: 0x0041545C File Offset: 0x0041365C
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BBD2 RID: 48082 RVA: 0x00415470 File Offset: 0x00413670
	public brj()
	{
		this.d = new List<string>
		{
			"dogCrate"
		};
	}

	// Token: 0x0600BBD3 RID: 48083 RVA: 0x00415490 File Offset: 0x00413690
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BBD4 RID: 48084 RVA: 0x00415498 File Offset: 0x00413698
	public override string bp(cnm A_0)
	{
		return qv.b("Items\\Utilities/DogCrate");
	}

	// Token: 0x0600BBD5 RID: 48085 RVA: 0x004154A4 File Offset: 0x004136A4
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BBD6 RID: 48086 RVA: 0x004154A8 File Offset: 0x004136A8
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd("dogCrate", 10000, false, false)
		};
	}

	// Token: 0x0600BBD7 RID: 48087 RVA: 0x004154C8 File Offset: 0x004136C8
	public override IList<string> bi()
	{
		return this.d;
	}

	// Token: 0x0600BBD8 RID: 48088 RVA: 0x004154D0 File Offset: 0x004136D0
	protected override int br(cnm A_0)
	{
		return 2500;
	}

	// Token: 0x0600BBD9 RID: 48089 RVA: 0x004154D8 File Offset: 0x004136D8
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600BBDA RID: 48090 RVA: 0x004154E0 File Offset: 0x004136E0
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BBDB RID: 48091 RVA: 0x004154E4 File Offset: 0x004136E4
	protected override int hi(cnm A_0)
	{
		return 40;
	}

	// Token: 0x040043EE RID: 17390
	private new const string a = "dogCrate";

	// Token: 0x040043EF RID: 17391
	private const int b = 10000;

	// Token: 0x040043F0 RID: 17392
	private const int c = 2500;

	// Token: 0x040043F1 RID: 17393
	private List<string> d;
}
