using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D53 RID: 3411
[e79("Xpbl_Le_SeegerUnlocksElevator")]
public sealed class bed : dgy
{
	// Token: 0x06004AB3 RID: 19123 RVA: 0x001FFCAC File Offset: 0x001FDEAC
	public bed()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bed.a a = new bed.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				a.g = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), a.a.Area).ao() as c5x);
				a.f = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), a.a.Area).ao() as c5x);
				a.e = (new ar7(new Guid("34b8bf7c-45dc-45b5-a4a0-79fe5ee77c39"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("f613302e-99a5-451c-9172-b845bc211152"), a.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("773484b5-c07b-49c0-9ee8-5aea6a05e748"), a.a.Area).ao() as c5x);
				a.h = (new ar7(new Guid("256697bc-d119-47f8-b155-0c6ae47d5c36"), a.a.Area).ao() as c5x);
				a.d = (new ar7(new Guid("da763586-46d8-4ae2-be7e-2e0cb0078b20"), a.a.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				s5 s = new s5();
				s.a(new ar7(a.e));
				s.a(new bt4("seeger_unlock"));
				s.IsAsync = true;
				s.a(true);
				array[num] = s;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				egx egx = new egx();
				egx.a("Ладно. Давай попробуем...");
				array2[num2] = new ace(egx)
				{
					TargetRef = new ar7(a.e)
				};
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Operating);
				bb.a(atp.a);
				bb.IsAsync = true;
				bb.a(new ar7(a.e));
				bb.b(6);
				array3[num3] = bb;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx2 = new egx();
				egx2.a("Заработало!");
				array4[num4] = new ace(egx2)
				{
					TargetRef = new ar7(a.e)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx3 = new egx();
				egx3.a("Я захватил сигнал, который вы использовали, чтобы открыть ворота. Это сработало!");
				array5[num5] = new ace(egx3)
				{
					TargetRef = new ar7(a.e)
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(6.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx4 = new egx();
				egx4.a("Молодец, Сигер. Дальше мы сами.");
				array6[num6] = new ace(egx4)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				egx egx5 = new egx();
				egx5.a("Хорошо, команда: идём этаж за этажом. Доложиться по завершению.");
				array7[num7] = new ace(egx5)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(6.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				egx egx6 = new egx();
				egx6.a("Не спать.");
				array8[num8] = new ace(egx6)
				{
					TargetRef = new ar7(a.f)
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array9[num9] = dky;
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.a(false);
				array10[num10] = c8s;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				d92 d = new d92();
				d.a("events\\xpbl\\le_openingFort");
				d.b(new ar7(a.g));
				d.a(new ar7(a.a));
				array11[num11] = d;
				base.a(array11);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D54 RID: 3412
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AB5 RID: 19125 RVA: 0x00200334 File Offset: 0x001FE534
		internal bool d(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.Northwest;
			this.c.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00200350 File Offset: 0x001FE550
		internal bool c(e6d A_0)
		{
			if (this.d.p.b != null)
			{
				this.d.p.b.a[1].b.X = 1;
			}
			return true;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x00200390 File Offset: 0x001FE590
		internal bool b(e6d A_0)
		{
			this.e.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x002003A0 File Offset: 0x001FE5A0
		internal bool a(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.Southwest;
			this.c.VisualDirection = HorizontalDirection.West;
			this.f.VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x002003C8 File Offset: 0x001FE5C8
		internal bool e(e6d A_0)
		{
			a0l.a(this.a, "DownElevator", true);
			a0l.a(this.f, "global:xpbl_briggs:bar", true);
			a0l.a(this.g, "global:xpbl_oldfield:bar", true);
			a0l.a(this.e, "global:xpbl_seeger:bar", true);
			a0l.a(this.c, "global:xpbl_aegis_guard1:bar", true);
			a0l.a(this.b, "global:xpbl_aegis_guard2:bar", true);
			a0l.a(this.h, "global:xpbl_aegis_guard3:bar", true);
			return true;
		}

		// Token: 0x04001DE1 RID: 7649
		public c5x a;

		// Token: 0x04001DE2 RID: 7650
		public c5x b;

		// Token: 0x04001DE3 RID: 7651
		public c5x c;

		// Token: 0x04001DE4 RID: 7652
		public c5x d;

		// Token: 0x04001DE5 RID: 7653
		public c5x e;

		// Token: 0x04001DE6 RID: 7654
		public c5x f;

		// Token: 0x04001DE7 RID: 7655
		public c5x g;

		// Token: 0x04001DE8 RID: 7656
		public c5x h;
	}
}
