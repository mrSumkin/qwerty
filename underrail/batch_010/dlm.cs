using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D7C RID: 3452
[e79("Xpbl_DudeOpenLabDoor")]
public sealed class dlm : dgy
{
	// Token: 0x06004B22 RID: 19234 RVA: 0x00205C84 File Offset: 0x00203E84
	public dlm()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			dlm.c c = new dlm.c();
			c.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (c.a != null)
			{
				c.b = c.a.Area;
				if (c.b != null)
				{
					c.c = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), c.a.Area).ao() as c5x);
					c5x c5x = new ar7(new Guid("8eef2622-e916-4703-83d9-9c3fbfbe0cde"), c.a.Area).ao() as c5x;
					c.d = (new ar7(new Guid("2ec5d90e-2de0-4e77-8042-c8f8ca66ae40"), c.a.Area).ao() as c5x);
					c.d.GetAspect<d2b>();
					c5x.GetAspect<d2b>();
					if (c.c != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.d), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array = new btm[1];
						int num = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.OperateShort);
						bb.a(atp.a);
						bb.IsAsync = false;
						bb.a(new ar7(c.c));
						bb.b(1);
						array[num] = bb;
						base.a(array);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.c), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(c.c));
						s.a(new bt4("dude_door"));
						s.IsAsync = true;
						s.a(true);
						array2[num2] = s;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(c.a));
						s2.a(new bt4("player_labDoorStraight"));
						s2.IsAsync = true;
						s2.a(true);
						array3[num3] = s2;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						if (c5x != null)
						{
							dlm.b b = new dlm.b();
							b.a = (c5x.GetAspect<bim>() as cnb);
							if (b.a != null)
							{
								btm[] array4 = new btm[1];
								int num4 = 0;
								bb8 bb2 = new bb8();
								bb2.a(CharacterState.OperateShort);
								bb2.a(atp.a);
								bb2.IsAsync = false;
								bb2.a(new ar7(c.c));
								bb2.b(1);
								array4[num4] = bb2;
								base.a(array4);
								base.a(new btm[]
								{
									new dva(null, new Func<e6d, bool>(b.a), null, null, null)
								});
								btm[] array5 = new btm[1];
								int num5 = 0;
								dva dva = new dva(null, null, null, null, null);
								dva.a(new Func<e6d, bool>(dlm.d.a.a));
								array5[num5] = dva;
								base.a(array5);
							}
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						if (c5x != null)
						{
							dlm.a a = new dlm.a();
							a.a = (c5x.GetAspect<bim>() as cnb);
							if (a.a != null)
							{
								btm[] array6 = new btm[1];
								int num6 = 0;
								bb8 bb3 = new bb8();
								bb3.a(CharacterState.OperateShort);
								bb3.a(atp.a);
								bb3.IsAsync = false;
								bb3.a(new ar7(c.c));
								bb3.b(1);
								array6[num6] = bb3;
								base.a(array6);
								base.a(new btm[]
								{
									new dva(null, new Func<e6d, bool>(a.a), null, null, null)
								});
								btm[] array7 = new btm[1];
								int num7 = 0;
								dva dva2 = new dva(null, null, null, null, null);
								dva2.a(new Func<e6d, bool>(dlm.d.a.b));
								array7[num7] = dva2;
								base.a(array7);
							}
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(c.c));
						s3.a(new bt4("dude_lockFacingAt"));
						s3.IsAsync = true;
						s3.a(true);
						array8[num8] = s3;
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						btm[] array9 = new btm[1];
						int num9 = 0;
						bb8 bb4 = new bb8();
						bb4.a(CharacterState.OperateShort);
						bb4.a(atp.a);
						bb4.IsAsync = false;
						bb4.a(new ar7(c.c));
						bb4.b(1);
						array9[num9] = bb4;
						base.a(array9);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.a), null, null, null)
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

	// Token: 0x02000D7D RID: 3453
	[CompilerGenerated]
	[Serializable]
	private new sealed class d
	{
		// Token: 0x06004B25 RID: 19237 RVA: 0x00206264 File Offset: 0x00204464
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00206288 File Offset: 0x00204488
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001E1E RID: 7710
		public static readonly dlm.d a = new dlm.d();

		// Token: 0x04001E1F RID: 7711
		public static Func<e6d, bool> b;

		// Token: 0x04001E20 RID: 7712
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000D7E RID: 3454
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004B28 RID: 19240 RVA: 0x002062B4 File Offset: 0x002044B4
		internal bool d(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x002062C4 File Offset: 0x002044C4
		internal bool c(e6d A_0)
		{
			if (this.d.p.b != null)
			{
				this.d.p.b.a[1].b.X = 1;
				this.d.c().a(Guid.NewGuid().ToString(), "StandingConsoleUse", 1f, c9z.a, false, false);
			}
			return true;
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00206340 File Offset: 0x00204540
		internal bool b(e6d A_0)
		{
			if (this.d.p.b != null)
			{
				this.d.p.b.a[1].b.X = 2;
				this.d.c().a(Guid.NewGuid().ToString(), "StandingConsoleUse", 1f, c9z.a, false, false);
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.b.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.t.b != null && c5x.h.b != null && c5x.h.b.aa().FactionId == asp.@as)
				{
					c5x.t.b.b("neutralAnimal");
				}
			}
			return true;
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00206470 File Offset: 0x00204670
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E21 RID: 7713
		public c5x a;

		// Token: 0x04001E22 RID: 7714
		public aud b;

		// Token: 0x04001E23 RID: 7715
		public c5x c;

		// Token: 0x04001E24 RID: 7716
		public c5x d;
	}

	// Token: 0x02000D7F RID: 3455
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B2D RID: 19245 RVA: 0x002064A8 File Offset: 0x002046A8
		internal bool a(e6d A_0)
		{
			this.a.d(true);
			return true;
		}

		// Token: 0x04001E25 RID: 7717
		public cnb a;
	}

	// Token: 0x02000D80 RID: 3456
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B2F RID: 19247 RVA: 0x002064C0 File Offset: 0x002046C0
		internal bool a(e6d A_0)
		{
			this.a.d(false);
			return true;
		}

		// Token: 0x04001E26 RID: 7718
		public cnb a;
	}
}
