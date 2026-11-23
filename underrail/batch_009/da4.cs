using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D63 RID: 3427
[e79("Xpbl_WashDishesInRc")]
public sealed class da4 : dgy
{
	// Token: 0x06004ADD RID: 19165 RVA: 0x002025A8 File Offset: 0x002007A8
	public da4()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			da4.a a = new da4.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				da4.b b = new da4.b();
				b.b = a;
				b.a = (new ar7(new Guid("1c8023b0-3cf3-48cd-86b7-00dc38fd8090"), b.b.a.Area).ao() as c5x);
				b.b.a.h.b.aa().StatusEffects.a(new djn(720000, -3), false, false, false);
				if (b.a != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					dky dky = new dky();
					dky.a(0.2f);
					dky.a(false);
					array[num] = dky;
					base.a(array);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = true;
					bb.a(new ar7(b.b.a));
					bb.b(23);
					array2[num2] = bb;
					base.a(array2);
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					array3[num3] = c8s;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Мои руки болят от всей этой чистки. А ваше тушёное мясо прилипает к тарелкам, как смола!");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(b.b.a)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(10.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx2 = new egx();
					egx2.a("Должен был заплатить по счёту. Теперь успокойтесь! Ещё один раунд.");
					egx2.a(true);
					array5[num5] = new ace(egx2)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array5);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(5.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array6 = new btm[1];
					int num6 = 0;
					dky dky2 = new dky();
					dky2.a(0.2f);
					dky2.a(false);
					array6[num6] = dky2;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					c8s c8s2 = new c8s();
					c8s2.a(0.2f);
					c8s2.a(false);
					array7[num7] = c8s2;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D64 RID: 3428
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ADF RID: 19167 RVA: 0x00202998 File Offset: 0x00200B98
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_dishes", true);
			return true;
		}

		// Token: 0x04001E01 RID: 7681
		public c5x a;
	}

	// Token: 0x02000D65 RID: 3429
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AE1 RID: 19169 RVA: 0x002029B4 File Offset: 0x00200BB4
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x002029C4 File Offset: 0x00200BC4
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x002029D4 File Offset: 0x00200BD4
		internal bool a(e6d A_0)
		{
			this.b.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E02 RID: 7682
		public c5x a;

		// Token: 0x04001E03 RID: 7683
		public da4.a b;
	}
}
