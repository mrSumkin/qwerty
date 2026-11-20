using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D1D RID: 3357
[e79("Cc_PlayerFallsInOldFacility")]
public sealed class dyc : dgy
{
	// Token: 0x06004A3A RID: 19002 RVA: 0x001F54B4 File Offset: 0x001F36B4
	public dyc()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dyc.b b = new dyc.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				dyc.a a = new dyc.a();
				a.d = b;
				serviceOrThrow.aqu().r()["npc_cc_vivian_playerFell"] = true;
				c5x c5x = new ar7(new Guid("b2a63066-90f3-4140-9eda-e36518cfc6e7"), a.d.a.Area).ao() as c5x;
				a.c = (new ar7(new Guid("91895482-c72e-4d44-8b27-81a01ec3c4c0"), a.d.a.Area).ao() as c5x);
				new ar7(new Guid("400f5cf3-319c-40d8-ac3d-95e1a9e056ba"), a.d.a.Area).ao();
				a.b = (new ar7(new Guid("ae9a9089-e9d6-4416-9b34-6ca5851683e3"), a.d.a.Area).ao() as c5x);
				a.a = (new ar7(new Guid("051dabae-4af1-4567-bf66-951609eab3c7"), a.d.a.Area).ao() as c5x);
				new Point(1, 0);
				if (c5x != null)
				{
					bim aspect = c5x.GetAspect<bim>();
					if (aspect != null)
					{
						aspect.g(false);
					}
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("cc_bcf0", new Vector3(3f, 4f, 0f)));
				kw.IsAsync = true;
				array[num] = kw;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				egx egx = new egx();
				egx.a("Кажется, он немного застрял. Может, если я...");
				array2[num2] = new ace(egx)
				{
					TargetRef = new ar7(a.d.a)
				};
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Operating);
				bb.a(atp.a);
				bb.IsAsync = true;
				bb.a(new ar7(a.d.a));
				bb.b(2);
				array3[num3] = bb;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx2 = new egx();
				egx2.a(serviceOrThrow.aqu().v().Name + "!");
				array4[num4] = new ace(egx2)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array5[num5] = dky;
				base.a(array5);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d.a), null, null, null)
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				c8s.a(false);
				array6[num6] = c8s;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				if (Enumerable.FirstOrDefault<coh>(a.d.a.h.b.aa().Bag.b("jkkCommDevice")) != null)
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("::Вы слышите голос, раздающийся из вашего рюкзака.:: Проклятье! " + serviceOrThrow.aqu().v().Name + ", вы меня слышите? Возьмите переговорное устройство!");
					array7[num7] = new ace(egx3)
					{
						TargetRef = new ar7(a.d.a)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D1E RID: 3358
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004A3C RID: 19004 RVA: 0x001F59BC File Offset: 0x001F3BBC
		internal bool a(e6d A_0)
		{
			a0l.a(this.a, "player_lands", true);
			this.a.ae = null;
			return true;
		}

		// Token: 0x04001D98 RID: 7576
		public c5x a;
	}

	// Token: 0x02000D1F RID: 3359
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A3E RID: 19006 RVA: 0x001F59F0 File Offset: 0x001F3BF0
		internal bool c(e6d A_0)
		{
			if (this.a != null)
			{
				boj.a(this.d.a.Area, new Vector3(1f, 2f, 0f), null, "Smoke", 1, double.MaxValue, null, null, null, null);
				this.d.a.ae = new float?(0f);
				this.a.ae = new float?(0f);
				this.a.TileFormationModifiers.s3(1);
				this.d.a.c().a("FallThroughGrate");
			}
			return true;
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x001F5ACC File Offset: 0x001F3CCC
		internal bool b(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		internal bool a(e6d A_0)
		{
			if (this.c != null)
			{
				new dvc().ym(null, this.c, null);
			}
			return true;
		}

		// Token: 0x04001D99 RID: 7577
		public c5x a;

		// Token: 0x04001D9A RID: 7578
		public c5x b;

		// Token: 0x04001D9B RID: 7579
		public c5x c;

		// Token: 0x04001D9C RID: 7580
		public dyc.b d;
	}
}
