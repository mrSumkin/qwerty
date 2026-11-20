using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x0200042E RID: 1070
[fe("gms_hacker")]
public sealed class be : b5g
{
	// Token: 0x06001C0B RID: 7179 RVA: 0x0009886C File Offset: 0x00096A6C
	public be(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		string a_2 = "Hacking";
		Func<bool> a_3 = new Func<bool>(this.b);
		Func<bool, float> a_4 = new Func<bool, float>(be.a.a.d);
		List<c96> list2 = new List<c96>();
		list2.Add(new cm7("TrekToRightWaypoint", new Func<bool>(this.a), new Func<bool, float>(be.a.a.b), new List<c96>
		{
			new cnp("Trek")
			{
				a = new bt4("lockedDoorHackingPoint"),
				b = double.MaxValue,
				d = 1500
			}
		}));
		list2.Add(new b64("FaceLock", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(be.a.a.a), null));
		list2.Add(new byh("OperateLock", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(be.a.a.c), null));
		list.Add(new cm7(a_2, a_3, a_4, list2));
		base.a(a_, list);
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x000989F0 File Offset: 0x00096BF0
	[CompilerGenerated]
	private bool b()
	{
		return this.Subject.a8().h.b.aa().IsInControl;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x00098A1C File Offset: 0x00096C1C
	[CompilerGenerated]
	private bool a()
	{
		return !aw1.a(this.Subject.a8(), new bt4("lockedDoorHackingPoint"), false);
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x00098A3C File Offset: 0x00096C3C
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		bt4 bt = new bt4("lockedDoorHackingPoint");
		aud aud;
		Vector3 vector;
		HorizontalDirection horizontalDirection;
		bt.a(this.Subject.a8().Zone, out aud, out vector, out horizontalDirection);
		return aw1.a(this.Subject.a8(), bt, false) && horizontalDirection != this.Subject.a8().VisualDirection;
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x00098AA0 File Offset: 0x00096CA0
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		aud aud;
		Vector3 vector;
		HorizontalDirection a_;
		new bt4("lockedDoorHackingPoint").a(this.Subject.a8().Zone, out aud, out vector, out a_);
		if (aud != null)
		{
			this.Subject.a8().VisualDirection = a_;
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x00098AEC File Offset: 0x00096CEC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return aw1.a(this.Subject.a8(), new bt4("lockedDoorHackingPoint"), false) && this.Subject.a8().h.b.aa().IsInControl;
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x00098B3C File Offset: 0x00096D3C
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		return new e4t(this.Subject.a8().h.b, CharacterState.Operating, cux.a, 0, null, 100);
	}

	// Token: 0x0200042F RID: 1071
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C14 RID: 7188 RVA: 0x00098B8C File Offset: 0x00096D8C
		internal float d(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00098B94 File Offset: 0x00096D94
		internal float b(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00098B9C File Offset: 0x00096D9C
		internal float a(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00098BA4 File Offset: 0x00096DA4
		internal float c(bool A_0)
		{
			return 0.7f;
		}

		// Token: 0x04000F8D RID: 3981
		public static readonly be.a a = new be.a();

		// Token: 0x04000F8E RID: 3982
		public static Func<bool, float> b;

		// Token: 0x04000F8F RID: 3983
		public static Func<bool, float> c;

		// Token: 0x04000F90 RID: 3984
		public static Func<bool, float> d;

		// Token: 0x04000F91 RID: 3985
		public static Func<bool, float> e;
	}
}
