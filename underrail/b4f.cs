using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F66 RID: 8038
public abstract class b4f : ehl
{
	// Token: 0x0600BBEF RID: 48111 RVA: 0x00415608 File Offset: 0x00413808
	public override ci8 bg()
	{
		return ci8.c;
	}

	// Token: 0x0600BBF0 RID: 48112 RVA: 0x0041560C File Offset: 0x0041380C
	public override string c1()
	{
		return "Бросает";
	}

	// Token: 0x0600BBF1 RID: 48113 RVA: 0x00415614 File Offset: 0x00413814
	public override bool cz()
	{
		return true;
	}

	// Token: 0x0600BBF2 RID: 48114 RVA: 0x00415618 File Offset: 0x00413818
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.i,
			b = new int?(int.MaxValue),
			c = c0e.i
		};
	}

	// Token: 0x0600BBF3 RID: 48115 RVA: 0x00415648 File Offset: 0x00413848
	public override IList<string> bi()
	{
		return this.c;
	}

	// Token: 0x0600BBF4 RID: 48116 RVA: 0x00415650 File Offset: 0x00413850
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.GroundAttack);
	}

	// Token: 0x0600BBF5 RID: 48117 RVA: 0x0041565C File Offset: 0x0041385C
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.DiscoveredTraversableSpot;
	}

	// Token: 0x0600BBF6 RID: 48118 RVA: 0x00415660 File Offset: 0x00413860
	public override dsk cv(cnm A_0)
	{
		return dsk.b;
	}

	// Token: 0x0600BBF7 RID: 48119 RVA: 0x00415664 File Offset: 0x00413864
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BBF8 RID: 48120 RVA: 0x00415668 File Offset: 0x00413868
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(b4f.b, b4f.a, false, false)
		};
	}

	// Token: 0x0600BBF9 RID: 48121 RVA: 0x00415688 File Offset: 0x00413888
	protected override int br(cnm A_0)
	{
		return 1500;
	}

	// Token: 0x0600BBFA RID: 48122 RVA: 0x00415690 File Offset: 0x00413890
	protected override float f0(cnm A_0)
	{
		return (float)as3.at;
	}

	// Token: 0x0600BBFB RID: 48123 RVA: 0x00415698 File Offset: 0x00413898
	protected override int d2(cnm A_0)
	{
		return 2;
	}

	// Token: 0x0600BBFC RID: 48124 RVA: 0x0041569C File Offset: 0x0041389C
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x040043F4 RID: 17396
	public new static readonly int a = 2 * d0u.b;

	// Token: 0x040043F5 RID: 17397
	public static readonly string b = "Caltrops";

	// Token: 0x040043F6 RID: 17398
	private List<string> c = new List<string>
	{
		b4f.b
	};
}
