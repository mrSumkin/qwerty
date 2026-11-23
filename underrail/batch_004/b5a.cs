using System;
using System.Diagnostics;

// Token: 0x02002212 RID: 8722
[bmq("1.0.0.10_dc-laby3", "1.0.0.10", "dc-laby3", false)]
public sealed class b5a : fg
{
	// Token: 0x0600CA7D RID: 51837 RVA: 0x0047BAA8 File Offset: 0x00479CA8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("5370fac8-caf0-4b43-af39-31347fc36113"), A_1.Areas[2]).ao() as c5x;
			c5x.o.b.a = "Objects\\Containers\\Remains\\CapHathor";
			c5x.o.b.b.X = 0;
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
