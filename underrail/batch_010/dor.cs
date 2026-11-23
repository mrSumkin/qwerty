using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020021A9 RID: 8617
[bmq("1.0.1.14_Fom_BatTrigger", "1.0.1.14", "crys1", false)]
public sealed class dor : fg
{
	// Token: 0x0600C9A6 RID: 51622 RVA: 0x00475568 File Offset: 0x00473768
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			te te = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_1.n("crys1").Triggers, new Func<ya, bool>(dor.a.a.a))) as te;
			if (te != null)
			{
				te.b(1000);
				List<cze> list = te.f();
				us us = new us();
				us.a(new Guid?(new Guid("7b369847-8693-4eb4-8758-b6d40ed42dae")));
				us.a("Проклятые мыши!");
				list.Add(us);
				List<cze> list2 = te.f();
				us us2 = new us();
				us2.a(new Guid?(new Guid("2512070f-ef6f-4af8-bbfe-7f99568af54f")));
				us2.a("А-а-а!");
				list2.Add(us2);
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x020021AA RID: 8618
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600C9AA RID: 51626 RVA: 0x00475670 File Offset: 0x00473870
		internal bool a(ya A_0)
		{
			return A_0.Name == "Bats";
		}

		// Token: 0x04004A0D RID: 18957
		public static readonly dor.a a = new dor.a();

		// Token: 0x04004A0E RID: 18958
		public static Func<ya, bool> b;
	}
}
