using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000D86 RID: 3462
[e79("Xpbl_Cc_Dh_RemoveThePanel")]
public sealed class a21 : dgy
{
	// Token: 0x06004B3F RID: 19263 RVA: 0x0020721C File Offset: 0x0020541C
	public a21()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			a21.a a = new a21.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = a.a.GetAspect<amc>();
				a.c = a.b.aa().Gear.j()[WeaponKey.Primary].Item;
				a.d = a.b.aa().Gear.j()[WeaponKey.Secondary].Item;
				if (a.a.Area != null)
				{
					a21.b b = new a21.b();
					b.e = a;
					b.a = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), b.e.a.Area).ao() as c5x);
					b.b = (new ar7(new Guid("c90e5cb1-8a3b-4b8d-8694-87cc32ce58f2"), b.e.a.Area).ao() as c5x);
					b.d = (new ar7(new Guid("c6aff67c-ddc3-4525-b354-5e2ee45223cc"), b.e.a.Area).ao() as c5x);
					b.c = (new ar7(new Guid("bcdaaaa6-84f7-4621-b811-498b12a33953"), b.e.a.Area).ao() as c5x);
					ar7 a_ = new ar7(new Guid("12f48b5f-6f10-4b70-a824-700f192cb21b"), b.e.a.Area);
					if (b.a != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.3))
						});
						btm[] array = new btm[1];
						int num = 0;
						s5 s = new s5();
						s.a(new ar7(b.e.a));
						s.a(new bt4("player_panel"));
						s.IsAsync = true;
						s.a(true);
						array[num] = s;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.e.a), null, null, null)
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.ChannelPsi);
						bb.a(atp.a);
						bb.IsAsync = true;
						bb.a(new ar7(b.e.a));
						bb.b(3);
						array2[num2] = bb;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(b.a));
						s2.a(new bt4("global:rc_dude:panel"));
						s2.IsAsync = true;
						s2.a(true);
						array3[num3] = s2;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.c), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						egx egx = new egx();
						egx.a("Есть что-нибудь?");
						array4[num4] = new ace(egx)
						{
							TargetRef = new ar7(b.a)
						};
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						bb8 bb2 = new bb8();
						bb2.a(CharacterState.ChannelPsi);
						bb2.a(atp.a);
						bb2.IsAsync = false;
						bb2.a(new ar7(b.e.a));
						bb2.b(2);
						array5[num5] = bb2;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						egx egx2 = new egx();
						egx2.a("У тебя получится!");
						array6[num6] = new ace(egx2)
						{
							TargetRef = new ar7(b.a)
						};
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						bb8 bb3 = new bb8();
						bb3.a(CharacterState.Attack2);
						bb3.a(cux.m);
						bb3.a(atp.a);
						bb3.IsAsync = true;
						bb3.a(new ar7(b.e.a));
						bb3.b(1);
						array7[num7] = bb3;
						base.a(array7);
						btm[] array8 = new btm[1];
						int num8 = 0;
						bfq bfq = new bfq();
						bfq.c("BulletHitMetal");
						array8[num8] = new ace(bfq)
						{
							TargetRef = new ar7(b.e.a)
						};
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (b.b != null)
						{
							btm[] array9 = new btm[1];
							int num9 = 0;
							egx egx3 = new egx();
							egx3.a("Что вы двое там делаете?");
							array9[num9] = new ace(egx3)
							{
								TargetRef = new ar7(b.b)
							};
							base.a(array9);
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(0.3))
							});
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.b), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						bb8 bb4 = new bb8();
						bb4.a(CharacterState.Operating);
						bb4.a(atp.a);
						bb4.IsAsync = true;
						bb4.a(new ar7(b.e.a));
						bb4.b(3);
						array10[num10] = bb4;
						base.a(array10);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.5))
						});
						btm[] array11 = new btm[1];
						int num11 = 0;
						uk uk = new uk();
						uk.c(true);
						uk.b(true);
						array11[num11] = new ace(uk)
						{
							TargetRef = a_
						};
						base.a(array11);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.d), null, null, null)
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

	// Token: 0x02000D87 RID: 3463
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B41 RID: 19265 RVA: 0x00207948 File Offset: 0x00205B48
		internal bool a(e6d A_0)
		{
			if (!euf.o(this.b.aa().Offense.u()) && euf.o(this.b.aa().Offense.q()))
			{
				this.b.aa().Offense.k();
			}
			if (!euf.o(this.b.aa().Offense.u()))
			{
				this.b.aa().Gear.j()[WeaponKey.Primary].b(null);
				this.b.aa().Gear.j()[WeaponKey.Secondary].b(null);
			}
			return true;
		}

		// Token: 0x04001E2D RID: 7725
		public c5x a;

		// Token: 0x04001E2E RID: 7726
		public amc b;

		// Token: 0x04001E2F RID: 7727
		public cd1 c;

		// Token: 0x04001E30 RID: 7728
		public cd1 d;
	}

	// Token: 0x02000D88 RID: 3464
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B43 RID: 19267 RVA: 0x00207A14 File Offset: 0x00205C14
		internal bool c(e6d A_0)
		{
			this.a.t.b.y6().RemoveProperty(ddq.k);
			this.a.t.b.y6().RemoveProperty(ddq.n);
			this.a.t.b.y6().RemoveProperty(ddq.l);
			return true;
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x00207A84 File Offset: 0x00205C84
		internal bool b(e6d A_0)
		{
			this.b.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x00207A98 File Offset: 0x00205C98
		internal bool a(e6d A_0)
		{
			if (this.c != null)
			{
				a9g a9g = this.c.GetAspect<cd0>() as a9g;
				if (a9g != null)
				{
					a9g.d = new float?((float)1);
				}
			}
			return true;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x00207AD8 File Offset: 0x00205CD8
		internal bool d(e6d A_0)
		{
			this.e.b.aa().Gear.j()[WeaponKey.Primary].b(this.e.c);
			this.e.b.aa().Gear.j()[WeaponKey.Secondary].b(this.e.d);
			this.d.s.b.g(true);
			this.e.a.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E31 RID: 7729
		public c5x a;

		// Token: 0x04001E32 RID: 7730
		public c5x b;

		// Token: 0x04001E33 RID: 7731
		public c5x c;

		// Token: 0x04001E34 RID: 7732
		public c5x d;

		// Token: 0x04001E35 RID: 7733
		public a21.a e;
	}
}
