using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003BD RID: 957
[fe("smallCrab")]
public sealed class ape : ua
{
	// Token: 0x06001A08 RID: 6664 RVA: 0x0008BF64 File Offset: 0x0008A164
	public ape(bm6 A_0) : base("SmallCrabBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		List<c96> list2 = list;
		string a_ = "CombatNearEnemies";
		List<c96> list3 = new List<c96>();
		list3.Add(new b64("InstantStandUp", new Func<TimeSpan, double, bool>(this.h), new Func<TimeSpan, double, ej1>(this.g), new Func<bool, float>(ape.a.a.b), null));
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
		Func<bool, float> a_4 = new Func<bool, float>(ape.a.a.e);
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
		array[1] = new byh("Sit-or-Bark", new Func<TimeSpan, double, bool>(this.e), new Func<TimeSpan, double, cst>(this.d), new Func<bool, float>(ape.a.a.d), null)
		{
			f = false
		};
		list4.Add(new ere(a_2, a_3, a_4, array));
		List<c96> list5 = list;
		string a_5 = "Sitting";
		Func<TimeSpan, double, bool> a_6 = new Func<TimeSpan, double, bool>(this.c);
		Func<bool, float> a_7 = new Func<bool, float>(ape.a.a.c);
		c96[] array2 = new c96[1];
		array2[0] = new byh("Stand-or-Scratch", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(ape.a.a.a), null)
		{
			f = false
		};
		list5.Add(new ere(a_5, a_6, a_7, array2));
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x0008C1C8 File Offset: 0x0008A3C8
	[CompilerGenerated]
	private bool h(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().h.b.ap.GetValueOrDefault() == CharacterState.Custom2;
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x0008C1F0 File Offset: 0x0008A3F0
	[CompilerGenerated]
	private ej1 g(TimeSpan A_0, double A_1)
	{
		this.Subject.a8().h.b.ap = null;
		this.Subject.a8().h.b.aq = null;
		return ej1.b;
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x0008C240 File Offset: 0x0008A440
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("DogState") != "sit";
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x0008C264 File Offset: 0x0008A464
	[CompilerGenerated]
	private bool e(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextDogStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0008C2E8 File Offset: 0x0008A4E8
	[CompilerGenerated]
	private cst d(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		this.Subject.y6()["DogState"] = "sit";
		this.Subject.a8().h.b.ap = new CharacterState?(CharacterState.Custom1);
		this.Subject.a8().h.b.aq = new int?(8);
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom1, 100, 0, null, 1));
		return awx;
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x0008C3CC File Offset: 0x0008A5CC
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		return this.Subject.y6().GetClassPropertyValue<string>("DogState") == "sit";
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x0008C3F0 File Offset: 0x0008A5F0
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("DogForceStand", new bool?(false)).Value)
		{
			return true;
		}
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextDogStateChangeTime", null);
		if (primitivePropertyValue == null)
		{
			this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
			return false;
		}
		return primitivePropertyValue.Value <= A_0;
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x0008C49C File Offset: 0x0008A69C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()["NextDogStateChangeTime"] = A_0 + TimeSpan.FromSeconds((double)(4 + cuo.a.Next(5)));
		awx awx = new awx();
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>("DogForceStand", new bool?(false)).Value && cuo.a.NextDouble() < 0.7)
		{
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, 100, 0, null, 1));
		}
		else
		{
			this.Subject.y6()["DogState"] = "stand";
			this.Subject.y6()["InheritNextIdleMoveTime"] = true;
			this.Subject.y6()["NextIdleMoveTime"] = A_0;
			this.Subject.a8().h.b.ap = null;
			this.Subject.a8().h.b.aq = null;
			awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom3, 100, 0, null, 1));
		}
		this.Subject.y6()["DogForceStand"] = null;
		return awx;
	}

	// Token: 0x020003BE RID: 958
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A13 RID: 6675 RVA: 0x0008C64C File Offset: 0x0008A84C
		internal float b(bool A_0)
		{
			return 100f;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0008C654 File Offset: 0x0008A854
		internal float e(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0008C65C File Offset: 0x0008A85C
		internal float d(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0008C670 File Offset: 0x0008A870
		internal float c(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0008C678 File Offset: 0x0008A878
		internal float a(bool A_0)
		{
			if (!A_0)
			{
				return 1f;
			}
			return 100f;
		}

		// Token: 0x04000EAA RID: 3754
		public static readonly ape.a a = new ape.a();

		// Token: 0x04000EAB RID: 3755
		public static Func<bool, float> b;

		// Token: 0x04000EAC RID: 3756
		public static Func<bool, float> c;

		// Token: 0x04000EAD RID: 3757
		public static Func<bool, float> d;

		// Token: 0x04000EAE RID: 3758
		public static Func<bool, float> e;

		// Token: 0x04000EAF RID: 3759
		public static Func<bool, float> f;
	}
}
