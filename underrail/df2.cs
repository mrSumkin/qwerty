using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F1E RID: 3870
[e79("Xpbl_EnterSubmarine")]
public sealed class df2 : dgy
{
	// Token: 0x06004ED8 RID: 20184 RVA: 0x00236AE4 File Offset: 0x00234CE4
	public df2()
	{
		df2.a a = new df2.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				bfq bfq = new bfq();
				bfq.a(bvl.b);
				bfq.c("SubmarineHatchOpen");
				bfq.a(true);
				array[num] = new ace(bfq);
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array2[num2] = dky;
				base.a(array2);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_submarine", "Enter"), false, new bool?(true), 0, null, false, false, false)
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000F1F RID: 3871
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EDA RID: 20186 RVA: 0x00236C70 File Offset: 0x00234E70
		internal bool a(e6d A_0)
		{
			if (this.b.h.b != null)
			{
				this.a.aqu().r()["vehicle_xpbl_submarine_exitZoneName"] = this.b.Zone.y8();
				this.a.aqu().r()["vehicle_xpbl_submarine_exitZoneId"] = this.b.Zone.qe();
				this.a.aqu().r()["vehicle_xpbl_submarine_exitAreaId"] = this.b.Area.qe();
				csd csd = new csd("ExitSubmarine");
				csd.Location = this.b.Location;
				csd.Direction = aw1.b(this.b.VisualDirection);
				csd.AreaName = this.b.Area.y8();
				csd.Layer = 1;
				this.a.aqw().a(csd);
				if (this.b.h.b.aa().Vehicle != null)
				{
					new an9().ym(this.b, null, null);
				}
				if (this.a.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_submarine_checkedPropulsion", new bool?(false)).Value && !this.a.aqu().r().GetPrimitivePropertyValue<bool>("interfacing_xpbl_submarine_readyToGo", new bool?(false)).Value && this.a.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_sc_foundDispatcherCoordinates", new bool?(false)).Value && this.b.Zone.y8() == "xpbl_l2")
				{
					this.a.aqz().atc("xpbl_investigatedSubmarine", true);
					this.a.aqz().atb("xpbl_submarineDescentIntoAbyss", true);
					this.a.aqu().r()["interfacing_xpbl_submarine_readyToGo"] = true;
				}
			}
			return true;
		}

		// Token: 0x0400204C RID: 8268
		public cnk a;

		// Token: 0x0400204D RID: 8269
		public c5x b;
	}
}
