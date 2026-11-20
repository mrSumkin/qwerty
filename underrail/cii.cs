using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000CB2 RID: 3250
[e79("Lux_LuperMakesShoes")]
public sealed class cii : dgy
{
	// Token: 0x06004948 RID: 18760 RVA: 0x001E5880 File Offset: 0x001E3A80
	public cii()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			cii.a a = new cii.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("1ffb3daa-25d6-4333-be8e-472bb414b840"), a.a.Area).ao() as c5x);
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
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000CB3 RID: 3251
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600494A RID: 18762 RVA: 0x001E5A3C File Offset: 0x001E3C3C
		internal bool b(e6d A_0)
		{
			a0l.a(this.b, "Luper_table", true);
			a0l.a(this.a, "Luper_guard", true);
			this.b.VisualDirection = HorizontalDirection.West;
			return true;
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001E5A70 File Offset: 0x001E3C70
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001D00 RID: 7424
		public c5x a;

		// Token: 0x04001D01 RID: 7425
		public c5x b;
	}
}
