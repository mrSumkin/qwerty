using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020021E2 RID: 8674
[bmq("1.0.0.9_Up_mallTraps", "1.0.0.9", "up_mall", false)]
public sealed class bpl : fg
{
	// Token: 0x0600CA1C RID: 51740 RVA: 0x004789A4 File Offset: 0x00476BA4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("53b87cde-c20f-408d-b8d3-6be8eb31b6e7"), A_1.n("up_mall2")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("6167e678-d8d3-450a-96eb-f72d768ba3e5"), A_1.n("up_mall1")).ao() as c5x;
			ya ya = Enumerable.FirstOrDefault<ya>(Enumerable.Where<ya>(A_1.n("up_mall2").Triggers, new Func<ya, bool>(bpl.a.a.a)));
			if (c5x != null)
			{
				c5x.an();
				c5x.w();
			}
			if (ya != null)
			{
				ya.o();
			}
			if (c5x2 != null && !A_0.r().GetPrimitivePropertyValue<bool>("patch_placedIncendiaryBulletsBlueprint", new bool?(false)).Value)
			{
				c7j c7j = c5x2.GetAspect<bim>() as c7j;
				if (c7j != null)
				{
					coh coh = new d48(ez2.CreateDefinitonProvider<avz>("blueprints\\incendiaryBullets"));
					if (coh != null)
					{
						c7j.ItemContainer.z3(coh, true);
						A_0.r()["patch_placedIncendiaryBulletsBlueprint"] = true;
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x020021E3 RID: 8675
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600CA20 RID: 51744 RVA: 0x00478B28 File Offset: 0x00476D28
		internal bool a(ya A_0)
		{
			return A_0.Name == "TrapTrigger_d9355005-b205-4d52-9b4c-382459bee9c1";
		}

		// Token: 0x04004A11 RID: 18961
		public static readonly bpl.a a = new bpl.a();

		// Token: 0x04004A12 RID: 18962
		public static Func<ya, bool> b;
	}
}
