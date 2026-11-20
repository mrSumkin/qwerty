using System;
using System.Diagnostics;
using Ouroboros.Common.Data;

// Token: 0x02000498 RID: 1176
public static class cxc
{
	// Token: 0x06001E07 RID: 7687 RVA: 0x000A68E4 File Offset: 0x000A4AE4
	public static void c(string A_0)
	{
		try
		{
			akt service = bpo.GetService<akt>();
			if (service != null)
			{
				bool flag = false;
				if (service.asv(A_0))
				{
					Trace.WriteLine("STEAM ACHIEVEMENT SET: " + A_0);
					flag = true;
				}
				if (!flag)
				{
					Trace.WriteLine("FAILED TO SET STEAM ACHIEVEMENT!: " + A_0);
				}
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE SETTING STEAM ACHIEVEMENT!: " + A_0 + ". Exception: " + ex.ToString());
		}
		try
		{
			acv service2 = bpo.GetService<acv>();
			if (service2 != null)
			{
				bool flag2 = false;
				if (service2.sz(A_0))
				{
					Trace.WriteLine("GALAXY ACHIEVEMENT SET: " + A_0);
					flag2 = true;
				}
				if (!flag2)
				{
					Trace.WriteLine("FAILED TO SET GALAXY ACHIEVEMENT!: " + A_0);
				}
			}
		}
		catch (Exception ex2)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE SETTING GALAXY ACHIEVEMENT!: " + A_0 + ". Exception: " + ex2.ToString());
		}
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x000A69E4 File Offset: 0x000A4BE4
	public static void b(string A_0)
	{
		try
		{
			akt service = bpo.GetService<akt>();
			if (service != null)
			{
				service.asw(A_0);
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE CLEARING STEAM ACHIEVEMENT!: " + A_0 + ". Exception: " + ex.ToString());
		}
		try
		{
			acv service2 = bpo.GetService<acv>();
			if (service2 != null)
			{
				service2.s0(A_0);
			}
		}
		catch (Exception ex2)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE CLEARING GALAXY ACHIEVEMENT!: " + A_0 + ". Exception: " + ex2.ToString());
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x000A6A84 File Offset: 0x000A4C84
	public static void a(string A_0)
	{
		try
		{
			akt service = bpo.GetService<akt>();
			if (service != null)
			{
				bool flag = false;
				if (service.asx(A_0))
				{
					Trace.WriteLine("STEAM STAT INCREMENTED: " + A_0);
					flag = true;
				}
				if (!flag)
				{
					Trace.WriteLine("FAILED TO INCREMENT STEAM STAT!: " + A_0);
				}
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE INCREMENTING STEAM STAT!: " + A_0 + ". Exception: " + ex.ToString());
		}
		try
		{
			acv service2 = bpo.GetService<acv>();
			if (service2 != null)
			{
				bool flag2 = false;
				if (service2.s1(A_0))
				{
					Trace.WriteLine("GALAXY STAT INCREMENTED: " + A_0);
					flag2 = true;
				}
				if (!flag2)
				{
					Trace.WriteLine("FAILED TO INCREMENT GALAXY STAT!: " + A_0);
				}
			}
		}
		catch (Exception ex2)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE INCREMENTING GALAXY STAT!: " + A_0 + ". Exception: " + ex2.ToString());
		}
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x000A6B84 File Offset: 0x000A4D84
	public static void c()
	{
		try
		{
			akt service = bpo.GetService<akt>();
			if (service != null)
			{
				service.asu(true);
			}
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE RESETING STEAM STATS! Exception: " + ex.ToString());
		}
		try
		{
			acv service2 = bpo.GetService<acv>();
			if (service2 != null)
			{
				service2.sy(true);
			}
		}
		catch (Exception ex2)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE RESETING GALAXY STATS! Exception: " + ex2.ToString());
		}
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000A6C18 File Offset: 0x000A4E18
	public static bool b()
	{
		if (cxc.b == null)
		{
			try
			{
				akt service = bpo.GetService<akt>();
				if (service != null)
				{
					bool value = service.asy();
					cxc.b = new bool?(value);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine("ERROR OCCURRED WHILE TRY TO CHECK IF THE GAME IS RUNNING ON STEAM DECK! Exception: " + ex.ToString());
			}
		}
		return cxc.b != null && cxc.b.Value;
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000A6CA0 File Offset: 0x000A4EA0
	public static bool a(int A_0, int A_1, int A_2, int A_3)
	{
		try
		{
			return bpo.GetService<akt>().as0(A_0, A_1, A_2, A_3);
		}
		catch (Exception ex)
		{
			Trace.WriteLine("ERROR OCCURRED WHILE TRY TO CHECK IF THE GAME IS RUNNING ON STEAM DECK! Exception: " + ex.ToString());
		}
		return false;
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000A6CF0 File Offset: 0x000A4EF0
	public static bool a()
	{
		if (cxc.c == null)
		{
			try
			{
				akt service = bpo.GetService<akt>();
				if (service != null)
				{
					bool value = service.asz();
					cxc.c = new bool?(value);
				}
			}
			catch (Exception ex)
			{
				Trace.WriteLine("ERROR OCCURRED WHILE TRY TO CHECK IF THE GAME IS RUNNING ON WINE! Exception: " + ex.ToString());
			}
		}
		return cxc.c != null && cxc.c.Value;
	}

	// Token: 0x0400129D RID: 4765
	public static PropertyCollection a = new PropertyCollection();

	// Token: 0x0400129E RID: 4766
	private static bool? b;

	// Token: 0x0400129F RID: 4767
	private static bool? c;
}
