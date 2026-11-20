using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000388 RID: 904
[fe("cat")]
public sealed class e8w : ua
{
	// Token: 0x06001915 RID: 6421 RVA: 0x0008334C File Offset: 0x0008154C
	public e8w(bm6 A_0) : base("cat", A_0)
	{
		List<c96> list = new List<c96>();
		List<c96> list2 = list;
		string a_ = "CombatNearEnemies";
		List<c96> list3 = new List<c96>();
		list3.Add(new b64("InstantStandUp", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, ej1>(this.g), new Func<bool, float>(e8w.a.a.b), null));
		list3.Add(new e8n("FocusPrimaryTarget", new List<c96>
		{
			new cta("AutoAttackCurrentTarget"),
			new rv("GiveUpOnTarget", 180, 300000)
		}));
		list3.Add(new chi("ChangeTargetActivity"));
		list2.Add(new efs(a_, list3));
		List<c96> list4 = list;
		string a_2 = "Standing";
		Func<TimeSpan, double, bool> a_3 = new Func<TimeSpan, double, bool>(this.f);
		Func<bool, float> a_4 = new Func<bool, float>(e8w.a.a.e);
		c96[] array = new c96[2];
		array[0] = new e1y("IdleMovement", new List<c96>
		{
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 5,
				c = 3
			},
			new aif("RestActivity")
		})
		{
			c = 0.75f
		};
		array[1] = new byh("Sit-or-Meow", new Func<TimeSpan, double, bool>(this.e), new Func<TimeSpan, double, cst>(this.d), new Func<bool, float>(e8w.a.a.d), null)
		{
			f = false
		};
		list4.Add(new ere(a_2, a_3, a_4, array));
		List<c96> list5 = list;
		string a_5 = "Sitting";
		Func<TimeSpan, double, bool> a_6 = new Func<TimeSpan, double, bool>(this.c);
		Func<bool, float> a_7 = new Func<bool, float>(e8w.a.a.c);
		c96[] array2 = new c96[1];
		array2[0] = new byh("Stand-or-Scratch", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(e8w.a.a.a), null)
		{
			f = false
		};
		list5.Add(new ere(a_5, a_6, a_7, array2));
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x000835B0 File Offset: 0x000817B0
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().h.b.ap.GetValueOrDefault() == CharacterState.Custom3;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x000835D8 File Offset: 0x000817D8
	[CompilerGenerated]
	private ej1 g(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.ap = null;
		this.Subject.a8().h.b.aq = null;
		return ej1.b;
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00083628 File Offset: 0x00081828
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("CatState") != "sit";
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x0008364C File Offset: 0x0008184C
	[CompilerGenerated]
	private bool e(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextCatStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextCatStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x000836D0 File Offset: 0x000818D0
	[CompilerGenerated]
	private cst d(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextCatStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		if (cuo.a.NextDouble() < 0.3)
		{
			if (cuo.a.NextDouble() < 0.5)
			{
				List<auv> list = awx.ad();
				bfq bfq = new bfq("meowing", "CatMeow" + cuo.a.Next(1, 4).ToString());
				bfq.a(0.5f);
				list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
			}
			else
			{
				awx.ad().Add(new a4s(new bfq("purr", "CatPurr"), null, new ar7(this.Subject.a8()), null));
			}
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom1, 150, 0, null, 1));
		}
		else
		{
			this.Subject.y6()["CatState"] = "sit";
			this.Subject.a8().h.b.ap = new CharacterState?(CharacterState.Custom3);
			this.Subject.a8().h.b.aq = new int?(5);
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom3, 100, 0, null, 1));
		}
		return awx;
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x000838AC File Offset: 0x00081AAC
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("CatState") == "sit";
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x000838D0 File Offset: 0x00081AD0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("CatForceStand", new bool?(false)).Value)
		{
			return true;
		}
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextCatStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextCatStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x0008397C File Offset: 0x00081B7C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextCatStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | m7.b);
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>("CatForceStand", new bool?(false)).Value && cuo.a.NextDouble() < 0.7)
		{
			if (cuo.a.NextDouble() < 0.5)
			{
				List<auv> list = awx.ad();
				bfq bfq = new bfq("meowing", "CatMeow" + cuo.a.Next(1, 4).ToString());
				bfq.a(0.5f);
				list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
			}
			else
			{
				awx.ad().Add(new a4s(new bfq("purr", "CatPurr"), null, new ar7(this.Subject.a8()), null));
			}
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, 100, 0, null, 1));
		}
		else
		{
			this.Subject.y6()["CatState"] = "stand";
			this.Subject.y6()["InheritNextIdleMoveTime"] = true;
			this.Subject.y6()["NextIdleMoveTime"] = A_0;
			this.Subject.a8().h.b.ap = null;
			this.Subject.a8().h.b.aq = null;
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom4, 100, 0, null, 1));
		}
		this.Subject.y6()["CatForceStand"] = null;
		return awx;
	}

	// Token: 0x02000389 RID: 905
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001920 RID: 6432 RVA: 0x00083BDC File Offset: 0x00081DDC
		internal float b(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00083BE4 File Offset: 0x00081DE4
		internal float e(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00083BEC File Offset: 0x00081DEC
		internal float d(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00083C00 File Offset: 0x00081E00
		internal float c(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00083C08 File Offset: 0x00081E08
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x04000E6C RID: 3692
		public static readonly e8w.a a = new e8w.a();

		// Token: 0x04000E6D RID: 3693
		public static Func<bool, float> b;

		// Token: 0x04000E6E RID: 3694
		public static Func<bool, float> c;

		// Token: 0x04000E6F RID: 3695
		public static Func<bool, float> d;

		// Token: 0x04000E70 RID: 3696
		public static Func<bool, float> e;

		// Token: 0x04000E71 RID: 3697
		public static Func<bool, float> f;
	}
}
