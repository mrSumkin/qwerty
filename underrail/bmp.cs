using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D1B RID: 3355
[e79("Cc_TrippyDrugs1")]
public sealed class bmp : dgy
{
	// Token: 0x06004A33 RID: 18995 RVA: 0x001F4B98 File Offset: 0x001F2D98
	public bmp()
	{
		bmp.a a = new bmp.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = new ar7(a.b);
			a.d = new ar7();
			a.e = new ar7();
			if (a.b != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Stunned)))
					{
						TargetRef = new ar7(a.b)
					}
				});
				base.a(new btm[]
				{
					new am8()
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new cmc(null)
				});
				base.a(new btm[]
				{
					new ace(new epw(null))
					{
						TargetRef = new ar7(a.b)
					}
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc_passage", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.d));
				array2[num2] = dva;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				egx egx = new egx();
				egx.a("...и тогда я говорю Таннеру...");
				array3[num3] = new ace(egx)
				{
					TargetRef = a.c
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx2 = new egx();
				egx2.a("Кто такой Таннер?");
				array4[num4] = new ace(egx2)
				{
					TargetRef = a.d
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx3 = new egx();
				egx3.a("Я говорю ему...");
				array5[num5] = new ace(egx3)
				{
					TargetRef = a.c
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx4 = new egx();
				egx4.a("Не могу вспомнить что это было...");
				array6[num6] = new ace(egx4)
				{
					TargetRef = a.c
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.c));
				array7[num7] = dva2;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.b));
				array8[num8] = dva3;
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				egx egx5 = new egx();
				egx5.a("Ковабанга!");
				array9[num9] = new ace(egx5)
				{
					TargetRef = a.d
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				egx egx6 = new egx();
				egx6.a("О, нет! Опять то же самое!");
				array10[num10] = new ace(egx6)
				{
					TargetRef = a.c
				};
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array11[num11] = dky2;
				base.a(array11);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array12 = new btm[1];
				int num12 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.a));
				array12[num12] = dva4;
				base.a(array12);
				base.a(new btm[]
				{
					new di4(new c2w("cc4", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(a.e));
				array13[num13] = dva5;
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				egx egx7 = new egx();
				egx7.a("А ты вообще кто?");
				array14[num14] = new ace(egx7)
				{
					TargetRef = a.e
				};
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D1C RID: 3356
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A35 RID: 18997 RVA: 0x001F51F0 File Offset: 0x001F33F0
		internal bool d(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.d.a(new ar7(new Guid("2c7fca17-fcc9-4744-9391-f4a81cca2cff"), this.b.Area).ao() as c5x);
			if (this.d.ao() != null)
			{
				aw1.b(this.d.ao(), this.b, false);
			}
			else
			{
				c5x c5x = vq.a("creatures\\generichumans\\commoner", this.b.Zone.g("07a64fca-3306-45fe-8b47-e1f585daf05a"), false);
				if (c5x != null && c5x.h.b != null)
				{
					c5x.Layer = 0;
					c5x.h.b.a("orb");
					c5x.q("Motioner");
					c5x.h.b.aa().Name = "Motioner";
					this.d.a(c5x);
				}
			}
			return true;
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x001F5310 File Offset: 0x001F3510
		internal bool c(e6d A_0)
		{
			c5x c5x = this.d.ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				boj.a(c5x, "Smoke", 1, double.MaxValue, true, true, null, null, null, null, false);
			}
			return true;
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x001F5384 File Offset: 0x001F3584
		internal bool b(e6d A_0)
		{
			c5x c5x = this.d.ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a("siphoner");
			}
			return true;
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x001F53D0 File Offset: 0x001F35D0
		internal bool a(e6d A_0)
		{
			c5x c5x = this.d.ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				c5x.h.b.a("orb");
			}
			return true;
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x001F541C File Offset: 0x001F361C
		internal bool e(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.e.a(new ar7(new Guid("e438a9b4-e960-4784-bea2-532594edf853"), this.b.Area).ao() as c5x);
			if (this.e.ao() != null)
			{
				aw1.b(this.e.ao(), this.b, false);
			}
			return true;
		}

		// Token: 0x04001D93 RID: 7571
		public cnk a;

		// Token: 0x04001D94 RID: 7572
		public c5x b;

		// Token: 0x04001D95 RID: 7573
		public ar7 c;

		// Token: 0x04001D96 RID: 7574
		public ar7 d;

		// Token: 0x04001D97 RID: 7575
		public ar7 e;
	}
}
