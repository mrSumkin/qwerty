using System;
using System.Diagnostics;

// Token: 0x020020B2 RID: 8370
[bmq("1.2.0.0_Tch_Entry_WhatCombatSpeakFix", "1.2.0.0", "tch-entry", false)]
public sealed class bqh : fg
{
	// Token: 0x0600C7D2 RID: 51154 RVA: 0x004665F4 File Offset: 0x004647F4
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			aud aud = A_1.n("tch-entry");
			if (aud != null)
			{
				c5x c5x = new ar7(new Guid("a5cb3e3a-8563-490b-af4f-f5553c358fc1"), aud).ao() as c5x;
				if (c5x != null && c5x.t.b != null)
				{
					c5x.t.b.a("Custom\\What");
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
}
