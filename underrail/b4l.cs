using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200037D RID: 893
[fe("CaveHopper")]
public sealed class b4l : ua, cqc
{
	// Token: 0x060018BC RID: 6332 RVA: 0x000801B4 File Offset: 0x0007E3B4
	public b4l(bm6 A_0) : base("CaveHopper", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new cz8("ActiveMode", cy1.g, "active", new List<c96>
		{
			new b64("HadEnoughMushrooms", new Func<TimeSpan, double, bool>(this.c), new Func<TimeSpan, double, ej1>(this.b), null, null)
			{
				c = 2f
			},
			new ebv("FindNextMushroom"),
			new e8q("TrekAndEatMushroom")
		}));
		string a_ = "HideMode";
		string g = cy1.g;
		object a_2 = "hide";
		List<c96> list2 = new List<c96>();
		list2.Add(new dt6("HideTimeout", "lgHideTimer", new Action<dt6>(b4l.a.a.a)));
		list.Add(new cz8(a_, g, a_2, list2));
		list.Add(new cz8("FlightMode", cy1.g, "flee", new List<c96>
		{
			new cou("EndFlightAndStartHiding")
			{
				c = 1.3f
			},
			new e1w("FleeToSafePlace")
			{
				c = 1.2f
			},
			new a4a("FindNextSafePlaceToFlee")
			{
				c = 1.1f
			}
		})
		{
			c = 1.2f
		});
		list.Add(new cz8("ReturnMode", cy1.g, "return", new List<c96>
		{
			new cou("EndReturnAndStartHiding")
			{
				c = 1.3f
			},
			new e1w("ReturnToSafePlace")
			{
				c = 1.2f
			},
			new a4a("FindNextSafePlaceToReturn")
			{
				c = 1.1f
			}
		})
		{
			c = 1.15f
		});
		list.Add(new bb9("ReactToUnfriendlies", new List<c96>
		{
			new bfo("EngageFlightMode")
		})
		{
			c = 1.1f
		});
		list.Add(new b64("SetModeToActiveIfNoMode", new Func<TimeSpan, double, bool>(b4l.a.a.a), new Func<TimeSpan, double, ej1>(this.a), null, null));
		base.a(list);
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x00080408 File Offset: 0x0007E608
	public amc adh()
	{
		return this.Subject.a8().h.b;
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00080420 File Offset: 0x0007E620
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetPrimitivePropertyValue<int>("lgMushroomsNeeded", new int?(0)).Value <= 0;
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00080458 File Offset: 0x0007E658
	[CompilerGenerated]
	private ej1 b(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[cy1.g] = "return";
		return ej1.b;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00080478 File Offset: 0x0007E678
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[cy1.g] = "active";
		this.Subject.y6()["lgMushroomsNeeded"] = 6;
		return ej1.b;
	}

	// Token: 0x04000E5B RID: 3675
	internal new const int a = 6;

	// Token: 0x0200037E RID: 894
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x000804D4 File Offset: 0x0007E6D4
		internal void a(dt6 A_0)
		{
			A_0.Subject.y6()[cy1.g] = "active";
			A_0.Subject.y6()["lgMushroomsNeeded"] = 6;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00080518 File Offset: 0x0007E718
		internal bool a(TimeSpan A_0, double A_1)
		{
			return true;
		}

		// Token: 0x04000E5C RID: 3676
		public static readonly b4l.a a = new b4l.a();

		// Token: 0x04000E5D RID: 3677
		public static Action<dt6> b;

		// Token: 0x04000E5E RID: 3678
		public static Func<TimeSpan, double, bool> c;
	}
}
