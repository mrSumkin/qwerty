using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020003DD RID: 989
[fe("fo_evelyn")]
public sealed class d07 : b5g
{
	// Token: 0x06001A74 RID: 6772 RVA: 0x0008EB48 File Offset: 0x0008CD48
	public d07(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("Open Power Box", new Func<TimeSpan, double, bool>(this.n), new Func<TimeSpan, double, cst>(this.m), new Func<bool, float>(d07.a.a.c), null)
		{
			e = false
		});
		list.Add(new byh("Turn Power On", new Func<TimeSpan, double, bool>(this.l), new Func<TimeSpan, double, cst>(this.k), new Func<bool, float>(d07.a.a.d), null)
		{
			e = false
		});
		list.Add(new b64("Start looking for player in the power room", new Func<TimeSpan, double, bool>(this.j), new Func<TimeSpan, double, ej1>(this.i), new Func<bool, float>(d07.a.a.f), null));
		list.Add(new b64("Set patrol default route to default", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, ej1>(this.g), new Func<bool, float>(d07.a.a.e), null));
		list.Add(new b64("Set patrol default route to searching the power room", new Func<TimeSpan, double, bool>(this.f), new Func<TimeSpan, double, ej1>(this.e), new Func<bool, float>(d07.a.a.b), null));
		list.Add(new b64("Abort power room search", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(d07.a.a.g), null));
		list.Add(new b64("Taunt", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(d07.a.a.a), null));
		base.a(list);
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x0008ED84 File Offset: 0x0008CF84
	private void a(c5x A_0, string A_1)
	{
		if (A_0.u.b != null)
		{
			A_0.u.b.a(A_1, true, null, null);
		}
		d60 addon = A_0.Zone.GetAddon<d60>();
		if (addon != null)
		{
			List<b0b> list = addon.ab4(new string[]
			{
				"speaker"
			});
			if (list != null)
			{
				foreach (b0b b0b in list)
				{
					c5x c5x = (c5x)b0b;
					if (c5x.u.b != null)
					{
						c5x.u.b.a(A_1, true, null, null);
					}
				}
			}
		}
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x0008EE70 File Offset: 0x0008D070
	private c5x a(aud A_0)
	{
		c5x c5x = new ar7(new Guid("34399c25-dc98-49ec-877d-b6dbb35c6373"), this.Subject.a8().Area).ao() as c5x;
		if (c5x != null)
		{
			return Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(c5x.l).c.Values, new Func<b0b, bool>(d07.a.a.a))) as c5x;
		}
		return null;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x0008EF30 File Offset: 0x0008D130
	[CompilerGenerated]
	private bool n(TimeSpan A_0, double A_1)
	{
		if (!base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) && base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan)) < A_0)
		{
			c5x c5x = new ar7(new Guid("34399c25-dc98-49ec-877d-b6dbb35c6373"), this.Subject.a8().Area).ao() as c5x;
			if (c5x != null)
			{
				b0e b0e = c5x.GetAspect<bim>() as b0e;
				if (b0e != null && !b0e.q())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
	[CompilerGenerated]
	private cst m(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		c5x c5x = new ar7(new Guid("34399c25-dc98-49ec-877d-b6dbb35c6373"), this.Subject.a8().Area).ao() as c5x;
		if (c5x != null && c5x.s.b != null)
		{
			return aspect.b(c5x, c5x.s.b.t(), 1, false, null);
		}
		return null;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x0008F040 File Offset: 0x0008D240
	[CompilerGenerated]
	private bool l(TimeSpan A_0, double A_1)
	{
		return !base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) && base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan)) < A_0 && this.a(this.Subject.a8().Area) != null;
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x0008F0A0 File Offset: 0x0008D2A0
	[CompilerGenerated]
	private cst k(TimeSpan A_0, double A_1)
	{
		ale aspect = this.Subject.a8().GetAspect<ale>();
		c5x c5x = this.a(this.Subject.a8().Area);
		if (c5x != null && c5x.s.b != null)
		{
			c4f c4f = new c4f();
			c4f.Properties[d07.a] = true;
			awx awx = aspect.b(c5x, c5x.s.b.t(), 1, false, null);
			awx.ad().Add(new a4s(c4f, null, null, null));
			return awx;
		}
		return null;
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x0008F138 File Offset: 0x0008D338
	[CompilerGenerated]
	private bool j(TimeSpan A_0, double A_1)
	{
		if (!base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) && base.GetGlobalProperty<bool>(d07.a, false))
		{
			TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.c, default(TimeSpan));
			TimeSpan cortexProperty2 = base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan));
			if (cortexProperty < A_0 && cortexProperty2 < A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x0008F1B0 File Offset: 0x0008D3B0
	[CompilerGenerated]
	private ej1 i(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d07.b] = A_0 + TimeSpan.FromMinutes(3.0);
		this.Subject.y6()[d07.c] = A_0 + TimeSpan.FromMinutes(4.0);
		return ej1.b;
	}

	// Token: 0x06001A7E RID: 6782 RVA: 0x0008F21C File Offset: 0x0008D41C
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.c, default(TimeSpan));
		TimeSpan cortexProperty2 = base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan));
		if (base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) || (cortexProperty > A_0 && cortexProperty2 < A_0))
		{
			List<string> list = this.Subject.y6()[ddq.k] as List<string>;
			if (list != null && list.Count > 0 && !list[0].StartsWith("p"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A7F RID: 6783 RVA: 0x0008F2C8 File Offset: 0x0008D4C8
	[CompilerGenerated]
	private ej1 g(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[ddq.k] = new List<string>
		{
			"p1",
			"p2",
			"p3",
			"p4",
			"p5",
			"p6",
			"p7",
			"p8",
			"p9"
		};
		return ej1.b;
	}

	// Token: 0x06001A80 RID: 6784 RVA: 0x0008F354 File Offset: 0x0008D554
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan));
		if (!base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) && cortexProperty > A_0)
		{
			List<string> list = this.Subject.y6()[ddq.k] as List<string>;
			if (list != null && list.Count > 0 && !list[0].StartsWith("r"))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A81 RID: 6785 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
	[CompilerGenerated]
	private ej1 e(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[ddq.k] = new List<string>
		{
			"r1",
			"r2",
			"r3"
		};
		return ej1.b;
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0008F42C File Offset: 0x0008D62C
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan));
		return base.GetGlobalProperty<bool>(bp5.f("fo_bunker"), false) && cortexProperty > A_0;
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x0008F474 File Offset: 0x0008D674
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		this.Subject.y6().RemoveProperty(d07.b);
		return ej1.b;
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x0008F490 File Offset: 0x0008D690
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk == null || !blk.b())
			{
				TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.d, default(TimeSpan));
				if (base.GetGlobalProperty<bool>(d07.a, false) && cortexProperty <= A_0)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x0008F558 File Offset: 0x0008D758
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[d07.d] = A_0 + TimeSpan.FromSeconds(20.0);
		object obj = this.Subject.y6()[ddq.k];
		TimeSpan cortexProperty = base.GetCortexProperty<TimeSpan>(d07.b, default(TimeSpan));
		int num = base.GetCortexProperty<int>(d07.e, 0);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			string[] array;
			if (cortexProperty != TimeSpan.Zero)
			{
				array = new string[]
				{
					"Где ты?!",
					"Выходи, жалкий трус. Я только немного тебя порежу!",
					"Тебя ждёт угощение, дай только я найду тебя!",
					"Чтоб тебя, где ты прячешься?"
				};
			}
			else
			{
				array = new string[]
				{
					c5x.y8() + ", выходи играть!",
					"Я иду искать!",
					"Больно не будет. Я просто тебе череп проломлю. ::Маниакально смеётся.::",
					"К ноге, мальчик!"
				};
			}
			this.a(this.Subject.a8(), array[num]);
		}
		if (++num > 3)
		{
			num = 0;
		}
		this.Subject.y6()[d07.e] = num;
		return ej1.b;
	}

	// Token: 0x04000ED3 RID: 3795
	private new static readonly string a = "fo_evelyn_turnedOnPower";

	// Token: 0x04000ED4 RID: 3796
	private new static readonly string b = "PowerSearchPhaseLastsUntil";

	// Token: 0x04000ED5 RID: 3797
	private new static readonly string c = "PowerSearchPhaseCooldownUntil";

	// Token: 0x04000ED6 RID: 3798
	private static readonly string d = "NextTauntTime";

	// Token: 0x04000ED7 RID: 3799
	private static readonly string e = "TauntIndex";

	// Token: 0x020003DE RID: 990
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x0008F6E0 File Offset: 0x0008D8E0
		internal float c(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0008F6E8 File Offset: 0x0008D8E8
		internal float d(bool A_0)
		{
			return 101f;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0008F6F0 File Offset: 0x0008D8F0
		internal float f(bool A_0)
		{
			return 102f;
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0008F6F8 File Offset: 0x0008D8F8
		internal float e(bool A_0)
		{
			return 102f;
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0008F700 File Offset: 0x0008D900
		internal float b(bool A_0)
		{
			return 103f;
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0008F708 File Offset: 0x0008D908
		internal float g(bool A_0)
		{
			return 103f;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0008F710 File Offset: 0x0008D910
		internal float a(bool A_0)
		{
			return 103f;
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0008F718 File Offset: 0x0008D918
		internal bool a(b0b A_0)
		{
			return A_0.y8() == "Рубильник";
		}

		// Token: 0x04000ED8 RID: 3800
		public static readonly d07.a a = new d07.a();

		// Token: 0x04000ED9 RID: 3801
		public static Func<bool, float> b;

		// Token: 0x04000EDA RID: 3802
		public static Func<bool, float> c;

		// Token: 0x04000EDB RID: 3803
		public static Func<bool, float> d;

		// Token: 0x04000EDC RID: 3804
		public static Func<bool, float> e;

		// Token: 0x04000EDD RID: 3805
		public static Func<bool, float> f;

		// Token: 0x04000EDE RID: 3806
		public static Func<bool, float> g;

		// Token: 0x04000EDF RID: 3807
		public static Func<bool, float> h;

		// Token: 0x04000EE0 RID: 3808
		public static Func<b0b, bool> i;
	}
}
