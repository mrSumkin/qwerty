using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D5A RID: 3418
[e79("Xpbl_EnteringTheMorgue")]
public sealed class ejk : dgy
{
	// Token: 0x06004ACD RID: 19149 RVA: 0x002012CC File Offset: 0x001FF4CC
	public ejk()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ejk.a a = new ejk.a();
			serviceOrThrow.aqu().b(new c2d());
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				ejk.c c = new ejk.c();
				c.b = a;
				c.a = c.b.a.Area;
				if (c.a != null)
				{
					ejk.b b = new ejk.b();
					b.b = c;
					ar7 ar = new ar7(new Guid("72713052-02de-41b2-997f-3f8bb66675a1"), b.b.b.a.Area);
					c5x c5x = ar.ao() as c5x;
					b.a = new bzm();
					bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_mc_acceptedDeath", new bool?(false)).Value;
					bool value2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_mc_man_life", new bool?(false)).Value;
					bool value3 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_mc_man_between", new bool?(false)).Value;
					int value4 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_mc_visionCounter", new int?(0)).Value;
					int num = 0;
					num += value4 * 2;
					num += Math.Max(0, b.b.b.a.h.b.aa().BaseAbilities.a("Will").f() - 5);
					if (c5x != null)
					{
						serviceOrThrow.aqu().a(new bw0("xpbl_mc1", new b91(), 1));
						serviceOrThrow.aqu().a(new bw0("xpbl_mc2", new b91(), 1));
						serviceOrThrow.aqu().r()["loc_xpbl_mc_resolved"] = true;
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(b.b.b.a));
						s.a(new bt4("player_wait"));
						s.IsAsync = false;
						s.a(true);
						array[num2] = s;
						base.a(array);
						btm[] array2 = new btm[1];
						int num3 = 0;
						kw kw = new kw();
						kw.a(new bt4("xpbl_mc3", new Vector3(6f, 15f, 0f)));
						kw.IsAsync = true;
						array2[num3] = kw;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						if (value)
						{
							btm[] array3 = new btm[1];
							int num4 = 0;
							egx egx = new egx();
							egx.a("Подписывайтесь на меня. И смотрите.");
							array3[num4] = new ace(egx)
							{
								TargetRef = new ar7(c5x)
							};
							base.a(array3);
						}
						else
						{
							btm[] array4 = new btm[1];
							int num5 = 0;
							egx egx2 = new egx();
							egx2.a("Прощай. Желаю удачи в будущем.");
							array4[num5] = new ace(egx2)
							{
								TargetRef = new ar7(c5x)
							};
							base.a(array4);
						}
						btm[] array5 = new btm[1];
						int num6 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(c5x));
						s2.a(new bt4("man_enter"));
						s2.IsAsync = false;
						s2.a(true);
						array5[num6] = s2;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num7 = 0;
						uk uk = new uk();
						uk.c(true);
						uk.b(true);
						array6[num7] = new ace(uk)
						{
							TargetRef = ar
						};
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (value)
						{
							btm[] array7 = new btm[1];
							int num8 = 0;
							s5 s3 = new s5();
							s3.a(new ar7(b.b.b.a));
							s3.a(new bt4("player_enter"));
							s3.IsAsync = false;
							s3.a(true);
							array7[num8] = s3;
							base.a(array7);
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (value)
						{
							if (num < 8)
							{
								btm[] array8 = new btm[1];
								int num9 = 0;
								nb nb = new nb();
								nb.a(bvl.d);
								nb.a(true);
								array8[num9] = new ace(nb);
								base.a(array8);
							}
							else
							{
								btm[] array9 = new btm[1];
								int num10 = 0;
								dky dky = new dky();
								dky.a(0.2f);
								dky.a(false);
								array9[num10] = dky;
								base.a(array9);
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(0.5))
								});
								base.a(new btm[]
								{
									new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
								});
								base.a(new btm[]
								{
									new ace(new jp())
								});
								base.a(new btm[]
								{
									new os(TimeSpan.FromSeconds(2.0))
								});
								btm[] array10 = new btm[1];
								int num11 = 0;
								c8s c8s = new c8s();
								c8s.a(0.2f);
								array10[num11] = c8s;
								base.a(array10);
								base.a(new btm[]
								{
									new dva(null, new Func<e6d, bool>(b.b.b.a), null, null, null)
								});
							}
						}
						else
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000D5B RID: 3419
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004ACF RID: 19151 RVA: 0x002018EC File Offset: 0x001FFAEC
		internal bool a(e6d A_0)
		{
			a72 a = new a72();
			a.b("events\\xpbl\\medicalVisions");
			a.d("vision");
			a.c("Headache");
			a.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001DF9 RID: 7673
		public c5x a;
	}

	// Token: 0x02000D5C RID: 3420
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004AD1 RID: 19153 RVA: 0x0020193C File Offset: 0x001FFB3C
		internal bool a(e6d A_0)
		{
			a0l.a(this.b.a, "player_exit", true);
			awh awh = new awh();
			awh.b(this.a.y8());
			awh.b(new Guid("4cb6fca5-3174-4cd8-8f7b-9c2ac5816f32"));
			awh.a(new Guid("b1d02816-884d-4e3c-b8ea-1c3fbce78c61"));
			awh.a(bbo.c);
			awh.ym(this.b.a, null, null);
			return true;
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x002019B0 File Offset: 0x001FFBB0
		internal bool b(e6d A_0)
		{
			awh awh = new awh();
			awh.b(this.a.y8());
			awh.b(new Guid("4cb6fca5-3174-4cd8-8f7b-9c2ac5816f32"));
			awh.a(new Guid("b1d02816-884d-4e3c-b8ea-1c3fbce78c61"));
			awh.a(bbo.c);
			awh.ym(this.b.a, null, null);
			return true;
		}

		// Token: 0x04001DFA RID: 7674
		public aud a;

		// Token: 0x04001DFB RID: 7675
		public ejk.a b;
	}

	// Token: 0x02000D5D RID: 3421
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AD4 RID: 19156 RVA: 0x00201A1C File Offset: 0x001FFC1C
		internal bool a(e6d A_0)
		{
			awh awh = new awh();
			awh.b(this.b.a.y8());
			awh.b(new Guid("4cb6fca5-3174-4cd8-8f7b-9c2ac5816f32"));
			awh.a(new Guid("b1d02816-884d-4e3c-b8ea-1c3fbce78c61"));
			awh.a(bbo.b);
			awh.ym(this.b.b.a, null, null);
			if (this.a != null)
			{
				this.a.a(true);
				this.a.a("NegativeLight");
				this.a.ym(this.b.b.a, null, null);
			}
			return true;
		}

		// Token: 0x04001DFC RID: 7676
		public bzm a;

		// Token: 0x04001DFD RID: 7677
		public ejk.c b;
	}
}
