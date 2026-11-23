using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002F2 RID: 754
[apc("threadBot")]
public sealed class xp : cqw
{
	// Token: 0x060015ED RID: 5613 RVA: 0x00068A48 File Offset: 0x00066C48
	public xp()
	{
		this.a = new fh(new arr[0]);
		this.b = new TryInvokeSpecialAbilityNode<dw7>();
		this.b.b = new Func<e1k, object>(xp.a.a.a);
		this.b.a = this.i.b;
		this.b.b = this.i.b;
		this.a.a(new arr[]
		{
			new arr(this.b, new Func<e1k, bool>(this.a)),
			new arr(this.i.b, null)
		});
		this.i.b = this.a;
		this.h.b = this.a;
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00068B34 File Offset: 0x00066D34
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.b.b(A_0);
	}

	// Token: 0x04000C85 RID: 3205
	private new fh a;

	// Token: 0x04000C86 RID: 3206
	private new TryInvokeSpecialAbilityNode<dw7> b;

	// Token: 0x020002F3 RID: 755
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015F1 RID: 5617 RVA: 0x00068B64 File Offset: 0x00066D64
		internal object a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.a8() != null && amc.a8().Area != null)
			{
				return amc.a8().Area.a(amc.a8().aj().a());
			}
			return null;
		}

		// Token: 0x04000C87 RID: 3207
		public static readonly xp.a a = new xp.a();

		// Token: 0x04000C88 RID: 3208
		public static Func<e1k, object> b;
	}
}
