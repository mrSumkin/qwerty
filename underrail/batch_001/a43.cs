using System;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x02000338 RID: 824
[apc("cc_gauntletRunner")]
public sealed class a43 : esk
{
	// Token: 0x06001768 RID: 5992 RVA: 0x00076470 File Offset: 0x00074670
	public a43()
	{
		this.a = new a6w(null);
		this.a.a = new Func<a6w, cst>(a43.a.a.a);
		this.a.a = this.c;
		this.a.b = this.c;
		this.a.a.Insert(0, new arr(this.a, new Func<e1k, bool>(a43.a.a.a)));
	}

	// Token: 0x04000DF0 RID: 3568
	private new a6w a;

	// Token: 0x02000339 RID: 825
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x00076530 File Offset: 0x00074730
		internal cst a(a6w A_0)
		{
			if (A_0.b().g().a8().k.b != null)
			{
				Guid value = A_0.b().c().y6().GetPrimitivePropertyValue<Guid>("LeverId", new Guid?(Guid.Empty)).Value;
				bim bim = new EntityAspectReference<bim, bim>(A_0.b().g().a8().Area, value).ao();
				if (bim != null && bim.ab())
				{
					return A_0.b().g().a8().k.b.b(bim.a8(), bim.t(), 1, false, null);
				}
			}
			return null;
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000765EC File Offset: 0x000747EC
		internal bool a(e1k A_0)
		{
			Guid value = A_0.c().y6().GetPrimitivePropertyValue<Guid>("LeverId", new Guid?(Guid.Empty)).Value;
			bim bim = new EntityAspectReference<bim, bim>(A_0.g().a8().Area, value).ao();
			return bim != null && bim.ab();
		}

		// Token: 0x04000DF1 RID: 3569
		public static readonly a43.a a = new a43.a();

		// Token: 0x04000DF2 RID: 3570
		public static Func<a6w, cst> b;

		// Token: 0x04000DF3 RID: 3571
		public static Func<e1k, bool> c;
	}
}
