using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000EBC RID: 3772
public abstract class ds5 : dgy
{
	// Token: 0x06004DB3 RID: 19891 RVA: 0x00228B88 File Offset: 0x00226D88
	protected virtual int abm()
	{
		return 1;
	}

	// Token: 0x06004DB4 RID: 19892
	protected abstract string abn();

	// Token: 0x06004DB5 RID: 19893 RVA: 0x00228B8C File Offset: 0x00226D8C
	protected ds5()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ds5.c c = new ds5.c();
			c.a = (serviceOrThrow.aqu().v().b() as c5x);
			new ar7(new Guid("5e65da5c-4111-4ab3-b948-4c19aad216af"), c.a.Area);
			if (c.a != null)
			{
				ds5.a a = new ds5.a();
				a.a = c.a.Zone.n("cc_arena");
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
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array[num] = dky;
						base.a(array);
						btm[] array2 = new btm[1];
						int num2 = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(a.a));
						array2[num2] = dva;
						base.a(array2);
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = "gladiator" + this.abm().ToString()
							})
							{
								InitiatorRef = new ar7(c.a)
							}
						});
						this.abo(serviceOrThrow, c.a);
						btm[] array3 = new btm[1];
						int num3 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(c.a));
						array3[num3] = dva2;
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						kw kw = new kw();
						kw.a(new bt4("announcerCam"));
						kw.a(true);
						array4[num4] = kw;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(this.a));
						array5[num5] = dva3;
						base.a(array5);
						btm[] array6 = new btm[1];
						int num6 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						array6[num6] = c8s;
						base.a(array6);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						this.abp(serviceOrThrow, c.a);
						btm[] array7 = new btm[1];
						int num7 = 0;
						kw kw2 = new kw();
						kw2.a(new bt4("arenaCam"));
						kw2.a(false);
						array7[num7] = kw2;
						base.a(array7);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						this.abq(serviceOrThrow, c.a);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array8 = new btm[1];
						int num8 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(ds5.b.a.b));
						array8[num8] = dva4;
						base.a(array8);
						btm[] array9 = new btm[1];
						int num9 = 0;
						dva dva5 = new dva(null, null, null, null, null);
						dva5.a(new Func<e6d, bool>(ds5.b.a.a));
						array9[num9] = dva5;
						base.a(array9);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
						base.a(new btm[]
						{
							new ace(new bu0("cp_arena"))
						});
					}
				}
			}
		}
	}

	// Token: 0x06004DB6 RID: 19894 RVA: 0x00228F70 File Offset: 0x00227170
	protected virtual void abp(cnk A_0, c5x A_1)
	{
	}

	// Token: 0x06004DB7 RID: 19895 RVA: 0x00228F74 File Offset: 0x00227174
	protected virtual void abq(cnk A_0, c5x A_1)
	{
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00228F78 File Offset: 0x00227178
	protected virtual void abo(cnk A_0, c5x A_1)
	{
	}

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00228F7C File Offset: 0x0022717C
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

	// Token: 0x06004DBA RID: 19898 RVA: 0x00229024 File Offset: 0x00227224
	[CompilerGenerated]
	private bool a(e6d A_0)
	{
		a3f aspect = this.b.GetAspect<a3f>();
		if (aspect != null)
		{
			aspect.a()["EndCutsceneName"] = this.abn();
		}
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.anf(edg.a);
		}
		return true;
	}

	// Token: 0x04001FC7 RID: 8135
	private new c5x a;

	// Token: 0x04001FC8 RID: 8136
	private new c5x b;

	// Token: 0x02000EBD RID: 3773
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004DBD RID: 19901 RVA: 0x00229088 File Offset: 0x00227288
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x002290AC File Offset: 0x002272AC
		internal bool a(e6d A_0)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != null && d4n.b.aa().Gear.h().Item != null)
					{
						d4n.b.aa().Defense.a(true);
					}
				}
				service.ahk(10000.0);
			}
			return true;
		}

		// Token: 0x04001FC9 RID: 8137
		public static readonly ds5.b a = new ds5.b();

		// Token: 0x04001FCA RID: 8138
		public static Func<e6d, bool> b;

		// Token: 0x04001FCB RID: 8139
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000EBE RID: 3774
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004DC0 RID: 19904 RVA: 0x00229164 File Offset: 0x00227364
		internal bool a(e6d A_0)
		{
			if (this.a.h.b.aa().Gear.h().Item != null)
			{
				this.a.h.b.aa().Defense.a(false);
			}
			return true;
		}

		// Token: 0x04001FCC RID: 8140
		public c5x a;
	}

	// Token: 0x02000EBF RID: 3775
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x002291C8 File Offset: 0x002273C8
		internal bool a(e6d A_0)
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
							if (!c5x.IsFloor && c5x.qe() != new Guid("21336a36-f3b5-4744-80d7-3c227763b6d5") && c5x.Layer == aju.x)
							{
								c5x.w();
								c5x.an();
							}
						}
						foreach (bqt bqt in Enumerable.ToList<bqt>(ak.TriggerProxies))
						{
							bqt.Trigger.o();
						}
					}
				}
			}
			return true;
		}

		// Token: 0x04001FCD RID: 8141
		public aud a;
	}
}
