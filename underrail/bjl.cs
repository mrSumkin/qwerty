using System;
using System.Diagnostics;

// Token: 0x0200211C RID: 8476
[bmq("1.1.2.5_ReplaceHiddenCaveDoors", "1.1.2.5", "ForlornStations3,dc-pp_e,dc-flo", false)]
public sealed class bjl : fg
{
	// Token: 0x0600C886 RID: 51334 RVA: 0x0046B2AC File Offset: 0x004694AC
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = null;
			if (string.Equals(A_1.y8(), "ForlornStations3", StringComparison.OrdinalIgnoreCase))
			{
				c5x = (new ar7(new Guid("5fa5757b-7932-4b31-b346-d7b45620b148"), A_1.n("ForlornStations3Underground")).ao() as c5x);
			}
			else if (string.Equals(A_1.y8(), "dc-pp_e", StringComparison.OrdinalIgnoreCase))
			{
				c5x = (new ar7(new Guid("3e3fcc8c-d5e7-491e-944e-30ddd5dedc1c"), A_1.n("dc-pp_e")).ao() as c5x);
			}
			else
			{
				c5x c5x2 = new ar7(new Guid("4dad70d5-4821-4aeb-93cb-fb3e167f0398"), A_1.n("dc-flo")).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("efa84a85-f8bf-4316-ab6e-5e883c48a322"), A_1.n("dc-flo")).ao() as c5x;
				if (c5x2 != null)
				{
					c5x2.w();
					c5x2.an();
				}
				if (c5x3 != null)
				{
					c5x3.w();
					c5x3.an();
				}
			}
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
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
