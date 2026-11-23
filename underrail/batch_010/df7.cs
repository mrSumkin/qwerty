using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CED RID: 3309
[e79("Cc_ZamanShocksYa")]
public sealed class df7 : dgy
{
	// Token: 0x060049DA RID: 18906 RVA: 0x001EEEBC File Offset: 0x001ED0BC
	public df7()
	{
		df7.a a = new df7.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			df7.b b = new df7.b();
			b.a = (a.a.aqu().v().b() as c5x);
			b.b = (a.a.aqu().ac() as bv9);
			if (b.a != null)
			{
				df7.c c = new df7.c();
				c.a = b.a.Area;
				if (c.a != null)
				{
					df7.d d = new df7.d();
					d.a = (new ar7(new Guid("70bb3004-9b67-4010-994e-cd449188bab3"), b.a.Area).ao() as c5x);
					if (d.a != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						s5 s = new s5();
						s.a(new ar7(d.a));
						s.a(new bt4("zaman3"));
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
						egx.a("::Маниакально смеётся.::");
						array2[num2] = new ace(egx)
						{
							TargetRef = new ar7(d.a)
						};
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.Operating);
						bb.a(atp.a);
						bb.IsAsync = true;
						bb.a(new ar7(d.a));
						bb.b(4);
						array3[num3] = bb;
						base.a(array3);
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
							new os(TimeSpan.FromSeconds(0.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(d.a), null, null, null)
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						egx egx2 = new egx();
						egx2.a("Нет! НЕТ! Этого не должно было случиться, нет! Будь проклята эта проводка!");
						array4[num4] = new ace(egx2)
						{
							TargetRef = new ar7(d.a)
						};
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						egx egx3 = new egx();
						egx3.a("Проклятье! Никуда не уходи!");
						array5[num5] = new ace(egx3)
						{
							TargetRef = new ar7(d.a)
						};
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(d.a));
						s2.a(new bt4("zaman1"));
						s2.IsAsync = true;
						array6[num6] = s2;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.c), null, null, null)
						});
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000CEE RID: 3310
	[CompilerGenerated]
	[Serializable]
	private new sealed class e
	{
		// Token: 0x060049DD RID: 18909 RVA: 0x001EF378 File Offset: 0x001ED578
		internal bool a(c5x A_0)
		{
			return A_0.IsFloor && A_0.o.b != null && A_0.o.b.a == "Floor\\Grate-Gray";
		}

		// Token: 0x04001D51 RID: 7505
		public static readonly df7.e a = new df7.e();

		// Token: 0x04001D52 RID: 7506
		public static Func<c5x, bool> b;
	}

	// Token: 0x02000CEF RID: 3311
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049DF RID: 18911 RVA: 0x001EF3BC File Offset: 0x001ED5BC
		internal bool a(e6d A_0)
		{
			d60 addon = this.a.aqw().GetAddon<d60>();
			if (addon != null)
			{
				foreach (b0b b0b in addon.ab4(new string[]
				{
					"electrocutionEffect"
				}))
				{
					b0b.w();
					b0b.an();
				}
			}
			return true;
		}

		// Token: 0x04001D53 RID: 7507
		public cnk a;
	}

	// Token: 0x02000CF0 RID: 3312
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x060049E1 RID: 18913 RVA: 0x001EF448 File Offset: 0x001ED648
		internal bool b(e6d A_0)
		{
			boj.a(this.a, "Electricity", 100, 300.0, true, true, null, null, null, null, false);
			this.a.c().a(Guid.NewGuid().ToString(), "Tazer", 1f, c9z.a, false, false);
			this.a.h.b.aa().StatusEffects.a(new ab3(2000), false, false, false);
			this.a.h.b.u();
			return true;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x001EF50C File Offset: 0x001ED70C
		internal bool a(e6d A_0)
		{
			b6r b6r = new b6r();
			b6r.b(this.a.Area.y8());
			b6r.b(new Guid("20d2f1ba-7ce1-4a3f-8aea-f50632c55005"));
			b6r.a(new Guid("aced1835-23ac-4e66-9e1d-dd3920cabf48"));
			b6r.a(bbo.b);
			b6r.ym(this.a, null, null);
			return true;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x001EF56C File Offset: 0x001ED76C
		internal bool c(e6d A_0)
		{
			this.b.a(asp.du, asp.a, h.a, null, false, true, false);
			return true;
		}

		// Token: 0x04001D54 RID: 7508
		public c5x a;

		// Token: 0x04001D55 RID: 7509
		public bv9 b;
	}

	// Token: 0x02000CF1 RID: 3313
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x060049E5 RID: 18917 RVA: 0x001EF5AC File Offset: 0x001ED7AC
		internal bool a(e6d A_0)
		{
			for (int i = 10; i <= 14; i++)
			{
				for (int j = 16; j <= 24; j++)
				{
					if (Enumerable.Any<c5x>(Enumerable.OfType<c5x>(this.a.b(i, j).c.Values), new Func<c5x, bool>(df7.e.a.a)))
					{
						c5x c5x = vq.a("wall\\ElectricCreepWall", this.a.Zone, new bt4(this.a.y8(), new Vector3((float)i, (float)j, 0f)), false);
						if (c5x != null)
						{
							ah7 ah = this.a.Zone.i("Electricity");
							if (ah != null)
							{
								ah.g().be(c5x);
							}
							c5x.q("electrocutionEffect");
							c5x.IsGround = true;
							c5x.VisualPriority = 10;
							c5x.TileFormationModifiers.c();
							c5x.z();
							c5x.SetAspect<e3l>(new e3l(c5x)
							{
								a = 
								{
									"electrocutionEffect"
								}
							});
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001D56 RID: 7510
		public aud a;
	}

	// Token: 0x02000CF2 RID: 3314
	[CompilerGenerated]
	private new sealed class d
	{
		// Token: 0x060049E7 RID: 18919 RVA: 0x001EF6E4 File Offset: 0x001ED8E4
		internal bool a(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x04001D57 RID: 7511
		public c5x a;
	}
}
