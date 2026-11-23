using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E80 RID: 7808
[ayj("openVent")]
public sealed class cfo : m0
{
	// Token: 0x0600AE56 RID: 44630 RVA: 0x003FC1A8 File Offset: 0x003FA3A8
	public override string y8()
	{
		return "Открыть вентиляционную решётку";
	}

	// Token: 0x0600AE57 RID: 44631 RVA: 0x003FC1B0 File Offset: 0x003FA3B0
	public override string os()
	{
		return "openVent";
	}

	// Token: 0x0600AE58 RID: 44632 RVA: 0x003FC1B8 File Offset: 0x003FA3B8
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE59 RID: 44633 RVA: 0x003FC1BC File Offset: 0x003FA3BC
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.Lockpick);
	}

	// Token: 0x0600AE5A RID: 44634 RVA: 0x003FC1C8 File Offset: 0x003FA3C8
	public override string c1()
	{
		return "Открывает";
	}

	// Token: 0x0600AE5B RID: 44635 RVA: 0x003FC1D0 File Offset: 0x003FA3D0
	public override bool q2()
	{
		return false;
	}

	// Token: 0x0600AE5D RID: 44637 RVA: 0x003FC1DC File Offset: 0x003FA3DC
	public override string bm(cnm A_0)
	{
		return "Abilities.24";
	}

	// Token: 0x0600AE5E RID: 44638 RVA: 0x003FC1E4 File Offset: 0x003FA3E4
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.ClosedVentilationShaft;
	}

	// Token: 0x0600AE5F RID: 44639 RVA: 0x003FC1E8 File Offset: 0x003FA3E8
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AE60 RID: 44640 RVA: 0x003FC1F4 File Offset: 0x003FA3F4
	public override string bp(cnm A_0)
	{
		return "Открывает вентиляционную решётку. Потребуется определённый уровень навыка взлом замков в зависимости от решётки.";
	}

	// Token: 0x0600AE61 RID: 44641 RVA: 0x003FC1FC File Offset: 0x003FA3FC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AE62 RID: 44642 RVA: 0x003FC204 File Offset: 0x003FA404
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AE63 RID: 44643 RVA: 0x003FC20C File Offset: 0x003FA40C
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600AE64 RID: 44644 RVA: 0x003FC210 File Offset: 0x003FA410
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600AE65 RID: 44645 RVA: 0x003FC218 File Offset: 0x003FA418
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}
}
