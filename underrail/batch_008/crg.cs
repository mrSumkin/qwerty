using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001E7F RID: 7807
[ayj("forceVent")]
public sealed class crg : m0
{
	// Token: 0x0600AE45 RID: 44613 RVA: 0x003FC084 File Offset: 0x003FA284
	public override string y8()
	{
		return "Силой открыть вентиляцию";
	}

	// Token: 0x0600AE46 RID: 44614 RVA: 0x003FC08C File Offset: 0x003FA28C
	public override string os()
	{
		return "forceVent";
	}

	// Token: 0x0600AE47 RID: 44615 RVA: 0x003FC094 File Offset: 0x003FA294
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600AE48 RID: 44616 RVA: 0x003FC098 File Offset: 0x003FA298
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.SpecialAttack);
	}

	// Token: 0x0600AE49 RID: 44617 RVA: 0x003FC0A0 File Offset: 0x003FA2A0
	public override bool cz()
	{
		return false;
	}

	// Token: 0x0600AE4B RID: 44619 RVA: 0x003FC0B0 File Offset: 0x003FA2B0
	public override a3b bl(cnm A_0, efk A_1)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().b(d8o.t))
		{
			return new a3b
			{
				c = c0e.k
			};
		}
		return new a3b
		{
			c = c0e.c
		};
	}

	// Token: 0x0600AE4C RID: 44620 RVA: 0x003FC108 File Offset: 0x003FA308
	public override string bm(cnm A_0)
	{
		return "ForceVent";
	}

	// Token: 0x0600AE4D RID: 44621 RVA: 0x003FC110 File Offset: 0x003FA310
	public override SpellTargetType bn(cnm A_0)
	{
		return SpellTargetType.ClosedVentilationShaft;
	}

	// Token: 0x0600AE4E RID: 44622 RVA: 0x003FC114 File Offset: 0x003FA314
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600AE4F RID: 44623 RVA: 0x003FC120 File Offset: 0x003FA320
	public override string bp(cnm A_0)
	{
		return "Открывает вентиляционную решётку. Потом её нельзя будет закрыть. Потребуется физическая сила в зависимости от прочности решётки.";
	}

	// Token: 0x0600AE50 RID: 44624 RVA: 0x003FC128 File Offset: 0x003FA328
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return d7f.o;
	}

	// Token: 0x0600AE51 RID: 44625 RVA: 0x003FC130 File Offset: 0x003FA330
	public override IList<string> bi()
	{
		return d7f.p;
	}

	// Token: 0x0600AE52 RID: 44626 RVA: 0x003FC138 File Offset: 0x003FA338
	public override dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x0600AE53 RID: 44627 RVA: 0x003FC140 File Offset: 0x003FA340
	public override bool hm(cnm A_0)
	{
		return base.hm(A_0) && A_0.b8() != null && Enumerable.Any<aia>(A_0.b8().Offense.u().TypedDefinition.@as(), new Func<aia, bool>(this.a));
	}

	// Token: 0x0600AE54 RID: 44628 RVA: 0x003FC194 File Offset: 0x003FA394
	protected override float f0(cnm A_0)
	{
		return as3.bk;
	}

	// Token: 0x0600AE55 RID: 44629 RVA: 0x003FC19C File Offset: 0x003FA39C
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}
}
