using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000DB8 RID: 3512
[e79("Sgs_EndTutorialDoNotRemoveItems")]
public sealed class bep : dgy
{
	// Token: 0x06004BA2 RID: 19362 RVA: 0x0020C830 File Offset: 0x0020AA30
	public bep()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bep.a a = new bep.a();
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

	// Token: 0x02000DB9 RID: 3513
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BA4 RID: 19364 RVA: 0x0020C944 File Offset: 0x0020AB44
		internal bool a(e6d A_0)
		{
			this.a.h.b.aa().Defense.a(100000, null, null, false, false, false, null);
			if (this.a.h.b.aa().Gear.l().Item == null)
			{
				this.a.h.b.aa().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\ShirtAndPants")), true);
			}
			return true;
		}

		// Token: 0x04001E6F RID: 7791
		public c5x a;
	}
}
