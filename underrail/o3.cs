using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000323 RID: 803
[apc("rathound")]
public class o3 : or
{
	// Token: 0x06001708 RID: 5896 RVA: 0x00072C04 File Offset: 0x00070E04
	public override CharacterState? jv()
	{
		return new CharacterState?(CharacterState.FinishPsi);
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x00072C0C File Offset: 0x00070E0C
	public override string jw()
	{
		return "RathoundHowl";
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00072C14 File Offset: 0x00070E14
	public override int jx()
	{
		return 1;
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00072C18 File Offset: 0x00070E18
	public override bool jy()
	{
		return true;
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00072C1C File Offset: 0x00070E1C
	public o3()
	{
		TryInvokeSpecialAttackNode<cgb> tryInvokeSpecialAttackNode = new TryInvokeSpecialAttackNode<cgb>();
		tryInvokeSpecialAttackNode.a = this.i.b;
		tryInvokeSpecialAttackNode.b = this.i.b;
		this.a = new d8l();
		this.a.a = tryInvokeSpecialAttackNode;
		this.h.b = this.a;
		this.i.b = this.a;
		this.b = new ej0(new Action<ej0>(o3.a.a.a));
		this.b.a = this.c.a;
		this.c.a = this.b;
	}

	// Token: 0x04000DA5 RID: 3493
	protected new d8l a;

	// Token: 0x04000DA6 RID: 3494
	protected new ej0 b;

	// Token: 0x02000324 RID: 804
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x00072CF8 File Offset: 0x00070EF8
		internal void a(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a);
		}

		// Token: 0x04000DA7 RID: 3495
		public static readonly o3.a a = new o3.a();

		// Token: 0x04000DA8 RID: 3496
		public static Action<ej0> b;
	}
}
