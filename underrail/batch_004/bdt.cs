using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x02002123 RID: 8483
[bmq("1.1.2.4_Xpbl_ojyc1_MoveLakePoppyAndRenameBAC", "1.1.2.4", "xpbl_ojyc1", false)]
public sealed class bdt : fg
{
	// Token: 0x0600C892 RID: 51346 RVA: 0x0046BC78 File Offset: 0x00469E78
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("619662a9-5f0a-40cd-b3aa-add70b8908e8"), A_1.n(A_1.y8())).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("5a52ef92-dd57-428b-8870-47222af49b2f"), A_1.n(A_1.y8())).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("3896adcd-1764-4372-b4cb-3b98d2007e71"), A_1.n(A_1.y8())).ao() as c5x;
			if (c5x != null)
			{
				c5x.Location = new Vector3(67f, 55f, -0.2f);
				c5x.ah();
			}
			if (c5x2 != null && c5x3 != null)
			{
				c5x2.w();
				c5x2.an();
				c5x3.w();
				c5x3.an();
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
