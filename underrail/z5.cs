using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000CFA RID: 3322
[e79("Cc_EnteringTheGauntlet")]
public sealed class z5 : dgy
{
	// Token: 0x060049F3 RID: 18931 RVA: 0x001EFF14 File Offset: 0x001EE114
	public z5()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			z5.a a = new z5.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = a.a.Area;
				if (a.b != null)
				{
					a.d = (new ar7(new Guid("f60bcb64-b4a1-4306-8212-c44bf085c794"), a.a.Area).ao() as c5x);
					a.e = (new ar7(new Guid("0794099b-0a9d-4999-9c3a-e9a2c93e385f"), a.a.Area).ao() as c5x);
					a.f = (new ar7(new Guid("d84dacbd-19f5-4acb-b18b-ac868fcb2362"), a.a.Area).ao() as c5x);
					c5x c5x = new ar7(new Guid("81f51ca1-5b99-4312-8d89-c3c8d261680c"), a.b).ao() as c5x;
					c5x a_ = new ar7(new Guid("e4dfe7a4-4c29-4454-8e8e-ec1cceb2501e"), a.b).ao() as c5x;
					a.c = (c5x.s.b as c7j);
					string str = (a.a.h.b.aa().Gender == Gender.Female) ? "люди" : "парни";
					a.g = new List<Guid>();
					a.g.Add(new Guid("54ae88d6-5531-4e39-bb18-dea987f0f48d"));
					a.g.Add(new Guid("d32ee2db-3898-4865-9afa-2d5e6f6a7c74"));
					a.g.Add(new Guid("e7274b7f-a792-4ded-b4e2-fd01d6e54dac"));
					a.g.Add(new Guid("d22f0fc1-3298-4063-8f35-d112fca36793"));
					a.g.Add(new Guid("f0ced5e3-775f-4714-8e2a-5eaeb4f1954e"));
					a.g.Add(new Guid("43f34641-88b9-4c5f-b9cf-3e1c0470d8f5"));
					a.g.Add(new Guid("9c869d6a-86be-4e92-84ce-f90f02fc74f2"));
					a.g.Add(new Guid("efa655f2-c8a4-403a-ba26-de853f93d883"));
					a.g.Add(new Guid("5d1352ee-20a8-4589-8708-9bb436116889"));
					a.g.Add(new Guid("10ab7034-8791-4a3c-b5bd-1ce2bd563492"));
					a.g.Add(new Guid("272ec0c9-ea7c-4a8a-8460-c64aedd019aa"));
					if (a.d != null && a.e != null && a.f != null)
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
						if (a.c != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(a.d), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.IsAsync = false;
						array2[num2] = c8s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						egx egx = new egx();
						egx.a("Итак, " + str + ", мы готовы к трансляции! Залезай туда и... э-э... да. И не забудьте захватить что-нибудь из снаряжения! Удачи!");
						array3[num3] = new ace(egx)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						egx egx2 = new egx();
						egx2.a("На старт... и марш.");
						array4[num4] = new ace(egx2)
						{
							TargetRef = new ar7(a.d)
						};
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(9.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						s5 s = new s5();
						s.a(new ar7(a.f));
						s.a(new bt4("runner2_gauntlet2"));
						s.IsAsync = false;
						s.a(true);
						array5[num5] = s;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.e));
						s2.a(new bt4("runner1_gauntlet2"));
						s2.IsAsync = false;
						s2.a(true);
						array6[num6] = s2;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(a.a));
						s3.a(new bt4("player_gauntlet2"));
						s3.IsAsync = false;
						s3.a(true);
						array7[num7] = s3;
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						a5 a2 = new a5();
						a2.a(new ar7(a.e));
						a2.c(false);
						array8[num8] = a2;
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						a5 a3 = new a5();
						a3.a(new ar7(a.f));
						a3.c(false);
						array9[num9] = a3;
						base.a(array9);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						btm[] array10 = new btm[1];
						int num10 = 0;
						kw kw = new kw();
						kw.a(new bt4("cc_enterGauntlet", new Vector3(8f, 3f, 0f)));
						kw.IsAsync = false;
						array10[num10] = kw;
						base.a(array10);
						btm[] array11 = new btm[1];
						int num11 = 0;
						egx egx3 = new egx();
						egx3.a("...помирать болезненной, но восхитительно ужасной смертью. Поэтому нашим бегущим придётся выбирать с умом.");
						array11[num11] = new ace(egx3)
						{
							TargetRef = new ar7(a_)
						};
						base.a(array11);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array12 = new btm[1];
						int num12 = 0;
						egx egx4 = new egx();
						egx4.a("И-и-и... они уже готовятся прямо сейчас! Приветствуйте дорогие маньяки, приветствуйте наших бегущих!");
						array12[num12] = new ace(egx4)
						{
							TargetRef = new ar7(a_)
						};
						base.a(array12);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						base.a(new btm[]
						{
							new ace(new bu0("cp_gauntlet"))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000CFB RID: 3323
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060049F5 RID: 18933 RVA: 0x001F062C File Offset: 0x001EE82C
		internal bool d(e6d A_0)
		{
			ke.a(this.a.h.b.aa(), this.c.ItemContainer, false, true);
			if (this.a.h.b.aa().Gear.l().Item == null)
			{
				this.a.h.b.aa().Gear.l().a(new c8d(new LibraryItemDefinitionProvider<c43>("Armor\\GuantletRunnerJumpsuit")), true);
			}
			return true;
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x001F06C0 File Offset: 0x001EE8C0
		internal bool c(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.North;
			a0l.a(this.a, "player_gauntlet1", true);
			a0l.a(this.e, "runner1_gauntlet1", true);
			a0l.a(this.f, "runner2_gauntlet1", true);
			return true;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x001F0710 File Offset: 0x001EE910
		internal bool b(e6d A_0)
		{
			crx crx = new crx();
			crx.a(this.b.y8());
			crx.a(bbo.b);
			crx.a(this.g);
			crx.ym(this.a, null, null);
			return true;
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x001F0754 File Offset: 0x001EE954
		internal bool a(e6d A_0)
		{
			crx crx = new crx();
			crx.a(this.b.y8());
			crx.a(bbo.c);
			crx.a(this.g);
			crx.ym(this.a, null, null);
			return true;
		}

		// Token: 0x04001D5F RID: 7519
		public c5x a;

		// Token: 0x04001D60 RID: 7520
		public aud b;

		// Token: 0x04001D61 RID: 7521
		public c7j c;

		// Token: 0x04001D62 RID: 7522
		public c5x d;

		// Token: 0x04001D63 RID: 7523
		public c5x e;

		// Token: 0x04001D64 RID: 7524
		public c5x f;

		// Token: 0x04001D65 RID: 7525
		public List<Guid> g;
	}
}
