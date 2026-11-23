using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Behaviors.Custom.Xphw;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000EF1 RID: 3825
[e79("Xphw_ExoskeletonAssembly")]
public sealed class buv : dgy
{
	// Token: 0x06004E57 RID: 20055 RVA: 0x0022CD18 File Offset: 0x0022AF18
	public buv()
	{
		buv.a a = new buv.a();
		base..ctor();
		a.a = this;
		a.b = bpo.GetServiceOrThrow<cnk>();
		if (a.b != null && a.b.aqu() != null)
		{
			d60 d = a.b.aqw().a();
			if (d != null)
			{
				a.c = (Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"exoass_machine"
				})) as c5x);
				a.d = (Enumerable.FirstOrDefault<b0b>(d.ab4(new string[]
				{
					"exoass_console"
				})) as c5x);
				if (a.c != null && a.d != null)
				{
					a.e = (a.b.aqu().v().b() as c5x);
					if (a.e != null)
					{
						a.e.i.b.a(true, false);
						c5x c5x = new ar7(c29.a, a.e.Area).ao() as c5x;
						a.h = a.b.aqu().r().GetClassPropertyValue<string>("interface_xphw_exoChamber_suitChosen");
						a.g = "Armor\\Xphw\\";
						a.f = false;
						string h = a.h;
						if (!(h == "technomedic"))
						{
							if (!(h == "intercessor"))
							{
								if (!(h == "psychophract"))
								{
									a.g += "CombatExoskeleton";
									a.f = true;
								}
								else
								{
									a.g += "PsychophractExoskeleton";
								}
							}
							else
							{
								a.g += "IntercessorExoskeleton";
							}
						}
						else
						{
							a.g += "TechnomedicExoskeleton";
							a.f = true;
						}
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						s5 s = new s5();
						s.a(new ar7(a.e));
						s.a(new bt4("player_exoAssembly"));
						s.IsAsync = true;
						s.a(true);
						array[num] = s;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (c5x != null && a.b.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_gunslinger_followPlayer", new bool?(false)).Value)
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							s5 s2 = new s5();
							s2.a(new ar7(c5x));
							s2.a(new bt4("gunslinger_waitDuringAssembly"));
							s2.IsAsync = true;
							s2.a(true);
							array2[num2] = s2;
							base.a(array2);
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(1.0))
							});
						}
						btm[] array3 = new btm[1];
						int num3 = 0;
						bfq bfq = new bfq();
						bfq.c("Xphw_ExoAssembly_Close");
						array3[num3] = new ace(bfq)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array3);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(4.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						bfq bfq2 = new bfq();
						bfq2.c("Xphw_ExoAssembly_Assembly1");
						array4[num4] = new ace(bfq2)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.4))
						});
						btm[] array5 = new btm[1];
						int num5 = 0;
						bfq bfq3 = new bfq();
						bfq3.c("Xphw_ExoAssembly_Assembly2");
						array5[num5] = new ace(bfq3)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.6))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						bfq bfq4 = new bfq();
						bfq4.c("Xphw_ExoAssembly_Assembly1");
						array6[num6] = new ace(bfq4)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						bfq bfq5 = new bfq();
						bfq5.c("Xphw_ExoAssembly_Open");
						array7[num7] = new ace(bfq5)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array7);
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						eln eln = new eln();
						eln.a(Xphw_GunslingerCommentCodeEnum.Event_ExoskeletonAssemblyFinished);
						array8[num8] = new ace(eln);
						base.a(array8);
						base.a(new btm[]
						{
							new ace(new cxz("XPHWEBIAL"))
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
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

	// Token: 0x06004E58 RID: 20056 RVA: 0x0022D2EC File Offset: 0x0022B4EC
	private void a(c5x A_0, c5x A_1, int A_2, int A_3, bool A_4)
	{
		if (A_0 != null && A_1 != null)
		{
			ny aspect = A_0.GetAspect<ny>();
			ny aspect2 = A_1.GetAspect<ny>();
			if (aspect != null && aspect2 != null)
			{
				int a_ = 125;
				awx awx = new awx();
				awx awx2 = new awx();
				awx awx3 = awx;
				awx3.a(awx3.kh() | m7.b);
				awx awx4 = awx2;
				awx4.a(awx4.kh() | m7.b);
				List<auv> list = awx2.ad();
				bi5 bi = new bi5();
				bi.a(new int?(0));
				bi.f(true);
				bi.a("Objects\\Devices\\xphw_exomachine_b" + ((A_4 > false) ? 1 : 0).ToString());
				list.Add(new a4s(bi, null, new ar7(A_1), null));
				List<auv> list2 = awx2.ad();
				bi5 bi2 = new bi5();
				bi2.a(new int?(1));
				bi2.f(true);
				bi2.a("Objects\\Devices\\xphw_exomachine_b" + ((A_4 > false) ? 1 : 0).ToString());
				list2.Add(new a4s(bi2, null, new ar7(A_1), null));
				int num = A_4 ? 5 : 0;
				for (int i = A_2; i <= A_3; i++)
				{
					int a_2 = i % 8;
					int num2 = Convert.ToInt32(Math.Floor((double)((float)i / 8f)));
					List<auv> list3 = awx.ad();
					bi5 bi3 = new bi5();
					bi3.a(new int?(0));
					bi3.b(true);
					bi3.c(true);
					bi3.b(a_2);
					bi3.a(num2 + num);
					list3.Add(new a4s(bi3, null, new ar7(A_0), null));
					List<auv> list4 = awx2.ad();
					bi5 bi4 = new bi5();
					bi4.a(new int?(0));
					bi4.b(true);
					bi4.c(true);
					bi4.b(a_2);
					bi4.a(num2);
					list4.Add(new a4s(bi4, null, new ar7(A_1), null));
					List<auv> list5 = awx2.ad();
					bi5 bi5 = new bi5();
					bi5.a(new int?(1));
					bi5.b(true);
					bi5.c(true);
					bi5.b(a_2);
					bi5.a(num2);
					list5.Add(new a4s(bi5, null, new ar7(A_1), null));
					awx.ad().Add(new bm3(a_));
					awx2.ad().Add(new bm3(a_));
					if (i == 39)
					{
						List<auv> list6 = awx.ad();
						bi5 bi6 = new bi5();
						bi6.a(new int?(0));
						bi6.b(true);
						bi6.c(true);
						bi6.b(0);
						bi6.a(0);
						list6.Add(new a4s(bi6, null, new ar7(A_0), null));
						List<auv> list7 = awx2.ad();
						bi5 bi7 = new bi5();
						bi7.a(new int?(0));
						bi7.b(true);
						bi7.c(true);
						bi7.b(0);
						bi7.a(0);
						list7.Add(new a4s(bi7, null, new ar7(A_1), null));
						List<auv> list8 = awx2.ad();
						bi5 bi8 = new bi5();
						bi8.a(new int?(1));
						bi8.b(true);
						bi8.c(true);
						bi8.b(0);
						bi8.a(0);
						list8.Add(new a4s(bi8, null, new ar7(A_1), null));
					}
				}
				aspect.a(awx, atp.a, true, false);
				aspect2.a(awx2, atp.a, true, false);
			}
		}
	}

	// Token: 0x02000EF2 RID: 3826
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E5A RID: 20058 RVA: 0x0022D624 File Offset: 0x0022B824
		internal bool c(e6d A_0)
		{
			this.a.a(this.c, this.d, 0, 28, this.f);
			return true;
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x0022D648 File Offset: 0x0022B848
		internal bool b(e6d A_0)
		{
			c8d c8d = new c8d(new LibraryItemDefinitionProvider<c43>(this.g));
			if (c8d != null)
			{
				if (this.e.h.b.aa().Gear.l().Item != null)
				{
					this.e.h.b.aa().Bag.z3(this.e.h.b.aa().Gear.l().Item, true);
					this.e.h.b.aa().Gear.l().Item = null;
				}
				this.e.h.b.aa().Gear.l().a(c8d, true);
				this.e.h.b.aa().Gear.l().Item.Battery = (double)this.e.h.b.aa().Gear.l().Item.MaxBattery;
			}
			return true;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0022D77C File Offset: 0x0022B97C
		internal bool a(e6d A_0)
		{
			this.a.a(this.c, this.d, 29, 39, this.f);
			this.d.b("exoskeletonIssued_" + this.h);
			this.b.aqu().r()["loc_xphw_exoBase_assembledExoskeleton"] = true;
			this.b.aqu().r()["interface_xphw_exoChamber_suitRegistered"] = true;
			this.b.aqu().r().RemoveProperty("interface_xphw_exoChamber_suitChosen");
			return true;
		}

		// Token: 0x04001FF0 RID: 8176
		public buv a;

		// Token: 0x04001FF1 RID: 8177
		public cnk b;

		// Token: 0x04001FF2 RID: 8178
		public c5x c;

		// Token: 0x04001FF3 RID: 8179
		public c5x d;

		// Token: 0x04001FF4 RID: 8180
		public c5x e;

		// Token: 0x04001FF5 RID: 8181
		public bool f;

		// Token: 0x04001FF6 RID: 8182
		public string g;

		// Token: 0x04001FF7 RID: 8183
		public string h;
	}
}
