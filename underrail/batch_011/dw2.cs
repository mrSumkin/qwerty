using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x02000317 RID: 791
[apc("mutatedDog")]
public class dw2 : or
{
	// Token: 0x060016A7 RID: 5799 RVA: 0x00070244 File Offset: 0x0006E444
	public dw2()
	{
		this.b = new TryInvokeSpecialAbilityNode<byc>();
		this.b.a = this.p.a;
		this.b.b = this.p.a;
		this.a = new fh(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.p.a, null)
		});
		this.p.a = this.a;
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x000702E0 File Offset: 0x0006E4E0
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (!this.b.b(A_0))
		{
			return false;
		}
		amc amc = new bzv(A_0.c().y6()).g();
		return amc != null && !amc.aa().SpecialStates.b && !amc.aa().SpecialStates.a;
	}

	// Token: 0x04000D48 RID: 3400
	public new fh a;

	// Token: 0x04000D49 RID: 3401
	public new TryInvokeSpecialAbilityNode<byc> b;
}
