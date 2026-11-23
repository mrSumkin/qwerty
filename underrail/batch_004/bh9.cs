using System;
using System.Runtime.CompilerServices;

// Token: 0x020002E6 RID: 742
[apc("smallCrab")]
public class bh9 : or
{
	// Token: 0x060015C4 RID: 5572 RVA: 0x00067420 File Offset: 0x00065620
	public override bool jy()
	{
		return true;
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00067428 File Offset: 0x00065628
	public bh9()
	{
		this.a = new ej0(new Action<ej0>(bh9.a.a.a));
		this.a.a = this.e.a;
		this.e.a = this.a;
	}

	// Token: 0x04000C68 RID: 3176
	protected new ej0 a;

	// Token: 0x020002E7 RID: 743
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015C8 RID: 5576 RVA: 0x000674A8 File Offset: 0x000656A8
		internal void a(ej0 A_0)
		{
			A_0.b().g().aq = null;
			A_0.b().g().ap = null;
			A_0.b().c().y6()["DogState"] = "stand";
		}

		// Token: 0x04000C69 RID: 3177
		public static readonly bh9.a a = new bh9.a();

		// Token: 0x04000C6A RID: 3178
		public static Action<ej0> b;
	}
}
