using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000D6E RID: 3438
[e79("Xpbl_Wumb2_Leave")]
public sealed class b07 : dgy
{
	// Token: 0x06004AF1 RID: 19185 RVA: 0x0020334C File Offset: 0x0020154C
	public b07()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b07.a a = new b07.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				b07.b b = new b07.b();
				b.b = a;
				b.a = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), b.b.a.Area).ao() as c5x);
				new ar7(new Guid("90592d76-9341-40d2-9d29-5e41b82fe3e6"), b.b.a.Area).ao();
				if (b.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(b.a));
					s.a(new bt4("dude_leave"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(b.b.a));
					s2.a(new bt4("player_leave"));
					s2.IsAsync = false;
					s2.a(true);
					array2[num2] = s2;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("Пора сваливать.");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D6F RID: 3439
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AF3 RID: 19187 RVA: 0x002035FC File Offset: 0x002017FC
		internal bool a(e6d A_0)
		{
			cwy a_ = new cwy(300000);
			this.a.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0020363C File Offset: 0x0020183C
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, new c2w("xpbl_lux_dh", "player_start"), 0, null);
			return true;
		}

		// Token: 0x04001E0D RID: 7693
		public c5x a;
	}

	// Token: 0x02000D70 RID: 3440
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AF6 RID: 19190 RVA: 0x00203678 File Offset: 0x00201878
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			this.b.a.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x04001E0E RID: 7694
		public c5x a;

		// Token: 0x04001E0F RID: 7695
		public b07.a b;
	}
}
