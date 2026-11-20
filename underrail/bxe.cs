using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000F35 RID: 3893
[e79("Xpbl_Le_BriggsRescueArrives")]
public sealed class bxe : dgy
{
	// Token: 0x06004F00 RID: 20224 RVA: 0x00239018 File Offset: 0x00237218
	public bxe()
	{
		bxe.c c = new bxe.c();
		base..ctor();
		c.a = this;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c.b = (serviceOrThrow.aqu().v().b() as c5x);
			if (c.b != null)
			{
				c.c = c.b.Area;
				if (c.c != null)
				{
					bool flag = false;
					if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quests_xpbl_expedition_saveTheProfessor_returnToCampWithoutProfessor", new bool?(false)).Value)
					{
						bxe.b b = new bxe.b();
						b.b = c;
						bool flag2 = false;
						b.a = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), b.b.c).ao() as c5x);
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
							new os(TimeSpan.FromSeconds(2.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.a), null, null, null)
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(b.b.c), null, null, null)
						});
						if (b.b.c.y8() == "xpbl_g3" && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_g3_gateOpen", new bool?(false)).Value)
						{
							base.a(new btm[]
							{
								new ace(new a8q())
							});
						}
						btm[] array2 = new btm[1];
						int num2 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.a(false);
						array2[num2] = c8s;
						base.a(array2);
						if (b.a != null)
						{
							serviceOrThrow.aqu().r()["quests_xpbl_expedition_professorSaved"] = true;
							btm[] array3 = new btm[1];
							int num3 = 0;
							egx egx = new egx();
							egx.a("Рад снова вас видеть, профессор.");
							array3[num3] = new ace(egx)
							{
								TargetRef = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), b.b.c)
							};
							base.a(array3);
							if (b.b.c.y8() == "xpbl_g3" && b.b.b.h.b.aa().Vehicle != null)
							{
								base.a(new btm[]
								{
									this.a(b.b.b, serviceOrThrow, out flag)
								});
							}
						}
						else
						{
							flag2 = true;
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.b.b), null, null, null)
							});
						}
						if (!flag2)
						{
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(4.0))
							});
							btm[] array4 = new btm[1];
							int num4 = 0;
							dky dky2 = new dky();
							dky2.a(0.2f);
							dky2.a(false);
							array4[num4] = dky2;
							base.a(array4);
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(b.b.a), null, null, null)
							});
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(1.0))
							});
							if (flag)
							{
								base.a(new btm[]
								{
									new di4(new c2w("xpbl_d5", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
								});
								base.a(new btm[]
								{
									new ace(new an9())
									{
										InitiatorRef = new ar7(aju.a, new Guid("9b12167a-09d6-488c-a45d-c0c968225b7c"), new Guid("61fa2bf3-e47b-4008-bbeb-75f2c57a143d"), bl1.a)
									}
								});
							}
							base.a(new btm[]
							{
								new ace(new e80(true))
							});
							base.a(new btm[]
							{
								new di4(new c2w("xpbl_d6", "player_oldTent"), false, new bool?(false), 0, null, true, false, false)
							});
							return;
						}
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						return;
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (c.c.y8() == "xpbl_g3" && c.b.h.b.aa().Vehicle != null)
						{
							base.a(new btm[]
							{
								this.a(c.b, serviceOrThrow, out flag)
							});
						}
						if (flag)
						{
							base.a(new btm[]
							{
								new di4(new c2w("xpbl_d5", "player_abandonJet"), false, new bool?(false), 0, null, false, false, false)
							});
							base.a(new btm[]
							{
								new ace(new an9())
								{
									InitiatorRef = new ar7(aju.a, new Guid("9b12167a-09d6-488c-a45d-c0c968225b7c"), new Guid("61fa2bf3-e47b-4008-bbeb-75f2c57a143d"), bl1.a)
								}
							});
						}
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_d6", "player_briggsTent"), false, new bool?(false), 0, null, true, false, false)
						});
					}
				}
			}
		}
	}

	// Token: 0x06004F01 RID: 20225 RVA: 0x00239608 File Offset: 0x00237808
	private void a(bool A_0, aud A_1)
	{
		gx gx = new gx();
		string a_ = "briggs'sEscort";
		if (A_0)
		{
			using (List<csd>.Enumerator enumerator = Enumerable.ToList<csd>(A_1.Zone.Waypoints).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					csd csd = enumerator.Current;
					if (csd.Name.StartsWith("aegisJet", StringComparison.OrdinalIgnoreCase))
					{
						bh8.b(gx.a(csd, new int?(10), "Aegis_Jetski", null, null, null, null, false, null, false)).b(a_);
					}
					else if (csd.Name.StartsWith("global:xpbl_briggs", StringComparison.OrdinalIgnoreCase))
					{
						c5x c5x = vq.a("creature\\characters\\xpbl\\Briggs", csd, true);
						if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Vehicle == null)
						{
							b5o b5o = new b5o("xpbl_AegisPatroller");
							agt value = new agt(ez2.CreateDefinitonProvider<eqg>("vehicleParts\\Engines\\BArmLightstep250"));
							agt value2 = new agt(ez2.CreateDefinitonProvider<esd>("vehicleParts\\Batteries\\BArmScilon250"));
							agt value3 = new agt(ez2.CreateDefinitonProvider<eu0>("vehicleParts\\Xpbl_JetskiSuspensions\\BArmMediumJetShocks"));
							c5x.h.b.a(bln.k6);
							if (b5o != null)
							{
								c5x.h.b.aa().Vehicle = new bcx();
								c5x.h.b.aa().Vehicle.a(b5o);
								c5x.h.b.aa().Vehicle.o()["engine"] = value;
								c5x.h.b.aa().Vehicle.o()["battery"] = value2;
								c5x.h.b.aa().Vehicle.o()["suspension"] = value3;
								c5x.h.b.aa().Vehicle.k();
								c5x.h.b.aa().Vehicle.b((double)c5x.h.b.aa().Vehicle.v());
								c5x.h.b.aa().Vehicle.a(double.MaxValue);
								c5x.h.b.aa().Vehicle.k();
								c5x.h.b.aa().Portrait = bln.hy;
								c5x.h.b.aa().bl();
								c5x.h.b.at();
							}
						}
					}
				}
				return;
			}
		}
		d60 d = A_1.Zone.a();
		if (d != null)
		{
			foreach (b0b b0b in d.ab4(new string[]
			{
				"briggs'sEscort"
			}))
			{
				b0b.w();
				b0b.an();
			}
		}
		c5x c5x2 = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), A_1).ao() as c5x;
		if (c5x2 != null)
		{
			c5x2.w();
			c5x2.an();
		}
	}

	// Token: 0x06004F02 RID: 20226 RVA: 0x002399A8 File Offset: 0x00237BA8
	private c6w a(c5x A_0, cnk A_1, out bool A_2)
	{
		bxe.a a = new bxe.a();
		a.a = A_1;
		a.b = A_0;
		c6w c6w = new c6w();
		c6w.a = new Func<auv>(a.a);
		c6w.a(new ar7(a.b));
		if (c6w != null)
		{
			A_2 = true;
			return c6w;
		}
		A_2 = false;
		return c6w;
	}

	// Token: 0x02000F36 RID: 3894
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004F04 RID: 20228 RVA: 0x00239A08 File Offset: 0x00237C08
		internal bool c(e6d A_0)
		{
			this.a.a(true, this.c);
			return true;
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00239A20 File Offset: 0x00237C20
		internal bool b(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), this.c).ao() as c5x;
			this.b.GetAspect<j7>().a(c5x.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x00239A68 File Offset: 0x00237C68
		internal bool a(e6d A_0)
		{
			this.a.a(false, this.c);
			return true;
		}

		// Token: 0x04002060 RID: 8288
		public bxe a;

		// Token: 0x04002061 RID: 8289
		public c5x b;

		// Token: 0x04002062 RID: 8290
		public aud c;
	}

	// Token: 0x02000F37 RID: 3895
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004F08 RID: 20232 RVA: 0x00239A8C File Offset: 0x00237C8C
		internal bool a(e6d A_0)
		{
			if (this.b.b.h.b.aa().Vehicle == null)
			{
				a0l.a(this.b.b, "playerCutscene", true);
			}
			else
			{
				a0l.a(this.b.b, "playerJetCutscene", true);
			}
			if (this.a != null)
			{
				a0l.a(this.a, "oldfieldCutscene", true);
			}
			return true;
		}

		// Token: 0x04002063 RID: 8291
		public c5x a;

		// Token: 0x04002064 RID: 8292
		public bxe.c b;
	}

	// Token: 0x02000F38 RID: 3896
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F0A RID: 20234 RVA: 0x00239B18 File Offset: 0x00237D18
		internal auv a()
		{
			d60 addon = this.a.aqw().GetAddon<d60>();
			if (addon != null)
			{
				c5x c5x = Enumerable.FirstOrDefault<b0b>(addon.ab4(new string[]
				{
					"playersJetTakenByPirates"
				})) as c5x;
				if (c5x != null)
				{
					wv wv = c5x.GetAspect<bim>() as wv;
					if (wv != null)
					{
						return new kp(wv, this.b.h.b);
					}
				}
			}
			return null;
		}

		// Token: 0x04002065 RID: 8293
		public cnk a;

		// Token: 0x04002066 RID: 8294
		public c5x b;
	}
}
