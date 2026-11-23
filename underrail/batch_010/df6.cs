using System;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02001192 RID: 4498
public static class df6
{
	// Token: 0x06006006 RID: 24582 RVA: 0x0029D6A4 File Offset: 0x0029B8A4
	public static bool a(string A_0, e3q A_1)
	{
		df6.a a = new df6.a();
		a.a = d79.a(A_0);
		if (a.a == null)
		{
			return false;
		}
		if (Enumerable.Any<bdc>(A_1.d(), new Func<bdc, bool>(a.a)))
		{
			return false;
		}
		A_1.b(a.a.GetType());
		a7v.a(new csv(new ap9(A_1), a.a.Name, a.a.Quality));
		return true;
	}

	// Token: 0x06006007 RID: 24583 RVA: 0x0029D728 File Offset: 0x0029B928
	public static void a(c5x A_0)
	{
		aru aru = A_0.c();
		aru.a("use", false);
		aru.a("use", "ConsoleDownloadItem", 1f, c9z.a, false, false);
	}

	// Token: 0x02001193 RID: 4499
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06006009 RID: 24585 RVA: 0x0029D768 File Offset: 0x0029B968
		internal bool a(bdc A_0)
		{
			return A_0.ao() == this.a;
		}

		// Token: 0x04002898 RID: 10392
		public cwp a;
	}
}
