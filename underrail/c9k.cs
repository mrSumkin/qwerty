using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003C9 RID: 969
[fe("shroomling")]
public sealed class c9k : ua
{
	// Token: 0x06001A39 RID: 6713 RVA: 0x0008D4C0 File Offset: 0x0008B6C0
	public c9k(bm6 A_0) : base("Shroomling", A_0)
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
		string a_ = "Sleeping";
		Func<TimeSpan, double, bool> a_2 = new Func<TimeSpan, double, bool>(this.d);
		Func<bool, float> a_3 = new Func<bool, float>(c9k.a.a.a);
		List<c96> list2 = new List<c96>();
		list2.Add(new byh("FallAsleep", new Func<TimeSpan, double, bool>(this.c), new Func<TimeSpan, double, cst>(this.b), new Func<bool, float>(c9k.a.a.b), null));
		list2.Add(new ceq("MoveToSleepLoc", new Func<TimeSpan, double, ak1>(this.a))
		{
			c = 1f,
			f = dnw.a,
			b = 3.0
		});
		list.Add(new ere(a_, a_2, a_3, list2));
		list.Add(new e1y("IdleMovement", new List<c96>
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
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0008D67C File Offset: 0x0008B87C
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		if (!base.h().aa().IsInCombat && this.Subject.y6().GetClassPropertyValue<bt4>("SleepLoc") != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == this.Subject.a8().Area && aw1.b(c5x, this.Subject.a8()) <= 9.0)
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x0008D734 File Offset: 0x0008B934
	[CompilerGenerated]
	private new bool c(TimeSpan A_0, double A_1)
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("SleepLoc");
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 value;
			classPropertyValue.a(this.Subject.a8().Zone, out aud, out value);
			return this.Subject.a8().Area == aud && this.Subject.a8().Location == value;
		}
		return false;
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x0008D7A8 File Offset: 0x0008B9A8
	[CompilerGenerated]
	private cst b(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().i != null)
		{
			string str;
			if (base.h().am() == bln.ev)
			{
				str = "ShroomlingSpitter-Static";
			}
			else
			{
				str = "ShroomlingChomper-Static";
			}
			c5x c5x = vq.a("object\\natural\\" + str, false);
			c5x.Layer = aju.x;
			c5x.Location = this.Subject.a8().Location;
			c5x.VisualDirection = this.Subject.a8().VisualDirection;
			awx awx = new awx();
			awx.a(awx.kh() | (m7.b | m7.k));
			awx.b(false);
			awx.c(false);
			awx.a(false);
			awx.ad().Add(new e4t(base.h(), CharacterState.Custom3, cux.a, 0, null, 1));
			awx.ad().Add(new a4s(new bk6(this.Subject.a8().Area, c5x), null, null, null));
			List<auv> list = awx.ad();
			c7 c = new c7(this.Subject.a8(), false, false, true, false);
			c.a(true);
			list.Add(c);
			return awx;
		}
		return null;
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0008D8E4 File Offset: 0x0008BAE4
	[CompilerGenerated]
	private ak1 a(TimeSpan A_0, double A_1)
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>("SleepLoc");
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 vector;
			classPropertyValue.a(this.Subject.a8().Zone, out aud, out vector);
			return aud.b((int)vector.X, (int)vector.Y);
		}
		return null;
	}

	// Token: 0x020003CA RID: 970
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x0008D954 File Offset: 0x0008BB54
		internal float a(bool A_0)
		{
			return 0.8f;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0008D95C File Offset: 0x0008BB5C
		internal float b(bool A_0)
		{
			return 2f;
		}

		// Token: 0x04000EBE RID: 3774
		public static readonly c9k.a a = new c9k.a();

		// Token: 0x04000EBF RID: 3775
		public static Func<bool, float> b;

		// Token: 0x04000EC0 RID: 3776
		public static Func<bool, float> c;
	}
}
