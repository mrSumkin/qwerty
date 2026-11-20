using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000C9D RID: 3229
[e79("Cvw_OldIbCallsSons")]
public sealed class y1 : dgy
{
	// Token: 0x06004909 RID: 18697 RVA: 0x001DD7C8 File Offset: 0x001DB9C8
	public y1()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				y1.a a = new y1.a();
				a.c = (new ar7(new Guid("6101d37c-5a06-415c-a1d3-6db3a64ef343"), c5x.Area).ao() as c5x);
				c5x c5x2 = new ar7(new Guid("edd57390-03cd-44e6-b4ec-cbd67dc9f333"), c5x.Area).ao() as c5x;
				a.a = (new ar7(new Guid("76a46a73-b9cb-41f7-bdfb-1e44d4539ee8"), c5x.Area).ao() as c5x);
				c5x c5x3 = new ar7(new Guid("e8d19002-1f56-48dc-8a46-7b4f423fdaa0"), c5x.Area).ao() as c5x;
				a.b = (new ar7(new Guid("b18b7cfc-4a2f-442b-b715-646899141ecf"), c5x.Area).ao() as c5x);
				c5x c5x4 = new ar7(new Guid("16578fdb-cca5-415c-b915-e036e54892f3"), c5x.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("65f87fb5-8d73-4e55-8e5d-2a773661d362"), c5x.Area).ao() as c5x;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_cvw_18x_dingleAndElmoArrived", new bool?(false)).Value;
				double num = 4.0;
				if (a.c != null)
				{
					c5x.i.b.a(true, false);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
					btm[] array = new btm[1];
					int num2 = 0;
					egx egx = new egx();
					egx.a("Moyse!");
					array[num2] = new ace(egx)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array);
					if (c5x2 != null)
					{
						btm[] array2 = new btm[1];
						int num3 = 0;
						s5 s = new s5();
						s.a(new ar7(c5x2));
						s.a(new bt4("call_moyse"));
						s.IsAsync = true;
						s.a(true);
						array2[num3] = s;
						base.a(array2);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num))
						});
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num - 2.0))
						});
					}
					btm[] array3 = new btm[1];
					int num4 = 0;
					egx egx2 = new egx();
					egx2.a("Manlius!");
					array3[num4] = new ace(egx2)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array3);
					if (a.a != null)
					{
						btm[] array4 = new btm[1];
						int num5 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.a));
						s2.a(new bt4("call_manlius"));
						s2.IsAsync = true;
						s2.a(true);
						array4[num5] = s2;
						base.a(array4);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num))
						});
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num - 2.0))
						});
					}
					btm[] array5 = new btm[1];
					int num6 = 0;
					egx egx3 = new egx();
					egx3.a("Chin!");
					array5[num6] = new ace(egx3)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array5);
					if (a.b != null)
					{
						btm[] array6 = new btm[1];
						int num7 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(a.b));
						s3.a(new bt4("call_chin"));
						s3.IsAsync = true;
						s3.a(true);
						array6[num7] = s3;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num))
						});
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num - 2.0))
						});
					}
					btm[] array7 = new btm[1];
					int num8 = 0;
					egx egx4 = new egx();
					egx4.a("Hobb!");
					array7[num8] = new ace(egx4)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array7);
					if (c5x3 != null)
					{
						btm[] array8 = new btm[1];
						int num9 = 0;
						s5 s4 = new s5();
						s4.a(new ar7(c5x3));
						s4.a(new bt4("call_hobb"));
						s4.IsAsync = true;
						s4.a(true);
						array8[num9] = s4;
						base.a(array8);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num))
						});
					}
					else
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(num - 2.0))
						});
					}
					if (!value)
					{
						btm[] array9 = new btm[1];
						int num10 = 0;
						egx egx5 = new egx();
						egx5.a("Dingle! Elmo!");
						array9[num10] = new ace(egx5)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array9);
						if (c5x4 != null)
						{
							btm[] array10 = new btm[1];
							int num11 = 0;
							s5 s5 = new s5();
							s5.a(new ar7(c5x4));
							s5.a(new bt4("call_dingle"));
							s5.IsAsync = true;
							s5.a(true);
							array10[num11] = s5;
							base.a(array10);
						}
						if (c5x5 != null)
						{
							btm[] array11 = new btm[1];
							int num12 = 0;
							s5 s6 = new s5();
							s6.a(new ar7(c5x5));
							s6.a(new bt4("call_elmo"));
							s6.IsAsync = true;
							s6.a(true);
							array11[num12] = s6;
							base.a(array11);
						}
						if (c5x4 != null || c5x5 != null)
						{
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(num + 2.0))
							});
						}
						else
						{
							base.a(new btm[]
							{
								new os(TimeSpan.FromSeconds(num - 2.0))
							});
						}
					}
					if (c5x2 == null && a.b == null && a.a == null && c5x3 == null && c5x4 == null && c5x5 == null)
					{
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.c), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.b), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(a.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array12 = new btm[1];
						int num13 = 0;
						egx egx6 = new egx();
						egx6.a("Р-ребята...?");
						array12[num13] = new ace(egx6)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array12);
					}
					else if (c5x.h.b.aa().Gender == Gender.Female)
					{
						btm[] array13 = new btm[1];
						int num14 = 0;
						egx egx7 = new egx();
						egx7.a("Возьми его!");
						array13[num14] = new ace(egx7)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array13);
					}
					else
					{
						btm[] array14 = new btm[1];
						int num15 = 0;
						egx egx8 = new egx();
						egx8.a("Возьми её!");
						array14[num15] = new ace(egx8)
						{
							TargetRef = new ar7(a.c)
						};
						base.a(array14);
					}
					btm[] array15 = new btm[1];
					int num16 = 0;
					eaq eaq = new eaq();
					eaq.b(asp.a);
					eaq.a(asp.fg);
					eaq.a(h.a);
					eaq.a(true);
					array15[num16] = new ace(eaq);
					base.a(array15);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000C9E RID: 3230
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600490B RID: 18699 RVA: 0x001DDFF8 File Offset: 0x001DC1F8
		internal bool d(e6d A_0)
		{
			if (this.a != null)
			{
				a0l.a(this.a, "teleport_manlius", true);
			}
			if (this.b != null)
			{
				a0l.a(this.b, "teleport_chin", true);
			}
			return true;
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x001DE034 File Offset: 0x001DC234
		internal bool c(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.Southeast;
			return true;
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x001DE044 File Offset: 0x001DC244
		internal bool b(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x001DE054 File Offset: 0x001DC254
		internal bool a(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x04001CDB RID: 7387
		public c5x a;

		// Token: 0x04001CDC RID: 7388
		public c5x b;

		// Token: 0x04001CDD RID: 7389
		public c5x c;
	}
}
