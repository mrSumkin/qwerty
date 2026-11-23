using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000EC2 RID: 3778
public abstract class bz6 : dgy
{
	// Token: 0x06004DCB RID: 19915 RVA: 0x002294CC File Offset: 0x002276CC
	protected bz6()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bz6.b b = new bz6.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			new ar7(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"), b.a.Area);
			if (b.a != null)
			{
				bz6.a a = new bz6.a();
				a.b = b;
				a.b.a.h.b.aa().StatusEffects.a(new egf(60000, 1000), false, false, false);
				a.a = a.b.a.Zone.n("cc_arena");
				if (a.a != null)
				{
					this.a = (new ar7(new Guid("dabcee2a-6946-4f2a-9402-5e27649c52a4"), a.a).ao() as c5x);
					this.b = (new ar7(new Guid("21336a36-f3b5-4744-80d7-3c227763b6d5"), a.a).ao() as c5x);
					if (this.a != null && this.b != null)
					{
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
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(bz6.c.a.b));
						array[num] = dva;
						base.a(array);
						btm[] array2 = new btm[1];
						int num2 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(a.b.a));
						array2[num2] = dva2;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						kw kw = new kw();
						kw.a(new bt4("announcerCam"));
						array3[num3] = kw;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						this.il(serviceOrThrow, a.b.a);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array4[num4] = dky;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(bz6.c.a.a));
						array5[num5] = dva3;
						base.a(array5);
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "FromArena"
							})
							{
								InitiatorRef = new ar7(a.b.a)
							}
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(a.a));
						array6[num6] = dva4;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array7 = new btm[1];
						int num7 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						array7[num7] = c8s;
						base.a(array7);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x0022985C File Offset: 0x00227A5C
	protected virtual void il(cnk A_0, c5x A_1)
	{
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x00229860 File Offset: 0x00227A60
	protected void a(string A_0, int A_1)
	{
		btm[] array = new btm[1];
		int num = 0;
		egx egx = new egx();
		egx.a(A_0);
		array[num] = new ace(egx)
		{
			TargetRef = new ar7(this.a)
		};
		base.a(array);
		btm[] array2 = new btm[1];
		int num2 = 0;
		egx egx2 = new egx();
		egx2.a(A_0);
		array2[num2] = new ace(egx2)
		{
			TargetRef = new ar7(this.b)
		};
		base.a(array2);
		int num3 = Math.Max((int)(ciz.a(A_0) - 250.0), A_1 * 1000);
		base.a(new btm[]
		{
			new os(TimeSpan.FromMilliseconds((double)num3))
		});
	}

	// Token: 0x04001FCF RID: 8143
	private new c5x a;

	// Token: 0x04001FD0 RID: 8144
	private new c5x b;

	// Token: 0x02000EC3 RID: 3779
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004DD0 RID: 19920 RVA: 0x0022991C File Offset: 0x00227B1C
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00229940 File Offset: 0x00227B40
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001FD1 RID: 8145
		public static readonly bz6.c a = new bz6.c();

		// Token: 0x04001FD2 RID: 8146
		public static Func<e6d, bool> b;

		// Token: 0x04001FD3 RID: 8147
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000EC4 RID: 3780
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004DD3 RID: 19923 RVA: 0x00229970 File Offset: 0x00227B70
		internal bool a(e6d A_0)
		{
			if (this.a.h.b.aa().Gear.h().Item != null)
			{
				this.a.h.b.aa().Defense.a(false);
			}
			return true;
		}

		// Token: 0x04001FD4 RID: 8148
		public c5x a;
	}

	// Token: 0x02000EC5 RID: 3781
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DD5 RID: 19925 RVA: 0x002299D4 File Offset: 0x00227BD4
		internal bool a(e6d A_0)
		{
			c7j c7j = (new ar7(new Guid("cffd6257-b28c-42d6-90e9-ba59dae40b45"), this.b.a.Zone.n("cc_arena_lower")).ao() as c5x).GetAspect<bim>() as c7j;
			if (c7j != null)
			{
				for (int i = 10; i <= this.a.Size.c; i++)
				{
					for (int j = 10; j <= this.a.Size.d; j++)
					{
						ak1 ak = this.a.b(i, j);
						if (ak != null)
						{
							foreach (b0b b0b in Enumerable.ToList<b0b>(ak.Entities))
							{
								c5x c5x = (c5x)b0b;
								if (c5x.s.b != null)
								{
									if (c5x.s.b is c7j)
									{
										c7j c7j2 = c5x.GetAspect<bim>() as c7j;
										using (List<coh>.Enumerator enumerator2 = Enumerable.ToList<coh>(c7j2.ItemContainer.z2()).GetEnumerator())
										{
											while (enumerator2.MoveNext())
											{
												coh coh = enumerator2.Current;
												if (coh.Definition is x2 || coh.Lootable)
												{
													c7j2.ItemContainer.z5(coh);
													c7j.ItemContainer.z3(coh, true);
												}
											}
											continue;
										}
									}
									if (c5x.a("thrownSpear") || c5x.a("thrownNet"))
									{
										mk mk = Enumerable.FirstOrDefault<mk>(Enumerable.OfType<mk>(c5x.s.b.s()));
										if (mk != null)
										{
											c7j.ItemContainer.z3(Enumerable.FirstOrDefault<coh>(mk.StaticItems.z2()), true);
										}
									}
								}
							}
						}
					}
				}
			}
			egf egf = Enumerable.FirstOrDefault<egf>(this.b.a.h.b.aa().StatusEffects.Get<egf>());
			if (egf != null)
			{
				this.b.a.h.b.aa().StatusEffects.d(egf);
			}
			return true;
		}

		// Token: 0x04001FD5 RID: 8149
		public aud a;

		// Token: 0x04001FD6 RID: 8150
		public bz6.b b;
	}
}
