using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D3C RID: 3388
[e79("Xpbl_Md_JumpIntoCraneShaft")]
public sealed class d7b : dgy
{
	// Token: 0x06004A88 RID: 19080 RVA: 0x001FB05C File Offset: 0x001F925C
	public d7b()
	{
		d7b.a a = new d7b.a();
		base..ctor();
		a.a = this;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Zone != null)
			{
				bool flag = c5x.Area != null;
				bool value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_md_craneShaftJump_lowerFloor", new bool?(false)).Value;
				a.c = 18;
				to to = c5x.h.b.aa().BaseAbilities.a("Agility");
				to to2 = c5x.h.b.aa().BaseAbilities.a("Constitution");
				a.b = to.g() + to2.g();
				a.d = 0;
				a.e = (to.g() < 12);
				if (d8s.b())
				{
					a.b -= 1000;
				}
				else
				{
					if (value)
					{
						a.b += 4;
					}
					if (c5x.h.b.aa().Feats.Contains<efa>())
					{
						a.b += 2;
					}
					if (c5x.h.b.aa().Feats.Contains<enb>())
					{
						a.b++;
					}
					if (c5x.h.b.aa().Feats.Contains<cek>())
					{
						a.b += 3;
					}
					if (c5x.h.b.aa().Feats.Contains<e6k>())
					{
						a.b++;
					}
					if (c5x.h.b.aa().Feats.Contains<ads>())
					{
						a.b++;
					}
					if (c5x.h.b.aa().Feats.Contains<chs>())
					{
						a.b += 2;
					}
					if (c5x.h.b.aa().StatusEffects.a(c6h.a))
					{
						a.d += 20;
					}
				}
				if (flag)
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
						new di4(new c2w("xpbl_md", "FromCrane"), true, new bool?(false), 0, null, true, false, false)
					});
					btm[] array = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(a.b));
					array[num] = dva;
					base.a(array);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(a.a));
					array2[num2] = dva2;
					base.a(array2);
				}
			}
		}
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x001FB3BC File Offset: 0x001F95BC
	private void a(c5x A_0, int A_1, bool A_2 = true)
	{
		doj doj = new doj();
		doj.a(A_1);
		doj.ym(A_0, null, null);
		if (A_2)
		{
			A_0.h.b.aa().StatusEffects.a(new eok(600000), false, false, false);
		}
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x001FB40C File Offset: 0x001F960C
	private void a(c5x A_0)
	{
		nb nb = new nb();
		nb.a(bvl.d);
		nb.ym(A_0, null, null);
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x001FB428 File Offset: 0x001F9628
	private void a(c5x A_0, bool A_1)
	{
		bfq bfq = new bfq();
		bfq.b("jump");
		bfq.a(bvl.d);
		bfq.c("SledgehammerHitBody");
		bfq.a(c9z.a);
		bfq.ym(A_0, null, null);
		if (A_1)
		{
			eym.a(A_0, 20.0);
		}
	}

	// Token: 0x02000D3D RID: 3389
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A8D RID: 19085 RVA: 0x001FB488 File Offset: 0x001F9688
		internal bool b(e6d A_0)
		{
			c5x a_ = new ar7(aju.a, new Guid("9d1d410c-8ef2-4089-ac6f-e2080ab066e3"), new Guid("d9012392-0499-478c-aa7d-5a945c6af0de"), bl1.a).ao() as c5x;
			if (this.b >= this.c + 8)
			{
				this.a.a(a_, 50 - this.d, false);
			}
			else if (this.b >= this.c + 6)
			{
				this.a.a(a_, 60 - this.d, false);
			}
			else if (this.b >= this.c + 4)
			{
				this.a.a(a_, 70 - this.d, true);
			}
			else if (this.b >= this.c + 2)
			{
				this.a.a(a_, 80 - this.d, true);
			}
			else if (this.b >= this.c)
			{
				this.a.a(a_, 90 - this.d, true);
			}
			else
			{
				this.a.a(a_);
			}
			return true;
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x001FB5B4 File Offset: 0x001F97B4
		internal bool a(e6d A_0)
		{
			c5x a_ = new ar7(aju.a, new Guid("9d1d410c-8ef2-4089-ac6f-e2080ab066e3"), new Guid("d9012392-0499-478c-aa7d-5a945c6af0de"), bl1.a).ao() as c5x;
			this.a.a(a_, this.e);
			return true;
		}

		// Token: 0x04001DC9 RID: 7625
		public d7b a;

		// Token: 0x04001DCA RID: 7626
		public int b;

		// Token: 0x04001DCB RID: 7627
		public int c;

		// Token: 0x04001DCC RID: 7628
		public int d;

		// Token: 0x04001DCD RID: 7629
		public bool e;
	}
}
