using System;
using System.Linq;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Game.Controllers;

// Token: 0x02000581 RID: 1409
public sealed class d7a : LocaleSubInterfaceController<amm, de8>
{
	// Token: 0x0600246D RID: 9325 RVA: 0x000CD910 File Offset: 0x000CBB10
	public c5x b()
	{
		return this.a;
	}

	// Token: 0x0600246E RID: 9326 RVA: 0x000CD918 File Offset: 0x000CBB18
	public object a()
	{
		return this.b;
	}

	// Token: 0x0600246F RID: 9327 RVA: 0x000CD920 File Offset: 0x000CBB20
	public d7a(dka A_0) : base(A_0, true, false, false)
	{
	}

	// Token: 0x06002470 RID: 9328 RVA: 0x000CD930 File Offset: 0x000CBB30
	protected override bool n1(de8 A_0)
	{
		czh.a(A_0, "context");
		this.a = A_0.d();
		this.b = A_0.b();
		base.a(base.g().ac().a(this.a, A_0.c(), A_0.e(), A_0.a()));
		return true;
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x000CD990 File Offset: 0x000CBB90
	protected override void n2(el5 A_0)
	{
		if (this.a != null && this.a.j == cgy.b)
		{
			c6g c6g = Enumerable.FirstOrDefault<c6g>(Enumerable.Where<c6g>(Enumerable.OfType<c6g>(this.a.RaysEmitters), new Func<c6g, bool>(d7a.a.a.a)));
			if (c6g != null)
			{
				c6g.ig();
			}
		}
		ny aspect = ces.c().b().GetAspect<ny>();
		if (aspect != null)
		{
			aspect.a(m7.g, true, false);
		}
		this.a = null;
		this.b = null;
	}

	// Token: 0x04001528 RID: 5416
	private new c5x a;

	// Token: 0x04001529 RID: 5417
	private object b;

	// Token: 0x02000582 RID: 1410
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06002474 RID: 9332 RVA: 0x000CDA44 File Offset: 0x000CBC44
		internal bool a(c6g A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "CameraEye";
		}

		// Token: 0x0400152A RID: 5418
		public static readonly d7a.a a = new d7a.a();

		// Token: 0x0400152B RID: 5419
		public static Func<c6g, bool> b;
	}
}
