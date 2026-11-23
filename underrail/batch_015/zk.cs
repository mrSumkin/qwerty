using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x02000321 RID: 801
[apc("wheeledBot1")]
public sealed class zk : cqw
{
	// Token: 0x06001703 RID: 5891 RVA: 0x00072928 File Offset: 0x00070B28
	public zk()
	{
		this.a = new b4d
		{
			a = 0
		};
		this.c = new TryInvokeSpecialAbilityNode<c09>();
		this.b = new fh(new arr[0]);
		this.d = new fh(new arr[0]);
		this.a.a = this.c;
		this.a.b = this.c;
		this.b.a(new arr[]
		{
			new arr(this.a, new Func<e1k, bool>(this.a)),
			new arr(this.i.b, null)
		});
		this.c.a = this.b;
		this.c.b = this.b;
		fh fh = this.d;
		arr[] array = new arr[2];
		array[0] = new arr(this.c, new Func<e1k, bool>(zk.a.a.a));
		array[1] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.d;
		this.h.b = this.d;
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x00072A70 File Offset: 0x00070C70
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		if (A_0.g().aa().Gear.d()[0].Item == null)
		{
			return false;
		}
		d4n d4n = bpo.GetServiceOrThrow<d02>().ahu(A_0.g().aa());
		if (d4n == null || d4n.c > 30.0)
		{
			return false;
		}
		if (!this.a.a(A_0))
		{
			return false;
		}
		amc amc = new bzv(A_0.c().y6()).g();
		if (amc != null && amc.aa().IsInControl && !amc.aa().c(d8o.e))
		{
			blk blk = new bzv(A_0.c().y6()).c(amc.a8().qe());
			if (blk != null && blk.b())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04000D9F RID: 3487
	private new b4d a;

	// Token: 0x04000DA0 RID: 3488
	private new fh b;

	// Token: 0x04000DA1 RID: 3489
	private new TryInvokeSpecialAbilityNode<c09> c;

	// Token: 0x04000DA2 RID: 3490
	private new fh d;

	// Token: 0x02000322 RID: 802
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001707 RID: 5895 RVA: 0x00072B70 File Offset: 0x00070D70
		internal bool a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			if (amc != null && amc.aa().IsInControl)
			{
				blk blk = new bzv(A_0.c().y6()).c(amc.a8().qe());
				if (blk != null && blk.b() && aw1.b(A_0.g().a8(), amc.a8()) < 2.0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000DA3 RID: 3491
		public static readonly zk.a a = new zk.a();

		// Token: 0x04000DA4 RID: 3492
		public static Func<e1k, bool> b;
	}
}
