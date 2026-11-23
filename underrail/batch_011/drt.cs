using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003AC RID: 940
[fe("rigGuard")]
public sealed class drt : b5g
{
	// Token: 0x060019D4 RID: 6612 RVA: 0x0008A7A0 File Offset: 0x000889A0
	public drt(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("TalkToHero", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(drt.a.a.a), null)
		{
			e = false
		});
		base.a(a_, list);
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x0008A820 File Offset: 0x00088A20
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x.h.b.aa().Vehicle != null)
			{
				return false;
			}
			double num = 5.0;
			bool flag = false;
			if (serviceOrThrow.aqu().v().Gear.l().Item != null && serviceOrThrow.aqu().v().Gear.l().Item.fu().e() == "wrk")
			{
				num = 3.0;
				flag = true;
			}
			bool flag2 = bui.b(bnx.a(this.Subject.a8().Location.b(), this.Subject.a8().VisualDirection, serviceOrThrow.aqu().v().b().Location.b())) == aiy.b8;
			if (!c5x.h.b.aa().IsInCombat && c5x.h.b.aa().IsInControl && aw1.b(c5x, this.Subject.a8()) <= num && (!flag || flag2) && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_safeAreaFromGuards", new bool?(false)).Value)
			{
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rig_guardApproachedPlayer", new bool?(false)).Value;
				if (!value || (value && serviceOrThrow.aqu().v().Gear.l().Item.fu().e() != "wrk"))
				{
					blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
					return blk != null && blk.b() && blk.f() > global::h.a;
				}
			}
		}
		return false;
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0008AAA0 File Offset: 0x00088CA0
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (this.Subject.a8().u.b != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			j7 aspect = (serviceOrThrow.aqu().v().b() as c5x).GetAspect<j7>();
			j7 aspect2 = this.Subject.a8().GetAspect<j7>();
			if (aspect2 != null && aspect != null)
			{
				return aspect2.a(aspect, true, null, false);
			}
		}
		return null;
	}

	// Token: 0x020003AD RID: 941
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x0008AB58 File Offset: 0x00088D58
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000E97 RID: 3735
		public static readonly drt.a a = new drt.a();

		// Token: 0x04000E98 RID: 3736
		public static Func<bool, float> b;
	}
}
