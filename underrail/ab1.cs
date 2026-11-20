using System;
using System.Diagnostics;

// Token: 0x020021D5 RID: 8661
[bmq("1.0.1.13_Pb_Worker", "1.0.1.13", "pb-mainhall", false)]
public sealed class ab1 : fg
{
	// Token: 0x0600CA01 RID: 51713 RVA: 0x00477D24 File Offset: 0x00475F24
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("95336ef1-273d-48ca-941d-3684c8099c0e"), A_1.n("pb-mainhall")).ao() as c5x;
			if (c5x != null && c5x.h.b != null && c5x.h.b.aa().Name != "Рабочий")
			{
				c5x.h.b.aa().Name = "Рабочий";
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
