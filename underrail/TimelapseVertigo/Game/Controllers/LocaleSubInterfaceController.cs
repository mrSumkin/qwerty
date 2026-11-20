using System;

namespace TimelapseVertigo.Game.Controllers
{
	// Token: 0x02000066 RID: 102
	public abstract class LocaleSubInterfaceController<TWindow, TContext> : dn1 where TWindow : amm
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00009228 File Offset: 0x00007428
		public y5 i()
		{
			return this.b;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009230 File Offset: 0x00007430
		public bool j()
		{
			return this.b == y5.c;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000923C File Offset: 0x0000743C
		protected dka g()
		{
			return this.a;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009244 File Offset: 0x00007444
		public TWindow h()
		{
			return this.c;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000924C File Offset: 0x0000744C
		public void a(TWindow A_0)
		{
			this.c = A_0;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009258 File Offset: 0x00007458
		public bool f()
		{
			return this.e;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009260 File Offset: 0x00007460
		public void b(bool A_0)
		{
			if (this.e != A_0)
			{
				this.e = A_0;
				this.a();
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000927C File Offset: 0x0000747C
		protected LocaleSubInterfaceController(dka A_0, bool A_1, bool A_2 = true, bool A_3 = true)
		{
			czh.a(A_0, "localeController");
			this.f = A_2;
			this.g = A_3;
			this.a = A_0;
			this.d = A_1;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000092B4 File Offset: 0x000074B4
		public void a(TContext A_0)
		{
			this.a(A_0, false, false);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000092C0 File Offset: 0x000074C0
		public void a(TContext A_0, bool A_1, bool A_2 = false)
		{
			if (this.b == y5.c && this.d)
			{
				this.ad();
			}
			if (this.b == y5.a && (this.ow() || A_1))
			{
				this.b = y5.d;
				if (this.n1(A_0))
				{
					if (this.c != null)
					{
						this.c.a(new EventHandler<el5>(this.a));
					}
					if (this.f && !A_2)
					{
						e4z.i();
					}
					this.a();
					this.b = y5.c;
					this.e();
					return;
				}
				this.b = y5.a;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00009374 File Offset: 0x00007574
		public void ad()
		{
			if (this.b == y5.c)
			{
				this.c.z();
				this.c = default(TWindow);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000093A0 File Offset: 0x000075A0
		protected virtual bool n1(TContext A_0)
		{
			return true;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000093A4 File Offset: 0x000075A4
		protected virtual void n2(el5 A_0)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000093A8 File Offset: 0x000075A8
		protected virtual bool ow()
		{
			return true;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000093AC File Offset: 0x000075AC
		protected virtual void e()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000093B0 File Offset: 0x000075B0
		private void a()
		{
			if (this.c != null)
			{
				this.c.Visible = this.e;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000093D8 File Offset: 0x000075D8
		private void a(object A_0, el5 A_1)
		{
			this.b = y5.b;
			if (this.g)
			{
				e4z.i();
			}
			this.n2(A_1);
			this.b = y5.a;
		}

		// Token: 0x04000348 RID: 840
		private dka a;

		// Token: 0x04000349 RID: 841
		private y5 b;

		// Token: 0x0400034A RID: 842
		private TWindow c;

		// Token: 0x0400034B RID: 843
		private bool d;

		// Token: 0x0400034C RID: 844
		private bool e = true;

		// Token: 0x0400034D RID: 845
		private bool f;

		// Token: 0x0400034E RID: 846
		private bool g;
	}
}
