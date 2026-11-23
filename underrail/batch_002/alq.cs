using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000E5E RID: 3678
[e79("Fo5_UnloadCart")]
public sealed class alq : dgy
{
	// Token: 0x06004D00 RID: 19712 RVA: 0x0021DD24 File Offset: 0x0021BF24
	public alq()
	{
		alq.a a = new alq.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			if (c5x != null)
			{
				ar7 ar = new ar7(new Guid("5e9e10c8-0f1d-4a37-80fc-bb75d632ecfd"), c5x.Area);
				a.b = (ar.ao() as c5x);
				if (a.b != null)
				{
					a.c = a.b.o.b;
					if (a.c != null)
					{
						alq.b b = new alq.b();
						b.b = a;
						btm[] array = new btm[1];
						int num = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(b.b.b));
						array[num] = dva;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						b.a = (b.b.b.GetAspect<bim>() as c7j);
						if (b.a != null && b.a.ItemContainer.z2().Count > 0)
						{
							btm[] array2 = new btm[1];
							int num2 = 0;
							dva dva2 = new dva(null, null, null, null, null);
							dva2.a(new Func<e6d, bool>(b.a));
							array2[num2] = dva2;
							base.a(array2);
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.5))
						});
						btm[] array3 = new btm[1];
						int num3 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(b.b.a));
						array3[num3] = dva3;
						base.a(array3);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array4 = new btm[1];
						int num4 = 0;
						dva dva4 = new dva(null, null, null, null, null);
						dva4.a(new Func<e6d, bool>(b.b.c));
						array4[num4] = dva4;
						base.a(array4);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E5F RID: 3679
	[CompilerGenerated]
	[Serializable]
	private sealed class c
	{
		// Token: 0x06004D03 RID: 19715 RVA: 0x0021DF74 File Offset: 0x0021C174
		internal int a(coh A_0)
		{
			return A_0.Stacks;
		}

		// Token: 0x04001F5A RID: 8026
		public static readonly alq.c a = new alq.c();

		// Token: 0x04001F5B RID: 8027
		public static Func<coh, int> b;
	}

	// Token: 0x02000E60 RID: 3680
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D05 RID: 19717 RVA: 0x0021DF84 File Offset: 0x0021C184
		internal bool b(e6d A_0)
		{
			this.c.e = "Locale\\Objects\\Vehicles\\CartUnload";
			this.c.b = new Point(0, this.c.b.Y);
			ny ny = this.b.i.b;
			dqm dqm = new dqm(this.c);
			dqm.b(0);
			dqm.c(7);
			dqm.a(1);
			dqm.a(100.0);
			ny.b(dqm, atp.a);
			return true;
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x0021E008 File Offset: 0x0021C208
		internal bool a(e6d A_0)
		{
			ny ny = this.b.i.b;
			dqm dqm = new dqm(this.c);
			dqm.b(7);
			dqm.c(7);
			dqm.a(-1);
			dqm.a(100.0);
			ny.b(dqm, atp.a);
			return true;
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x0021E05C File Offset: 0x0021C25C
		internal bool c(e6d A_0)
		{
			this.c.e = "Locale\\Objects\\Vehicles\\CartMov";
			this.c.b = new Point(0, this.c.b.Y);
			return true;
		}

		// Token: 0x04001F5C RID: 8028
		public cnk a;

		// Token: 0x04001F5D RID: 8029
		public c5x b;

		// Token: 0x04001F5E RID: 8030
		public cd0 c;
	}

	// Token: 0x02000E61 RID: 3681
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004D09 RID: 19721 RVA: 0x0021E09C File Offset: 0x0021C29C
		internal bool a(e6d A_0)
		{
			this.b.b.c().a(Guid.NewGuid().ToString(), "CartUnloadOre", 0.8f, c9z.a, false, false);
			int num = this.b.a.aqu().r().GetPrimitivePropertyValue<int>("loc_fo5_storedOre", new int?(0)).Value;
			num += Enumerable.Sum<coh>(this.a.ItemContainer.z2(), new Func<coh, int>(alq.c.a.a));
			this.b.a.aqu().r()["loc_fo5_storedOre"] = num;
			this.a.ItemContainer.z7();
			return true;
		}

		// Token: 0x04001F5F RID: 8031
		public c7j a;

		// Token: 0x04001F60 RID: 8032
		public alq.a b;
	}
}
