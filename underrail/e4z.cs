using System;
using System.Collections.Generic;

// Token: 0x02001FAF RID: 8111
public static class e4z
{
	// Token: 0x0600BE67 RID: 48743 RVA: 0x00418DDC File Offset: 0x00416FDC
	public static void j(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.i));
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE68 RID: 48744 RVA: 0x00418E04 File Offset: 0x00417004
	public static void i(cao A_0)
	{
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE69 RID: 48745 RVA: 0x00418E18 File Offset: 0x00417018
	public static void a(clf A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.i));
		A_0.j(new EventHandler<b25>(e4z.f));
		A_0.a(new EventHandler<c1>(e4z.a));
	}

	// Token: 0x0600BE6A RID: 48746 RVA: 0x00418E50 File Offset: 0x00417050
	public static void h(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.a));
	}

	// Token: 0x0600BE6B RID: 48747 RVA: 0x00418E64 File Offset: 0x00417064
	public static void g(cao A_0)
	{
		A_0.c(new EventHandler<c1>(e4z.b));
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE6C RID: 48748 RVA: 0x00418E8C File Offset: 0x0041708C
	public static void f(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.e));
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE6D RID: 48749 RVA: 0x00418EB4 File Offset: 0x004170B4
	public static void b(eb1 A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.g));
		A_0.j(new EventHandler<b25>(e4z.h));
	}

	// Token: 0x0600BE6E RID: 48750 RVA: 0x00418EDC File Offset: 0x004170DC
	public static void a(eb1 A_0)
	{
		A_0.j(new EventHandler<b25>(e4z.h));
	}

	// Token: 0x0600BE6F RID: 48751 RVA: 0x00418EF0 File Offset: 0x004170F0
	public static void e(cao A_0)
	{
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE70 RID: 48752 RVA: 0x00418F04 File Offset: 0x00417104
	public static void a(euz A_0)
	{
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE71 RID: 48753 RVA: 0x00418F18 File Offset: 0x00417118
	public static void d(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.d));
	}

	// Token: 0x0600BE72 RID: 48754 RVA: 0x00418F2C File Offset: 0x0041712C
	public static void c(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.d));
	}

	// Token: 0x0600BE73 RID: 48755 RVA: 0x00418F40 File Offset: 0x00417140
	public static void b(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.b));
	}

	// Token: 0x0600BE74 RID: 48756 RVA: 0x00418F54 File Offset: 0x00417154
	public static void a(cao A_0)
	{
		A_0.m(new EventHandler<b25>(e4z.c));
		A_0.j(new EventHandler<b25>(e4z.f));
	}

	// Token: 0x0600BE75 RID: 48757 RVA: 0x00418F7C File Offset: 0x0041717C
	public static void j()
	{
		e4z.a("ButtonPressed", 1f);
	}

	// Token: 0x0600BE76 RID: 48758 RVA: 0x00418F90 File Offset: 0x00417190
	public static void i()
	{
		e4z.a("OpenCloseSubinterface", 1f);
	}

	// Token: 0x0600BE77 RID: 48759 RVA: 0x00418FA4 File Offset: 0x004171A4
	public static void h()
	{
		e4z.a("TbcOn", 1f);
	}

	// Token: 0x0600BE78 RID: 48760 RVA: 0x00418FB8 File Offset: 0x004171B8
	public static void g()
	{
		e4z.a("TbcOff", 1f);
	}

	// Token: 0x0600BE79 RID: 48761 RVA: 0x00418FCC File Offset: 0x004171CC
	public static void f()
	{
		e4z.a("KeyEntered", 1f);
	}

	// Token: 0x0600BE7A RID: 48762 RVA: 0x00418FE0 File Offset: 0x004171E0
	public static void e()
	{
		e4z.a("WeaponSwap", 1f);
	}

	// Token: 0x0600BE7B RID: 48763 RVA: 0x00418FF4 File Offset: 0x004171F4
	public static void d()
	{
		e4z.a("ItemPickUp", 1f);
	}

	// Token: 0x0600BE7C RID: 48764 RVA: 0x00419008 File Offset: 0x00417208
	public static void c()
	{
		e4z.a("ItemDrop", 1f);
	}

	// Token: 0x0600BE7D RID: 48765 RVA: 0x0041901C File Offset: 0x0041721C
	public static void b()
	{
		e4z.a("DialogButton", 1f);
	}

	// Token: 0x0600BE7E RID: 48766 RVA: 0x00419030 File Offset: 0x00417230
	public static void a()
	{
		e4z.a("ActionButton", 1f);
	}

	// Token: 0x0600BE7F RID: 48767 RVA: 0x00419044 File Offset: 0x00417244
	public static void a(string A_0, float A_1 = 1f)
	{
		DateTime d;
		if (e4z.a.TryGetValue(A_0, out d) && DateTime.Now - d < TimeSpan.FromMilliseconds(100.0))
		{
			return;
		}
		dd7 service = bpo.GetService<dd7>();
		if (service != null)
		{
			service.aeb("Interface." + A_0, 1f, false, c9z.e, false);
			e4z.a[A_0] = DateTime.Now;
		}
	}

	// Token: 0x0600BE80 RID: 48768 RVA: 0x004190C0 File Offset: 0x004172C0
	private static void i(object A_0, b25 A_1)
	{
		e4z.a("ButtonPressed", 1f);
	}

	// Token: 0x0600BE81 RID: 48769 RVA: 0x004190D4 File Offset: 0x004172D4
	private static void h(object A_0, b25 A_1)
	{
		eb1 eb = A_0 as eb1;
		if (eb != null && eb.zc() != null)
		{
			e4z.a("ButtonRollover", 1f);
		}
	}

	// Token: 0x0600BE82 RID: 48770 RVA: 0x00419108 File Offset: 0x00417308
	private static void g(object A_0, b25 A_1)
	{
		eb1 eb = A_0 as eb1;
		if (eb != null && eb.zc() != null && eb.zc().yw())
		{
			e4z.a();
		}
	}

	// Token: 0x0600BE83 RID: 48771 RVA: 0x00419144 File Offset: 0x00417344
	private static void f(object A_0, b25 A_1)
	{
		e4z.a("ButtonRollover", 1f);
	}

	// Token: 0x0600BE84 RID: 48772 RVA: 0x00419158 File Offset: 0x00417358
	private static void b(object A_0, c1 A_1)
	{
		e4z.a("Checkbox", 1f);
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x0041916C File Offset: 0x0041736C
	private static void e(object A_0, b25 A_1)
	{
		e4z.a("ChoiceButtonPressed", 1f);
	}

	// Token: 0x0600BE86 RID: 48774 RVA: 0x00419180 File Offset: 0x00417380
	private static void d(object A_0, b25 A_1)
	{
		e4z.a("ScrollBarButtonPressed", 1f);
	}

	// Token: 0x0600BE87 RID: 48775 RVA: 0x00419194 File Offset: 0x00417394
	private static void c(object A_0, b25 A_1)
	{
		e4z.a("TabPageButtonPressed", 1f);
	}

	// Token: 0x0600BE88 RID: 48776 RVA: 0x004191A8 File Offset: 0x004173A8
	private static void b(object A_0, b25 A_1)
	{
		e4z.a("IncrementDecrementButtonPressed", 1f);
	}

	// Token: 0x0600BE89 RID: 48777 RVA: 0x004191BC File Offset: 0x004173BC
	private static void a(object A_0, b25 A_1)
	{
		e4z.b();
	}

	// Token: 0x0600BE8A RID: 48778 RVA: 0x004191C4 File Offset: 0x004173C4
	private static void a(object A_0, c1 A_1)
	{
		e4z.f();
	}

	// Token: 0x04004469 RID: 17513
	private static Dictionary<string, DateTime> a = new Dictionary<string, DateTime>();
}
