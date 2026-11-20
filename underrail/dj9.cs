using System;
using System.Runtime.CompilerServices;

// Token: 0x020002E3 RID: 739
[apc("laserCat")]
public class dj9 : or
{
	// Token: 0x060015BF RID: 5567 RVA: 0x000672C8 File Offset: 0x000654C8
	public dj9()
	{
		this.a = new ej0(new Action<ej0>(dj9.a.a.a));
		this.a.a = this.e.a;
		this.e.a = this.a;
		this.h.b = this.i.b;
		this.i.b = this.i.b;
	}

	// Token: 0x04000C65 RID: 3173
	protected new ej0 a;

	// Token: 0x020002E4 RID: 740
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015C2 RID: 5570 RVA: 0x00067374 File Offset: 0x00065574
		internal void a(ej0 A_0)
		{
			A_0.b().g().aq = null;
			A_0.b().g().ap = null;
			A_0.b().c().y6()["CatState"] = "stand";
		}

		// Token: 0x04000C66 RID: 3174
		public static readonly dj9.a a = new dj9.a();

		// Token: 0x04000C67 RID: 3175
		public static Action<ej0> b;
	}
}
