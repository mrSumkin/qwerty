using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002D4 RID: 724
[apc("machineGunTurret")]
public class w6 : or
{
	// Token: 0x0600157C RID: 5500 RVA: 0x00064BC8 File Offset: 0x00062DC8
	public override bool m2()
	{
		return true;
	}

	// Token: 0x0600157D RID: 5501 RVA: 0x00064BCC File Offset: 0x00062DCC
	public w6()
	{
		this.h.c = 0;
		this.h.d = 1;
		this.b = new TryInvokeSpecialAttackNode<c91>();
		this.a = new fh(new arr[0]);
		this.p.a = this.a;
		this.a.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.d, null)
		});
		this.b.a = this.j;
		this.b.b = this.c;
	}

	// Token: 0x0600157E RID: 5502 RVA: 0x00064C80 File Offset: 0x00062E80
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (this.b.a(A_0))
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && aw1.b(amc.a8(), A_0.g().a8()) <= (double)A_0.g().aa().Offense.u().TypedDefinition.ad())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000C31 RID: 3121
	protected new fh a;

	// Token: 0x04000C32 RID: 3122
	protected new TryInvokeSpecialAttackNode<c91> b;
}
