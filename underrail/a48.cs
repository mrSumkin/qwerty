using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x0200218B RID: 8587
[bmq("1.0.3.21_HangingRatExpansionTrigger", "1.0.3.21", "lux-b11", false)]
public sealed class a48 : fg
{
	// Token: 0x0600C967 RID: 51559 RVA: 0x00472F5C File Offset: 0x0047115C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_1.n("lux-b11").Triggers, new Func<ya, bool>(a48.a.a.a)));
			if (ya != null && ya.Location.Y != 28)
			{
				ya.o();
				ya.Location = new Point(29, 28);
				A_1.n("lux-b11").b(ya);
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x0200218C RID: 8588
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C96B RID: 51563 RVA: 0x0047302C File Offset: 0x0047122C
		internal bool a(ya A_0)
		{
			return A_0.Name == "azifTravel";
		}

		// Token: 0x04004A0B RID: 18955
		public static readonly a48.a a = new a48.a();

		// Token: 0x04004A0C RID: 18956
		public static Func<ya, bool> b;
	}
}
