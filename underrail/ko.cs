using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000EF8 RID: 3832
[e79("Xphw_TripToNorthUnderrail1")]
public sealed class ko : dgy
{
	// Token: 0x06004E75 RID: 20085 RVA: 0x00231000 File Offset: 0x0022F200
	public ko()
	{
		ko.b b = new ko.b();
		base..ctor();
		b.a = this;
		b.b = bpo.GetServiceOrThrow<cnk>();
		if (b.b != null && b.b.aqu() != null)
		{
			ko.a a = new ko.a();
			a.b = b;
			a.a = (a.b.b.aqu().v().b() as c5x);
			if (a.a != null)
			{
				ko.c c = new ko.c();
				c.g = a;
				c.g.a.i.b.a(true, false);
				c.a = (new ar7(new Guid("8120ceb3-c07c-4992-aaaf-d2ded349c170"), c.g.a.Area).ao() as c5x);
				c.b = (new ar7(new Guid("c31eeaf5-65f9-4863-9dc2-8e35578ff9db"), c.g.a.Area).ao() as c5x);
				c.c = (new ar7(new Guid("859f2bdc-6252-4749-8e22-b66136d94fc1"), c.g.a.Area).ao() as c5x);
				c.d = (new ar7(new Guid("1cb39d22-9ae4-4c34-a52b-579155b4756b"), c.g.a.Area).ao() as c5x);
				c.e = (new ar7(new Guid("3cc21abd-8fb0-426e-8fbc-a32d36bbd5e8"), c.g.a.Area).ao() as c5x);
				c.f = (new ar7(new Guid("88e61977-9277-4527-b280-89446fbab7b6"), c.g.b.b.aqw().n("xphw_up_railcar")).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.d), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("xphw_up_railcar", new Vector3(2f, 7f, 0f)));
				kw.IsAsync = false;
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Мы покидаем Верхнюю Подземку, господин Бак.");
				array4[num4] = new ace(egx)
				{
					TargetRef = new ar7(c.c)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Custom2);
				bb.a(atp.a);
				bb.IsAsync = false;
				bb.a(new ar7(c.d));
				bb.b(1);
				array5[num5] = bb;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx2 = new egx();
				egx2.a("Мы подходим... сейчас посмотрю по карте... Да, мы подходим к станции отдыха \"Гипноз\".");
				array6[num6] = new ace(egx2)
				{
					TargetRef = new ar7(c.c)
				};
				base.a(array6);
				btm[] array7 = new btm[1];
				int num7 = 0;
				bb8 bb2 = new bb8();
				bb2.a(CharacterState.Operating);
				bb2.a(atp.a);
				bb2.IsAsync = false;
				bb2.a(new ar7(c.c));
				bb2.b(3);
				array7[num7] = bb2;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				if (c.g.a.h.b.aa().Gender == Gender.Female)
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx3 = new egx();
					egx3.a("Добро пожаловать на тёмную территорию. Чем дольше мы придерживаемся главной линии, тем лучше. ");
					array8[num8] = new ace(egx3)
					{
						TargetRef = new ar7(c.a)
					};
					base.a(array8);
				}
				else
				{
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx4 = new egx();
					egx4.a("Что ж, господа, добро пожаловать на тёмную территорию. Чем дольше мы придерживаемся главной линии, тем лучше. ");
					array9[num9] = new ace(egx4)
					{
						TargetRef = new ar7(c.a)
					};
					base.a(array9);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.g), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.f), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				egx egx5 = new egx();
				egx5.a("Теперь пути назад нет.");
				array10[num10] = new ace(egx5)
				{
					TargetRef = new ar7(c.a)
				};
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.5))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				bb8 bb3 = new bb8();
				bb3.a(CharacterState.Custom2);
				bb3.a(atp.a);
				bb3.IsAsync = false;
				bb3.a(new ar7(c.d));
				bb3.b(1);
				array11[num11] = bb3;
				base.a(array11);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.g.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array12 = new btm[1];
				int num12 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array12[num12] = dky2;
				base.a(array12);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.e), null, null, null)
				});
				base.a(new btm[]
				{
					new di4(new c2w("xphw_darkTer2", "player_railcarStop"), false, new bool?(false), 0, null, false, false, true)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.g.b.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				c8s c8s2 = new c8s();
				c8s2.a(0.2f);
				c8s2.IsAsync = false;
				array13[num13] = c8s2;
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(c.g.b), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x06004E76 RID: 20086 RVA: 0x00231904 File Offset: 0x0022FB04
	private c5x a(Guid A_0)
	{
		return new ar7(A_0, new Guid("13d96d3b-f5e6-4753-bbe8-a4736657ad01"), new Guid("3c576103-bda0-4fec-9032-d5457e47f383"), bl1.a).ao() as c5x;
	}

	// Token: 0x02000EF9 RID: 3833
	[CompilerGenerated]
	[Serializable]
	private new sealed class d
	{
		// Token: 0x06004E79 RID: 20089 RVA: 0x00231944 File Offset: 0x0022FB44
		internal bool a(ya A_0)
		{
			return A_0.Name == "RailcarVisibility";
		}

		// Token: 0x04002005 RID: 8197
		public static readonly ko.d a = new ko.d();

		// Token: 0x04002006 RID: 8198
		public static Func<ya, bool> b;
	}

	// Token: 0x02000EFA RID: 3834
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004E7B RID: 20091 RVA: 0x00231964 File Offset: 0x0022FB64
		internal bool a(e6d A_0)
		{
			d60 addon = this.b.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"underRailcar"
				}))
				{
					((c5x)b0b).ae = new float?(0f);
				}
			}
			doq a_ = doq.a(Path.Combine(d5x.q(), "xphw_darkTer2_l" + 2.ToString()) + ".uzl");
			this.b.aqw().a(a_, 1, null);
			ld.a(this.b.aqw(), "railcar_itemTransfer", true);
			return true;
		}

		// Token: 0x04002007 RID: 8199
		public ko a;

		// Token: 0x04002008 RID: 8200
		public cnk b;
	}

	// Token: 0x02000EFB RID: 3835
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E7D RID: 20093 RVA: 0x00231A50 File Offset: 0x0022FC50
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00231A60 File Offset: 0x0022FC60
		internal bool b(e6d A_0)
		{
			this.b.a.a(this.a.qe()).GetAspect<j7>().a(this.b.a.a(new Guid("8120ceb3-c07c-4992-aaaf-d2ded349c170")).GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04002009 RID: 8201
		public c5x a;

		// Token: 0x0400200A RID: 8202
		public ko.b b;
	}

	// Token: 0x02000EFC RID: 3836
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004E80 RID: 20096 RVA: 0x00231AC4 File Offset: 0x0022FCC4
		internal bool d(e6d A_0)
		{
			a0l.a(this.g.a, "player_railcar", true);
			a0l.a(this.a, "nimble_railcar", true);
			a0l.a(this.b, "torrence_railcar", true);
			a0l.a(this.c, "wilkos_railcar", true);
			a0l.a(this.d, "gunslinger_railcar", true);
			a0l.a(this.e, "spanner_railcar", true);
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			if (this.d.h.b.aa().StatusEffects.a(c9i.a))
			{
				this.d.h.b.aa().StatusEffects.d(Enumerable.FirstOrDefault<c9i>(this.d.h.b.aa().StatusEffects.Get<c9i>()));
			}
			d60 addon = this.g.b.b.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"tracks"
				}))
				{
					c5x c5x = (c5x)b0b;
					bpu bpu = new bpu(c5x);
					bpu.a(1.2f);
					bpu.b(1.2f);
					c5x.SetAspect<bpu>(bpu);
					mj mj = new mj(c5x, bpu);
					c5x.SetAspect<mj>(mj);
					dtb dtb = new dtb("tracks");
					dtb.ad().Add(new bpr(mj, new Vector3(c5x.Location.X, c5x.Location.Y + 1f, c5x.Location.Z)));
					dtb.ad().Add(new a8v(c5x, new Vector3(c5x.Location.X, c5x.Location.Y, c5x.Location.Z)));
					this.g.a.Zone.ActionManager.g9(dtb, atp.b);
				}
			}
			if (this.f != null)
			{
				this.f.v.b.a("railcar", "TrainInteriorLoop", 0.9f, c9z.b, true, false);
			}
			dvn dvn = new dvn(this.g.b.b.aqw().y8(), "UpperUnderrail");
			dvn.a(new float?(0f));
			dvn.ym(null, null, null);
			ld.b(this.g.b.b.aqw(), "railcar_itemTransfer", false);
			return true;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00231DA4 File Offset: 0x0022FFA4
		internal bool c(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x00231DB4 File Offset: 0x0022FFB4
		internal bool b(e6d A_0)
		{
			this.e.VisualDirection = HorizontalDirection.Southeast;
			return true;
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x00231DC4 File Offset: 0x0022FFC4
		internal bool a(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x00231DD4 File Offset: 0x0022FFD4
		internal bool g(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x00231DE4 File Offset: 0x0022FFE4
		internal bool f(e6d A_0)
		{
			this.e.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x00231DF4 File Offset: 0x0022FFF4
		internal bool e(e6d A_0)
		{
			d60 addon = this.g.b.b.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"railcarParts"
				}))
				{
					c5x c5x = (c5x)b0b;
					c5x.w();
					c5x.an();
				}
			}
			a7c a7c = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(this.g.a.Area.Triggers, new Func<ya, bool>(ko.d.a.a))) as a7c;
			if (a7c != null)
			{
				a7c.o();
			}
			foreach (e36 e in Enumerable.ToList<e36>(this.g.a.Zone.ActionManager.g8()))
			{
				if (e.a is dtb && e.a.Name == "tracks")
				{
					(e.a as dtb).j();
				}
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			if (this.f != null)
			{
				this.f.v.b.a("railcar", true);
			}
			dvn dvn = new dvn(this.g.b.b.aqw().y8(), "UpperUnderrail");
			dvn.a(null);
			dvn.ym(null, null, null);
			return true;
		}

		// Token: 0x0400200B RID: 8203
		public c5x a;

		// Token: 0x0400200C RID: 8204
		public c5x b;

		// Token: 0x0400200D RID: 8205
		public c5x c;

		// Token: 0x0400200E RID: 8206
		public c5x d;

		// Token: 0x0400200F RID: 8207
		public c5x e;

		// Token: 0x04002010 RID: 8208
		public c5x f;

		// Token: 0x04002011 RID: 8209
		public ko.a g;
	}
}
