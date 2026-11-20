using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000440 RID: 1088
[fe("cc_tchortistInvestigator")]
public sealed class a47 : b5g
{
	// Token: 0x06001C65 RID: 7269 RVA: 0x0009A93C File Offset: 0x00098B3C
	public a47(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new b64("Увеличение скорости бегства чортистов", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(a47.a.a.a), null));
		base.a(list);
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x0009A9A8 File Offset: 0x00098BA8
	private void a(c5x A_0)
	{
		List<string> list = new List<string>
		{
			"::Оглядывается через плечо.::",
			"::Набирает темп.::",
			"::Набрасывает капюшон.::"
		};
		string a_ = list[cuo.a.Next(0, list.Count)];
		if (A_0.u.b != null)
		{
			A_0.u.b.a(a_, true, null, null);
		}
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x0009AA3C File Offset: 0x00098C3C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().Zone.y8().Equals("cc_passage") && base.GetCortexProperty<TimeSpan>(a47.a, default(TimeSpan)) <= A_0;
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x0009AA90 File Offset: 0x00098C90
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				this.Subject.y6()[a47.a] = A_0 + TimeSpan.FromSeconds(3.0);
				if (aw1.b(this.Subject.a8(), c5x) < 5.0)
				{
					this.Subject.a8().h.b.aa().BaseMovementSpeed = MathHelper.Clamp(this.Subject.a8().h.b.aa().BaseMovementSpeed + 0.075f, 0f, 2f);
					this.Subject.a8().h.b.aa().MovementSpeed = MathHelper.Clamp(this.Subject.a8().h.b.aa().MovementSpeed + 0.075f, 0f, 2f);
					this.a(this.Subject.a8());
				}
			}
		}
		return ej1.b;
	}

	// Token: 0x04000FC0 RID: 4032
	private new static readonly string a = "NextSpeedupTime";

	// Token: 0x02000441 RID: 1089
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C6C RID: 7276 RVA: 0x0009ABE4 File Offset: 0x00098DE4
		internal float a(bool A_0)
		{
			return 1f;
		}

		// Token: 0x04000FC1 RID: 4033
		public static readonly a47.a a = new a47.a();

		// Token: 0x04000FC2 RID: 4034
		public static Func<bool, float> b;
	}
}
