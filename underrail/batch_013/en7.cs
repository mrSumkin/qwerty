using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000DD6 RID: 3542
[e79("Sgs_EndTutorial")]
public sealed class en7 : dgy
{
	// Token: 0x06004BE3 RID: 19427 RVA: 0x0020FDCC File Offset: 0x0020DFCC
	public en7()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			en7.a a = new en7.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Zone != null)
			{
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new dva(new Func<e6d, bool>(a.a), null, null, null, null)
				});
				base.a(new btm[]
				{
					new di4(new c2w("StationAlpha-Level5", "start"), false, null, 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x02000DD7 RID: 3543
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BE5 RID: 19429 RVA: 0x0020FEE0 File Offset: 0x0020E0E0
		internal bool a(e6d A_0)
		{
			dcw a_ = new dcw();
			ke.a(this.a.h.b.aa(), a_, false, false);
			this.a.h.b.aa().Defense.a(100000, null, null, false, false, false, null);
			if (this.a.h.b.aa().Gear.l().Item == null)
			{
				this.a.h.b.aa().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\ShirtAndPants")), true);
			}
			return true;
		}

		// Token: 0x04001E9D RID: 7837
		public c5x a;
	}
}
