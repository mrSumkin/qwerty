using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020002F6 RID: 758
[apc("tchortTentacle")]
public sealed class av1 : cqw
{
	// Token: 0x060015FF RID: 5631 RVA: 0x000695A4 File Offset: 0x000677A4
	public override bool ef()
	{
		return false;
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x000695A8 File Offset: 0x000677A8
	public av1()
	{
		this.c = new fh(new arr[0]);
		this.a = new ej0(new Action<ej0>(av1.a.a.a));
		this.a.a = this.i.b;
		this.b = new ej0(new Action<ej0>(av1.a.a.b));
		this.b.a = this.i.b;
		fh fh = this.c;
		arr[] array = new arr[2];
		array[0] = new arr(this.a, new Func<e1k, bool>(av1.a.a.a));
		array[1] = new arr(this.b, null);
		fh.a(array);
		this.i.b = this.c;
		this.h.b = this.c;
	}

	// Token: 0x04000C95 RID: 3221
	private new ej0 a;

	// Token: 0x04000C96 RID: 3222
	private new ej0 b;

	// Token: 0x04000C97 RID: 3223
	private new fh c;

	// Token: 0x020002F7 RID: 759
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x000696D8 File Offset: 0x000678D8
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Primary);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00069700 File Offset: 0x00067900
		internal void b(ej0 A_0)
		{
			A_0.b().g().aa().Offense.a(WeaponKey.Secondary);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00069728 File Offset: 0x00067928
		internal bool a(e1k A_0)
		{
			amc amc = new bzv(A_0.c().y6()).g();
			return amc != null && aw1.b(A_0.g().a8(), amc.a8()) <= 1.5;
		}

		// Token: 0x04000C98 RID: 3224
		public static readonly av1.a a = new av1.a();

		// Token: 0x04000C99 RID: 3225
		public static Action<ej0> b;

		// Token: 0x04000C9A RID: 3226
		public static Action<ej0> c;

		// Token: 0x04000C9B RID: 3227
		public static Func<e1k, bool> d;
	}
}
