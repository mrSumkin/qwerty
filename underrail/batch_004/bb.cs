using System;
using System.Runtime.CompilerServices;

// Token: 0x020002B6 RID: 694
[apc("cat")]
public class bb : or
{
	// Token: 0x0600144F RID: 5199 RVA: 0x000582AC File Offset: 0x000564AC
	public override bool cp()
	{
		return true;
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x000582B0 File Offset: 0x000564B0
	public bb()
	{
		this.a = new ej0(new Action<ej0>(bb.a.a.a));
		this.a.a = this.e.a;
		this.e.a = this.a;
		this.h.b = this.i.b;
		this.i.b = this.i.b;
	}

	// Token: 0x04000B22 RID: 2850
	protected new ej0 a;

	// Token: 0x020002B7 RID: 695
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001453 RID: 5203 RVA: 0x0005835C File Offset: 0x0005655C
		internal void a(ej0 A_0)
		{
			A_0.b().g().aq = null;
			A_0.b().g().ap = null;
			A_0.b().c().y6()["CatState"] = "stand";
		}

		// Token: 0x04000B23 RID: 2851
		public static readonly bb.a a = new bb.a();

		// Token: 0x04000B24 RID: 2852
		public static Action<ej0> b;
	}
}
