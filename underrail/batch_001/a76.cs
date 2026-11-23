using System;
using System.Diagnostics;

// Token: 0x02002158 RID: 8536
[bmq("1.1.0.15_Fo2_FixGuardLocationlessGuard", "1.1.0.15", "fo2", false)]
public sealed class a76 : fg
{
	// Token: 0x0600C8FC RID: 51452 RVA: 0x0046FEF8 File Offset: 0x0046E0F8
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("9517351e-00ea-4ade-ad50-2da51a653382"), A_1.n("fo2")).ao() as c5x;
			if (c5x != null && c5x.t.b != null && c5x.t.b.y6()[ddq.ay] == null)
			{
				c5x.t.b.y6()[ddq.ay] = new bt4("7eb06905-18ff-4459-ba6b-f5a3e0eb5e85");
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
