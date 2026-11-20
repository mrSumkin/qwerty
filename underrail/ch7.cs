using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003B2 RID: 946
[fe("strider")]
public sealed class ch7 : ua
{
	// Token: 0x060019E3 RID: 6627 RVA: 0x0008AD74 File Offset: 0x00088F74
	public ch7(bm6 A_0) : base("StriderBehavior", A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new efs("CombatNearEnemies", new List<c96>
		{
			new e8n("FocusPrimaryTarget", new List<c96>
			{
				new cta("AutoAttackCurrentTarget"),
				new rv("GiveUpOnTarget", 180, 300000)
			}),
			new chi("ChangeTargetActivity")
		}));
		List<c96> list2 = list;
		string a_ = "Улей больше не встревожен";
		Func<TimeSpan, double, bool> a_2 = new Func<TimeSpan, double, bool>(this.c);
		Func<bool, float> a_3 = new Func<bool, float>(ch7.a.a.a);
		c96[] array = new c96[1];
		array[0] = new byh("Путешествие в улей", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(ch7.a.a.b), null);
		list2.Add(new ere(a_, a_2, a_3, array));
		list.Add(new e1y("IdleMovement", new List<c96>
		{
			new c1j("Chitter")
			{
				c = 1f,
				b = "xpbl_StriderChitter",
				d = new CharacterState?(CharacterState.Custom1),
				a = 15000,
				c = 3
			},
			new e7y("IdleMoveToTile")
			{
				c = 0.75f,
				b = 15,
				c = 4
			},
			new aif("RestActivity")
		})
		{
			c = 0.75f
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0008AF3C File Offset: 0x0008913C
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		ar7 classPropertyValue = this.Subject.y6().GetClassPropertyValue<ar7>("HomeHiveRef");
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			cya aspect = classPropertyValue.ao().GetAspect<cya>();
			if (aspect != null && !aspect.q())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0008AF90 File Offset: 0x00089190
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		ar7 classPropertyValue = this.Subject.y6().GetClassPropertyValue<ar7>("HomeHiveRef");
		return classPropertyValue != null && classPropertyValue.ao() != null;
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x0008AFC8 File Offset: 0x000891C8
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		ar7 classPropertyValue = this.Subject.y6().GetClassPropertyValue<ar7>("HomeHiveRef");
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			awx awx = new awx();
			awx.a(m7.b);
			awx.ad().Add(new fk(this.Subject.a8().GetAspect<ale>(), classPropertyValue.ao(), null, false, 0));
			awx.ad().Add(new a4s(new cdd(), new ar7(this.Subject.a8()), new ar7(classPropertyValue.ao()), null));
			return awx;
		}
		return null;
	}

	// Token: 0x020003B3 RID: 947
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060019E9 RID: 6633 RVA: 0x0008B078 File Offset: 0x00089278
		internal float a(bool A_0)
		{
			return 0.76f;
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0008B080 File Offset: 0x00089280
		internal float b(bool A_0)
		{
			return 1f;
		}

		// Token: 0x04000E9C RID: 3740
		public static readonly ch7.a a = new ch7.a();

		// Token: 0x04000E9D RID: 3741
		public static Func<bool, float> b;

		// Token: 0x04000E9E RID: 3742
		public static Func<bool, float> c;
	}
}
