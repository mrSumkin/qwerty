using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000318 RID: 792
[apc("dog")]
public class e5k : or
{
	// Token: 0x060016A9 RID: 5801 RVA: 0x0007034C File Offset: 0x0006E54C
	public override CharacterState? jv()
	{
		return new CharacterState?(CharacterState.Custom1);
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x00070358 File Offset: 0x0006E558
	public override string jw()
	{
		return "DogBark";
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x00070360 File Offset: 0x0006E560
	public override int jx()
	{
		return 1;
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x00070364 File Offset: 0x0006E564
	public override bool jy()
	{
		return true;
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00070368 File Offset: 0x0006E568
	public e5k()
	{
		this.b = new ej0(new Action<ej0>(e5k.a.a.a));
		this.b.a = this.e.a;
		this.e.a = this.b;
		this.a = new d8l();
		this.a.a = this.i.b;
		this.h.b = this.a;
		this.i.b = this.a;
	}

	// Token: 0x04000D4A RID: 3402
	protected new d8l a;

	// Token: 0x04000D4B RID: 3403
	protected new ej0 b;

	// Token: 0x02000319 RID: 793
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060016B0 RID: 5808 RVA: 0x0007042C File Offset: 0x0006E62C
		internal void a(ej0 A_0)
		{
			A_0.b().g().aq = null;
			A_0.b().g().ap = null;
			A_0.b().c().y6()["DogState"] = "stand";
		}

		// Token: 0x04000D4C RID: 3404
		public static readonly e5k.a a = new e5k.a();

		// Token: 0x04000D4D RID: 3405
		public static Action<ej0> b;
	}
}
