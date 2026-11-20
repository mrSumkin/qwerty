using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002FA RID: 762
[apc("devourer")]
public sealed class d0o : cqw
{
	// Token: 0x0600160A RID: 5642 RVA: 0x00069858 File Offset: 0x00067A58
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0006985C File Offset: 0x00067A5C
	public d0o()
	{
		d0o.b b = new d0o.b();
		b.a = new TryInvokeSpecialAttackNode<ceg>();
		b.a.a = this.i.b;
		b.a.b = this.i.b;
		fh fh = new fh(new arr[0]);
		fh.a(new arr[]
		{
			new arr(b.a, new Func<e1k, bool>(b.a)),
			new arr(this.i.b, null)
		});
		this.h.b = fh;
		this.i.b = fh;
		this.a = new ej0(new Action<ej0>(d0o.a.a.a));
		this.a.a = this.c.a;
		this.c.a = this.a;
	}

	// Token: 0x04000C9D RID: 3229
	private new ej0 a;

	// Token: 0x020002FB RID: 763
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x00069978 File Offset: 0x00067B78
		internal void a(ej0 A_0)
		{
			A_0.b().c().y6().RemoveProperty(ddq.a);
		}

		// Token: 0x04000C9E RID: 3230
		public static readonly d0o.a a = new d0o.a();

		// Token: 0x04000C9F RID: 3231
		public static Action<ej0> b;
	}

	// Token: 0x020002FC RID: 764
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x000699A8 File Offset: 0x00067BA8
		internal bool a(e1k A_0)
		{
			if (this.a.a(A_0))
			{
				amc amc = new bzv(A_0.c().y6()).g();
				if (euf.f(A_0.g().aa()) < 0.8f && amc != null && amc.a8() != null && !amc.aa().b(d8o.e))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000CA0 RID: 3232
		public TryInvokeSpecialAttackNode<ceg> a;
	}
}
