using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200042C RID: 1068
[fe("wba_guard")]
public sealed class dt4 : b5g
{
	// Token: 0x06001BFE RID: 7166 RVA: 0x000984EC File Offset: 0x000966EC
	private string d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("l_wba1_moved", new bool?(false)).Value)
		{
			return "guardPos2";
		}
		return "guardPos1";
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x00098544 File Offset: 0x00096744
	public dt4(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		string a_2 = "Guarding";
		Func<bool> a_3 = new Func<bool>(this.c);
		Func<bool, float> a_4 = new Func<bool, float>(dt4.a.a.b);
		List<c96> list2 = new List<c96>();
		string a_5 = "TrekToRightWaypoint";
		Func<bool> a_6 = new Func<bool>(this.b);
		Func<bool, float> a_7 = new Func<bool, float>(dt4.a.a.d);
		List<c96> list3 = new List<c96>();
		list3.Add(new cm7("TrekToPos1Container", new Func<bool>(this.a), new Func<bool, float>(dt4.a.a.c), new List<c96>
		{
			new cnp("TrekToPos1")
			{
				a = new bt4("guardPos1"),
				b = double.MaxValue,
				d = 1500
			}
		}));
		list3.Add(new cnp("TrekToPos2")
		{
			a = new bt4("guardPos2"),
			c = 0.9f,
			b = double.MaxValue,
			d = 1500
		});
		list2.Add(new cm7(a_5, a_6, a_7, list3));
		list2.Add(new b64("FacePassage", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(dt4.a.a.a), null));
		list.Add(new cm7(a_2, a_3, a_4, list2));
		base.a(a_, list);
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00098704 File Offset: 0x00096904
	[CompilerGenerated]
	private new bool c()
	{
		return this.Subject.a8().h.b.aa().IsInControl;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x00098730 File Offset: 0x00096930
	[CompilerGenerated]
	private bool b()
	{
		return !aw1.a(this.Subject.a8(), new bt4(this.d()), false);
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x0009875C File Offset: 0x0009695C
	[CompilerGenerated]
	private bool a()
	{
		return this.d() == "guardPos1";
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00098770 File Offset: 0x00096970
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (A_0.Seconds % 7 != 0)
		{
			return false;
		}
		bt4 bt = new bt4(this.d());
		aud aud;
		Vector3 vector;
		HorizontalDirection horizontalDirection;
		bt.a(this.Subject.a8().Zone, out aud, out vector, out horizontalDirection);
		return aw1.a(this.Subject.a8(), bt, false) && horizontalDirection != this.Subject.a8().VisualDirection;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x000987E4 File Offset: 0x000969E4
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		aud aud;
		Vector3 vector;
		HorizontalDirection a_;
		new bt4(this.d()).a(this.Subject.a8().Zone, out aud, out vector, out a_);
		if (aud != null)
		{
			this.Subject.a8().VisualDirection = a_;
			return ej1.b;
		}
		return ej1.c;
	}

	// Token: 0x0200042D RID: 1069
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x00098848 File Offset: 0x00096A48
		internal float b(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00098850 File Offset: 0x00096A50
		internal float d(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00098858 File Offset: 0x00096A58
		internal float c(bool A_0)
		{
			return 1f;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00098860 File Offset: 0x00096A60
		internal float a(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x04000F88 RID: 3976
		public static readonly dt4.a a = new dt4.a();

		// Token: 0x04000F89 RID: 3977
		public static Func<bool, float> b;

		// Token: 0x04000F8A RID: 3978
		public static Func<bool, float> c;

		// Token: 0x04000F8B RID: 3979
		public static Func<bool, float> d;

		// Token: 0x04000F8C RID: 3980
		public static Func<bool, float> e;
	}
}
