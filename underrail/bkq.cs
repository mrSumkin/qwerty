using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EA5 RID: 3749
[e79("Jy_PrivateTalkWithEddy")]
public sealed class bkq : dgy
{
	// Token: 0x06004D92 RID: 19858 RVA: 0x00225DC4 File Offset: 0x00223FC4
	public bkq()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bkq.a a = new bkq.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Zone != null)
			{
				a.b = (new ar7(new Guid("5ff0fa90-d45d-418e-ad80-e947fd0467a6"), a.a.Area).ao() as c5x);
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
					new dva(null, new Func<e6d, bool>(a.b), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("playerToEddy"));
				kw.a(true);
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = true;
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
			}
		}
	}

	// Token: 0x02000EA6 RID: 3750
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D94 RID: 19860 RVA: 0x00225F7C File Offset: 0x0022417C
		internal bool b(e6d A_0)
		{
			csd csd = this.a.Zone.g("eddy2");
			csd csd2 = this.a.Zone.g("playerToEddy");
			if (csd != null && this.b != null)
			{
				this.b.Location = csd.Location;
				this.b.VisualDirection = csd.Direction;
				this.b.ah();
				if (this.b.t.b != null)
				{
					this.b.t.b.y6()[ddq.ay] = new bt4("eddy2");
				}
			}
			if (csd2 != null)
			{
				this.a.Location = csd2.Location;
				this.a.VisualDirection = csd2.Direction;
				this.a.ah();
			}
			return true;
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00226068 File Offset: 0x00224268
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001FBB RID: 8123
		public c5x a;

		// Token: 0x04001FBC RID: 8124
		public c5x b;
	}
}
