using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.AI.Model.TurnBased;

// Token: 0x020002E8 RID: 744
[apc("psiCrab")]
public sealed class dr : cqw
{
	// Token: 0x060015C9 RID: 5577 RVA: 0x00067500 File Offset: 0x00065700
	public override bool ef()
	{
		return false;
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00067504 File Offset: 0x00065704
	public dr()
	{
		this.d = new ej0();
		this.b = new fh(new arr[0]);
		this.c = new fh(new arr[0]);
		this.a = new TryInvokePsiAbilityNode<dl3>();
		this.e = new ej0();
		this.d.a = new Action<ej0>(dr.a.a.a);
		this.d.a = this.c.a;
		this.c.a = this.d;
		fh fh = this.b;
		arr[] array = new arr[2];
		array[0] = new arr(this.c, new Func<e1k, bool>(dr.a.a.a));
		array[1] = new arr(this.p.a, null);
		fh.a(array);
		this.c.a(new arr[]
		{
			new arr(this.a, new Func<e1k, bool>(this.a)),
			new arr(this.c, null)
		});
		this.a.a = this.b;
		this.a.b = this.e;
		this.e.a = new Action<ej0>(dr.a.a.b);
		this.e.a = this.b;
		this.p.a = this.b;
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x000676B0 File Offset: 0x000658B0
	[CompilerGenerated]
	private new bool a(e1k A_0)
	{
		return this.a.a(A_0);
	}

	// Token: 0x04000C6B RID: 3179
	private new TryInvokePsiAbilityNode<dl3> a;

	// Token: 0x04000C6C RID: 3180
	private new fh b;

	// Token: 0x04000C6D RID: 3181
	private new fh c;

	// Token: 0x04000C6E RID: 3182
	private new ej0 d;

	// Token: 0x04000C6F RID: 3183
	private new ej0 e;

	// Token: 0x020002E9 RID: 745
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060015CE RID: 5582 RVA: 0x000676D4 File Offset: 0x000658D4
		internal void a(ej0 A_0)
		{
			A_0.b().d().RemoveProperty("kited");
			A_0.b().d().RemoveProperty("psiInhibited");
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00067710 File Offset: 0x00065910
		internal bool a(e1k A_0)
		{
			if (!A_0.d().GetPrimitivePropertyValue<bool>("psiInhibited", new bool?(false)).Value && new bzv(A_0.c().y6()).g() != null)
			{
				dl3 dl = dgk.Get<dl3>();
				return !A_0.g().aa().SpecialStates.d && A_0.g().aa().Offense.aa().zo() >= dl.e(new eoj(A_0.g().aa(), null, null));
			}
			return false;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000677B8 File Offset: 0x000659B8
		internal void b(ej0 A_0)
		{
			A_0.b().d()["psiInhibited"] = true;
		}

		// Token: 0x04000C70 RID: 3184
		public static readonly dr.a a = new dr.a();

		// Token: 0x04000C71 RID: 3185
		public static Action<ej0> b;

		// Token: 0x04000C72 RID: 3186
		public static Func<e1k, bool> c;

		// Token: 0x04000C73 RID: 3187
		public static Action<ej0> d;
	}
}
