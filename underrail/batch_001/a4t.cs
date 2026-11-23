using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E3B RID: 3643
[e79("Lup_BurnLock")]
public sealed class a4t : dgy
{
	// Token: 0x06004CB6 RID: 19638 RVA: 0x00219A48 File Offset: 0x00217C48
	public a4t()
	{
		a4t.a a = new a4t.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			a.a.aqu().ac();
			if (c5x != null)
			{
				a.c = (new ar7(new Guid("06b7c193-a583-4152-85c0-b9ae228d6413"), c5x.Area).ao() as c5x);
				a.d = (new ar7(new Guid("1f581427-2bb0-4c47-9cf6-b57558158a04"), c5x.Area).ao() as c5x);
				a.e = (new ar7(new Guid("0cb91089-301a-49c3-9329-a9cca493d2fe"), c5x.Area).ao() as c5x);
				a.b = (new ar7(new Guid("a0d2c57a-53f9-480e-bb9e-8db2c4373b9d"), c5x.Area).ao() as c5x);
				if (a.c != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					kw kw = new kw();
					kw.a(new bt4("global:pr_bioagent2"));
					kw.a(false);
					kw.IsAsync = false;
					array[num] = kw;
					base.a(array);
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s = new s5();
					s.a(new ar7(a.d));
					s.a(new bt4("global:pr_bioagent2"));
					s.IsAsync = false;
					s.a(true);
					array2[num2] = s;
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					bb8 bb = new bb8();
					bb.a(new ar7(a.d));
					bb.a(CharacterState.Operating);
					bb.b(3);
					array3[num3] = bb;
					base.a(array3);
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
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Следуйте за мной в вентиляцию.");
					array4[num4] = new ace(egx)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array4);
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E3C RID: 3644
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CB8 RID: 19640 RVA: 0x00219D24 File Offset: 0x00217F24
		internal bool b(e6d A_0)
		{
			if (this.b != null)
			{
				boj.a(this.b, "AcidSplash", 1, double.MaxValue, true, true, new Vector3?(new Vector3(0.1f, 0f, 0.2f)), null, null, null, false);
				this.b.c().a("AcidFizz");
			}
			this.a.aqu().r()["quest_prmutation_openedLock"] = true;
			if (this.c != null)
			{
				this.c.a("IntoVents");
				if (this.c.t.b != null)
				{
					this.c.t.b.y6()[ddq.bg] = true;
				}
			}
			if (this.d != null)
			{
				this.d.a("global:pr_bioagent2:ready");
			}
			if (this.e != null)
			{
				this.e.a("global:pr_bioagent3:ready");
			}
			bv9 bv = this.a.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.dc, asp.a, h.a, null, true, false, false);
			}
			return true;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00219E8C File Offset: 0x0021808C
		internal bool a(e6d A_0)
		{
			if (this.b != null)
			{
				d2b aspect = this.b.GetAspect<d2b>();
				if (aspect != null)
				{
					aspect.a(true, false);
				}
				cnb cnb = this.b.s.b as cnb;
				if (cnb != null && !cnb.q())
				{
					cnb.a(this.d, null, false, false);
				}
			}
			return true;
		}

		// Token: 0x04001F2F RID: 7983
		public cnk a;

		// Token: 0x04001F30 RID: 7984
		public c5x b;

		// Token: 0x04001F31 RID: 7985
		public c5x c;

		// Token: 0x04001F32 RID: 7986
		public c5x d;

		// Token: 0x04001F33 RID: 7987
		public c5x e;
	}
}
