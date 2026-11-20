using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D45 RID: 3397
[e79("Xpbl_Le_SleepInBed")]
public sealed class rq : dgy
{
	// Token: 0x06004A9D RID: 19101 RVA: 0x001FD158 File Offset: 0x001FB358
	public rq()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			rq.b b = new rq.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				rq.a a = new rq.a();
				new ar7(new Guid("a34f05d2-80ea-4f8b-98bb-d13572cafe1a"), b.a.Area).ao();
				a.a = (new ar7(new Guid("1e20c06c-ae01-4cd8-830f-0e9399eebfd9"), b.a.Area).ao() as c5x);
				c5x c5x = new ar7(new Guid("931f6c61-e5a7-4541-9213-daad39382962"), b.a.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), b.a.Area).ao() as c5x;
				base.a(new btm[]
				{
					new ace(new e80(false))
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
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackHandled", new bool?(false)).Value)
				{
					azq azq = new azq();
					azq.a("professorsKidnapping");
					azq.ym(null, null, null);
					new arc().ym(null, null, null);
					if (c5x != null)
					{
						c5x.w();
						c5x.an();
					}
					if (c5x2 != null)
					{
						uk uk = new uk();
						uk.a(new Guid?(c5x2.qe()));
						uk.c(true);
						uk.ym(b.a, null, null);
					}
				}
				if (((serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_professorKidnapped", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_toldAboutEvent", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_completed", new bool?(false)).Value) || (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_fu_pirateAttackFailed", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_talkedDeadPirates", new bool?(false)).Value)) && a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.a), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D46 RID: 3398
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A9F RID: 19103 RVA: 0x001FD4C8 File Offset: 0x001FB6C8
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("interfacing\\xpbl\\campBed");
			a.d("interface");
			a.c("Bed");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001DD5 RID: 7637
		public c5x a;
	}

	// Token: 0x02000D47 RID: 3399
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AA1 RID: 19105 RVA: 0x001FD518 File Offset: 0x001FB718
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "guard_kidnapping", true);
			if (this.a.t.b != null)
			{
				this.a.t.b.y6()[ddq.bc] = "quests_xpbl_expedition_saveTheProfessor_toldAboutEvent";
				this.a.t.b.y6()[ddq.ay] = new bt4("guard_kidnapping");
			}
			return true;
		}

		// Token: 0x04001DD6 RID: 7638
		public c5x a;
	}
}
